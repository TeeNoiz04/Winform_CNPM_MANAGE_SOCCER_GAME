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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnHeader = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            btnAddRound = new Guna.UI2.WinForms.Guna2Button();
            btnAddSchedule = new Guna.UI2.WinForms.Guna2Button();
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
            pnHeader.Controls.Add(guna2Button1);
            pnHeader.Controls.Add(btnAddRound);
            pnHeader.Controls.Add(btnAddSchedule);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1920, 50);
            pnHeader.TabIndex = 24;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(60, 211, 252);
            guna2Button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(12, 12);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(154, 30);
            guna2Button1.TabIndex = 31;
            guna2Button1.Text = "Refresh";
            guna2Button1.Click += btnRefresh_Click;
            // 
            // btnAddRound
            // 
            btnAddRound.BorderRadius = 5;
            btnAddRound.CustomizableEdges = customizableEdges3;
            btnAddRound.DisabledState.BorderColor = Color.DarkGray;
            btnAddRound.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddRound.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddRound.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddRound.FillColor = Color.FromArgb(60, 211, 252);
            btnAddRound.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRound.ForeColor = Color.White;
            btnAddRound.Location = new Point(1767, 12);
            btnAddRound.Name = "btnAddRound";
            btnAddRound.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAddRound.Size = new Size(141, 30);
            btnAddRound.TabIndex = 30;
            btnAddRound.Text = "Add Round";
            btnAddRound.Click += btnAddRound_Click;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.BorderRadius = 5;
            btnAddSchedule.CustomizableEdges = customizableEdges5;
            btnAddSchedule.DisabledState.BorderColor = Color.DarkGray;
            btnAddSchedule.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddSchedule.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddSchedule.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddSchedule.FillColor = Color.FromArgb(60, 211, 252);
            btnAddSchedule.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSchedule.ForeColor = Color.White;
            btnAddSchedule.Location = new Point(1590, 12);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddSchedule.Size = new Size(154, 30);
            btnAddSchedule.TabIndex = 29;
            btnAddSchedule.Text = "Add Schedule";
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // pnLayoutMain
            // 
            pnLayoutMain.AutoScroll = true;
            pnLayoutMain.Controls.Add(pnLayout);
            pnLayoutMain.Location = new Point(40, 63);
            pnLayoutMain.Name = "pnLayoutMain";
            pnLayoutMain.Size = new Size(1847, 855);
            pnLayoutMain.TabIndex = 8;
            // 
            // pnLayout
            // 
            pnLayout.BorderStyle = BorderStyle.FixedSingle;
            pnLayout.Controls.Add(pnTitle);
            pnLayout.Controls.Add(pnContent);
            pnLayout.Location = new Point(3, 3);
            pnLayout.Name = "pnLayout";
            pnLayout.Size = new Size(832, 246);
            pnLayout.TabIndex = 27;
            pnLayout.Visible = false;
            // 
            // pnTitle
            // 
            pnTitle.Controls.Add(lblRound);
            pnTitle.CustomizableEdges = customizableEdges7;
            pnTitle.Dock = DockStyle.Top;
            pnTitle.Location = new Point(3, 3);
            pnTitle.Name = "pnTitle";
            pnTitle.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
            pnContent.CustomizableEdges = customizableEdges13;
            pnContent.Location = new Point(3, 59);
            pnContent.Name = "pnContent";
            pnContent.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pnContent.Size = new Size(480, 60);
            pnContent.TabIndex = 6;
            pnContent.Click += view_Match_Click;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblResult.ForeColor = Color.IndianRed;
            lblResult.Location = new Point(192, 14);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(100, 32);
            lblResult.TabIndex = 4;
            lblResult.Text = "00 - 00";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Click += view_Match_Click;
            // 
            // lblTeam2
            // 
            lblTeam2.AutoSize = true;
            lblTeam2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblTeam2.ForeColor = Color.White;
            lblTeam2.Location = new Point(298, 18);
            lblTeam2.Name = "lblTeam2";
            lblTeam2.Size = new Size(69, 25);
            lblTeam2.TabIndex = 3;
            lblTeam2.Text = "MMM";
            lblTeam2.TextAlign = ContentAlignment.MiddleCenter;
            lblTeam2.Click += view_Match_Click;
            // 
            // lblTeam1
            // 
            lblTeam1.AutoSize = true;
            lblTeam1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lblTeam1.ForeColor = Color.White;
            lblTeam1.Location = new Point(60, 18);
            lblTeam1.Name = "lblTeam1";
            lblTeam1.Size = new Size(69, 25);
            lblTeam1.TabIndex = 2;
            lblTeam1.Text = "MMM";
            lblTeam1.TextAlign = ContentAlignment.MiddleCenter;
            lblTeam1.Click += view_Match_Click;
            // 
            // picTeam2
            // 
            picTeam2.CustomizableEdges = customizableEdges9;
            picTeam2.ImageRotate = 0F;
            picTeam2.Location = new Point(427, 3);
            picTeam2.Name = "picTeam2";
            picTeam2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            picTeam2.Size = new Size(50, 50);
            picTeam2.TabIndex = 1;
            picTeam2.TabStop = false;
            picTeam2.Click += view_Match_Click;
            // 
            // picTeam1
            // 
            picTeam1.CustomizableEdges = customizableEdges11;
            picTeam1.ImageRotate = 0F;
            picTeam1.Location = new Point(5, 5);
            picTeam1.Name = "picTeam1";
            picTeam1.ShadowDecoration.CustomizableEdges = customizableEdges12;
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
            pnLayoutMain.ResumeLayout(false);
            pnLayout.ResumeLayout(false);
            pnTitle.ResumeLayout(false);
            pnContent.ResumeLayout(false);
            pnContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTeam2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTeam1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
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
        private Guna.UI2.WinForms.Guna2Button btnAddRound;
        private Guna.UI2.WinForms.Guna2Button btnAddSchedule;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}