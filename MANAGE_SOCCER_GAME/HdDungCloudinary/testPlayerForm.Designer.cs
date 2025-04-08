namespace MANAGE_SOCCER_GAME.HdDungCloudinary
{
    partial class testPlayerForm
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
            cbTeam = new ComboBox();
            lbName = new Label();
            txtName = new TextBox();
            btnCreate = new Button();
            lvPlayer = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPosition = new TextBox();
            txtNumber = new TextBox();
            txtNational = new TextBox();
            txtStatus = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            Ibirthdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbTeam
            // 
            cbTeam.FormattingEnabled = true;
            cbTeam.Location = new Point(29, 34);
            cbTeam.Name = "cbTeam";
            cbTeam.Size = new Size(121, 23);
            cbTeam.TabIndex = 0;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(40, 76);
            lbName.Name = "lbName";
            lbName.Size = new Size(37, 15);
            lbName.TabIndex = 1;
            lbName.Text = "name";
            // 
            // txtName
            // 
            txtName.Location = new Point(40, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(651, 68);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lvPlayer
            // 
            lvPlayer.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader3, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            lvPlayer.ContextMenuStrip = contextMenuStrip1;
            lvPlayer.FullRowSelect = true;
            lvPlayer.Location = new Point(29, 226);
            lvPlayer.Name = "lvPlayer";
            lvPlayer.Size = new Size(720, 212);
            lvPlayer.TabIndex = 4;
            lvPlayer.UseCompatibleStateImageBehavior = false;
            lvPlayer.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "name";
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 3;
            columnHeader4.Text = "birthdate";
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 2;
            columnHeader3.Text = "Position";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Number";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "National";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "status";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "height";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "weight";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "team";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(651, 153);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(40, 153);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 7;
            label1.Text = "birthdate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Location = new Point(200, 76);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 8;
            label2.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Location = new Point(199, 153);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 9;
            label3.Text = "Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.Location = new Point(326, 76);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 10;
            label4.Text = "National";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Location = new Point(339, 153);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 11;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.Location = new Point(482, 153);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 12;
            label6.Text = "weight";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLight;
            label7.Location = new Point(482, 76);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 13;
            label7.Text = "height";
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(199, 104);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(100, 23);
            txtPosition.TabIndex = 14;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(200, 178);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 15;
            // 
            // txtNational
            // 
            txtNational.Location = new Point(326, 104);
            txtNational.Name = "txtNational";
            txtNational.Size = new Size(100, 23);
            txtNational.TabIndex = 16;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(339, 178);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 17;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(473, 104);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 18;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(482, 187);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 19;
            // 
            // Ibirthdate
            // 
            Ibirthdate.Checked = true;
            Ibirthdate.CustomizableEdges = customizableEdges1;
            Ibirthdate.Font = new Font("Segoe UI", 9F);
            Ibirthdate.Format = DateTimePickerFormat.Long;
            Ibirthdate.Location = new Point(12, 184);
            Ibirthdate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            Ibirthdate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            Ibirthdate.Name = "Ibirthdate";
            Ibirthdate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Ibirthdate.Size = new Size(182, 36);
            Ibirthdate.TabIndex = 20;
            Ibirthdate.Value = new DateTime(2025, 4, 7, 0, 53, 52, 836);
            // 
            // testPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ibirthdate);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtStatus);
            Controls.Add(txtNational);
            Controls.Add(txtNumber);
            Controls.Add(txtPosition);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(lvPlayer);
            Controls.Add(btnCreate);
            Controls.Add(txtName);
            Controls.Add(lbName);
            Controls.Add(cbTeam);
            Name = "testPlayerForm";
            Text = "testPlayerForm";
            Load += testPlayerForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTeam;
        private Label lbName;
        private TextBox txtName;
        private Button btnCreate;
        private ListView lvPlayer;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPosition;
        private TextBox txtNumber;
        private TextBox txtNational;
        private TextBox txtStatus;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Guna.UI2.WinForms.Guna2DateTimePicker Ibirthdate;
    }
}