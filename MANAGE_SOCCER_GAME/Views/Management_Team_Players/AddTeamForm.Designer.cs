namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    partial class AddTeamForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txbProvince = new Guna.UI2.WinForms.Guna2TextBox();
            txbTeamname = new Guna.UI2.WinForms.Guna2TextBox();
            lblName = new Label();
            lblProvince = new Label();
            lblTitle = new Label();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            gnElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            openFileDialog = new OpenFileDialog();
            picAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            cbbTournament = new Guna.UI2.WinForms.Guna2ComboBox();
            lblTournament = new Label();
            lblCoach = new Label();
            cbbCoach = new Guna.UI2.WinForms.Guna2ComboBox();
            txbUpload = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // txbProvince
            // 
            txbProvince.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbProvince.BorderColor = Color.FromArgb(52, 52, 116);
            txbProvince.BorderRadius = 5;
            txbProvince.Cursor = Cursors.IBeam;
            txbProvince.CustomizableEdges = customizableEdges1;
            txbProvince.DefaultText = "";
            txbProvince.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbProvince.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbProvince.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbProvince.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbProvince.FillColor = Color.FromArgb(52, 52, 116);
            txbProvince.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbProvince.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbProvince.ForeColor = Color.Silver;
            txbProvince.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbProvince.Location = new Point(50, 420);
            txbProvince.Margin = new Padding(6, 5, 6, 5);
            txbProvince.Name = "txbProvince";
            txbProvince.PlaceholderText = "Province";
            txbProvince.SelectedText = "";
            txbProvince.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txbProvince.Size = new Size(400, 50);
            txbProvince.TabIndex = 34;
            txbProvince.Tag = "Province";
            txbProvince.Click += txbProvince_Click;
            txbProvince.Leave += txbProvince_Leave;
            txbProvince.MouseLeave += txbProvince_MouseLeave;
            txbProvince.MouseHover += txbProvince_MouseHover;
            // 
            // txbTeamname
            // 
            txbTeamname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbTeamname.AutoSize = true;
            txbTeamname.BorderColor = Color.FromArgb(52, 52, 116);
            txbTeamname.BorderRadius = 5;
            txbTeamname.Cursor = Cursors.IBeam;
            txbTeamname.CustomizableEdges = customizableEdges3;
            txbTeamname.DefaultText = "";
            txbTeamname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbTeamname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbTeamname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbTeamname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbTeamname.FillColor = Color.FromArgb(52, 52, 116);
            txbTeamname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTeamname.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTeamname.ForeColor = Color.Silver;
            txbTeamname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTeamname.Location = new Point(50, 320);
            txbTeamname.Margin = new Padding(6);
            txbTeamname.Name = "txbTeamname";
            txbTeamname.PlaceholderText = "Team name";
            txbTeamname.SelectedText = "";
            txbTeamname.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txbTeamname.Size = new Size(400, 50);
            txbTeamname.TabIndex = 33;
            txbTeamname.Tag = "Team Name";
            txbTeamname.Click += txbTeamname_Click;
            txbTeamname.Leave += txbTeamname_Leave;
            txbTeamname.MouseLeave += txbTeamname_MouseLeave;
            txbTeamname.MouseHover += txbTeamname_MouseHover;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(50, 280);
            lblName.Name = "lblName";
            lblName.Size = new Size(120, 30);
            lblName.TabIndex = 38;
            lblName.Text = "Team Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProvince
            // 
            lblProvince.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblProvince.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProvince.ForeColor = Color.White;
            lblProvince.Location = new Point(50, 380);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(90, 30);
            lblProvince.TabIndex = 39;
            lblProvince.Text = "Province";
            lblProvince.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(170, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(160, 40);
            lblTitle.TabIndex = 40;
            lblTitle.Text = "ADD TEAM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnCancel.BorderRadius = 5;
            btnCancel.CustomizableEdges = customizableEdges5;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(60, 211, 252);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(50, 710);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnSubmit.BorderRadius = 5;
            btnSubmit.CustomizableEdges = customizableEdges7;
            btnSubmit.DisabledState.BorderColor = Color.DarkGray;
            btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSubmit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSubmit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSubmit.FillColor = Color.FromArgb(60, 211, 252);
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(350, 710);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSubmit.Size = new Size(100, 40);
            btnSubmit.TabIndex = 42;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // gnElipse
            // 
            gnElipse.BorderRadius = 40;
            gnElipse.TargetControl = this;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // picAvatar
            // 
            picAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picAvatar.CustomizableEdges = customizableEdges15;
            picAvatar.ImageRotate = 0F;
            picAvatar.Location = new Point(50, 143);
            picAvatar.Name = "picAvatar";
            picAvatar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            picAvatar.Size = new Size(120, 120);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 43;
            picAvatar.TabStop = false;
            // 
            // cbbTournament
            // 
            cbbTournament.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cbbTournament.BackColor = Color.Transparent;
            cbbTournament.CustomizableEdges = customizableEdges13;
            cbbTournament.DrawMode = DrawMode.OwnerDrawFixed;
            cbbTournament.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTournament.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbTournament.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbTournament.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbTournament.ForeColor = Color.FromArgb(68, 88, 112);
            cbbTournament.ItemHeight = 30;
            cbbTournament.Location = new Point(50, 520);
            cbbTournament.Name = "cbbTournament";
            cbbTournament.ShadowDecoration.CustomizableEdges = customizableEdges14;
            cbbTournament.Size = new Size(400, 36);
            cbbTournament.TabIndex = 44;
            // 
            // lblTournament
            // 
            lblTournament.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTournament.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTournament.ForeColor = Color.White;
            lblTournament.Location = new Point(50, 480);
            lblTournament.Name = "lblTournament";
            lblTournament.Size = new Size(120, 30);
            lblTournament.TabIndex = 45;
            lblTournament.Text = "Tournament";
            lblTournament.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCoach
            // 
            lblCoach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCoach.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoach.ForeColor = Color.White;
            lblCoach.Location = new Point(50, 566);
            lblCoach.Name = "lblCoach";
            lblCoach.Size = new Size(70, 30);
            lblCoach.TabIndex = 46;
            lblCoach.Text = "Coach";
            lblCoach.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbCoach
            // 
            cbbCoach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cbbCoach.BackColor = Color.Transparent;
            cbbCoach.CustomizableEdges = customizableEdges11;
            cbbCoach.DrawMode = DrawMode.OwnerDrawFixed;
            cbbCoach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCoach.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbCoach.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbCoach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbCoach.ForeColor = Color.FromArgb(68, 88, 112);
            cbbCoach.ItemHeight = 30;
            cbbCoach.Location = new Point(50, 606);
            cbbCoach.Name = "cbbCoach";
            cbbCoach.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cbbCoach.Size = new Size(400, 36);
            cbbCoach.TabIndex = 47;
            // 
            // txbUpload
            // 
            txbUpload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbUpload.BorderRadius = 5;
            txbUpload.CustomizableEdges = customizableEdges9;
            txbUpload.DisabledState.BorderColor = Color.DarkGray;
            txbUpload.DisabledState.CustomBorderColor = Color.DarkGray;
            txbUpload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            txbUpload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            txbUpload.FillColor = Color.FromArgb(60, 211, 252);
            txbUpload.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbUpload.ForeColor = Color.White;
            txbUpload.Location = new Point(190, 185);
            txbUpload.Name = "txbUpload";
            txbUpload.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txbUpload.Size = new Size(140, 30);
            txbUpload.TabIndex = 48;
            txbUpload.Text = "Upload logo";
            txbUpload.Click += txbUpload_Click;
            // 
            // AddTeamForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(31, 70, 121);
            ClientSize = new Size(500, 800);
            Controls.Add(txbUpload);
            Controls.Add(cbbCoach);
            Controls.Add(lblCoach);
            Controls.Add(lblTournament);
            Controls.Add(cbbTournament);
            Controls.Add(picAvatar);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Controls.Add(lblProvince);
            Controls.Add(lblName);
            Controls.Add(txbProvince);
            Controls.Add(txbTeamname);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTeamForm";
            Text = "AddTeamForm";
            Load += AddTeamForm_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txbProvince;
        private Guna.UI2.WinForms.Guna2TextBox txbTeamname;
        private Label lblName;
        private Label lblProvince;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Elipse gnElipse;
        private Guna.UI2.WinForms.Guna2PictureBox picAvatar;
        private OpenFileDialog openFileDialog;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTournament;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCoach;
        private Label lblCoach;
        private Label lblTournament;
        private Guna.UI2.WinForms.Guna2Button txbUpload;
    }
}