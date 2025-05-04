namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    partial class AddTourmentForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txbName = new Guna.UI2.WinForms.Guna2TextBox();
            lblName = new Label();
            lblDayStart = new Label();
            lblTitle = new Label();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            gnElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            openFileDialog = new OpenFileDialog();
            lblDescription = new Label();
            lblDayEnd = new Label();
            txbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            dtEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            SuspendLayout();
            // 
            // txbName
            // 
            txbName.Anchor = AnchorStyles.Top;
            txbName.AutoSize = true;
            txbName.BorderColor = Color.FromArgb(52, 52, 116);
            txbName.BorderRadius = 5;
            txbName.Cursor = Cursors.IBeam;
            txbName.CustomizableEdges = customizableEdges1;
            txbName.DefaultText = "";
            txbName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbName.FillColor = Color.FromArgb(52, 52, 116);
            txbName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbName.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbName.ForeColor = Color.Silver;
            txbName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbName.Location = new Point(170, 90);
            txbName.Margin = new Padding(6);
            txbName.Name = "txbName";
            txbName.PlaceholderText = "Name";
            txbName.SelectedText = "";
            txbName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txbName.Size = new Size(280, 50);
            txbName.TabIndex = 33;
            txbName.Tag = "Name";
            txbName.Click += txbFullName_Click;
            txbName.Leave += txbFullName_Leave;
            txbName.MouseLeave += txbFullName_MouseLeave;
            txbName.MouseHover += txbFullName_MouseHover;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(50, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 30);
            lblName.TabIndex = 38;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDayStart
            // 
            lblDayStart.Anchor = AnchorStyles.Top;
            lblDayStart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDayStart.ForeColor = Color.White;
            lblDayStart.Location = new Point(50, 160);
            lblDayStart.Name = "lblDayStart";
            lblDayStart.Size = new Size(100, 30);
            lblDayStart.TabIndex = 39;
            lblDayStart.Text = "Day Start";
            lblDayStart.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(125, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 40);
            lblTitle.TabIndex = 40;
            lblTitle.Text = "ADD TOURMENT";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            btnCancel.Location = new Point(50, 370);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
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
            btnSubmit.Location = new Point(350, 370);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top;
            lblDescription.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(50, 280);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(121, 30);
            lblDescription.TabIndex = 52;
            lblDescription.Text = "Description";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDayEnd
            // 
            lblDayEnd.Anchor = AnchorStyles.Top;
            lblDayEnd.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDayEnd.ForeColor = Color.White;
            lblDayEnd.Location = new Point(50, 220);
            lblDayEnd.Name = "lblDayEnd";
            lblDayEnd.Size = new Size(100, 30);
            lblDayEnd.TabIndex = 51;
            lblDayEnd.Text = "Day End";
            lblDayEnd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbDescription
            // 
            txbDescription.Anchor = AnchorStyles.Top;
            txbDescription.BorderColor = Color.FromArgb(52, 52, 116);
            txbDescription.BorderRadius = 5;
            txbDescription.Cursor = Cursors.IBeam;
            txbDescription.CustomizableEdges = customizableEdges11;
            txbDescription.DefaultText = "";
            txbDescription.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbDescription.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbDescription.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbDescription.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbDescription.FillColor = Color.FromArgb(52, 52, 116);
            txbDescription.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbDescription.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDescription.ForeColor = Color.Silver;
            txbDescription.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbDescription.Location = new Point(170, 270);
            txbDescription.Margin = new Padding(6, 5, 6, 5);
            txbDescription.Name = "txbDescription";
            txbDescription.PlaceholderText = "Description";
            txbDescription.SelectedText = "";
            txbDescription.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txbDescription.Size = new Size(280, 50);
            txbDescription.TabIndex = 50;
            txbDescription.Tag = "Description";
            txbDescription.Click += txbNumber_Click;
            txbDescription.Leave += txbNumber_Leave;
            txbDescription.MouseLeave += txbNumber_MouseLeave;
            txbDescription.MouseHover += txbNumber_MouseHover;
            // 
            // dtEndDate
            // 
            dtEndDate.Checked = true;
            dtEndDate.CustomizableEdges = customizableEdges7;
            dtEndDate.FillColor = Color.FromArgb(52, 52, 116);
            dtEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtEndDate.ForeColor = Color.Silver;
            dtEndDate.Format = DateTimePickerFormat.Short;
            dtEndDate.Location = new Point(170, 219);
            dtEndDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtEndDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtEndDate.Size = new Size(280, 36);
            dtEndDate.TabIndex = 72;
            dtEndDate.Value = new DateTime(2025, 5, 1, 8, 13, 37, 590);
            // 
            // dtStartDate
            // 
            dtStartDate.Checked = true;
            dtStartDate.CustomizableEdges = customizableEdges9;
            dtStartDate.FillColor = Color.FromArgb(52, 52, 116);
            dtStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtStartDate.ForeColor = Color.Silver;
            dtStartDate.Format = DateTimePickerFormat.Short;
            dtStartDate.Location = new Point(170, 154);
            dtStartDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtStartDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            dtStartDate.Size = new Size(280, 36);
            dtStartDate.TabIndex = 71;
            dtStartDate.Value = new DateTime(2025, 5, 1, 8, 13, 37, 590);
            // 
            // AddTourmentForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(31, 70, 121);
            ClientSize = new Size(500, 440);
            Controls.Add(dtEndDate);
            Controls.Add(dtStartDate);
            Controls.Add(lblDescription);
            Controls.Add(lblDayEnd);
            Controls.Add(txbDescription);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Controls.Add(lblDayStart);
            Controls.Add(lblName);
            Controls.Add(txbName);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTourmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTeamForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txbName;
        private Label lblName;
        private Label lblDayStart;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Elipse gnElipse;
        private OpenFileDialog openFileDialog;
        private Label lblDescription;
        private Label lblDayEnd;
        private Guna.UI2.WinForms.Guna2TextBox txbDescription;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtStartDate;
    }
}