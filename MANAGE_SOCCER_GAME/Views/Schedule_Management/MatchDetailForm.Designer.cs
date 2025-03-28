namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    partial class MatchDetailForm
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
            pnHeader = new Panel();
            btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            txbTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            cbbCot = new ComboBox();
            lblCot = new Label();
            lblSapXep = new Label();
            cbbSapXep = new ComboBox();
            txbTeam1 = new Guna.UI2.WinForms.Guna2TextBox();
            txbTeam2 = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            lblTitle = new Label();
            picTeam1 = new Guna.UI2.WinForms.Guna2PictureBox();
            picTeam2 = new Guna.UI2.WinForms.Guna2PictureBox();
            lblResult = new Label();
            pnHeader.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTeam1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTeam2).BeginInit();
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
            // txbTeam1
            // 
            txbTeam1.CustomizableEdges = customizableEdges5;
            txbTeam1.DefaultText = "Team 1";
            txbTeam1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbTeam1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbTeam1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbTeam1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbTeam1.Enabled = false;
            txbTeam1.FillColor = Color.IndianRed;
            txbTeam1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTeam1.Font = new Font("Segoe UI", 9F);
            txbTeam1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTeam1.Location = new Point(401, 114);
            txbTeam1.Name = "txbTeam1";
            txbTeam1.PlaceholderText = "";
            txbTeam1.SelectedText = "";
            txbTeam1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txbTeam1.Size = new Size(200, 36);
            txbTeam1.TabIndex = 27;
            // 
            // txbTeam2
            // 
            txbTeam2.CustomizableEdges = customizableEdges7;
            txbTeam2.DefaultText = "Team 2";
            txbTeam2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbTeam2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbTeam2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbTeam2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbTeam2.Enabled = false;
            txbTeam2.FillColor = Color.IndianRed;
            txbTeam2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTeam2.Font = new Font("Segoe UI", 9F);
            txbTeam2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTeam2.Location = new Point(763, 114);
            txbTeam2.Name = "txbTeam2";
            txbTeam2.PlaceholderText = "";
            txbTeam2.SelectedText = "";
            txbTeam2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txbTeam2.Size = new Size(200, 36);
            txbTeam2.TabIndex = 28;
            txbTeam2.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(184, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 451);
            panel1.TabIndex = 29;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(432, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(128, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Match Stats";
            // 
            // picTeam1
            // 
            picTeam1.CustomizableEdges = customizableEdges9;
            picTeam1.ImageRotate = 0F;
            picTeam1.Location = new Point(283, 86);
            picTeam1.Name = "picTeam1";
            picTeam1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            picTeam1.Size = new Size(97, 94);
            picTeam1.TabIndex = 30;
            picTeam1.TabStop = false;
            // 
            // picTeam2
            // 
            picTeam2.CustomizableEdges = customizableEdges11;
            picTeam2.ImageRotate = 0F;
            picTeam2.Location = new Point(981, 86);
            picTeam2.Name = "picTeam2";
            picTeam2.ShadowDecoration.CustomizableEdges = customizableEdges12;
            picTeam2.Size = new Size(83, 94);
            picTeam2.TabIndex = 31;
            picTeam2.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(641, 120);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(81, 30);
            lblResult.TabIndex = 1;
            lblResult.Text = "00 - 00";
            // 
            // MatchDetailForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(20, 44, 76);
            ClientSize = new Size(1920, 930);
            Controls.Add(lblResult);
            Controls.Add(picTeam2);
            Controls.Add(picTeam1);
            Controls.Add(panel1);
            Controls.Add(txbTeam2);
            Controls.Add(txbTeam1);
            Controls.Add(pnHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MatchDetailForm";
            Text = "OrdersForm";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTeam1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTeam2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private Guna.UI2.WinForms.Guna2TextBox txbTimKiem;
        private System.Windows.Forms.ComboBox cbbCot;
        private System.Windows.Forms.Label lblCot;
        private System.Windows.Forms.Label lblSapXep;
        private System.Windows.Forms.ComboBox cbbSapXep;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txbTeam1;
        private Guna.UI2.WinForms.Guna2TextBox txbTeam2;
        private Panel panel1;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox picTeam1;
        private Guna.UI2.WinForms.Guna2PictureBox picTeam2;
        private Label lblResult;
    }
}