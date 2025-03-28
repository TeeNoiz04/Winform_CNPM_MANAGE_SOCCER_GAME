namespace MANAGE_SOCCER_GAME.Views
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.pnContentMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.ElipseAccount = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnAccount = new Guna.UI2.WinForms.Guna2Panel();
            this.btnShowPnAccount = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTimePlay = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ElipseMainMenu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnMainMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPrizeVault = new Guna.UI2.WinForms.Guna2Button();
            this.btnShop = new Guna.UI2.WinForms.Guna2Button();
            this.btnApps = new Guna.UI2.WinForms.Guna2Button();
            this.btnArcade = new Guna.UI2.WinForms.Guna2Button();
            this.btnGames = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.ElipseContentMenu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnNotify = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnVolum = new Guna.UI2.WinForms.Guna2ImageButton();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CheckCart = new System.Windows.Forms.Timer(this.components);
            this.btnCheck = new Guna.UI2.WinForms.Guna2Button();
            this.pnAccount.SuspendLayout();
            this.pnMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContentMenu
            // 
            this.pnContentMenu.Location = new System.Drawing.Point(582, 82);
            this.pnContentMenu.Name = "pnContentMenu";
            this.pnContentMenu.Size = new System.Drawing.Size(755, 55);
            this.pnContentMenu.TabIndex = 6;
            // 
            // ElipseAccount
            // 
            this.ElipseAccount.BorderRadius = 50;
            this.ElipseAccount.TargetControl = this.pnAccount;
            // 
            // pnAccount
            // 
            this.pnAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnAccount.BackgroundImage")));
            this.pnAccount.Controls.Add(this.btnShowPnAccount);
            this.pnAccount.Controls.Add(this.lblTimePlay);
            this.pnAccount.Controls.Add(this.lblUserName);
            this.pnAccount.Location = new System.Drawing.Point(1700, 20);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(195, 70);
            this.pnAccount.TabIndex = 10;
            // 
            // btnShowPnAccount
            // 
            this.btnShowPnAccount.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnShowPnAccount.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnShowPnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPnAccount.Image")));
            this.btnShowPnAccount.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShowPnAccount.ImageRotate = 0F;
            this.btnShowPnAccount.Location = new System.Drawing.Point(158, 28);
            this.btnShowPnAccount.Name = "btnShowPnAccount";
            this.btnShowPnAccount.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnShowPnAccount.Size = new System.Drawing.Size(20, 20);
            this.btnShowPnAccount.TabIndex = 12;
            this.btnShowPnAccount.Click += new System.EventHandler(this.btnShowPnAccount_Click);
            // 
            // lblTimePlay
            // 
            this.lblTimePlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.lblTimePlay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.lblTimePlay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTimePlay.DefaultText = "Time";
            this.lblTimePlay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblTimePlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblTimePlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblTimePlay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblTimePlay.Enabled = false;
            this.lblTimePlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.lblTimePlay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTimePlay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePlay.ForeColor = System.Drawing.Color.White;
            this.lblTimePlay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTimePlay.Location = new System.Drawing.Point(20, 37);
            this.lblTimePlay.Name = "lblTimePlay";
            this.lblTimePlay.PlaceholderText = "";
            this.lblTimePlay.ReadOnly = true;
            this.lblTimePlay.SelectedText = "";
            this.lblTimePlay.Size = new System.Drawing.Size(100, 22);
            this.lblTimePlay.TabIndex = 11;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(20, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Name";
            // 
            // ElipseMainMenu
            // 
            this.ElipseMainMenu.BorderRadius = 30;
            this.ElipseMainMenu.TargetControl = this.pnMainMenu;
            // 
            // pnMainMenu
            // 
            this.pnMainMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMainMenu.BackgroundImage")));
            this.pnMainMenu.Controls.Add(this.btnPrizeVault);
            this.pnMainMenu.Controls.Add(this.btnShop);
            this.pnMainMenu.Controls.Add(this.btnApps);
            this.pnMainMenu.Controls.Add(this.btnArcade);
            this.pnMainMenu.Controls.Add(this.btnGames);
            this.pnMainMenu.Controls.Add(this.btnHome);
            this.pnMainMenu.Location = new System.Drawing.Point(582, 13);
            this.pnMainMenu.Name = "pnMainMenu";
            this.pnMainMenu.Size = new System.Drawing.Size(755, 55);
            this.pnMainMenu.TabIndex = 1;
            // 
            // btnPrizeVault
            // 
            this.btnPrizeVault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrizeVault.BackgroundImage")));
            this.btnPrizeVault.BorderRadius = 15;
            this.btnPrizeVault.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnPrizeVault.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrizeVault.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrizeVault.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrizeVault.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrizeVault.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrizeVault.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnPrizeVault.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrizeVault.ForeColor = System.Drawing.Color.White;
            this.btnPrizeVault.Location = new System.Drawing.Point(630, 5);
            this.btnPrizeVault.Name = "btnPrizeVault";
            this.btnPrizeVault.Size = new System.Drawing.Size(120, 45);
            this.btnPrizeVault.TabIndex = 5;
            this.btnPrizeVault.Text = "Prize Vault";
            // 
            // btnShop
            // 
            this.btnShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShop.BackgroundImage")));
            this.btnShop.BorderRadius = 15;
            this.btnShop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnShop.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnShop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Location = new System.Drawing.Point(505, 5);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(120, 45);
            this.btnShop.TabIndex = 4;
            this.btnShop.Text = "Shop";
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnApps
            // 
            this.btnApps.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApps.BackgroundImage")));
            this.btnApps.BorderRadius = 15;
            this.btnApps.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnApps.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnApps.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApps.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApps.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApps.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApps.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnApps.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApps.ForeColor = System.Drawing.Color.White;
            this.btnApps.Location = new System.Drawing.Point(380, 5);
            this.btnApps.Name = "btnApps";
            this.btnApps.Size = new System.Drawing.Size(120, 45);
            this.btnApps.TabIndex = 3;
            this.btnApps.Text = "Apps";
            this.btnApps.Click += new System.EventHandler(this.btnApps_Click);
            // 
            // btnArcade
            // 
            this.btnArcade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArcade.BackgroundImage")));
            this.btnArcade.BorderRadius = 15;
            this.btnArcade.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnArcade.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnArcade.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnArcade.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnArcade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnArcade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnArcade.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnArcade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcade.ForeColor = System.Drawing.Color.White;
            this.btnArcade.Location = new System.Drawing.Point(255, 5);
            this.btnArcade.Name = "btnArcade";
            this.btnArcade.Size = new System.Drawing.Size(120, 45);
            this.btnArcade.TabIndex = 2;
            this.btnArcade.Text = "Arcade";
            // 
            // btnGames
            // 
            this.btnGames.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGames.BackgroundImage")));
            this.btnGames.BorderRadius = 15;
            this.btnGames.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnGames.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGames.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGames.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGames.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGames.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGames.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnGames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGames.ForeColor = System.Drawing.Color.White;
            this.btnGames.Location = new System.Drawing.Point(130, 5);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(120, 45);
            this.btnGames.TabIndex = 1;
            this.btnGames.Text = "Games";
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BorderRadius = 15;
            this.btnHome.Checked = true;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(252)))));
            this.btnHome.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(5, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ElipseContentMenu
            // 
            this.ElipseContentMenu.BorderRadius = 30;
            this.ElipseContentMenu.TargetControl = this.pnContentMenu;
            // 
            // btnNotify
            // 
            this.btnNotify.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNotify.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNotify.Image = ((System.Drawing.Image)(resources.GetObject("btnNotify.Image")));
            this.btnNotify.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNotify.ImageRotate = 0F;
            this.btnNotify.Location = new System.Drawing.Point(1640, 35);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNotify.Size = new System.Drawing.Size(40, 40);
            this.btnNotify.TabIndex = 9;
            // 
            // btnVolum
            // 
            this.btnVolum.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnVolum.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnVolum.Image = ((System.Drawing.Image)(resources.GetObject("btnVolum.Image")));
            this.btnVolum.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnVolum.ImageRotate = 0F;
            this.btnVolum.Location = new System.Drawing.Point(1580, 35);
            this.btnVolum.Name = "btnVolum";
            this.btnVolum.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnVolum.Size = new System.Drawing.Size(40, 40);
            this.btnVolum.TabIndex = 8;
            // 
            // picLogo
            // 
            //this.picLogo.Image = global::AppCyberGameClient.Properties.Resources.Logo_2_1;
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(20, 35);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(300, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // CheckCart
            // 
            this.CheckCart.Interval = 500;
            //this.CheckCart.Tick += new System.EventHandler(this.CheckCart_Tick);
            // 
            // btnCheck
            // 
            this.btnCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheck.FillColor = System.Drawing.Color.Red;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(1512, 35);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(40, 40);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "X";
            this.btnCheck.Visible = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(1920, 150);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.pnAccount);
            this.Controls.Add(this.btnNotify);
            this.Controls.Add(this.btnVolum);
            this.Controls.Add(this.pnContentMenu);
            this.Controls.Add(this.pnMainMenu);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            this.pnMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Panel pnMainMenu;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnApps;
        private Guna.UI2.WinForms.Guna2Button btnArcade;
        private Guna.UI2.WinForms.Guna2Button btnGames;
        private Guna.UI2.WinForms.Guna2Button btnPrizeVault;
        private Guna.UI2.WinForms.Guna2Button btnShop;
        private Guna.UI2.WinForms.Guna2Panel pnContentMenu;
        private Guna.UI2.WinForms.Guna2ImageButton btnVolum;
        private Guna.UI2.WinForms.Guna2ImageButton btnNotify;
        private Guna.UI2.WinForms.Guna2Panel pnAccount;
        private Guna.UI2.WinForms.Guna2Elipse ElipseAccount;
        private Guna.UI2.WinForms.Guna2Elipse ElipseMainMenu;
        private Guna.UI2.WinForms.Guna2Elipse ElipseContentMenu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserName;
        private Guna.UI2.WinForms.Guna2TextBox lblTimePlay;
        private Guna.UI2.WinForms.Guna2ImageButton btnShowPnAccount;
        private System.Windows.Forms.Timer CheckCart;
        private Guna.UI2.WinForms.Guna2Button btnCheck;
    }
}