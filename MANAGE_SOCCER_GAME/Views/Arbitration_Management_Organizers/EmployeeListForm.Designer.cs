namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    partial class EmployeeListForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnHeader = new Panel();
            btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            txbTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            cbbCot = new ComboBox();
            lblCot = new Label();
            lblSapXep = new Label();
            cbbSapXep = new ComboBox();
            pnContent = new Guna.UI2.WinForms.Guna2Panel();
            pnFooter = new Panel();
            btnAddReferee = new Guna.UI2.WinForms.Guna2Button();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            lblSoDong = new Label();
            cbbSoDong = new ComboBox();
            lblSoTrang = new Label();
            btnTrangKe = new Button();
            btnTrangTruoc = new Button();
            dataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            Action2 = new DataGridViewButtonColumn();
            pnHeader.SuspendLayout();
            pnContent.SuspendLayout();
            pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(btnTimKiem);
            pnHeader.Controls.Add(txbTimKiem);
            pnHeader.Controls.Add(cbbCot);
            pnHeader.Controls.Add(lblCot);
            pnHeader.Controls.Add(lblSapXep);
            pnHeader.Controls.Add(cbbSapXep);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1620, 50);
            pnHeader.TabIndex = 24;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BorderRadius = 5;
            btnTimKiem.CustomizableEdges = customizableEdges1;
            btnTimKiem.DisabledState.BorderColor = Color.DarkGray;
            btnTimKiem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTimKiem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTimKiem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTimKiem.FillColor = Color.FromArgb(60, 211, 252);
            btnTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(10, 10);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnTimKiem.Size = new Size(80, 30);
            btnTimKiem.TabIndex = 26;
            btnTimKiem.Text = "Search";
            btnTimKiem.Click += btnTimKiem_ClickAsync;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txbTimKiem.Cursor = Cursors.IBeam;
            txbTimKiem.CustomizableEdges = customizableEdges3;
            txbTimKiem.DefaultText = "Search";
            txbTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txbTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txbTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txbTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txbTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTimKiem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txbTimKiem.Location = new Point(96, 10);
            txbTimKiem.Margin = new Padding(3, 4, 3, 4);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.PlaceholderText = "";
            txbTimKiem.SelectedText = "";
            txbTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txbTimKiem.Size = new Size(1187, 30);
            txbTimKiem.TabIndex = 15;
            txbTimKiem.Click += txbTimKiem_Click;
            txbTimKiem.KeyPress += txbTimKiem_KeyPress;
            txbTimKiem.Leave += txbTimKiem_Leave;
            // 
            // cbbCot
            // 
            cbbCot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbCot.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbCot.FormattingEnabled = true;
            cbbCot.Location = new Point(1495, 13);
            cbbCot.Margin = new Padding(3, 2, 3, 2);
            cbbCot.Name = "cbbCot";
            cbbCot.Size = new Size(115, 26);
            cbbCot.TabIndex = 11;
            cbbCot.SelectedIndexChanged += cbbCot_SelectedIndexChanged;
            // 
            // lblCot
            // 
            lblCot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCot.AutoSize = true;
            lblCot.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCot.ForeColor = Color.White;
            lblCot.Location = new Point(1432, 16);
            lblCot.Name = "lblCot";
            lblCot.Size = new Size(60, 18);
            lblCot.TabIndex = 10;
            lblCot.Text = "Column";
            // 
            // lblSapXep
            // 
            lblSapXep.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSapXep.AutoSize = true;
            lblSapXep.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSapXep.ForeColor = Color.White;
            lblSapXep.Location = new Point(1289, 16);
            lblSapXep.Name = "lblSapXep";
            lblSapXep.Size = new Size(36, 18);
            lblSapXep.TabIndex = 8;
            lblSapXep.Text = "Sort";
            // 
            // cbbSapXep
            // 
            cbbSapXep.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbSapXep.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbSapXep.FormattingEnabled = true;
            cbbSapXep.Items.AddRange(new object[] { "Tăng dần", "Giảm dần" });
            cbbSapXep.Location = new Point(1331, 13);
            cbbSapXep.Margin = new Padding(3, 2, 3, 2);
            cbbSapXep.Name = "cbbSapXep";
            cbbSapXep.Size = new Size(95, 26);
            cbbSapXep.TabIndex = 9;
            cbbSapXep.SelectedIndexChanged += cbbSapXep_SelectedIndexChanged;
            // 
            // pnContent
            // 
            pnContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnContent.Controls.Add(pnFooter);
            pnContent.Controls.Add(dataGridView);
            pnContent.CustomizableEdges = customizableEdges9;
            pnContent.Location = new Point(50, 60);
            pnContent.Name = "pnContent";
            pnContent.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnContent.Size = new Size(1520, 600);
            pnContent.TabIndex = 25;
            // 
            // pnFooter
            // 
            pnFooter.Controls.Add(btnAddReferee);
            pnFooter.Controls.Add(btnRefresh);
            pnFooter.Controls.Add(lblSoDong);
            pnFooter.Controls.Add(cbbSoDong);
            pnFooter.Controls.Add(lblSoTrang);
            pnFooter.Controls.Add(btnTrangKe);
            pnFooter.Controls.Add(btnTrangTruoc);
            pnFooter.Dock = DockStyle.Bottom;
            pnFooter.Location = new Point(0, 560);
            pnFooter.Name = "pnFooter";
            pnFooter.Size = new Size(1520, 40);
            pnFooter.TabIndex = 18;
            // 
            // btnAddReferee
            // 
            btnAddReferee.BorderRadius = 5;
            btnAddReferee.CustomizableEdges = customizableEdges5;
            btnAddReferee.DisabledState.BorderColor = Color.DarkGray;
            btnAddReferee.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddReferee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddReferee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddReferee.FillColor = Color.FromArgb(60, 211, 252);
            btnAddReferee.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddReferee.ForeColor = Color.White;
            btnAddReferee.Location = new Point(1395, 5);
            btnAddReferee.Name = "btnAddReferee";
            btnAddReferee.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAddReferee.Size = new Size(120, 30);
            btnAddReferee.TabIndex = 34;
            btnAddReferee.Text = "Add Employee";
            // 
            // btnRefresh
            // 
            btnRefresh.BorderRadius = 5;
            btnRefresh.CustomizableEdges = customizableEdges7;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.FromArgb(60, 211, 252);
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(449, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRefresh.Size = new Size(80, 30);
            btnRefresh.TabIndex = 33;
            btnRefresh.Text = "Refresh";
            // 
            // lblSoDong
            // 
            lblSoDong.AutoSize = true;
            lblSoDong.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblSoDong.ForeColor = Color.White;
            lblSoDong.Location = new Point(10, 11);
            lblSoDong.Name = "lblSoDong";
            lblSoDong.Size = new Size(89, 18);
            lblSoDong.TabIndex = 28;
            lblSoDong.Text = "Line number";
            // 
            // cbbSoDong
            // 
            cbbSoDong.Font = new Font("Microsoft Sans Serif", 11.25F);
            cbbSoDong.FormattingEnabled = true;
            cbbSoDong.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            cbbSoDong.Location = new Point(105, 7);
            cbbSoDong.Margin = new Padding(3, 2, 3, 2);
            cbbSoDong.Name = "cbbSoDong";
            cbbSoDong.Size = new Size(70, 26);
            cbbSoDong.TabIndex = 29;
            // 
            // lblSoTrang
            // 
            lblSoTrang.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblSoTrang.ForeColor = Color.White;
            lblSoTrang.Location = new Point(287, 10);
            lblSoTrang.Name = "lblSoTrang";
            lblSoTrang.Size = new Size(50, 20);
            lblSoTrang.TabIndex = 32;
            lblSoTrang.Text = "Page";
            lblSoTrang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTrangKe
            // 
            btnTrangKe.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnTrangKe.Location = new Point(343, 5);
            btnTrangKe.Margin = new Padding(3, 2, 3, 2);
            btnTrangKe.Name = "btnTrangKe";
            btnTrangKe.Size = new Size(100, 30);
            btnTrangKe.TabIndex = 31;
            btnTrangKe.Text = "Next";
            btnTrangKe.UseVisualStyleBackColor = true;
            // 
            // btnTrangTruoc
            // 
            btnTrangTruoc.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnTrangTruoc.Location = new Point(181, 5);
            btnTrangTruoc.Margin = new Padding(3, 2, 3, 2);
            btnTrangTruoc.Name = "btnTrangTruoc";
            btnTrangTruoc.Size = new Size(100, 30);
            btnTrangTruoc.TabIndex = 30;
            btnTrangTruoc.Text = "Previous";
            btnTrangTruoc.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 30;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Username, Password, Role, Action, Action2 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 22;
            dataGridView.Size = new Size(1520, 600);
            dataGridView.TabIndex = 16;
            dataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView.ThemeStyle.BackColor = Color.White;
            dataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ThemeStyle.HeaderStyle.Height = 30;
            dataGridView.ThemeStyle.ReadOnly = false;
            dataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridView.ThemeStyle.RowsStyle.Height = 22;
            dataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // Username
            // 
            Username.FillWeight = 66.1519F;
            Username.HeaderText = "User name";
            Username.Name = "Username";
            // 
            // Password
            // 
            Password.FillWeight = 66.1519F;
            Password.HeaderText = "Password";
            Password.Name = "Password";
            // 
            // Role
            // 
            Role.FillWeight = 66.1519F;
            Role.HeaderText = "Role";
            Role.Name = "Role";
            // 
            // Action
            // 
            Action.FillWeight = 50F;
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.Resizable = DataGridViewTriState.True;
            Action.SortMode = DataGridViewColumnSortMode.Automatic;
            Action.Text = "Edit";
            Action.UseColumnTextForButtonValue = true;
            // 
            // Action2
            // 
            Action2.FillWeight = 50F;
            Action2.HeaderText = "";
            Action2.Name = "Action2";
            Action2.Resizable = DataGridViewTriState.True;
            Action2.SortMode = DataGridViewColumnSortMode.Automatic;
            Action2.Text = "Delete";
            Action2.UseColumnTextForButtonValue = true;
            // 
            // EmployeeListForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(20, 44, 76);
            ClientSize = new Size(1620, 1000);
            Controls.Add(pnHeader);
            Controls.Add(pnContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeListForm";
            Text = "OrdersForm";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnContent.ResumeLayout(false);
            pnFooter.ResumeLayout(false);
            pnFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private Guna.UI2.WinForms.Guna2TextBox txbTimKiem;
        private System.Windows.Forms.ComboBox cbbCot;
        private System.Windows.Forms.Label lblCot;
        private System.Windows.Forms.Label lblSapXep;
        private System.Windows.Forms.ComboBox cbbSapXep;
        private Guna.UI2.WinForms.Guna2Panel pnContent;
        private System.Windows.Forms.Panel pnFooter;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewButtonColumn Action;
        private DataGridViewButtonColumn Action2;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Label lblSoDong;
        private ComboBox cbbSoDong;
        private Label lblSoTrang;
        private Button btnTrangKe;
        private Button btnTrangTruoc;
        private Guna.UI2.WinForms.Guna2Button btnAddReferee;
    }
}