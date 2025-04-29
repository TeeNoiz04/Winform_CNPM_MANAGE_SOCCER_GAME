namespace MANAGE_SOCCER_GAME.Views.SignInSignUp
{
    partial class ForgotPasswordForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblAsk = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnReset = new Guna.UI2.WinForms.Guna2Button();
            picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            lblTitle2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTitlle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblAsk
            // 
            lblAsk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblAsk.AutoSize = false;
            lblAsk.BackColor = Color.Transparent;
            lblAsk.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAsk.ForeColor = Color.FromArgb(60, 211, 252);
            lblAsk.Location = new Point(100, 415);
            lblAsk.Name = "lblAsk";
            lblAsk.Size = new Size(185, 19);
            lblAsk.TabIndex = 25;
            lblAsk.Text = "Back to login";
            lblAsk.Click += lblAsk_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnReset.BorderRadius = 10;
            btnReset.CustomizableEdges = customizableEdges1;
            btnReset.DisabledState.BorderColor = Color.DarkGray;
            btnReset.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReset.FillColor = Color.FromArgb(60, 211, 252);
            btnReset.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(100, 625);
            btnReset.Name = "btnReset";
            btnReset.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnReset.Size = new Size(400, 45);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset password";
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picLogo.CustomizableEdges = customizableEdges3;
            picLogo.Image = Properties.Resources.LogoV;
            picLogo.ImageRotate = 0F;
            picLogo.Location = new Point(220, 225);
            picLogo.Name = "picLogo";
            picLogo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            picLogo.Size = new Size(160, 160);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 13;
            picLogo.TabStop = false;
            // 
            // txbEmail
            // 
            txbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbEmail.AutoSize = true;
            txbEmail.BorderColor = Color.FromArgb(52, 52, 116);
            txbEmail.BorderRadius = 5;
            txbEmail.Cursor = Cursors.IBeam;
            txbEmail.CustomizableEdges = customizableEdges5;
            txbEmail.DefaultText = "Email Address";
            txbEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbEmail.FillColor = Color.FromArgb(52, 52, 116);
            txbEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbEmail.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbEmail.ForeColor = Color.Silver;
            txbEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbEmail.Location = new Point(100, 555);
            txbEmail.Margin = new Padding(6);
            txbEmail.Name = "txbEmail";
            txbEmail.PlaceholderText = "";
            txbEmail.SelectedText = "";
            txbEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txbEmail.Size = new Size(400, 50);
            txbEmail.TabIndex = 26;
            txbEmail.Click += txbEmail_Click;
            txbEmail.Leave += txbEmail_Leave;
            txbEmail.MouseLeave += txbEmail_MouseLeave;
            txbEmail.MouseHover += txbEmail_MouseHover;
            // 
            // lblTitle2
            // 
            lblTitle2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTitle2.AutoSize = false;
            lblTitle2.BackColor = Color.Transparent;
            lblTitle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle2.ForeColor = Color.DarkGray;
            lblTitle2.Location = new Point(100, 495);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(320, 40);
            lblTitle2.TabIndex = 32;
            lblTitle2.Text = "Please enter your email information to complete your password reset.";
            lblTitle2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // lblTitlle
            // 
            lblTitlle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTitlle.BackColor = Color.Transparent;
            lblTitlle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitlle.ForeColor = Color.White;
            lblTitlle.Location = new Point(100, 455);
            lblTitlle.Name = "lblTitlle";
            lblTitlle.Size = new Size(199, 33);
            lblTitlle.TabIndex = 33;
            lblTitlle.Text = "Reset password";
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(20, 44, 76);
            ClientSize = new Size(600, 1080);
            Controls.Add(lblTitlle);
            Controls.Add(lblTitle2);
            Controls.Add(txbEmail);
            Controls.Add(lblAsk);
            Controls.Add(btnReset);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordForm";
            Text = "RegisterManuallyForm";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAsk;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitlle;
    }
}