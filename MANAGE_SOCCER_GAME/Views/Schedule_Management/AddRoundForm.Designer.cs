namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    partial class AddRoundForm
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
            lblEndDate = new Label();
            lblStartDate = new Label();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            lblTitle = new Label();
            lblRoundName = new Label();
            txbRoundName = new Guna.UI2.WinForms.Guna2TextBox();
            dtStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            SuspendLayout();
            // 
            // lblEndDate
            // 
            lblEndDate.Anchor = AnchorStyles.Top;
            lblEndDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEndDate.ForeColor = Color.White;
            lblEndDate.Location = new Point(58, 215);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(100, 30);
            lblEndDate.TabIndex = 68;
            lblEndDate.Text = "End Date";
            lblEndDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStartDate
            // 
            lblStartDate.Anchor = AnchorStyles.Top;
            lblStartDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = Color.White;
            lblStartDate.Location = new Point(58, 144);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(100, 30);
            lblStartDate.TabIndex = 65;
            lblStartDate.Text = "Start Date";
            lblStartDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom;
            btnSubmit.BorderRadius = 5;
            btnSubmit.CustomizableEdges = customizableEdges1;
            btnSubmit.DisabledState.BorderColor = Color.DarkGray;
            btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSubmit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSubmit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSubmit.FillColor = Color.FromArgb(60, 211, 252);
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(393, 305);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSubmit.Size = new Size(100, 40);
            btnSubmit.TabIndex = 63;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BorderRadius = 5;
            btnCancel.CustomizableEdges = customizableEdges3;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(60, 211, 252);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(58, 305);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 62;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(169, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 40);
            lblTitle.TabIndex = 61;
            lblTitle.Text = "ADD ROUND";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoundName
            // 
            lblRoundName.Anchor = AnchorStyles.Top;
            lblRoundName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoundName.ForeColor = Color.White;
            lblRoundName.Location = new Point(43, 85);
            lblRoundName.Name = "lblRoundName";
            lblRoundName.Size = new Size(150, 30);
            lblRoundName.TabIndex = 60;
            lblRoundName.Text = "Round Name";
            lblRoundName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbRoundName
            // 
            txbRoundName.Anchor = AnchorStyles.Top;
            txbRoundName.AutoSize = true;
            txbRoundName.BorderColor = Color.FromArgb(52, 52, 116);
            txbRoundName.BorderRadius = 5;
            txbRoundName.Cursor = Cursors.IBeam;
            txbRoundName.CustomizableEdges = customizableEdges5;
            txbRoundName.DefaultText = "";
            txbRoundName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbRoundName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbRoundName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbRoundName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbRoundName.FillColor = Color.FromArgb(52, 52, 116);
            txbRoundName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbRoundName.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbRoundName.ForeColor = Color.Silver;
            txbRoundName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbRoundName.Location = new Point(213, 75);
            txbRoundName.Margin = new Padding(6);
            txbRoundName.Name = "txbRoundName";
            txbRoundName.PlaceholderText = "Round Name";
            txbRoundName.SelectedText = "";
            txbRoundName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txbRoundName.Size = new Size(280, 50);
            txbRoundName.TabIndex = 59;
            txbRoundName.Tag = "Round Name";
            // 
            // dtStartDate
            // 
            dtStartDate.Checked = true;
            dtStartDate.CustomizableEdges = customizableEdges7;
            dtStartDate.FillColor = Color.FromArgb(52, 52, 116);
            dtStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtStartDate.ForeColor = Color.Silver;
            dtStartDate.Format = DateTimePickerFormat.Short;
            dtStartDate.Location = new Point(213, 150);
            dtStartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtStartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtStartDate.Size = new Size(280, 36);
            dtStartDate.TabIndex = 69;
            dtStartDate.Value = new DateTime(2025, 5, 1, 8, 13, 37, 590);
            // 
            // dtEndDate
            // 
            dtEndDate.Checked = true;
            dtEndDate.CustomizableEdges = customizableEdges9;
            dtEndDate.FillColor = Color.FromArgb(52, 52, 116);
            dtEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtEndDate.ForeColor = Color.Silver;
            dtEndDate.Format = DateTimePickerFormat.Short;
            dtEndDate.Location = new Point(213, 215);
            dtEndDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtEndDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            dtEndDate.Size = new Size(280, 36);
            dtEndDate.TabIndex = 70;
            dtEndDate.Value = new DateTime(2025, 5, 1, 8, 13, 37, 590);
            // 
            // AddRoundForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 70, 121);
            ClientSize = new Size(551, 357);
            Controls.Add(dtEndDate);
            Controls.Add(dtStartDate);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Controls.Add(lblRoundName);
            Controls.Add(txbRoundName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddRoundForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddRoundForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEndDate;
        private Label lblStartDate;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Label lblTitle;
        private Label lblRoundName;
        private Guna.UI2.WinForms.Guna2TextBox txbRoundName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtEndDate;
    }
}