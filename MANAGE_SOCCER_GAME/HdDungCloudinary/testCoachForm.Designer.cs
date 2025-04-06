namespace MANAGE_SOCCER_GAME.HdDungCloudinary
{
    partial class testCoachForm
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
            label1 = new Label();
            txtName = new TextBox();
            btnCreate = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNational = new TextBox();
            txtExpYear = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            btnUpdate = new Button();
            lvCoach = new ListView();
            id = new ColumnHeader();
            name = new ColumnHeader();
            National = new ColumnHeader();
            expYear = new ColumnHeader();
            email = new ColumnHeader();
            phonenumber = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sửaToolStripMenuItem = new ToolStripMenuItem();
            xemToolStripMenuItem = new ToolStripMenuItem();
            lbID = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 51);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(49, 96);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(695, 47);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 51);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "National";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 51);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "ExpTear";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 51);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(520, 51);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 6;
            label5.Text = "PhoneNumber";
            // 
            // txtNational
            // 
            txtNational.Location = new Point(172, 96);
            txtNational.Name = "txtNational";
            txtNational.Size = new Size(100, 23);
            txtNational.TabIndex = 7;
            // 
            // txtExpYear
            // 
            txtExpYear.Location = new Point(295, 96);
            txtExpYear.Name = "txtExpYear";
            txtExpYear.Size = new Size(100, 23);
            txtExpYear.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(401, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(520, 96);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(695, 95);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lvCoach
            // 
            lvCoach.Columns.AddRange(new ColumnHeader[] { id, name, National, expYear, email, phonenumber });
            lvCoach.ContextMenuStrip = contextMenuStrip1;
            lvCoach.FullRowSelect = true;
            lvCoach.GridLines = true;
            lvCoach.Location = new Point(56, 221);
            lvCoach.Name = "lvCoach";
            lvCoach.Size = new Size(686, 176);
            lvCoach.TabIndex = 12;
            lvCoach.UseCompatibleStateImageBehavior = false;
            lvCoach.View = View.Details;
            lvCoach.MouseClick += lvCoach_MouseClick;
            // 
            // id
            // 
            id.Text = "id";
            id.Width = 100;
            // 
            // name
            // 
            name.Text = "name";
            name.Width = 100;
            // 
            // National
            // 
            National.Text = "National";
            National.Width = 100;
            // 
            // expYear
            // 
            expYear.Text = "expYear";
            expYear.Width = 100;
            // 
            // email
            // 
            email.Text = "email";
            email.Width = 100;
            // 
            // phonenumber
            // 
            phonenumber.Text = "phonenumber";
            phonenumber.Width = 100;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { sửaToolStripMenuItem, xemToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(99, 48);
            // 
            // sửaToolStripMenuItem
            // 
            sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            sửaToolStripMenuItem.Size = new Size(98, 22);
            sửaToolStripMenuItem.Text = "Sửa";
            sửaToolStripMenuItem.Click += LoadCoach;
            // 
            // xemToolStripMenuItem
            // 
            xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            xemToolStripMenuItem.Size = new Size(98, 22);
            xemToolStripMenuItem.Text = "Xem";
            xemToolStripMenuItem.Click += LoadCoach;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(56, 140);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 13;
            lbID.Text = "ID";
            // 
            // testCoachForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbID);
            Controls.Add(lvCoach);
            Controls.Add(btnUpdate);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtExpYear);
            Controls.Add(txtNational);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCreate);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "testCoachForm";
            Text = "testCoachForm";
            Load += testCoachForm_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnCreate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNational;
        private TextBox txtExpYear;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Button btnUpdate;
        private ListView lvCoach;
        private Label lbID;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader National;
        private ColumnHeader expYear;
        private ColumnHeader email;
        private ColumnHeader phonenumber;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sửaToolStripMenuItem;
        private ToolStripMenuItem xemToolStripMenuItem;
    }
}