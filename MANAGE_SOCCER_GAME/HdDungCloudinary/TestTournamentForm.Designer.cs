namespace MANAGE_SOCCER_GAME.HdDungCloudinary
{
    partial class TestTournamentForm
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
            txtName = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            lblSelectedId = new Label();
            lstTournaments = new ListView();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(178, 23);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(146, 99);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(178, 23);
            txtDescription.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(32, 32);
            label1.Name = "label1";
            label1.Size = new Size(100, 78);
            label1.TabIndex = 4;
            label1.Text = "txtName, txtDescription, dtpStartDate, dtpEndDate";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(445, 36);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(155, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "btnCreate";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(445, 99);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(155, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(445, 157);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(445, 214);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(155, 23);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "btnLoad";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblSelectedId
            // 
            lblSelectedId.AutoSize = true;
            lblSelectedId.Location = new Point(46, 165);
            lblSelectedId.Name = "lblSelectedId";
            lblSelectedId.Size = new Size(38, 15);
            lblSelectedId.TabIndex = 10;
            lblSelectedId.Text = "label2";
            // 
            // lstTournaments
            // 
            lstTournaments.Location = new Point(27, 294);
            lstTournaments.Name = "lstTournaments";
            lstTournaments.Size = new Size(720, 144);
            lstTournaments.TabIndex = 11;
            lstTournaments.UseCompatibleStateImageBehavior = false;
            lstTournaments.SelectedIndexChanged += lstTournaments_SelectedIndexChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(124, 165);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 12;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(124, 233);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 13;
            // 
            // TestTournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lstTournaments);
            Controls.Add(lblSelectedId);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Name = "TestTournamentForm";
            Text = "TestTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDescription;
        private Label label1;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoad;
        private Label lblSelectedId;
        private ListView lstTournaments;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
    }
}