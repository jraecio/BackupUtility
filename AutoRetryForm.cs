using System;
using System.Drawing;
using System.Windows.Forms;

namespace BackUtilsoftcom
{
    public class AutoRetryForm : Form
    {
        private int _secondsLeft = 5;
        private Label lblMessage;
        private Button btnYes;
        private Button btnNo;
        private Timer timer;

        public AutoRetryForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblMessage = new Label();
            this.btnYes = new Button();
            this.btnNo = new Button();
            this.timer = new Timer();
            
            this.SuspendLayout();

            this.lblMessage.AutoSize = false;
            this.lblMessage.Font = new Font("Segoe UI", 10F);
            this.lblMessage.Location = new Point(20, 20);
            this.lblMessage.Size = new Size(340, 50);
            this.lblMessage.Text = "Ocorreu uma falha no envio para a nuvem.\nDeseja tentar enviar novamente?";

            this.btnYes.Location = new Point(80, 80);
            this.btnYes.Size = new Size(110, 35);
            this.btnYes.Text = "Sim (5)";
            this.btnYes.DialogResult = DialogResult.Yes;
            this.btnYes.BackColor = Color.FromArgb(255, 204, 0); // Amarelo
            this.btnYes.FlatStyle = FlatStyle.Flat;
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            this.btnNo.Location = new Point(210, 80);
            this.btnNo.Size = new Size(90, 35);
            this.btnNo.Text = "Não";
            this.btnNo.DialogResult = DialogResult.No;
            this.btnNo.BackColor = Color.LightGray;
            this.btnNo.FlatStyle = FlatStyle.Flat;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            this.timer.Interval = 1000;
            this.timer.Tick += new EventHandler(Timer_Tick);

            this.ClientSize = new Size(380, 140);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Falha no Envio";
            this.AcceptButton = this.btnYes;
            this.CancelButton = this.btnNo;

            this.Load += new EventHandler(AutoRetryForm_Load);
            this.FormClosing += new FormClosingEventHandler(AutoRetryForm_FormClosing);
            this.ResumeLayout(false);
        }

        private void AutoRetryForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _secondsLeft--;
            if (_secondsLeft <= 0)
            {
                timer.Stop();
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                this.btnYes.Text = string.Format("Sim ({0})", _secondsLeft);
            }
        }

        private void AutoRetryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }
    }
}
