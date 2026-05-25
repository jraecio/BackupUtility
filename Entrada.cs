using BackupUtilSoftcom;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;


namespace BackUtilsoftcom
{
    public partial class Entrada : Form, IBackupLogger
    {
        public string LinkBkpText ;
        public Entrada()
        {
            InitializeComponent();
        }

        public void Log(string s)
        {
            if (InvokeRequired)
                Invoke(new Action(() => txtLog.AppendText(string.Format("{0:T} {1}\r\n", DateTime.Now, s))));
            else
                txtLog.AppendText(string.Format("{0:T} {1}\r\n", DateTime.Now, s));
        }
        private void btnSelecionarFront_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Title = "Selecione o arquivo Front ou atalho";
                    dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                    dialog.Filter = "Arquivos MDB ou Atalhos (*.mdb;*.lnk)|*.mdb;*.lnk|Todos os arquivos (*.*)|*.*";

                    DialogResult result = dialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string entrada = dialog.FileName;

                        // 1. Se for um arquivo .lnk (atalho do Windows)
                        if (entrada.EndsWith(".lnk", StringComparison.OrdinalIgnoreCase))
                        {
                            entrada = ResolverAtalho(entrada);
                        }

                        // 2. Extrair o MDB do texto/atalho
                        string caminhoMdb = ExtrairCaminhoMdb(entrada);

