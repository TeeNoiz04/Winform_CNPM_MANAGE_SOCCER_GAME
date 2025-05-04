namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    partial class AddScheduleForm
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
            dtStartTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lblTimeStart = new Label();
            lblStartDate = new Label();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            lblTitle = new Label();
            lblRoundName = new Label();
            cbRound = new Guna.UI2.WinForms.Guna2ComboBox();
            cbHomeTeam = new Guna.UI2.WinForms.Guna2ComboBox();
            cbAwayTeam = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblStartDateR = new Label();
            lblEndDateR = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // dtStartTime
            // 
            dtStartTime.Checked = true;
            dtStartTime.CustomizableEdges = customizableEdges1;
            dtStartTime.FillColor = Color.FromArgb(52, 52, 116);
            dtStartTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtStartTime.ForeColor = Color.Silver;
            dtStartTime.Format = DateTimePickerFormat.Time;
            dtStartTime.Location = new Point(217, 269);
            dtStartTime.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtStartTime.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtStartTime.Name = "dtStartTime";
            dtStartTime.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtStartTime.ShowUpDown = true;
            dtStartTime.Size = new Size(280, 36);
            dtStartTime.TabIndex = 79;
            dtStartTime.Value = new DateTime(2025, 5, 1, 8, 13, 37, 590);
            // 
            // dtStartDate
            // 
            dtStartDate.Checked = true;
            dtStartDate.CustomizableEdges = customizableEdges3;
            dtStartDate.FillColor = Color.FromArgb(52, 52, 116);
            dtStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtStartDate.ForeColor = Color.Silver;
            dtStartDate.Format = DateTimePickerFormat.Short;
            dtStartDate.Location = new Point(217, 203);
            dtStartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtStartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtStartDate.Size = new Size(280, 36);
            dtStartDate.TabIndex = 78;
            dtStartDate.Value = new DateTime(2025, 5, 1, 8, 13, 37, 590);
            // 
            // lblTimeStart
            // 
            lblTimeStart.Anchor = AnchorStyles.Top;
            lblTimeStart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimeStart.ForeColor = Color.White;
            lblTimeStart.Location = new Point(24, 269);
            lblTimeStart.Name = "lblTimeStart";
            lblTimeStart.Size = new Size(100, 30);
            lblTimeStart.TabIndex = 77;
            lblTimeStart.Text = "Time Start";
            lblTimeStart.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = AnchorStyles.Top;
            lblStartDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = Color.White;
            lblStartDate.Location = new Point(24, 209);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(100, 30);
            lblStartDate.TabIndex = 76;
            lblStartDate.Text = "Start Date";
            lblStartDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom;
            btnSubmit.BorderRadius = 5;
            btnSubmit.CustomizableEdges = customizableEdges5;
            btnSubmit.DisabledState.BorderColor = Color.DarkGray;
            btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSubmit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSubmit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSubmit.FillColor = Color.FromArgb(60, 211, 252);
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(397, 500);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnSubmit.Size = new Size(100, 40);
            btnSubmit.TabIndex = 75;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BorderRadius = 5;
            btnCancel.CustomizableEdges = customizableEdges7;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(60, 211, 252);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(74, 500);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 74;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(152, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 40);
            lblTitle.TabIndex = 73;
            lblTitle.Text = "ADD SCHEDULE";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoundName
            // 
            lblRoundName.Anchor = AnchorStyles.Top;
            lblRoundName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoundName.ForeColor = Color.White;
            lblRoundName.Location = new Point(24, 91);
            lblRoundName.Name = "lblRoundName";
            lblRoundName.Size = new Size(150, 30);
            lblRoundName.TabIndex = 72;
            lblRoundName.Text = "Round";
            lblRoundName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbRound
            // 
            cbRound.BackColor = Color.Transparent;
            cbRound.CustomizableEdges = customizableEdges9;
            cbRound.DrawMode = DrawMode.OwnerDrawFixed;
            cbRound.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRound.FocusedColor = Color.FromArgb(94, 148, 255);
            cbRound.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbRound.Font = new Font("Segoe UI", 10F);
            cbRound.ForeColor = Color.FromArgb(68, 88, 112);
            cbRound.ItemHeight = 30;
            cbRound.Location = new Point(217, 85);
            cbRound.Name = "cbRound";
            cbRound.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbRound.Size = new Size(280, 36);
            cbRound.TabIndex = 80;
            cbRound.SelectedIndexChanged += cbRound_SelectedIndexChanged;
            // 
            // cbHomeTeam
            // 
            cbHomeTeam.BackColor = Color.Transparent;
            cbHomeTeam.CustomizableEdges = customizableEdges11;
            cbHomeTeam.DrawMode = DrawMode.OwnerDrawFixed;
            cbHomeTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHomeTeam.FocusedColor = Color.FromArgb(94, 148, 255);
            cbHomeTeam.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbHomeTeam.Font = new Font("Segoe UI", 10F);
            cbHomeTeam.ForeColor = Color.FromArgb(68, 88, 112);
            cbHomeTeam.ItemHeight = 30;
            cbHomeTeam.Location = new Point(217, 324);
            cbHomeTeam.Name = "cbHomeTeam";
            cbHomeTeam.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cbHomeTeam.Size = new Size(280, 36);
            cbHomeTeam.TabIndex = 81;
            // 
            // cbAwayTeam
            // 
            cbAwayTeam.BackColor = Color.Transparent;
            cbAwayTeam.CustomizableEdges = customizableEdges13;
            cbAwayTeam.DrawMode = DrawMode.OwnerDrawFixed;
            cbAwayTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAwayTeam.FocusedColor = Color.FromArgb(94, 148, 255);
            cbAwayTeam.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbAwayTeam.Font = new Font("Segoe UI", 10F);
            cbAwayTeam.ForeColor = Color.FromArgb(68, 88, 112);
            cbAwayTeam.ItemHeight = 30;
            cbAwayTeam.Location = new Point(217, 386);
            cbAwayTeam.Name = "cbAwayTeam";
            cbAwayTeam.ShadowDecoration.CustomizableEdges = customizableEdges14;
            cbAwayTeam.Size = new Size(280, 36);
            cbAwayTeam.TabIndex = 82;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 324);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 83;
            label1.Text = "Home Team";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 386);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 84;
            label2.Text = "Away Team";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 139);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 85;
            label3.Text = "Start Date";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStartDateR
            // 
            lblStartDateR.Anchor = AnchorStyles.Top;
            lblStartDateR.AutoSize = true;
            lblStartDateR.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDateR.ForeColor = Color.White;
            lblStartDateR.Location = new Point(130, 140);
            lblStartDateR.Name = "lblStartDateR";
            lblStartDateR.Size = new Size(120, 28);
            lblStartDateR.TabIndex = 86;
            lblStartDateR.Text = "?? / ?? / ????";
            lblStartDateR.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEndDateR
            // 
            lblEndDateR.Anchor = AnchorStyles.Top;
            lblEndDateR.AutoSize = true;
            lblEndDateR.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndDateR.ForeColor = Color.White;
            lblEndDateR.Location = new Point(377, 141);
            lblEndDateR.Name = "lblEndDateR";
            lblEndDateR.Size = new Size(120, 28);
            lblEndDateR.TabIndex = 88;
            lblEndDateR.Text = "?? / ?? / ????";
            lblEndDateR.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(271, 139);
            label6.Name = "label6";
            label6.Size = new Size(100, 30);
            label6.TabIndex = 87;
            label6.Text = "End Date";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 70, 121);
            ClientSize = new Size(572, 571);
            Controls.Add(lblEndDateR);
            Controls.Add(label6);
            Controls.Add(lblStartDateR);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbAwayTeam);
            Controls.Add(cbHomeTeam);
            Controls.Add(cbRound);
            Controls.Add(dtStartTime);
            Controls.Add(dtStartDate);
            Controls.Add(lblTimeStart);
            Controls.Add(lblStartDate);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Controls.Add(lblRoundName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddScheduleForm";
            Text = "AddScheduleForm";
            Load += AddScheduleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtStartTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtStartDate;
        private Label lblTimeStart;
        private Label lblStartDate;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Label lblTitle;
        private Label lblRoundName;
        private Guna.UI2.WinForms.Guna2ComboBox cbRound;
        private Guna.UI2.WinForms.Guna2ComboBox cbHomeTeam;
        private Guna.UI2.WinForms.Guna2ComboBox cbAwayTeam;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStartDateR;
        private Label lblEndDateR;
        private Label label6;
    }
}