namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    partial class MatchScheduleForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnHeader = new Panel();
            btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            txbTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            cbbCot = new ComboBox();
            lblCot = new Label();
            lblSapXep = new Label();
            cbbSapXep = new ComboBox();
            pnLayoutMain = new FlowLayoutPanel();
            pnLayout = new FlowLayoutPanel();
            pnTitle = new Guna.UI2.WinForms.Guna2Panel();
            lblRound = new Label();
            pnContent = new Guna.UI2.WinForms.Guna2Panel();
            lblResult = new Label();
            lblTeam2 = new Label();
            lblTeam1 = new Label();
            picTeam2 = new Guna.UI2.WinForms.Guna2PictureBox();
            picTeam1 = new Guna.UI2.WinForms.Guna2PictureBox();
            pnHeader.SuspendLayout();
            pnLayoutMain.SuspendLayout();
            pnLayout.SuspendLayout();
            pnTitle.SuspendLayout();
            pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTeam2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTeam1).BeginInit();
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
            // pnLayoutMain
            // 
            pnLayoutMain.AutoScroll = true;
            pnLayoutMain.Controls.Add(pnLayout);
            pnLayoutMain.Location = new Point(122, 63);
            pnLayoutMain.Name = "pnLayoutMain";
            pnLayoutMain.Size = new Size(1765, 855);
            pnLayoutMain.TabIndex = 8;
            // 
            // pnLayout
            // 
            pnLayout.Controls.Add(pnTitle);
            pnLayout.Controls.Add(pnContent);
            pnLayout.Location = new Point(3, 3);
            pnLayout.Name = "pnLayout";
            pnLayout.Size = new Size(832, 246);
            pnLayout.TabIndex = 27;
            // 
            // pnTitle
            // 
            pnTitle.Controls.Add(lblRound);
            pnTitle.CustomizableEdges = customizableEdges5;
            pnTitle.Dock = DockStyle.Top;
            pnTitle.Location = new Point(3, 3);
            pnTitle.Name = "pnTitle";
            pnTitle.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnTitle.Size = new Size(832, 50);
            pnTitle.TabIndex = 7;
            // 
            // lblRound
            // 
            lblRound.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRound.ForeColor = Color.White;
            lblRound.Location = new Point(0, 0);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(200, 50);
            lblRound.TabIndex = 0;
            lblRound.Text = "ROUND 00";
            lblRound.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnContent
            // 
            pnContent.Controls.Add(lblResult);
            pnContent.Controls.Add(lblTeam2);
            pnContent.Controls.Add(lblTeam1);
            pnContent.Controls.Add(picTeam2);
            pnContent.Controls.Add(picTeam1);
            pnContent.CustomizableEdges = customizableEdges11;
            pnContent.Location = new Point(3, 59);
            pnContent.Name = "pnContent";
            pnContent.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pnContent.Size = new Size(410, 60);
            pnContent.TabIndex = 6;
            pnContent.Click += view_Match_Click;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblResult.ForeColor = Color.IndianRed;
            lblResult.Location = new Point(155, 14);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(100, 32);
            lblResult.TabIndex = 4;
            lblResult.Text = "00 - 00";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Click += view_Match_Click;
            // 
            // lblTeam2
            // 
            lblTeam2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblTeam2.ForeColor = Color.White;
            lblTeam2.Location = new Point(265, 14);
            lblTeam2.Name = "lblTeam2";
            lblTeam2.Size = new Size(85, 32);
            lblTeam2.TabIndex = 3;
            lblTeam2.Text = "MMM";
            lblTeam2.TextAlign = ContentAlignment.MiddleCenter;
            lblTeam2.Click += view_Match_Click;
            // 
            // lblTeam1
            // 
            lblTeam1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblTeam1.ForeColor = Color.White;
            lblTeam1.Location = new Point(60, 14);
            lblTeam1.Name = "lblTeam1";
            lblTeam1.Size = new Size(85, 32);
            lblTeam1.TabIndex = 2;
            lblTeam1.Text = "MMM";
            lblTeam1.TextAlign = ContentAlignment.MiddleCenter;
            lblTeam1.Click += view_Match_Click;
            // 
            // picTeam2
            // 
            picTeam2.CustomizableEdges = customizableEdges7;
            picTeam2.ImageRotate = 0F;
            picTeam2.Location = new Point(355, 5);
            picTeam2.Name = "picTeam2";
            picTeam2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            picTeam2.Size = new Size(50, 50);
            picTeam2.TabIndex = 1;
            picTeam2.TabStop = false;
            picTeam2.Click += view_Match_Click;
            // 
            // picTeam1
            // 
            picTeam1.CustomizableEdges = customizableEdges9;
            picTeam1.ImageRotate = 0F;
            picTeam1.Location = new Point(5, 5);
            picTeam1.Name = "picTeam1";
            picTeam1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            picTeam1.Size = new Size(50, 50);
            picTeam1.TabIndex = 0;
            picTeam1.TabStop = false;
            picTeam1.Click += view_Match_Click;
            // 
            // MatchScheduleForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(20, 44, 76);
            ClientSize = new Size(1920, 930);
            Controls.Add(pnHeader);
            Controls.Add(pnLayoutMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MatchScheduleForm";
            Text = "OrdersForm";
            Load += MatchScheduleForm_Load;
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnLayoutMain.ResumeLayout(false);
            pnLayout.ResumeLayout(false);
            pnTitle.ResumeLayout(false);
            pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picTeam2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTeam1).EndInit();
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
        private Label label5;
        private Label label6;
        private FlowLayoutPanel pnLayoutMain;
        private FlowLayoutPanel pnLayout;
        private Guna.UI2.WinForms.Guna2Panel pnTitle;
        private Label lblRound;
        private Guna.UI2.WinForms.Guna2Panel pnContent;
        private Label lblResult;
        private Label lblTeam2;
        private Label lblTeam1;
        private Guna.UI2.WinForms.Guna2PictureBox picTeam2;
        private Guna.UI2.WinForms.Guna2PictureBox picTeam1;
    }
}