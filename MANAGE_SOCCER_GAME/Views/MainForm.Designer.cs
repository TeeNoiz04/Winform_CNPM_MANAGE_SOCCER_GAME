namespace MANAGE_SOCCER_GAME.Views
{
    partial class MainForm
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
            pnContent1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            pnContent2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            pnContent4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            pnContent3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            SuspendLayout();
            // 
            // pnContent1
            // 
            pnContent1.BackColor = SystemColors.Control;
            pnContent1.CustomizableEdges = customizableEdges1;
            pnContent1.Dock = DockStyle.Top;
            pnContent1.FillColor = Color.FromArgb(255, 128, 128);
            pnContent1.Location = new Point(0, 0);
            pnContent1.Name = "pnContent1";
            pnContent1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnContent1.Size = new Size(960, 150);
            pnContent1.TabIndex = 0;
            pnContent1.Visible = false;
            // 
            // pnContent2
            // 
            pnContent2.CustomizableEdges = customizableEdges3;
            pnContent2.Dock = DockStyle.Left;
            pnContent2.FillColor = Color.Lime;
            pnContent2.Location = new Point(0, 150);
            pnContent2.Name = "pnContent2";
            pnContent2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnContent2.Size = new Size(300, 390);
            pnContent2.TabIndex = 1;
            pnContent2.Visible = false;
            // 
            // pnContent4
            // 
            pnContent4.CustomizableEdges = customizableEdges5;
            pnContent4.Dock = DockStyle.Right;
            pnContent4.FillColor = Color.FromArgb(255, 128, 255);
            pnContent4.Location = new Point(760, 150);
            pnContent4.Name = "pnContent4";
            pnContent4.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnContent4.Size = new Size(200, 390);
            pnContent4.TabIndex = 2;
            pnContent4.Visible = false;
            // 
            // pnContent3
            // 
            pnContent3.CustomizableEdges = customizableEdges7;
            pnContent3.FillColor = Color.FromArgb(128, 128, 255);
            pnContent3.Location = new Point(180, 0);
            pnContent3.Name = "pnContent3";
            pnContent3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnContent3.Size = new Size(600, 540);
            pnContent3.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(960, 540);
            Controls.Add(pnContent3);
            Controls.Add(pnContent4);
            Controls.Add(pnContent2);
            Controls.Add(pnContent1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnContent1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnContent2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnContent4;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnContent3;
    }
}