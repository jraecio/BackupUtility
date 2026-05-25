namespace BackUtilsoftcom
{
    partial class Entrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.chB_BackupEmNuvem = new System.Windows.Forms.CheckBox();
            this.lblLinckNuvem = new System.Windows.Forms.LinkLabel();
            this.lblLinkBkp = new System.Windows.Forms.LinkLabel();
            this.lblLinksHeader = new System.Windows.Forms.Label();
            this.progressBarBackup = new System.Windows.Forms.ProgressBar();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.gpBoxLocalFront = new System.Windows.Forms.GroupBox();
            this.lblLocalTx = new System.Windows.Forms.Label();
            this.TxLocalFront = new System.Windows.Forms.TextBox();
            this.btnSelecionarFront = new System.Windows.Forms.Button();
            this.gpBoxTipoOperacao = new System.Windows.Forms.GroupBox();
            this.chB_CompactarRepara = new System.Windows.Forms.CheckBox();
            this.chB_Manutencao = new System.Windows.Forms.CheckBox();
            this.gpBoxIniciarCopia = new System.Windows.Forms.GroupBox();
            this.btnIniciarCopia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageEnvio = new System.Windows.Forms.TabPage();
            this.tabPageImportar = new System.Windows.Forms.TabPage();
            this.chB_FrontSQL = new System.Windows.Forms.CheckBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtCaminhoImportar = new System.Windows.Forms.TextBox();
            this.lblCaminhoImportar = new System.Windows.Forms.Label();
            this.btnSelecionarCaminhoImportar = new System.Windows.Forms.Button();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.lblStatusFront = new System.Windows.Forms.Label();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.gpBoxImportar = new System.Windows.Forms.GroupBox();

            this.gpBoxLocalFront.SuspendLayout();
            this.gpBoxIniciarCopia.SuspendLayout();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPageEnvio.SuspendLayout();
            this.tabPageImportar.SuspendLayout();
            this.gpBoxImportar.SuspendLayout();
            this.SuspendLayout();
            // 
            // chB_BackupEmNuvem
            // 
            this.chB_BackupEmNuvem.AutoSize = true;
            this.chB_BackupEmNuvem.Checked = true;
            this.chB_BackupEmNuvem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_BackupEmNuvem.Location = new System.Drawing.Point(27, 140);
            this.chB_BackupEmNuvem.Name = "chB_BackupEmNuvem";
            this.chB_BackupEmNuvem.Size = new System.Drawing.Size(117, 17);
            this.chB_BackupEmNuvem.TabIndex = 21;
            this.chB_BackupEmNuvem.Text = "Backup em Nuvem";
            this.chB_BackupEmNuvem.UseVisualStyleBackColor = true;
            // 
            // chB_CompactarRepara
            // 
            this.chB_CompactarRepara.AutoSize = true;
            this.chB_CompactarRepara.Checked = false;
            this.chB_CompactarRepara.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chB_CompactarRepara.Location = new System.Drawing.Point(160, 140);
            this.chB_CompactarRepara.Name = "chB_CompactarRepara";
            this.chB_CompactarRepara.Size = new System.Drawing.Size(120, 17);
            this.chB_CompactarRepara.TabIndex = 23;
            this.chB_CompactarRepara.Text = "Compactar/Repara";
            this.chB_CompactarRepara.UseVisualStyleBackColor = true;
            // 
            // chB_Manutencao
            // 
            this.chB_Manutencao.AutoSize = true;
            this.chB_Manutencao.Checked = false;
            this.chB_Manutencao.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chB_Manutencao.Location = new System.Drawing.Point(300, 140);
            this.chB_Manutencao.Name = "chB_Manutencao";
            this.chB_Manutencao.Size = new System.Drawing.Size(89, 17);
            this.chB_Manutencao.TabIndex = 24;
            this.chB_Manutencao.Text = "Manutenção";
            this.chB_Manutencao.UseVisualStyleBackColor = true;
            // 
            // lblLinckNuvem
            // 
            this.lblLinckNuvem.AutoSize = true;
            this.lblLinckNuvem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinckNuvem.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLinckNuvem.ActiveLinkColor = System.Drawing.Color.DarkOrange;
            this.lblLinckNuvem.LinkColor = System.Drawing.Color.Orange;
            this.lblLinckNuvem.Location = new System.Drawing.Point(16, 265);
            this.lblLinckNuvem.Name = "lblLinckNuvem";
            this.lblLinckNuvem.Size = new System.Drawing.Size(0, 17);
            this.lblLinckNuvem.TabIndex = 20;
            this.lblLinckNuvem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinckNuvem_LinkClicked);
            // 
            // lblLinkBkp
            // 
            this.lblLinkBkp.AutoSize = true;
            this.lblLinkBkp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkBkp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLinkBkp.ActiveLinkColor = System.Drawing.Color.DarkOrange;
            this.lblLinkBkp.LinkColor = System.Drawing.Color.Orange;
            this.lblLinkBkp.Location = new System.Drawing.Point(16, 244);
            this.lblLinkBkp.Name = "lblLinkBkp";
            this.lblLinkBkp.Size = new System.Drawing.Size(0, 17);
            this.lblLinkBkp.TabIndex = 14;
            this.lblLinkBkp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBkp_LinkClicked);
            // 
            // lblLinksHeader
            // 
            this.lblLinksHeader.AutoSize = true;
            this.lblLinksHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinksHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblLinksHeader.Location = new System.Drawing.Point(13, 225);
            this.lblLinksHeader.Name = "lblLinksHeader";
            this.lblLinksHeader.Size = new System.Drawing.Size(350, 17);
            this.lblLinksHeader.TabIndex = 22;
            this.lblLinksHeader.Text = "🔗 Copie os links abaixo (local ou da nuvem):";
            this.lblLinksHeader.Visible = false;
            // 
            // progressBarBackup
            // 
            this.progressBarBackup.Location = new System.Drawing.Point(12, 283);
            this.progressBarBackup.Name = "progressBarBackup";
            this.progressBarBackup.Size = new System.Drawing.Size(460, 24);
            this.progressBarBackup.TabIndex = 19;
            this.progressBarBackup.Visible = false;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtLog.ForeColor = System.Drawing.Color.Gray;
            this.txtLog.Location = new System.Drawing.Point(12, 316);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(460, 114);
            this.txtLog.TabIndex = 18;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::BackUtilsoftcom.Properties.Resources.Logo_Softcom_Pequena;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 28);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 13;
            this.picLogo.TabStop = false;
            // 
            // gpBoxLocalFront
            // 
            this.gpBoxLocalFront.Controls.Add(this.lblLocalTx);
            this.gpBoxLocalFront.Controls.Add(this.TxLocalFront);
            this.gpBoxLocalFront.Controls.Add(this.btnSelecionarFront);
            this.gpBoxLocalFront.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpBoxLocalFront.ForeColor = System.Drawing.Color.DimGray;
            this.gpBoxLocalFront.Location = new System.Drawing.Point(12, 50);
            this.gpBoxLocalFront.Name = "gpBoxLocalFront";
            this.gpBoxLocalFront.Size = new System.Drawing.Size(460, 59);
            this.gpBoxLocalFront.TabIndex = 15;
            this.gpBoxLocalFront.TabStop = false;
            this.gpBoxLocalFront.Text = "Origem dos Dados";
            // 
            // lblLocalTx
            // 
            this.lblLocalTx.AutoSize = true;
            this.lblLocalTx.Location = new System.Drawing.Point(15, 25);
            this.lblLocalTx.Name = "lblLocalTx";
            this.lblLocalTx.Size = new System.Drawing.Size(38, 15);
            this.lblLocalTx.TabIndex = 0;
            this.lblLocalTx.Text = "Local:";
            // 
            // TxLocalFront
            // 
            this.TxLocalFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxLocalFront.Location = new System.Drawing.Point(60, 22);
            this.TxLocalFront.Name = "TxLocalFront";
            this.TxLocalFront.Size = new System.Drawing.Size(340, 23);
            this.TxLocalFront.TabIndex = 1;
            // 
            // btnSelecionarFront
            // 
            this.btnSelecionarFront.BackColor = System.Drawing.Color.Orange;
            this.btnSelecionarFront.FlatAppearance.BorderSize = 0;
            this.btnSelecionarFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarFront.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarFront.Location = new System.Drawing.Point(410, 21);
            this.btnSelecionarFront.Name = "btnSelecionarFront";
            this.btnSelecionarFront.Size = new System.Drawing.Size(35, 25);
            this.btnSelecionarFront.TabIndex = 2;
            this.btnSelecionarFront.Text = "...";
            this.btnSelecionarFront.UseVisualStyleBackColor = false;
            this.btnSelecionarFront.Click += new System.EventHandler(this.btnSelecionarFront_Click);
            // 
            // gpBoxTipoOperacao
            // 
            this.gpBoxTipoOperacao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpBoxTipoOperacao.ForeColor = System.Drawing.Color.DimGray;
            this.gpBoxTipoOperacao.Location = new System.Drawing.Point(12, 115);
            this.gpBoxTipoOperacao.Name = "gpBoxTipoOperacao";
            this.gpBoxTipoOperacao.Size = new System.Drawing.Size(460, 50);
            this.gpBoxTipoOperacao.TabIndex = 16;
            this.gpBoxTipoOperacao.TabStop = false;
            this.gpBoxTipoOperacao.Text = "Tipo de Operação";
            // 
            // gpBoxIniciarCopia
            // 
            this.gpBoxIniciarCopia.Controls.Add(this.btnIniciarCopia);
            this.gpBoxIniciarCopia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpBoxIniciarCopia.ForeColor = System.Drawing.Color.DimGray;
            this.gpBoxIniciarCopia.Location = new System.Drawing.Point(12, 171);
            this.gpBoxIniciarCopia.Name = "gpBoxIniciarCopia";
            this.gpBoxIniciarCopia.Size = new System.Drawing.Size(460, 69);
            this.gpBoxIniciarCopia.TabIndex = 17;
            this.gpBoxIniciarCopia.TabStop = false;
            this.gpBoxIniciarCopia.Text = "Ação";
            // 
            // btnIniciarCopia
            // 
            this.btnIniciarCopia.BackColor = System.Drawing.Color.Orange;
            this.btnIniciarCopia.FlatAppearance.BorderSize = 0;
            this.btnIniciarCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarCopia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIniciarCopia.ForeColor = System.Drawing.Color.White;
            this.btnIniciarCopia.Location = new System.Drawing.Point(15, 20);
            this.btnIniciarCopia.Name = "btnIniciarCopia";
            this.btnIniciarCopia.Size = new System.Drawing.Size(430, 35);
            this.btnIniciarCopia.TabIndex = 0;
            this.btnIniciarCopia.Text = "INICIAR BACKUP";
            this.btnIniciarCopia.UseVisualStyleBackColor = false;
            this.btnIniciarCopia.Click += new System.EventHandler(this.btnIniciarCopia_Click);
            // tabControlPrincipal
            this.tabControlPrincipal.Controls.Add(this.tabPageEnvio);
            this.tabControlPrincipal.Controls.Add(this.tabPageImportar);
            this.tabControlPrincipal.Location = new System.Drawing.Point(5, 5);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(490, 500);
            this.tabControlPrincipal.TabIndex = 0;

            // tabPageEnvio
            this.tabPageEnvio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageEnvio.Controls.Add(this.lblLinksHeader);
            this.tabPageEnvio.Controls.Add(this.chB_BackupEmNuvem);
            this.tabPageEnvio.Controls.Add(this.chB_CompactarRepara);
            this.tabPageEnvio.Controls.Add(this.chB_Manutencao);
            this.tabPageEnvio.Controls.Add(this.chB_FrontSQL);
            this.tabPageEnvio.Controls.Add(this.lblLinckNuvem);
            this.tabPageEnvio.Controls.Add(this.lblLinkBkp);
            this.tabPageEnvio.Controls.Add(this.progressBarBackup);
            this.tabPageEnvio.Controls.Add(this.txtLog);
            this.tabPageEnvio.Controls.Add(this.picLogo);
            this.tabPageEnvio.Controls.Add(this.gpBoxLocalFront);
            this.tabPageEnvio.Controls.Add(this.gpBoxTipoOperacao);
            this.tabPageEnvio.Controls.Add(this.gpBoxIniciarCopia);
            this.tabPageEnvio.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnvio.Name = "tabPageEnvio";
            this.tabPageEnvio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnvio.Size = new System.Drawing.Size(482, 474);
            this.tabPageEnvio.TabIndex = 0;
            this.tabPageEnvio.Text = "Envio";

            // chB_FrontSQL
            this.chB_FrontSQL.AutoSize = true;
            this.chB_FrontSQL.Checked = true;
            this.chB_FrontSQL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_FrontSQL.Location = new System.Drawing.Point(395, 140);
            this.chB_FrontSQL.Name = "chB_FrontSQL";
            this.chB_FrontSQL.Size = new System.Drawing.Size(76, 17);
            this.chB_FrontSQL.TabIndex = 26;
            this.chB_FrontSQL.Text = "Front SQL";
            this.chB_FrontSQL.UseVisualStyleBackColor = true;

            // tabPageImportar
            this.tabPageImportar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageImportar.Controls.Add(this.gpBoxImportar);
            this.tabPageImportar.Location = new System.Drawing.Point(4, 22);
            this.tabPageImportar.Name = "tabPageImportar";
            this.tabPageImportar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImportar.Size = new System.Drawing.Size(482, 474);
            this.tabPageImportar.TabIndex = 1;
            this.tabPageImportar.Text = "Importar";

            // gpBoxImportar
            this.gpBoxImportar.Controls.Add(this.lblServer);
            this.gpBoxImportar.Controls.Add(this.txtServer);
            this.gpBoxImportar.Controls.Add(this.lblPorta);
            this.gpBoxImportar.Controls.Add(this.txtPorta);
            this.gpBoxImportar.Controls.Add(this.lblLogin);
            this.gpBoxImportar.Controls.Add(this.txtLogin);
            this.gpBoxImportar.Controls.Add(this.lblSenha);
            this.gpBoxImportar.Controls.Add(this.txtSenha);
            this.gpBoxImportar.Controls.Add(this.btnTestarConexao);
            this.gpBoxImportar.Controls.Add(this.lblBanco);
            this.gpBoxImportar.Controls.Add(this.cmbBanco);
            this.gpBoxImportar.Controls.Add(this.lblStatusFront);
            this.gpBoxImportar.Controls.Add(this.lblCaminhoImportar);
            this.gpBoxImportar.Controls.Add(this.txtCaminhoImportar);
            this.gpBoxImportar.Controls.Add(this.btnSelecionarCaminhoImportar);
            this.gpBoxImportar.Controls.Add(this.btnRecuperar);
            this.gpBoxImportar.Location = new System.Drawing.Point(12, 12);
            this.gpBoxImportar.Name = "gpBoxImportar";
            this.gpBoxImportar.Size = new System.Drawing.Size(460, 360);
            this.gpBoxImportar.TabIndex = 0;
            this.gpBoxImportar.TabStop = false;
            this.gpBoxImportar.Text = "Configurações de Importação";

            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(15, 25);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(49, 13);
            this.lblServer.Text = "Servidor:";

            this.txtServer.Location = new System.Drawing.Point(70, 22);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(130, 20);
            this.txtServer.Text = "Localhost\\sqlexpress";

            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(210, 25);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(35, 13);
            this.lblPorta.Text = "Porta:";

            this.txtPorta.Location = new System.Drawing.Point(250, 22);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(50, 20);
            this.txtPorta.Text = "5433";

            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(15, 60);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.Text = "Login:";

            this.txtLogin.Location = new System.Drawing.Point(70, 57);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(130, 20);
            this.txtLogin.Text = "sa_softcom";

            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(210, 60);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.Text = "Senha:";

            this.txtSenha.Location = new System.Drawing.Point(250, 57);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(120, 20);

            this.btnTestarConexao.Location = new System.Drawing.Point(70, 90);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(110, 25);
            this.btnTestarConexao.Text = "Testar Conexão";
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);

            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(15, 135);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.Text = "Banco:";

            this.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(70, 132);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(200, 21);
            this.cmbBanco.SelectedIndexChanged += new System.EventHandler(this.cmbBanco_SelectedIndexChanged);

            this.lblStatusFront.AutoSize = true;
            this.lblStatusFront.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusFront.ForeColor = System.Drawing.Color.Gray;
            this.lblStatusFront.Location = new System.Drawing.Point(70, 165);
            this.lblStatusFront.Name = "lblStatusFront";
            this.lblStatusFront.Size = new System.Drawing.Size(130, 15);
            this.lblStatusFront.Text = "STATUS: Não verificado";

            this.lblCaminhoImportar.AutoSize = true;
            this.lblCaminhoImportar.Location = new System.Drawing.Point(15, 200);
            this.lblCaminhoImportar.Name = "lblCaminhoImportar";
            this.lblCaminhoImportar.Size = new System.Drawing.Size(46, 13);
            this.lblCaminhoImportar.Text = "Destino:";

            this.txtCaminhoImportar.Location = new System.Drawing.Point(70, 197);
            this.txtCaminhoImportar.Name = "txtCaminhoImportar";
            this.txtCaminhoImportar.Size = new System.Drawing.Size(320, 20);
            this.txtCaminhoImportar.ReadOnly = true;

            this.btnSelecionarCaminhoImportar.Location = new System.Drawing.Point(395, 195);
            this.btnSelecionarCaminhoImportar.Name = "btnSelecionarCaminhoImportar";
            this.btnSelecionarCaminhoImportar.Size = new System.Drawing.Size(35, 25);
            this.btnSelecionarCaminhoImportar.Text = "...";
            this.btnSelecionarCaminhoImportar.UseVisualStyleBackColor = true;
            this.btnSelecionarCaminhoImportar.Click += new System.EventHandler(this.btnSelecionarCaminhoImportar_Click);

            this.btnRecuperar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRecuperar.FlatAppearance.BorderSize = 0;
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRecuperar.ForeColor = System.Drawing.Color.White;
            this.btnRecuperar.Location = new System.Drawing.Point(15, 240);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(430, 35);
            this.btnRecuperar.Text = "RECUPERAR FRONT";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Enabled = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);

            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(510, 520);
            this.Controls.Add(this.tabControlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Utility - v3.0.0";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.gpBoxLocalFront.ResumeLayout(false);
            this.gpBoxLocalFront.PerformLayout();
            this.gpBoxIniciarCopia.ResumeLayout(false);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPageEnvio.ResumeLayout(false);
            this.tabPageEnvio.PerformLayout();
            this.tabPageImportar.ResumeLayout(false);
            this.tabPageImportar.PerformLayout();
            this.gpBoxImportar.ResumeLayout(false);
            this.gpBoxImportar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chB_BackupEmNuvem;
        private System.Windows.Forms.CheckBox chB_CompactarRepara;
        private System.Windows.Forms.CheckBox chB_Manutencao;
        private System.Windows.Forms.LinkLabel lblLinckNuvem;
        private System.Windows.Forms.LinkLabel lblLinkBkp;
        private System.Windows.Forms.Label lblLinksHeader;
        private System.Windows.Forms.ProgressBar progressBarBackup;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox gpBoxLocalFront;
        private System.Windows.Forms.Label lblLocalTx;
        private System.Windows.Forms.TextBox TxLocalFront;
        private System.Windows.Forms.Button btnSelecionarFront;
        private System.Windows.Forms.GroupBox gpBoxTipoOperacao;
        private System.Windows.Forms.GroupBox gpBoxIniciarCopia;
        private System.Windows.Forms.Button btnIniciarCopia;

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageEnvio;
        private System.Windows.Forms.TabPage tabPageImportar;
        private System.Windows.Forms.CheckBox chB_FrontSQL;

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtCaminhoImportar;
        private System.Windows.Forms.Label lblCaminhoImportar;
        private System.Windows.Forms.Button btnSelecionarCaminhoImportar;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.Label lblStatusFront;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.GroupBox gpBoxImportar;
    }
}