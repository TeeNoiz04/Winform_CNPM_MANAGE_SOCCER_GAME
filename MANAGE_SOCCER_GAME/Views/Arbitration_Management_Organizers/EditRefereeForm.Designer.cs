﻿namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    partial class EditRefereeForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txbFullName = new Guna.UI2.WinForms.Guna2TextBox();
            lblFullName = new Label();
            lblBirthDate = new Label();
            lblTitle = new Label();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            gnElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            openFileDialog = new OpenFileDialog();
            lblPosition = new Label();
            txbPosition = new Guna.UI2.WinForms.Guna2TextBox();
            lblExperience = new Label();
            lblNational = new Label();
            txbExperience = new Guna.UI2.WinForms.Guna2TextBox();
            txbNational = new Guna.UI2.WinForms.Guna2TextBox();
            dtBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            SuspendLayout();
            // 
            // txbFullName
            // 
            txbFullName.Anchor = AnchorStyles.Top;
            txbFullName.AutoSize = true;
            txbFullName.BorderColor = Color.FromArgb(52, 52, 116);
            txbFullName.BorderRadius = 5;
            txbFullName.Cursor = Cursors.IBeam;
            txbFullName.CustomizableEdges = customizableEdges13;
            txbFullName.DefaultText = "Full name";
            txbFullName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbFullName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbFullName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbFullName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbFullName.FillColor = Color.FromArgb(52, 52, 116);
            txbFullName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbFullName.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbFullName.ForeColor = Color.Silver;
            txbFullName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbFullName.Location = new Point(170, 100);
            txbFullName.Margin = new Padding(6);
            txbFullName.Name = "txbFullName";
            txbFullName.PlaceholderText = "";
            txbFullName.SelectedText = "";
            txbFullName.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txbFullName.Size = new Size(280, 50);
            txbFullName.TabIndex = 33;
            txbFullName.Click += txbFullName_Click;
            txbFullName.Leave += txbFullName_Leave;
            txbFullName.MouseLeave += txbFullName_MouseLeave;
            txbFullName.MouseHover += txbFullName_MouseHover;
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Top;
            lblFullName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.White;
            lblFullName.Location = new Point(50, 110);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 30);
            lblFullName.TabIndex = 38;
            lblFullName.Text = "Full name";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBirthDate
            // 
            lblBirthDate.Anchor = AnchorStyles.Top;
            lblBirthDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthDate.ForeColor = Color.White;
            lblBirthDate.Location = new Point(50, 170);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(100, 30);
            lblBirthDate.TabIndex = 39;
            lblBirthDate.Text = "BirthDate";
            lblBirthDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(140, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 40);
            lblTitle.TabIndex = 40;
            lblTitle.Text = "EDIT REFEREE";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BorderRadius = 5;
            btnCancel.CustomizableEdges = customizableEdges15;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.FromArgb(60, 211, 252);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(50, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom;
            btnSubmit.BorderRadius = 5;
            btnSubmit.CustomizableEdges = customizableEdges17;
            btnSubmit.DisabledState.BorderColor = Color.DarkGray;
            btnSubmit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSubmit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSubmit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSubmit.FillColor = Color.FromArgb(60, 211, 252);
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(350, 430);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.ShadowDecoration.CustomizableEdges = customizableEdges18;
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
            // lblPosition
            // 
            lblPosition.Anchor = AnchorStyles.Top;
            lblPosition.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.ForeColor = Color.White;
            lblPosition.Location = new Point(50, 230);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(100, 30);
            lblPosition.TabIndex = 51;
            lblPosition.Text = "Position";
            lblPosition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbPosition
            // 
            txbPosition.Anchor = AnchorStyles.Top;
            txbPosition.AutoSize = true;
            txbPosition.BorderColor = Color.FromArgb(52, 52, 116);
            txbPosition.BorderRadius = 5;
            txbPosition.Cursor = Cursors.IBeam;
            txbPosition.CustomizableEdges = customizableEdges25;
            txbPosition.DefaultText = "Position";
            txbPosition.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbPosition.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbPosition.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbPosition.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbPosition.FillColor = Color.FromArgb(52, 52, 116);
            txbPosition.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbPosition.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPosition.ForeColor = Color.Silver;
            txbPosition.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbPosition.Location = new Point(170, 220);
            txbPosition.Margin = new Padding(6);
            txbPosition.Name = "txbPosition";
            txbPosition.PlaceholderText = "";
            txbPosition.SelectedText = "";
            txbPosition.ShadowDecoration.CustomizableEdges = customizableEdges26;
            txbPosition.Size = new Size(280, 50);
            txbPosition.TabIndex = 49;
            txbPosition.Click += txbPosition_Click;
            txbPosition.Leave += txbPosition_Leave;
            txbPosition.MouseLeave += txbPosition_MouseLeave;
            txbPosition.MouseHover += txbPosition_MouseHover;
            // 
            // lblExperience
            // 
            lblExperience.Anchor = AnchorStyles.Top;
            lblExperience.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExperience.ForeColor = Color.White;
            lblExperience.Location = new Point(50, 350);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(111, 30);
            lblExperience.TabIndex = 56;
            lblExperience.Text = "Experience";
            lblExperience.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNational
            // 
            lblNational.Anchor = AnchorStyles.Top;
            lblNational.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNational.ForeColor = Color.White;
            lblNational.Location = new Point(50, 290);
            lblNational.Name = "lblNational";
            lblNational.Size = new Size(100, 30);
            lblNational.TabIndex = 55;
            lblNational.Text = "National";
            lblNational.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbExperience
            // 
            txbExperience.Anchor = AnchorStyles.Top;
            txbExperience.BorderColor = Color.FromArgb(52, 52, 116);
            txbExperience.BorderRadius = 5;
            txbExperience.Cursor = Cursors.IBeam;
            txbExperience.CustomizableEdges = customizableEdges21;
            txbExperience.DefaultText = "Experience";
            txbExperience.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbExperience.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbExperience.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbExperience.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbExperience.FillColor = Color.FromArgb(52, 52, 116);
            txbExperience.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbExperience.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbExperience.ForeColor = Color.Silver;
            txbExperience.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbExperience.Location = new Point(170, 340);
            txbExperience.Margin = new Padding(6, 5, 6, 5);
            txbExperience.Name = "txbExperience";
            txbExperience.PlaceholderText = "";
            txbExperience.SelectedText = "";
            txbExperience.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txbExperience.Size = new Size(280, 50);
            txbExperience.TabIndex = 54;
            txbExperience.Click += txbHeight_Click;
            txbExperience.Leave += txbHeight_Leave;
            txbExperience.MouseLeave += txbHeight_MouseLeave;
            txbExperience.MouseHover += txbHeight_MouseHover;
            // 
            // txbNational
            // 
            txbNational.Anchor = AnchorStyles.Top;
            txbNational.AutoSize = true;
            txbNational.BorderColor = Color.FromArgb(52, 52, 116);
            txbNational.BorderRadius = 5;
            txbNational.Cursor = Cursors.IBeam;
            txbNational.CustomizableEdges = customizableEdges23;
            txbNational.DefaultText = "National";
            txbNational.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbNational.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbNational.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbNational.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbNational.FillColor = Color.FromArgb(52, 52, 116);
            txbNational.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbNational.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbNational.ForeColor = Color.Silver;
            txbNational.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbNational.Location = new Point(170, 280);
            txbNational.Margin = new Padding(6);
            txbNational.Name = "txbNational";
            txbNational.PlaceholderText = "";
            txbNational.SelectedText = "";
            txbNational.ShadowDecoration.CustomizableEdges = customizableEdges24;
            txbNational.Size = new Size(280, 50);
            txbNational.TabIndex = 53;
            txbNational.Click += txbNational_Click;
            txbNational.Leave += txbNational_Leave;
            txbNational.MouseLeave += txbNational_MouseLeave;
            txbNational.MouseHover += txbNational_MouseHover;
            // 
            // dtBirthDate
            // 
            dtBirthDate.Checked = true;
            dtBirthDate.CustomizableEdges = customizableEdges19;
            dtBirthDate.FillColor = Color.FromArgb(52, 52, 116);
            dtBirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtBirthDate.ForeColor = Color.White;
            dtBirthDate.Format = DateTimePickerFormat.Short;
            dtBirthDate.Location = new Point(170, 170);
            dtBirthDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtBirthDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.ShadowDecoration.CustomizableEdges = customizableEdges20;
            dtBirthDate.Size = new Size(280, 36);
            dtBirthDate.TabIndex = 58;
            dtBirthDate.Value = new DateTime(2025, 5, 2, 17, 39, 23, 13);
            // 
            // EditRefereeForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(31, 70, 121);
            ClientSize = new Size(500, 500);
            Controls.Add(dtBirthDate);
            Controls.Add(lblExperience);
            Controls.Add(lblNational);
            Controls.Add(txbExperience);
            Controls.Add(txbNational);
            Controls.Add(lblPosition);
            Controls.Add(txbPosition);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(lblTitle);
            Controls.Add(lblBirthDate);
            Controls.Add(lblFullName);
            Controls.Add(txbFullName);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditRefereeForm";
            Text = "AddTeamForm";
            Load += EditRefereeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txbFullName;
        private Label lblFullName;
        private Label lblBirthDate;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Elipse gnElipse;
        private OpenFileDialog openFileDialog;
        private Label lblExperience;
        private Label lblNational;
        private Guna.UI2.WinForms.Guna2TextBox txbExperience;
        private Guna.UI2.WinForms.Guna2TextBox txbNational;
        private Label lblPosition;
        private Guna.UI2.WinForms.Guna2TextBox txbPosition;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtBirthDate;
    }
}