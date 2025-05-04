namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    partial class UcTimeLine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResult = new Label();
            lbTeam1 = new Label();
            lbTeam2 = new Label();
            lbMinute = new Label();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(494, 8);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(91, 50);
            lblResult.TabIndex = 2;
            lblResult.Text = "0 - 0";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTeam1
            // 
            lbTeam1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbTeam1.ForeColor = Color.White;
            lbTeam1.Location = new Point(100, 8);
            lbTeam1.Name = "lbTeam1";
            lbTeam1.Size = new Size(349, 50);
            lbTeam1.TabIndex = 3;
            lbTeam1.Text = "Nguyen Van A";
            lbTeam1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTeam2
            // 
            lbTeam2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbTeam2.ForeColor = Color.White;
            lbTeam2.Location = new Point(639, 8);
            lbTeam2.Name = "lbTeam2";
            lbTeam2.Size = new Size(435, 50);
            lbTeam2.TabIndex = 4;
            lbTeam2.Text = "Nguyen Van A";
            lbTeam2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbMinute
            // 
            lbMinute.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbMinute.ForeColor = Color.White;
            lbMinute.Location = new Point(42, 17);
            lbMinute.Name = "lbMinute";
            lbMinute.Size = new Size(52, 33);
            lbMinute.TabIndex = 5;
            lbMinute.Text = "80'";
            lbMinute.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UcTimeLine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 71, 99);
            Controls.Add(lbMinute);
            Controls.Add(lbTeam2);
            Controls.Add(lbTeam1);
            Controls.Add(lblResult);
            Name = "UcTimeLine";
            Size = new Size(1100, 67);
            Click += UcTimeLine_Click;
            ResumeLayout(false);
        }

        #endregion

        private Label lblResult;
        private Label lbTeam1;
        private Label lbTeam2;
        private Label lbMinute;
    }
}
