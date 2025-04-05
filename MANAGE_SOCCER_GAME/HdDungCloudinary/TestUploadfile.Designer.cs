namespace MANAGE_SOCCER_GAME.HdDungCloudinary
{
    partial class TestUploadfile
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtPublicId = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(299, 107);
            button1.Name = "button1";
            button1.Size = new Size(94, 68);
            button1.TabIndex = 0;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(506, 107);
            button2.Name = "button2";
            button2.Size = new Size(94, 68);
            button2.TabIndex = 1;
            button2.Text = "Lấy ảnh ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(429, 244);
            button3.Name = "button3";
            button3.Size = new Size(94, 68);
            button3.TabIndex = 2;
            button3.Text = "xóa ảnh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtPublicId
            // 
            txtPublicId.Location = new Point(51, 148);
            txtPublicId.Name = "txtPublicId";
            txtPublicId.Size = new Size(125, 27);
            txtPublicId.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(404, 46);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(62, 20);
            lblResult.TabIndex = 4;
            lblResult.Text = "\u007fkết quả";
            // 
            // TestUploadfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(txtPublicId);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TestUploadfile";
            Text = "TestUploadfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtPublicId;
        private Label lblResult;
    }
}