namespace MANAGE_SOCCER_GAME.Views.Manage_Results_Rankings
{
    partial class SidebarMRRForm
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
            btnResult = new Guna.UI2.WinForms.Guna2Button();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnRanking = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnResult
            // 
            btnResult.BorderRadius = 15;
            btnResult.CheckedState.FillColor = Color.FromArgb(60, 211, 252);
            btnResult.CustomizableEdges = customizableEdges1;
            btnResult.DisabledState.BorderColor = Color.DarkGray;
            btnResult.DisabledState.CustomBorderColor = Color.DarkGray;
            btnResult.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnResult.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnResult.FillColor = Color.FromArgb(31, 70, 121);
            btnResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResult.ForeColor = Color.White;
            btnResult.Location = new Point(30, 121);
            btnResult.Name = "btnResult";
            btnResult.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnResult.Size = new Size(235, 45);
            btnResult.TabIndex = 23;
            btnResult.Text = "Match Result";
            btnResult.TextAlign = HorizontalAlignment.Left;
            btnResult.Click += btnResult_Click;
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
            // btnRanking
            // 
            btnRanking.BorderRadius = 15;
            btnRanking.Checked = true;
            btnRanking.CheckedState.FillColor = Color.FromArgb(60, 211, 252);
            btnRanking.CustomizableEdges = customizableEdges3;
            btnRanking.DisabledState.BorderColor = Color.DarkGray;
            btnRanking.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRanking.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRanking.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRanking.FillColor = Color.FromArgb(31, 70, 121);
            btnRanking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRanking.ForeColor = Color.White;
            btnRanking.Location = new Point(30, 76);
            btnRanking.Name = "btnRanking";
            btnRanking.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRanking.Size = new Size(235, 45);
            btnRanking.TabIndex = 19;
            btnRanking.Text = "Ranking";
            btnRanking.TextAlign = HorizontalAlignment.Left;
            btnRanking.Click += btnRanking_Click;
            // 
            // SidebarMRRForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(31, 70, 121);
            ClientSize = new Size(300, 930);
            Controls.Add(btnResult);
            Controls.Add(lblTitle);
            Controls.Add(btnRanking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SidebarMRRForm";
            Text = "SidebarAppsForm";
            ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnResult;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnRanking;
    }
}