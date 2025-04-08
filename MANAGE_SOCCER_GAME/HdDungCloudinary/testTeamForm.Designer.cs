namespace MANAGE_SOCCER_GAME.HdDungCloudinary
{
    partial class testTeamForm
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
            cbTounament = new ComboBox();
            lbName = new Label();
            txtName = new TextBox();
            txtProvince = new TextBox();
            lbProvince = new Label();
            btnCreate = new Button();
            lvTeam = new ListView();
            id = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sửaToolStripMenuItem = new ToolStripMenuItem();
            xoaToolStripMenuItem = new ToolStripMenuItem();
            cbCoach = new ComboBox();
            btnUpdate = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbTounament
            // 
            cbTounament.FormattingEnabled = true;
            cbTounament.Location = new Point(12, 26);
            cbTounament.Name = "cbTounament";
            cbTounament.Size = new Size(121, 23);
            cbTounament.TabIndex = 0;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(243, 26);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(243, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(129, 23);
            txtName.TabIndex = 2;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(420, 66);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(129, 23);
            txtProvince.TabIndex = 3;
            // 
            // lbProvince
            // 
            lbProvince.AutoSize = true;
            lbProvince.Location = new Point(420, 29);
            lbProvince.Name = "lbProvince";
            lbProvince.Size = new Size(53, 15);
            lbProvince.TabIndex = 4;
            lbProvince.Text = "Province";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(642, 66);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lvTeam
            // 
            lvTeam.Columns.AddRange(new ColumnHeader[] { id, columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvTeam.ContextMenuStrip = contextMenuStrip1;
            lvTeam.FullRowSelect = true;
            lvTeam.Location = new Point(52, 227);
            lvTeam.Name = "lvTeam";
            lvTeam.Size = new Size(655, 175);
            lvTeam.TabIndex = 6;
            lvTeam.UseCompatibleStateImageBehavior = false;
            lvTeam.View = View.Details;
            // 
            // id
            // 
            id.Text = "id";
            id.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Province";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "tournamentId";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "coachId";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { sửaToolStripMenuItem, xoaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(95, 48);
            // 
            // sửaToolStripMenuItem
            // 
            sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            sửaToolStripMenuItem.Size = new Size(94, 22);
            sửaToolStripMenuItem.Text = "Sửa";
            sửaToolStripMenuItem.Click += LoadTeam;
            // 
            // xoaToolStripMenuItem
            // 
            xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            xoaToolStripMenuItem.Size = new Size(94, 22);
            xoaToolStripMenuItem.Text = "Xoa";
            xoaToolStripMenuItem.Click += xoaToolStripMenuItem_Click;
            // 
            // cbCoach
            // 
            cbCoach.FormattingEnabled = true;
            cbCoach.Location = new Point(12, 66);
            cbCoach.Name = "cbCoach";
            cbCoach.Size = new Size(121, 23);
            cbCoach.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(642, 126);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_ClickAsync;
            // 
            // testTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(cbCoach);
            Controls.Add(lvTeam);
            Controls.Add(btnCreate);
            Controls.Add(lbProvince);
            Controls.Add(txtProvince);
            Controls.Add(txtName);
            Controls.Add(lbName);
            Controls.Add(cbTounament);
            Name = "testTeamForm";
            Text = "testTeamForm";
            Load += testTeamForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTounament;
        private Label lbName;
        private TextBox txtName;
        private TextBox txtProvince;
        private Label lbProvince;
        private Button btnCreate;
        private ListView lvTeam;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sửaToolStripMenuItem;
        private ComboBox cbCoach;
        private Button btnUpdate;
        private ColumnHeader id;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ToolStripMenuItem xoaToolStripMenuItem;
    }
}