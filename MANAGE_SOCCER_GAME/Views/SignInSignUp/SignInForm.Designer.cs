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
            this.pnFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFooter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblForgotPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblContinue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAskCreate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCreateAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFB = new Guna.UI2.WinForms.Guna2Button();
            this.btnApple = new Guna.UI2.WinForms.Guna2Button();
            this.btnGG = new Guna.UI2.WinForms.Guna2Button();
            this.lblAsk = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnLine = new Guna.UI2.WinForms.Guna2Panel();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFooter
            // 
            this.pnFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(116)))));
            this.pnFooter.Controls.Add(this.lblFooter);
            this.pnFooter.Location = new System.Drawing.Point(0, 1000);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(600, 80);
            this.pnFooter.TabIndex = 1;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = false;
            this.lblFooter.BackColor = System.Drawing.Color.Transparent;
            this.lblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.White;
            this.lblFooter.Location = new System.Drawing.Point(246, 24);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(122, 35);
            this.lblFooter.TabIndex = 13;
            this.lblFooter.Text = "MAY 63";
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(100, 500);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbUsername
            // 
            this.txbUsername.AutoSize = true;
            this.txbUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(116)))));
            this.txbUsername.BorderRadius = 5;
            this.txbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUsername.DefaultText = "Email or Username";
            this.txbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(116)))));
            this.txbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsername.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.ForeColor = System.Drawing.Color.Silver;
            this.txbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsername.Location = new System.Drawing.Point(100, 370);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.PasswordChar = '\0';
            this.txbUsername.PlaceholderText = "";
            this.txbUsername.SelectedText = "";
            this.txbUsername.Size = new System.Drawing.Size(400, 50);
            this.txbUsername.TabIndex = 3;
            this.txbUsername.Click += new System.EventHandler(this.txbUserName_Click);
            this.txbUsername.Leave += new System.EventHandler(this.txbUsername_Leave);
            this.txbUsername.MouseLeave += new System.EventHandler(this.txbUsername_MouseLeave);
            this.txbUsername.MouseHover += new System.EventHandler(this.txbUsername_MouseHover);
            // 
            // txbPassword
            // 
            this.txbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(116)))));
            this.txbPassword.BorderRadius = 5;
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassword.DefaultText = "Password";
            this.txbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(116)))));
            this.txbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPassword.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.ForeColor = System.Drawing.Color.Silver;
            this.txbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPassword.Location = new System.Drawing.Point(100, 430);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '\0';
            this.txbPassword.PlaceholderText = "";
            this.txbPassword.SelectedText = "";
            this.txbPassword.Size = new System.Drawing.Size(400, 50);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.Click += new System.EventHandler(this.txbPassword_Click);
            this.txbPassword.Leave += new System.EventHandler(this.txbPassword_Leave);
            this.txbPassword.MouseLeave += new System.EventHandler(this.txbPassword_MouseLeave);
            this.txbPassword.MouseHover += new System.EventHandler(this.txbPassword_MouseHover);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = false;
            this.lblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(230, 575);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(140, 19);
            this.lblForgotPassword.TabIndex = 5;
            this.lblForgotPassword.Text = "Forgot password?";
            this.lblForgotPassword.MouseHover += new System.EventHandler(this.lblForgotPassword_MouseHover);
            // 
            // lblContinue
            // 
            this.lblContinue.AutoSize = false;
            this.lblContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(44)))), ((int)(((byte)(76)))));
            this.lblContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinue.ForeColor = System.Drawing.Color.DarkGray;
            this.lblContinue.Location = new System.Drawing.Point(238, 625);
            this.lblContinue.Name = "lblContinue";
            this.lblContinue.Size = new System.Drawing.Size(123, 19);
            this.lblContinue.TabIndex = 6;
            this.lblContinue.Text = "CONTINUE WITH";
            // 
            // lblAskCreate
            // 
            this.lblAskCreate.AutoSize = false;
            this.lblAskCreate.BackColor = System.Drawing.Color.Transparent;
            this.lblAskCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskCreate.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAskCreate.Location = new System.Drawing.Point(154, 725);
            this.lblAskCreate.Name = "lblAskCreate";
            this.lblAskCreate.Size = new System.Drawing.Size(181, 19);
            this.lblAskCreate.TabIndex = 7;
            this.lblAskCreate.Text = "Don\'t have an account yet?";
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = false;
            this.lblCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.lblCreateAccount.Location = new System.Drawing.Point(341, 725);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(104, 19);
            this.lblCreateAccount.TabIndex = 8;
            this.lblCreateAccount.Text = "Create account";
            this.lblCreateAccount.Click += new System.EventHandler(this.lblCreateAccount_Click);
            this.lblCreateAccount.MouseHover += new System.EventHandler(this.lblCreateAccount_MouseHover);
            // 
            // btnFB
            // 
            this.btnFB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(44)))), ((int)(((byte)(76)))));
            this.btnFB.BorderRadius = 10;
            this.btnFB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(116)))));
            this.btnFB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFB.ForeColor = System.Drawing.Color.White;
            this.btnFB.Location = new System.Drawing.Point(100, 660);
            this.btnFB.Name = "btnFB";
            this.btnFB.Size = new System.Drawing.Size(120, 35);
            this.btnFB.TabIndex = 9;
            this.btnFB.Text = "Facebook";
            // 
            // btnApple
            // 
            this.btnApple.BorderRadius = 10;
            this.btnApple.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApple.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApple.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApple.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApple.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(116)))));
            this.btnApple.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApple.ForeColor = System.Drawing.Color.White;
            this.btnApple.Location = new System.Drawing.Point(380, 660);
            this.btnApple.Name = "btnApple";
            this.btnApple.Size = new System.Drawing.Size(120, 35);
            this.btnApple.TabIndex = 10;
            this.btnApple.Text = "Apple";
            // 
            // btnGG
            // 
            this.btnGG.BorderRadius = 10;
            this.btnGG.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(116)))));
            this.btnGG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGG.ForeColor = System.Drawing.Color.White;
            this.btnGG.Location = new System.Drawing.Point(240, 660);
            this.btnGG.Name = "btnGG";
            this.btnGG.Size = new System.Drawing.Size(120, 35);
            this.btnGG.TabIndex = 11;
            this.btnGG.Text = "Google";
            // 
            // lblAsk
            // 
            this.lblAsk.AutoSize = false;
            this.lblAsk.BackColor = System.Drawing.Color.Transparent;
            this.lblAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsk.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAsk.Location = new System.Drawing.Point(209, 330);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(181, 19);
            this.lblAsk.TabIndex = 12;
            this.lblAsk.Text = "Log in with your credentials";
            // 
            // pnLine
            // 
            this.pnLine.BorderColor = System.Drawing.Color.Gray;
            this.pnLine.BorderThickness = 1;
            this.pnLine.FillColor = System.Drawing.Color.Gray;
            this.pnLine.ForeColor = System.Drawing.Color.DarkGray;
            this.pnLine.Location = new System.Drawing.Point(100, 635);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(400, 1);
            this.pnLine.TabIndex = 13;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            //this.picLogo.Image = global::AppCyberGameClient.Properties.Resources.Logo_2;
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(0, 150);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(600, 140);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = AppColors.GreenPakistan;
            //this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(44)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(600, 1080);
            this.Controls.Add(this.pnLine);
            this.Controls.Add(this.lblAsk);
            this.Controls.Add(this.btnGG);
            this.Controls.Add(this.btnApple);
            this.Controls.Add(this.btnFB);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.lblAskCreate);
            this.Controls.Add(this.lblContinue);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.pnFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Panel pnFooter;
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFooter;
        private Guna.UI2.WinForms.Guna2Panel pnLine;
    }
}