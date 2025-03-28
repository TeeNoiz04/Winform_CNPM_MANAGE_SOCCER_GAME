namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    partial class PlayerDetailForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnHeader = new Panel();
            btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            txbTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            cbbCot = new ComboBox();
            lblCot = new Label();
            lblSapXep = new Label();
            cbbSapXep = new ComboBox();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            lblAge = new Label();
            lblPosition = new Label();
            lblName = new Label();
            guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblNameClub = new Label();
            lblAssists = new Label();
            lblGoalsScored = new Label();
            lblMatchPlayed = new Label();
            lblRedCards = new Label();
            lblYellowCards = new Label();
            label1 = new Label();
            pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(btnTimKiem);
            pnHeader.Controls.Add(txbTimKiem);
            pnHeader.Controls.Add(cbbCot);
            pnHeader.Controls.Add(lblCot);
            pnHeader.Controls.Add(lblSapXep);
            pnHeader.Controls.Add(cbbSapXep);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1620, 50);
            pnHeader.TabIndex = 24;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BorderRadius = 5;
            btnTimKiem.CustomizableEdges = customizableEdges1;
            btnTimKiem.DisabledState.BorderColor = Color.DarkGray;
            btnTimKiem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTimKiem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTimKiem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTimKiem.FillColor = Color.FromArgb(60, 211, 252);
            btnTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(10, 10);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnTimKiem.Size = new Size(80, 30);
            btnTimKiem.TabIndex = 26;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.Click += btnTimKiem_ClickAsync;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbTimKiem.Cursor = Cursors.IBeam;
            txbTimKiem.CustomizableEdges = customizableEdges3;
            txbTimKiem.DefaultText = "Search";
            txbTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTimKiem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTimKiem.Location = new Point(96, 10);
            txbTimKiem.Margin = new Padding(3, 4, 3, 4);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.PlaceholderText = "";
            txbTimKiem.SelectedText = "";
            txbTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txbTimKiem.Size = new Size(1187, 30);
            txbTimKiem.TabIndex = 15;
            txbTimKiem.Click += txbTimKiem_Click;
            txbTimKiem.KeyPress += txbTimKiem_KeyPress;
            txbTimKiem.Leave += txbTimKiem_Leave;
            // 
            // cbbCot
            // 
            cbbCot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbCot.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbCot.FormattingEnabled = true;
            cbbCot.Location = new Point(1495, 13);
            cbbCot.Margin = new Padding(3, 2, 3, 2);
            cbbCot.Name = "cbbCot";
            cbbCot.Size = new Size(115, 26);
            cbbCot.TabIndex = 11;
            //cbbCot.SelectedIndexChanged += cbbCot_SelectedIndexChanged;
            // 
            // lblCot
            // 
            lblCot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCot.AutoSize = true;
            lblCot.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCot.ForeColor = Color.White;
            lblCot.Location = new Point(1457, 16);
            lblCot.Name = "lblCot";
            lblCot.Size = new Size(32, 18);
            lblCot.TabIndex = 10;
            lblCot.Text = "Cột";
            // 
            // lblSapXep
            // 
            lblSapXep.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSapXep.AutoSize = true;
            lblSapXep.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSapXep.ForeColor = Color.White;
            lblSapXep.Location = new Point(1289, 16);
            lblSapXep.Name = "lblSapXep";
            lblSapXep.Size = new Size(61, 18);
            lblSapXep.TabIndex = 8;
            lblSapXep.Text = "Sắp xếp";
            // 
            // cbbSapXep
            // 
            cbbSapXep.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbSapXep.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbSapXep.FormattingEnabled = true;
            cbbSapXep.Items.AddRange(new object[] { "Tăng dần", "Giảm dần" });
            cbbSapXep.Location = new Point(1356, 13);
            cbbSapXep.Margin = new Padding(3, 2, 3, 2);
            cbbSapXep.Name = "cbbSapXep";
            cbbSapXep.Size = new Size(95, 26);
            cbbSapXep.TabIndex = 9;
            //cbbSapXep.SelectedIndexChanged += cbbSapXep_SelectedIndexChanged;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges5;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(0, 0);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2PictureBox1.Size = new Size(270, 270);
            guna2PictureBox1.TabIndex = 28;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(lblRedCards);
            guna2Panel1.Controls.Add(lblYellowCards);
            guna2Panel1.Controls.Add(lblAssists);
            guna2Panel1.Controls.Add(lblGoalsScored);
            guna2Panel1.Controls.Add(lblMatchPlayed);
            guna2Panel1.Controls.Add(lblNameClub);
            guna2Panel1.Controls.Add(guna2PictureBox2);
            guna2Panel1.Controls.Add(guna2Button1);
            guna2Panel1.Controls.Add(lblAge);
            guna2Panel1.Controls.Add(lblPosition);
            guna2Panel1.Controls.Add(lblName);
            guna2Panel1.Controls.Add(guna2PictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.Location = new Point(96, 244);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(977, 318);
            guna2Panel1.TabIndex = 29;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges9;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(60, 211, 252);
            guna2Button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(317, 240);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button1.Size = new Size(80, 30);
            guna2Button1.TabIndex = 30;
            guna2Button1.Text = "Edit";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.White;
            lblAge.Location = new Point(317, 119);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(37, 18);
            lblAge.TabIndex = 31;
            lblAge.Text = "Tuổi";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.ForeColor = Color.White;
            lblPosition.Location = new Point(317, 87);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(36, 18);
            lblPosition.TabIndex = 30;
            lblPosition.Text = "Vị trí";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(317, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 18);
            lblName.TabIndex = 29;
            lblName.Text = "Họ tên";
            // 
            // guna2PictureBox2
            // 
            guna2PictureBox2.CustomizableEdges = customizableEdges7;
            guna2PictureBox2.ImageRotate = 0F;
            guna2PictureBox2.Location = new Point(800, 45);
            guna2PictureBox2.Name = "guna2PictureBox2";
            guna2PictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2PictureBox2.Size = new Size(127, 127);
            guna2PictureBox2.TabIndex = 32;
            guna2PictureBox2.TabStop = false;
            // 
            // lblNameClub
            // 
            lblNameClub.AutoSize = true;
            lblNameClub.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameClub.ForeColor = Color.White;
            lblNameClub.Location = new Point(822, 189);
            lblNameClub.Name = "lblNameClub";
            lblNameClub.Size = new Size(105, 18);
            lblNameClub.TabIndex = 33;
            lblNameClub.Text = "Tên câu lạp bộ";
            // 
            // lblAssists
            // 
            lblAssists.AutoSize = true;
            lblAssists.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssists.ForeColor = Color.White;
            lblAssists.Location = new Point(553, 119);
            lblAssists.Name = "lblAssists";
            lblAssists.Size = new Size(62, 18);
            lblAssists.TabIndex = 36;
            lblAssists.Text = "Kiến tạo";
            // 
            // lblGoalsScored
            // 
            lblGoalsScored.AutoSize = true;
            lblGoalsScored.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGoalsScored.ForeColor = Color.White;
            lblGoalsScored.Location = new Point(553, 87);
            lblGoalsScored.Name = "lblGoalsScored";
            lblGoalsScored.Size = new Size(74, 18);
            lblGoalsScored.TabIndex = 35;
            lblGoalsScored.Text = "Bàn thắng";
            // 
            // lblMatchPlayed
            // 
            lblMatchPlayed.AutoSize = true;
            lblMatchPlayed.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatchPlayed.ForeColor = Color.White;
            lblMatchPlayed.Location = new Point(553, 58);
            lblMatchPlayed.Name = "lblMatchPlayed";
            lblMatchPlayed.Size = new Size(56, 18);
            lblMatchPlayed.TabIndex = 34;
            lblMatchPlayed.Text = "Số trận";
            // 
            // lblRedCards
            // 
            lblRedCards.AutoSize = true;
            lblRedCards.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRedCards.ForeColor = Color.White;
            lblRedCards.Location = new Point(553, 196);
            lblRedCards.Name = "lblRedCards";
            lblRedCards.Size = new Size(54, 18);
            lblRedCards.TabIndex = 38;
            lblRedCards.Text = "Thẻ đỏ";
            // 
            // lblYellowCards
            // 
            lblYellowCards.AutoSize = true;
            lblYellowCards.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYellowCards.ForeColor = Color.White;
            lblYellowCards.Location = new Point(553, 164);
            lblYellowCards.Name = "lblYellowCards";
            lblYellowCards.Size = new Size(68, 18);
            lblYellowCards.TabIndex = 37;
            lblYellowCards.Text = "Thẻ vàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(316, 154);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 39;
            label1.Text = "Chiều cao";
            // 
            // PlayerDetailForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(20, 44, 76);
            ClientSize = new Size(1620, 1000);
            Controls.Add(guna2Panel1);
            Controls.Add(pnHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlayerDetailForm";
            Text = "OrdersForm";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private Guna.UI2.WinForms.Guna2TextBox txbTimKiem;
        private System.Windows.Forms.ComboBox cbbCot;
        private System.Windows.Forms.Label lblCot;
        private System.Windows.Forms.Label lblSapXep;
        private System.Windows.Forms.ComboBox cbbSapXep;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label lblAge;
        private Label lblPosition;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Label lblNameClub;
        private Label lblAssists;
        private Label lblGoalsScored;
        private Label lblMatchPlayed;
        private Label label1;
        private Label lblRedCards;
        private Label lblYellowCards;
    }
}