using MANAGE_SOCCER_GAME.Utils.Config;

namespace MANAGE_SOCCER_GAME.Views.SignInSignUp
{
    partial class SignInForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            lblForgotPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblContinue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblAskCreate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblCreateAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnFB = new Guna.UI2.WinForms.Guna2Button();
            btnApple = new Guna.UI2.WinForms.Guna2Button();
            btnGG = new Guna.UI2.WinForms.Guna2Button();
            lblAsk = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnLine = new Guna.UI2.WinForms.Guna2Panel();
            picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnLogin.BorderRadius = 10;
            btnLogin.CustomizableEdges = customizableEdges1;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(60, 211, 252);
            btnLogin.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(100, 520);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogin.Size = new Size(400, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.Click += btnLogin_Click;
            // 
            // txbUsername
            // 
            txbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbUsername.AutoSize = true;
            txbUsername.BorderColor = Color.FromArgb(52, 52, 116);
            txbUsername.BorderRadius = 5;
            txbUsername.Cursor = Cursors.IBeam;
            txbUsername.CustomizableEdges = customizableEdges3;
            txbUsername.DefaultText = "Email or Username";
            txbUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbUsername.FillColor = Color.FromArgb(52, 52, 116);
            txbUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbUsername.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbUsername.ForeColor = Color.Silver;
            txbUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbUsername.Location = new Point(100, 390);
            txbUsername.Margin = new Padding(6);
            txbUsername.Name = "txbUsername";
            txbUsername.PlaceholderText = "";
            txbUsername.SelectedText = "";
            txbUsername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txbUsername.Size = new Size(400, 50);
            txbUsername.TabIndex = 3;
            txbUsername.Click += txbUserName_Click;
            txbUsername.Leave += txbUsername_Leave;
            txbUsername.MouseLeave += txbUsername_MouseLeave;
            txbUsername.MouseHover += txbUsername_MouseHover;
            // 
            // txbPassword
            // 
            txbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbPassword.BorderColor = Color.FromArgb(52, 52, 116);
            txbPassword.BorderRadius = 5;
            txbPassword.Cursor = Cursors.IBeam;
            txbPassword.CustomizableEdges = customizableEdges5;
            txbPassword.DefaultText = "Password";
            txbPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbPassword.FillColor = Color.FromArgb(52, 52, 116);
            txbPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbPassword.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPassword.ForeColor = Color.Silver;
            txbPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbPassword.Location = new Point(100, 450);
            txbPassword.Margin = new Padding(6, 5, 6, 5);
            txbPassword.Name = "txbPassword";
            txbPassword.PlaceholderText = "";
            txbPassword.SelectedText = "";
            txbPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txbPassword.Size = new Size(400, 50);
            txbPassword.TabIndex = 4;
            txbPassword.Click += txbPassword_Click;
            txbPassword.Leave += txbPassword_Leave;
            txbPassword.MouseLeave += txbPassword_MouseLeave;
            txbPassword.MouseHover += txbPassword_MouseHover;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblForgotPassword.AutoSize = false;
            lblForgotPassword.BackColor = Color.Transparent;
            lblForgotPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.FromArgb(60, 211, 252);
            lblForgotPassword.Location = new Point(230, 595);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(140, 19);
            lblForgotPassword.TabIndex = 5;
            lblForgotPassword.Text = "Forgot password?";
            lblForgotPassword.MouseHover += lblForgotPassword_MouseHover;
            // 
            // lblContinue
            // 
            lblContinue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblContinue.AutoSize = false;
            lblContinue.BackColor = Color.FromArgb(20, 44, 76);
            lblContinue.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContinue.ForeColor = Color.DarkGray;
            lblContinue.Location = new Point(238, 645);
            lblContinue.Name = "lblContinue";
            lblContinue.Size = new Size(123, 19);
            lblContinue.TabIndex = 6;
            lblContinue.Text = "CONTINUE WITH";
            // 
            // lblAskCreate
            // 
            lblAskCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblAskCreate.AutoSize = false;
            lblAskCreate.BackColor = Color.Transparent;
            lblAskCreate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAskCreate.ForeColor = Color.DarkGray;
            lblAskCreate.Location = new Point(154, 745);
            lblAskCreate.Name = "lblAskCreate";
            lblAskCreate.Size = new Size(181, 19);
            lblAskCreate.TabIndex = 7;
            lblAskCreate.Text = "Don't have an account yet?";
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCreateAccount.AutoSize = false;
            lblCreateAccount.BackColor = Color.Transparent;
            lblCreateAccount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreateAccount.ForeColor = Color.FromArgb(60, 211, 252);
            lblCreateAccount.Location = new Point(341, 745);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(104, 19);
            lblCreateAccount.TabIndex = 8;
            lblCreateAccount.Text = "Create account";
            lblCreateAccount.Click += lblCreateAccount_Click;
            lblCreateAccount.MouseHover += lblCreateAccount_MouseHover;
            // 
            // btnFB
            // 
            btnFB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnFB.BackColor = Color.FromArgb(20, 44, 76);
            btnFB.BorderRadius = 10;
            btnFB.CustomizableEdges = customizableEdges7;
            btnFB.DisabledState.BorderColor = Color.DarkGray;
            btnFB.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFB.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFB.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFB.FillColor = Color.FromArgb(52, 52, 116);
            btnFB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFB.ForeColor = Color.White;
            btnFB.Location = new Point(100, 680);
            btnFB.Name = "btnFB";
            btnFB.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnFB.Size = new Size(120, 35);
            btnFB.TabIndex = 9;
            btnFB.Text = "Facebook";
            // 
            // btnApple
            // 
            btnApple.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnApple.BorderRadius = 10;
            btnApple.CustomizableEdges = customizableEdges9;
            btnApple.DisabledState.BorderColor = Color.DarkGray;
            btnApple.DisabledState.CustomBorderColor = Color.DarkGray;
            btnApple.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnApple.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnApple.FillColor = Color.FromArgb(52, 52, 116);
            btnApple.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApple.ForeColor = Color.White;
            btnApple.Location = new Point(380, 680);
            btnApple.Name = "btnApple";
            btnApple.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnApple.Size = new Size(120, 35);
            btnApple.TabIndex = 10;
            btnApple.Text = "Apple";
            // 
            // btnGG
            // 
            btnGG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnGG.BorderRadius = 10;
            btnGG.CustomizableEdges = customizableEdges11;
            btnGG.DisabledState.BorderColor = Color.DarkGray;
            btnGG.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGG.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGG.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGG.FillColor = Color.FromArgb(52, 52, 116);
            btnGG.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGG.ForeColor = Color.White;
            btnGG.Location = new Point(240, 680);
            btnGG.Name = "btnGG";
            btnGG.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnGG.Size = new Size(120, 35);
            btnGG.TabIndex = 11;
            btnGG.Text = "Google";
            // 
            // lblAsk
            // 
            lblAsk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblAsk.AutoSize = false;
            lblAsk.BackColor = Color.Transparent;
            lblAsk.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAsk.ForeColor = Color.DarkGray;
            lblAsk.Location = new Point(209, 350);
            lblAsk.Name = "lblAsk";
            lblAsk.Size = new Size(181, 19);
            lblAsk.TabIndex = 12;
            lblAsk.Text = "Log in with your credentials";
            // 
            // pnLine
            // 
            pnLine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pnLine.BorderColor = Color.Gray;
            pnLine.BorderThickness = 1;
            pnLine.CustomizableEdges = customizableEdges13;
            pnLine.FillColor = Color.Gray;
            pnLine.ForeColor = Color.DarkGray;
            pnLine.Location = new Point(100, 655);
            pnLine.Name = "pnLine";
            pnLine.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pnLine.Size = new Size(400, 1);
            pnLine.TabIndex = 13;
            // 
            // picLogo
            // 
            picLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.CustomizableEdges = customizableEdges15;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.ImageRotate = 0F;
            picLogo.Location = new Point(225, 170);
            picLogo.Name = "picLogo";
            picLogo.ShadowDecoration.CustomizableEdges = customizableEdges16;
            picLogo.Size = new Size(150, 150);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(20, 44, 76);
            ClientSize = new Size(600, 1080);
            Controls.Add(pnLine);
            Controls.Add(lblAsk);
            Controls.Add(btnGG);
            Controls.Add(btnApple);
            Controls.Add(btnFB);
            Controls.Add(lblCreateAccount);
            Controls.Add(lblAskCreate);
            Controls.Add(lblContinue);
            Controls.Add(lblForgotPassword);
            Controls.Add(txbPassword);
            Controls.Add(txbUsername);
            Controls.Add(btnLogin);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignInForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txbUsername;
        private Guna.UI2.WinForms.Guna2TextBox txbPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblForgotPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContinue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAskCreate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCreateAccount;
        private Guna.UI2.WinForms.Guna2Button btnFB;
        private Guna.UI2.WinForms.Guna2Button btnApple;
        private Guna.UI2.WinForms.Guna2Button btnGG;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAsk;
        private Guna.UI2.WinForms.Guna2Panel pnLine;
    }
}