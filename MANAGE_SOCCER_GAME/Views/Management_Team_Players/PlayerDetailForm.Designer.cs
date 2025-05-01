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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnHeader = new Panel();
            btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            txbTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            cbbCot = new ComboBox();
            lblCot = new Label();
            lblSapXep = new Label();
            cbbSapXep = new ComboBox();
            picAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            pnContent = new Guna.UI2.WinForms.Guna2Panel();
            lblRedCards = new Label();
            lblYellowCards = new Label();
            lblAssists = new Label();
            lblGoalsScored = new Label();
            lblMatchPlayed = new Label();
            lblHeight = new Label();
            lblAge = new Label();
            lblPosition = new Label();
            btnRemove = new Guna.UI2.WinForms.Guna2Button();
            lb3 = new Label();
            lb8 = new Label();
            lb7 = new Label();
            lb6 = new Label();
            lb5 = new Label();
            lb4 = new Label();
            lblNameClub = new Label();
            picClub = new Guna.UI2.WinForms.Guna2PictureBox();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            lb2 = new Label();
            lb1 = new Label();
            lblName = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClub).BeginInit();
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
            pnHeader.Size = new Size(1920, 50);
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
            txbTimKiem.Size = new Size(1487, 30);
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
            cbbCot.Location = new Point(1795, 13);
            cbbCot.Margin = new Padding(3, 2, 3, 2);
            cbbCot.Name = "cbbCot";
            cbbCot.Size = new Size(115, 26);
            cbbCot.TabIndex = 11;
            // 
            // lblCot
            // 
            lblCot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCot.AutoSize = true;
            lblCot.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCot.ForeColor = Color.White;
            lblCot.Location = new Point(1757, 16);
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
            lblSapXep.Location = new Point(1589, 16);
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
            cbbSapXep.Location = new Point(1656, 13);
            cbbSapXep.Margin = new Padding(3, 2, 3, 2);
            cbbSapXep.Name = "cbbSapXep";
            cbbSapXep.Size = new Size(95, 26);
            cbbSapXep.TabIndex = 9;
            // 
            // picAvatar
            // 
            picAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            picAvatar.CustomizableEdges = customizableEdges5;
            picAvatar.ImageRotate = 0F;
            picAvatar.Location = new Point(0, 0);
            picAvatar.Name = "picAvatar";
            picAvatar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            picAvatar.Size = new Size(250, 250);
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            picAvatar.TabIndex = 28;
            picAvatar.TabStop = false;
            // 
            // pnContent
            // 
            pnContent.Controls.Add(lblRedCards);
            pnContent.Controls.Add(lblYellowCards);
            pnContent.Controls.Add(lblAssists);
            pnContent.Controls.Add(lblGoalsScored);
            pnContent.Controls.Add(lblMatchPlayed);
            pnContent.Controls.Add(lblHeight);
            pnContent.Controls.Add(lblAge);
            pnContent.Controls.Add(lblPosition);
            pnContent.Controls.Add(btnRemove);
            pnContent.Controls.Add(lb3);
            pnContent.Controls.Add(lb8);
            pnContent.Controls.Add(lb7);
            pnContent.Controls.Add(lb6);
            pnContent.Controls.Add(lb5);
            pnContent.Controls.Add(lb4);
            pnContent.Controls.Add(lblNameClub);
            pnContent.Controls.Add(picClub);
            pnContent.Controls.Add(btnEdit);
            pnContent.Controls.Add(lb2);
            pnContent.Controls.Add(lb1);
            pnContent.Controls.Add(lblName);
            pnContent.Controls.Add(picAvatar);
            pnContent.CustomizableEdges = customizableEdges13;
            pnContent.Location = new Point(460, 150);
            pnContent.Name = "pnContent";
            pnContent.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pnContent.Size = new Size(1000, 250);
            pnContent.TabIndex = 29;
            // 
            // lblRedCards
            // 
            lblRedCards.Anchor = AnchorStyles.Left;
            lblRedCards.AutoSize = true;
            lblRedCards.Font = new Font("Microsoft Sans Serif", 12.75F);
            lblRedCards.ForeColor = Color.White;
            lblRedCards.Location = new Point(641, 165);
            lblRedCards.Name = "lblRedCards";
            lblRedCards.Size = new Size(18, 20);
            lblRedCards.TabIndex = 48;
            lblRedCards.Text = "?";
            // 
            // lblYellowCards
            // 
            lblYellowCards.Anchor = AnchorStyles.Left;
            lblYellowCards.AutoSize = true;
            lblYellowCards.Font = new Font("Microsoft Sans Serif", 12.75F);
            lblYellowCards.ForeColor = Color.White;
            lblYellowCards.Location = new Point(641, 135);
            lblYellowCards.Name = "lblYellowCards";
            lblYellowCards.Size = new Size(18, 20);
            lblYellowCards.TabIndex = 47;
            lblYellowCards.Text = "?";
            // 
            // lblAssists
            // 
            lblAssists.Anchor = AnchorStyles.Left;
            lblAssists.AutoSize = true;
            lblAssists.Font = new Font("Microsoft Sans Serif", 12.75F);
            lblAssists.ForeColor = Color.White;
            lblAssists.Location = new Point(641, 105);
            lblAssists.Name = "lblAssists";
            lblAssists.Size = new Size(18, 20);
            lblAssists.TabIndex = 46;
            lblAssists.Text = "?";
            // 
            // lblGoalsScored
            // 
            lblGoalsScored.Anchor = AnchorStyles.Left;
            lblGoalsScored.AutoSize = true;
            lblGoalsScored.Font = new Font("Microsoft Sans Serif", 12.75F);
            lblGoalsScored.ForeColor = Color.White;
            lblGoalsScored.Location = new Point(641, 75);
            lblGoalsScored.Name = "lblGoalsScored";
            lblGoalsScored.Size = new Size(18, 20);
            lblGoalsScored.TabIndex = 45;
            lblGoalsScored.Text = "?";
            // 
            // lblMatchPlayed
            // 
            lblMatchPlayed.Anchor = AnchorStyles.Left;
            lblMatchPlayed.AutoSize = true;
            lblMatchPlayed.Font = new Font("Microsoft Sans Serif", 12.75F);
            lblMatchPlayed.ForeColor = Color.White;
            lblMatchPlayed.Location = new Point(349, 165);
            lblMatchPlayed.Name = "lblMatchPlayed";
            lblMatchPlayed.Size = new Size(18, 20);
            lblMatchPlayed.TabIndex = 44;
            lblMatchPlayed.Text = "?";
            // 
            // lblHeight
            // 
            lblHeight.Anchor = AnchorStyles.Left;
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Microsoft Sans Serif", 12.75F);
            lblHeight.ForeColor = Color.White;
            lblHeight.Location = new Point(371, 135);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(18, 20);
            lblHeight.TabIndex = 43;
            lblHeight.Text = "?";
            // 
            // lblAge
            // 
            lblAge.Anchor = AnchorStyles.Left;
            lblAge.Font = new Font("Microsoft Sans Serif", 12.75F);
            lblAge.ForeColor = Color.White;
            lblAge.Location = new Point(332, 105);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(46, 20);
            lblAge.TabIndex = 42;
            lblAge.Text = "?";
            // 
            // lblPosition
            // 
            lblPosition.Anchor = AnchorStyles.Left;
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Microsoft Sans Serif", 12.75F);
            lblPosition.ForeColor = Color.White;
            lblPosition.Location = new Point(330, 75);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(18, 20);
            lblPosition.TabIndex = 41;
            lblPosition.Text = "?";
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom;
            btnRemove.BorderRadius = 5;
            btnRemove.CustomizableEdges = customizableEdges7;
            btnRemove.DisabledState.BorderColor = Color.DarkGray;
            btnRemove.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRemove.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRemove.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRemove.FillColor = Color.FromArgb(60, 211, 252);
            btnRemove.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(535, 205);
            btnRemove.Name = "btnRemove";
            btnRemove.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRemove.Size = new Size(80, 30);
            btnRemove.TabIndex = 40;
            btnRemove.Text = "Remove";
            // 
            // lb3
            // 
            lb3.Anchor = AnchorStyles.Left;
            lb3.AutoSize = true;
            lb3.Font = new Font("Microsoft Sans Serif", 12.75F);
            lb3.ForeColor = Color.White;
            lb3.Location = new Point(280, 135);
            lb3.Name = "lb3";
            lb3.Size = new Size(84, 20);
            lb3.TabIndex = 39;
            lb3.Text = "Chiều cao";
            // 
            // lb8
            // 
            lb8.Anchor = AnchorStyles.Left;
            lb8.AutoSize = true;
            lb8.Font = new Font("Microsoft Sans Serif", 12.75F);
            lb8.ForeColor = Color.White;
            lb8.Location = new Point(550, 165);
            lb8.Name = "lb8";
            lb8.Size = new Size(60, 20);
            lb8.TabIndex = 38;
            lb8.Text = "Thẻ đỏ";
            // 
            // lb7
            // 
            lb7.Anchor = AnchorStyles.Left;
            lb7.AutoSize = true;
            lb7.Font = new Font("Microsoft Sans Serif", 12.75F);
            lb7.ForeColor = Color.White;
            lb7.Location = new Point(550, 135);
            lb7.Name = "lb7";
            lb7.Size = new Size(77, 20);
            lb7.TabIndex = 37;
            lb7.Text = "Thẻ vàng";
            // 
            // lb6
            // 
            lb6.Anchor = AnchorStyles.Left;
            lb6.AutoSize = true;
            lb6.Font = new Font("Microsoft Sans Serif", 12.75F);
            lb6.ForeColor = Color.White;
            lb6.Location = new Point(550, 105);
            lb6.Name = "lb6";
            lb6.Size = new Size(70, 20);
            lb6.TabIndex = 36;
            lb6.Text = "Kiến tạo";
            // 
            // lb5
            // 
            lb5.Anchor = AnchorStyles.Left;
            lb5.AutoSize = true;
            lb5.Font = new Font("Microsoft Sans Serif", 12.75F);
            lb5.ForeColor = Color.White;
            lb5.Location = new Point(550, 75);
            lb5.Name = "lb5";
            lb5.Size = new Size(85, 20);
            lb5.TabIndex = 35;
            lb5.Text = "Bàn thắng";
            // 
            // lb4
            // 
            lb4.Anchor = AnchorStyles.Left;
            lb4.AutoSize = true;
            lb4.Font = new Font("Microsoft Sans Serif", 12.75F);
            lb4.ForeColor = Color.White;
            lb4.Location = new Point(280, 165);
            lb4.Name = "lb4";
            lb4.Size = new Size(63, 20);
            lb4.TabIndex = 34;
            lb4.Text = "Số trận";
            // 
            // lblNameClub
            // 
            lblNameClub.Anchor = AnchorStyles.Right;
            lblNameClub.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameClub.ForeColor = Color.White;
            lblNameClub.Location = new Point(830, 175);
            lblNameClub.Name = "lblNameClub";
            lblNameClub.Size = new Size(120, 20);
            lblNameClub.TabIndex = 33;
            lblNameClub.Text = "Tên câu lạp bộ";
            lblNameClub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picClub
            // 
            picClub.Anchor = AnchorStyles.Right;
            picClub.CustomizableEdges = customizableEdges9;
            picClub.ImageRotate = 0F;
            picClub.Location = new Point(830, 50);
            picClub.Name = "picClub";
            picClub.ShadowDecoration.CustomizableEdges = customizableEdges10;
            picClub.Size = new Size(120, 120);
            picClub.SizeMode = PictureBoxSizeMode.StretchImage;
            picClub.TabIndex = 32;
            picClub.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom;
            btnEdit.BorderRadius = 5;
            btnEdit.CustomizableEdges = customizableEdges11;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.FromArgb(60, 211, 252);
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(385, 205);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnEdit.Size = new Size(80, 30);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // lb2
            // 
            lb2.Anchor = AnchorStyles.Left;
            lb2.Font = new Font("Microsoft Sans Serif", 12.75F);
            lb2.ForeColor = Color.White;
            lb2.Location = new Point(280, 105);
            lb2.Name = "lb2";
            lb2.Size = new Size(46, 20);
            lb2.TabIndex = 31;
            lb2.Text = "Tuổi";
            // 
            // lb1
            // 
            lb1.Anchor = AnchorStyles.Left;
            lb1.AutoSize = true;
            lb1.Font = new Font("Microsoft Sans Serif", 12.75F);
            lb1.ForeColor = Color.White;
            lb1.Location = new Point(280, 75);
            lb1.Name = "lb1";
            lb1.Size = new Size(44, 20);
            lb1.TabIndex = 30;
            lb1.Text = "Vị trí";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(280, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(400, 45);
            lblName.TabIndex = 29;
            lblName.Text = "NGUYỄN TIẾN LINH";
            // 
            // btnBack
            // 
            btnBack.CustomizableEdges = customizableEdges15;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.FromArgb(20, 44, 76);
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 60);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnBack.Size = new Size(60, 35);
            btnBack.TabIndex = 35;
            btnBack.Text = "<<";
            btnBack.Click += btnBack_Click;
            // 
            // PlayerDetailForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(20, 44, 76);
            ClientSize = new Size(1920, 930);
            Controls.Add(btnBack);
            Controls.Add(pnContent);
            Controls.Add(pnHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlayerDetailForm";
            Text = "OrdersForm";
            Load += PlayerDetailForm_Load;
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnContent.ResumeLayout(false);
            pnContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClub).EndInit();
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
        private Guna.UI2.WinForms.Guna2PictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2Panel pnContent;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Label lb2;
        private Label lb1;
        private Guna.UI2.WinForms.Guna2PictureBox picClub;
        private Label lblNameClub;
        private Label lb6;
        private Label lb5;
        private Label lb4;
        private Label lb3;
        private Label lb8;
        private Label lb7;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Label lblPosition;
        private Label lblAge;
        private Label lblHeight;
        private Label lblMatchPlayed;
        private Label lblRedCards;
        private Label lblYellowCards;
        private Label lblAssists;
        private Label lblGoalsScored;
    }
}