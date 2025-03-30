namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    partial class SidebarAMOForm
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
            btnAssignReferee = new Guna.UI2.WinForms.Guna2Button();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnRefereeList = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnAssignReferee
            // 
            btnAssignReferee.BorderRadius = 15;
            btnAssignReferee.CheckedState.FillColor = Color.FromArgb(60, 211, 252);
            btnAssignReferee.CustomizableEdges = customizableEdges1;
            btnAssignReferee.DisabledState.BorderColor = Color.DarkGray;
            btnAssignReferee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAssignReferee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAssignReferee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAssignReferee.FillColor = Color.FromArgb(31, 70, 121);
            btnAssignReferee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssignReferee.ForeColor = Color.White;
            btnAssignReferee.Location = new Point(30, 121);
            btnAssignReferee.Name = "btnAssignReferee";
            btnAssignReferee.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAssignReferee.Size = new Size(235, 45);
            btnAssignReferee.TabIndex = 23;
            btnAssignReferee.Text = "Assign Referee";
            btnAssignReferee.TextAlign = HorizontalAlignment.Left;
            btnAssignReferee.Click += btnAssignReferee_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = false;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(87, 40);
            lblTitle.TabIndex = 21;
            lblTitle.Text = "Apps";
            // 
            // btnRefereeList
            // 
            btnRefereeList.BorderRadius = 15;
            btnRefereeList.Checked = true;
            btnRefereeList.CheckedState.FillColor = Color.FromArgb(60, 211, 252);
            btnRefereeList.CustomizableEdges = customizableEdges3;
            btnRefereeList.DisabledState.BorderColor = Color.DarkGray;
            btnRefereeList.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefereeList.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefereeList.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefereeList.FillColor = Color.FromArgb(31, 70, 121);
            btnRefereeList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefereeList.ForeColor = Color.White;
            btnRefereeList.Location = new Point(30, 76);
            btnRefereeList.Name = "btnRefereeList";
            btnRefereeList.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRefereeList.Size = new Size(235, 45);
            btnRefereeList.TabIndex = 19;
            btnRefereeList.Text = "Referee List";
            btnRefereeList.TextAlign = HorizontalAlignment.Left;
            btnRefereeList.Click += btnRefereeList_Click;
            // 
            // SidebarAMOForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(31, 70, 121);
            ClientSize = new Size(300, 930);
            Controls.Add(btnAssignReferee);
            Controls.Add(lblTitle);
            Controls.Add(btnRefereeList);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SidebarAMOForm";
            Text = "SidebarAppsForm";
            ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAssignReferee;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnRefereeList;
    }
}