                        if (caminhoMdb != null && File.Exists(caminhoMdb))
                        {
                            TxLocalFront.Text = caminhoMdb;
                            LinkBkpText = null;
                        }
                        else
                        {
                            MessageBox.Show(
                                "Não foi possível identificar um arquivo MDB válido.",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao selecionar o arquivo:\n\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private string ResolverAtalho(string caminhoAtalho)
        {
            try
            {
                // Usa COM para ler atalhos
                Type wshShell = Type.GetTypeFromProgID("WScript.Shell");
                dynamic shell = Activator.CreateInstance(wshShell);
                dynamic shortcut = shell.CreateShortcut(caminhoAtalho);

                return shortcut.Arguments != null && shortcut.Arguments.ToString().Length > 0
                    ? string.Format("{0} {1}", shortcut.TargetPath, shortcut.Arguments)
                    : shortcut.TargetPath;
            }
            catch
            {
                return caminhoAtalho; // se falhar, devolve o próprio caminho
            }
        }

        private string ExtrairCaminhoMdb(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            // Remove aspas e espaços
            input = input.Trim().Trim('"');

            // Caso seja um arquivo MDB direto
            if (input.EndsWith(".mdb", StringComparison.OrdinalIgnoreCase) && File.Exists(input))
                return input;

            // Verifica se existe algum .mdb na string
            if (input.IndexOf(".mdb", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                // Divide a linha por aspas
                string[] partes = input.Split('"');

                foreach (var p in partes)
                {
                    string path = p.Trim();

                    if (path.EndsWith(".mdb", StringComparison.OrdinalIgnoreCase) && File.Exists(path))
                        return path;
                }
            }

            return null;
        }

        private async void btnIniciarCopia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxLocalFront.Text))
            {
                MessageBox.Show("Selecione o arquivo Front primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            progressBarBackup.Visible = true;
            progressBarBackup.Value = 0;


            try
            {
                var backup = new BackupManager(this, TxLocalFront.Text);

                await backup.RealizarBackup((progress, status) =>
                    {
                        // Atualiza UI na thread principal
                        this.Invoke(new Action(() =>
                        {
                            progressBarBackup.Value = progress;

                        }));
                    }, chB_BackupEmNuvem.Checked, chB_CompactarRepara.Checked, chB_FrontSQL.Checked, () => 
                    {
                        bool retryResult = false;
                        this.Invoke(new Action(() => 
                        {
                            using (var form = new AutoRetryForm())
                            {
                                var res = form.ShowDialog(this);
                                retryResult = (res == DialogResult.Yes);
                            }
                        }));
                        return Task.FromResult(retryResult);
                    });


                LinkBkpText = backup.GetCaminhoPastaBackup();

                if (LinkBkpText != null && LinkBkpText.Length > 50)
                    lblLinkBkp.Text = "📁 " + LinkBkpText.Substring(0, 50) + "...";
                else
                    lblLinkBkp.Text = "📁 " + LinkBkpText;

                if (chB_BackupEmNuvem.Checked) { 
                    string urlFinal = $"https://upload-files.softcom.services/{backup.GetArquivozip()}";
                    lblLinckNuvem.Tag = urlFinal; // armazena a url completa para não cortar no CTRL+C
                    lblLinckNuvem.Text = "☁️ " + urlFinal;
                }
                
                lblLinksHeader.Visible = true;

                if (chB_Manutencao.Checked)
                {
                    CopiarParaManutencao();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar backup: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                btnIniciarCopia.Enabled = true;
                btnSelecionarFront.Enabled = true;
                // progressBarBackup.Visible = false; // Opcional: manter visível para mostrar 100%
            }
        }

        private void linkBkp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Caminho da pasta que você quer abrir:
            if (string.IsNullOrEmpty(LinkBkpText)) return;
            var parent = Directory.GetParent(LinkBkpText);
            if (parent == null) return;
            string pasta = parent.FullName;

            if (Directory.Exists(pasta))
            {
                // Abre o Explorer na pasta
                Process.Start("explorer.exe", pasta);
            }
            else
            {
                MessageBox.Show("A pasta não existe: " + pasta);
            }

        }
   
        private void lblLinckNuvem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblLinckNuvem.Tag != null)
            {
                Clipboard.SetText(lblLinckNuvem.Tag.ToString());
                MessageBox.Show("O link de nuvem foi copiado com sucesso para sua área de transferência!\nAgora é só colar (Ctrl+V) onde precisar.", "Link Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CopiarParaManutencao()
        {
            try
            {
                string origem = TxLocalFront.Text;
                if (!File.Exists(origem)) return;

                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string pastaManutencao = Path.Combine(basePath, "Manutenção", DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("dd"));

                if (!Directory.Exists(pastaManutencao))
                {
                    Directory.CreateDirectory(pastaManutencao);
                }

                string destino = Path.Combine(pastaManutencao, Path.GetFileName(origem));
                File.Copy(origem, destino, true);

                Log(string.Format("✅ Arquivo copiado para manutenção: {0}", destino));
                Process.Start("explorer.exe", pastaManutencao);
            }
            catch (Exception ex)
            {
                Log("❌ Erro ao copiar para manutenção: " + ex.Message);
            }
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtServer.Text))
                {
                    MessageBox.Show("Informe o Servidor SQL.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool connected = FrontSqlService.VerificarConexaoSql(txtServer.Text, txtPorta.Text, txtLogin.Text, txtSenha.Text);
                if (connected)
                {
                    MessageBox.Show("✅ Conexão estabelecida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Listar bancos
                    List<string> databases = FrontSqlService.ListarBancos(txtServer.Text, txtPorta.Text, txtLogin.Text, txtSenha.Text);
                    cmbBanco.Items.Clear();
                    foreach(var db in databases)
                    {
                        cmbBanco.Items.Add(db);
                    }
                    if (cmbBanco.Items.Count > 0)
                        cmbBanco.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("❌ Falha na conexão. Revise as credenciais ou cheque se o servidor está rodando.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao tentar conexão: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBanco.SelectedItem != null && !string.IsNullOrWhiteSpace(cmbBanco.SelectedItem.ToString()))
            {
                string selectedDb = cmbBanco.SelectedItem.ToString();
                bool exists = FrontSqlService.Verificar_Tabela(txtServer.Text, txtPorta.Text, txtLogin.Text, txtSenha.Text, selectedDb);
                
                if (exists)
                {
                    lblStatusFront.Text = "STATUS: ✅ FRONT encontrado";
                    lblStatusFront.ForeColor = System.Drawing.Color.Green;
                    if (!string.IsNullOrWhiteSpace(txtCaminhoImportar.Text))
                        btnRecuperar.Enabled = true;
                }
                else
                {
                    lblStatusFront.Text = "STATUS: ❌ FRONT não encontrado";
                    lblStatusFront.ForeColor = System.Drawing.Color.Red;
                    btnRecuperar.Enabled = false;
                }
            }
        }

        private void btnSelecionarCaminhoImportar_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Selecione o diretório para extrair o arquivo MDB";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtCaminhoImportar.Text = fbd.SelectedPath;
                    
                    if (lblStatusFront.Text.Contains("encontrado"))
                        btnRecuperar.Enabled = true;
                }
            }
        }

        private async void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (cmbBanco.SelectedItem == null)
            {
                MessageBox.Show("Selecione um banco primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCaminhoImportar.Text))
            {
                MessageBox.Show("Selecione o diretório de destino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnRecuperar.Enabled = false;
                btnRecuperar.Text = "Processando...";
                lblStatusFront.Text = "STATUS: ⏳ Recuperando, aguarde...";
                lblStatusFront.ForeColor = System.Drawing.Color.Orange;
                
                string server = txtServer.Text;
                string port = txtPorta.Text;
                string login = txtLogin.Text;
                string senha = txtSenha.Text;
                string banco = cmbBanco.SelectedItem.ToString();
                string dest = txtCaminhoImportar.Text;

                await Task.Run(() => 
                {
                    bool sucesso = FrontSqlService.ExportFileFromSQL(server, port, login, senha, banco, dest, this);
                    
                    this.Invoke(new Action(() => 
                    {
                        if (sucesso)
                        {
                            lblStatusFront.Text = "STATUS: ✅ FRONT recuperado com sucesso!";
                            lblStatusFront.ForeColor = System.Drawing.Color.Green;
                            MessageBox.Show("Recuperação do FRONT MDB concluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Process.Start("explorer.exe", dest);
                        }
                        else
                        {
                            lblStatusFront.Text = "STATUS: ❌ Falha na recuperação";
                            lblStatusFront.ForeColor = System.Drawing.Color.Red;
                            MessageBox.Show("Falha na recuperação. Verifique os logs.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }));
                });
            }
            finally
            {
                btnRecuperar.Text = "RECUPERAR FRONT";
                btnRecuperar.Enabled = true;

                // Restaura o status caso tenha ficado em erro
                if (!lblStatusFront.Text.Contains("recuperado")) 
                {
                    cmbBanco_SelectedIndexChanged(null, null);
                }
            }
        }
    }
}
