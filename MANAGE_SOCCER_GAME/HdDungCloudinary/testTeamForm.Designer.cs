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
            cbTounament = new ComboBox();
            lbName = new Label();
            txtName = new TextBox();
            txtProvince = new TextBox();
            lbProvince = new Label();
            btnCreate = new Button();
            listView1 = new ListView();
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
            btnCreate.Text = "created";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(52, 227);
            listView1.Name = "listView1";
            listView1.Size = new Size(655, 175);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // testTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btnCreate);
            Controls.Add(lbProvince);
            Controls.Add(txtProvince);
            Controls.Add(txtName);
            Controls.Add(lbName);
            Controls.Add(cbTounament);
            Name = "testTeamForm";
            Text = "testTeamForm";
            Load += testTeamForm_Load;
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
        private ListView listView1;
    }
}