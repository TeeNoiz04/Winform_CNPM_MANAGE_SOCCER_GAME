namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    partial class EditResultForm
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
            label1 = new Label();
            cbTeam = new Guna.UI2.WinForms.Guna2ComboBox();
            cbSoccerType = new ComboBox();
            ckbAssitant = new Guna.UI2.WinForms.Guna2CheckBox();
            cbAssitant = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            txbTime = new Guna.UI2.WinForms.Guna2TextBox();
            cbGoalScorer = new Guna.UI2.WinForms.Guna2ComboBox();
            lblTimeStart = new Label();
            lblStartDate = new Label();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            lblTitle = new Label();
            lblRoundName = new Label();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 183);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 123;
            label1.Text = "Team";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbTeam
            // 
            cbTeam.BackColor = Color.Transparent;
            cbTeam.CustomizableEdges = customizableEdges1;
            cbTeam.DrawMode = DrawMode.OwnerDrawFixed;
            cbTeam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeam.FocusedColor = Color.FromArgb(94, 148, 255);
            cbTeam.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbTeam.Font = new Font("Segoe UI", 10F);
            cbTeam.ForeColor = Color.FromArgb(68, 88, 112);
            cbTeam.ItemHeight = 30;
            cbTeam.Location = new Point(221, 183);
            cbTeam.Name = "cbTeam";
            cbTeam.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbTeam.Size = new Size(280, 36);
            cbTeam.TabIndex = 122;
            // 
            // cbSoccerType
            // 
            cbSoccerType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSoccerType.FormattingEnabled = true;
            cbSoccerType.Items.AddRange(new object[] { "Normal", "Penalty", "Own goal" });
            cbSoccerType.Location = new Point(221, 376);
            cbSoccerType.Name = "cbSoccerType";
            cbSoccerType.Size = new Size(280, 33);
            cbSoccerType.TabIndex = 121;
            // 
            // ckbAssitant
            // 
            ckbAssitant.AutoSize = true;
            ckbAssitant.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ckbAssitant.CheckedState.BorderRadius = 0;
            ckbAssitant.CheckedState.BorderThickness = 0;
            ckbAssitant.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ckbAssitant.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbAssitant.Location = new Point(131, 329);
            ckbAssitant.Name = "ckbAssitant";
            ckbAssitant.Size = new Size(15, 14);
            ckbAssitant.TabIndex = 120;
            ckbAssitant.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ckbAssitant.UncheckedState.BorderRadius = 0;
            ckbAssitant.UncheckedState.BorderThickness = 0;
            ckbAssitant.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ckbAssitant.CheckedChanged += ckbAssitant_CheckedChanged;
            // 
            // cbAssitant
            // 
            cbAssitant.BackColor = Color.Transparent;
            cbAssitant.CustomizableEdges = customizableEdges3;
            cbAssitant.DrawMode = DrawMode.OwnerDrawFixed;
            cbAssitant.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAssitant.Enabled = false;
            cbAssitant.FocusedColor = Color.FromArgb(94, 148, 255);
            cbAssitant.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbAssitant.Font = new Font("Segoe UI", 10F);
            cbAssitant.ForeColor = Color.FromArgb(68, 88, 112);
            cbAssitant.ItemHeight = 30;
            cbAssitant.Location = new Point(221, 307);
            cbAssitant.Name = "cbAssitant";
            cbAssitant.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbAssitant.Size = new Size(280, 36);
            cbAssitant.TabIndex = 119;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 315);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 118;
            label3.Text = "Assitant";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbTime
            // 
            txbTime.Anchor = AnchorStyles.Top;
            txbTime.AutoSize = true;
            txbTime.BorderColor = Color.FromArgb(52, 52, 116);
            txbTime.BorderRadius = 5;
            txbTime.Cursor = Cursors.IBeam;
            txbTime.CustomizableEdges = customizableEdges5;
            txbTime.DefaultText = "";
            txbTime.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbTime.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbTime.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbTime.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbTime.FillColor = Color.FromArgb(52, 52, 116);
            txbTime.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTime.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTime.ForeColor = Color.Silver;
            txbTime.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTime.Location = new Point(221, 121);
            txbTime.Margin = new Padding(6);
            txbTime.Name = "txbTime";
            txbTime.PlaceholderText = "Time";
            txbTime.SelectedText = "";
            txbTime.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txbTime.Size = new Size(280, 50);
            txbTime.TabIndex = 117;
            txbTime.Tag = "Time";
            // 
            // cbGoalScorer
            // 
            cbGoalScorer.BackColor = Color.Transparent;
            cbGoalScorer.CustomizableEdges = customizableEdges7;
            cbGoalScorer.DrawMode = DrawMode.OwnerDrawFixed;
            cbGoalScorer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGoalScorer.FocusedColor = Color.FromArgb(94, 148, 255);
            cbGoalScorer.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbGoalScorer.Font = new Font("Segoe UI", 10F);
            cbGoalScorer.ForeColor = Color.FromArgb(68, 88, 112);
            cbGoalScorer.ItemHeight = 30;
            cbGoalScorer.Location = new Point(221, 232);
            cbGoalScorer.Name = "cbGoalScorer";
            cbGoalScorer.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbGoalScorer.Size = new Size(280, 36);
            cbGoalScorer.TabIndex = 116;
            // 
            // lblTimeStart
            // 
            lblTimeStart.Anchor = AnchorStyles.Top;
            lblTimeStart.AutoSize = true;
            lblTimeStart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimeStart.ForeColor = Color.White;
            lblTimeStart.Location = new Point(30, 376);
            lblTimeStart.Name = "lblTimeStart";
            lblTimeStart.Size = new Size(116, 28);
            lblTimeStart.TabIndex = 115;
            lblTimeStart.Text = "Soccer Type";
            lblTimeStart.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = AnchorStyles.Top;
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = Color.White;
            lblStartDate.Location = new Point(30, 232);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(114, 28);
            lblStartDate.TabIndex = 114;
            lblStartDate.Text = "Goal Scorer";
            lblStartDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom;
            btnSubmit.BorderRadius = 5;
            btnSubmit.CustomizableEdges = customizableEdges9;
            btnSubmit.DisabledState.BorderColor = Color.DarkGray;
            btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSubmit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSubmit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSubmit.FillColor = Color.FromArgb(60, 211, 252);
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(442, 450);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnSubmit.Size = new Size(100, 40);
            btnSubmit.TabIndex = 113;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BorderRadius = 5;
            btnCancel.CustomizableEdges = customizableEdges11;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(60, 211, 252);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(267, 450);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 112;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(172, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 40);
            lblTitle.TabIndex = 111;
            lblTitle.Text = "EDIT RESULT";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoundName
            // 
            lblRoundName.Anchor = AnchorStyles.Top;
            lblRoundName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoundName.ForeColor = Color.White;
            lblRoundName.Location = new Point(30, 121);
            lblRoundName.Name = "lblRoundName";
            lblRoundName.Size = new Size(150, 30);
            lblRoundName.TabIndex = 110;
            lblRoundName.Text = "Time (minute)";
            lblRoundName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom;
            btnDelete.BorderRadius = 5;
            btnDelete.CustomizableEdges = customizableEdges13;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(12, 450);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 124;
            btnDelete.Text = "Delete";
            btnDelete.Click += guna2Button1_Click;
            // 
            // EditResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 70, 121);
            ClientSize = new Size(580, 502);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(cbTeam);
            Controls.Add(cbSoccerType);
            Controls.Add(ckbAssitant);
            Controls.Add(cbAssitant);
            Controls.Add(label3);
            Controls.Add(txbTime);
            Controls.Add(cbGoalScorer);
            Controls.Add(lblTimeStart);
            Controls.Add(lblStartDate);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Controls.Add(lblRoundName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditResultForm";
            Text = "EditResultForm";
            Load += UpdateResultForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTeam;
        private ComboBox cbSoccerType;
        private Guna.UI2.WinForms.Guna2CheckBox ckbAssitant;
        private Guna.UI2.WinForms.Guna2ComboBox cbAssitant;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txbTime;
        private Guna.UI2.WinForms.Guna2ComboBox cbGoalScorer;
        private Label lblTimeStart;
        private Label lblStartDate;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Label lblTitle;
        private Label lblRoundName;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}