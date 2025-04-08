using Guna.UI2.WinForms;
using MANAGE_SOCCER_GAME.Utils.Routing;
using MANAGE_SOCCER_GAME.Views.Management_Team_Players;
using MANAGE_SOCCER_GAME.Views.Schedule_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGE_SOCCER_GAME.Views.Manage_Results_Rankings
{
    public partial class MatchResultForm : Form
    {
        private Router _router;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        public MatchResultForm()
        {
            InitializeComponent();
            _router = new Router();

            cbbSapXep.SelectedIndex = 0;
            cbbCot.DataSource = typeof(ViewHoaDon).GetProperties().Select(prop => prop.Name).ToList();
            cbbCot.SelectedIndex = 0;

        }

        private async void LoadData()
        {
        }

        private void cbbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbbCot_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void btnTimKiem_ClickAsync(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadData();
            }
        }

        private void txbTimKiem_Click(object sender, EventArgs e)
        {
            if (txbTimKiem.Text == "Search")
            {
                txbTimKiem.Text = string.Empty;
                txbTimKiem.ForeColor = Color.Black;
            }
        }

        private void txbTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTimKiem.Text) || txbTimKiem.Text == "Search")
            {
                txbTimKiem.Text = "Search";
                txbTimKiem.ForeColor = Color.DarkGray;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // Xem chi tiết trận đấu 
        private void view_Match_Click(object sender, EventArgs e)
        {
            _router.LoadForm3(new MatchDetailForm());
        }

        private void MatchResultForm_Load(object sender, EventArgs e)
        {
            createRound();
        }

        // Tạo từng vòng đấu
        void createRound()
        {
            for (int i = 0; i < 6; i++)
            {
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                FlowLayoutPanel layoutPanel = new FlowLayoutPanel();
                Guna2Panel titlePanel = new Guna2Panel();
                Label roundLabel = new Label();
                // 
                // pnLayout
                // 
                layoutPanel.Controls.Add(titlePanel);
                layoutPanel.Location = new Point(3, 3);
                layoutPanel.Name = "pnLayout" + i.ToString();
                layoutPanel.Size = new Size(416, 380);
                layoutPanel.TabIndex = 27;
                // 
                // pnTitle
                // 
                titlePanel.Controls.Add(roundLabel);
                titlePanel.CustomizableEdges = customizableEdges17;
                titlePanel.Dock = DockStyle.Top;
                titlePanel.Location = new Point(3, 3);
                titlePanel.Name = "pnTitle" + i.ToString();
                titlePanel.ShadowDecoration.CustomizableEdges = customizableEdges18;
                titlePanel.Size = new Size(410, 50);
                titlePanel.TabIndex = 7;
                // 
                // lblRound
                // 
                roundLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
                roundLabel.ForeColor = Color.White;
                roundLabel.Location = new Point(0, 0);
                roundLabel.Name = "lblRound" + i.ToString();
                roundLabel.Size = new Size(200, 50);
                roundLabel.TabIndex = 0;
                roundLabel.Text = "ROUND 00" + i.ToString();
                roundLabel.TextAlign = ContentAlignment.MiddleLeft;

                createMatch(layoutPanel);
                pnLayoutMain.Controls.Add(layoutPanel);
            }
        }

        // Tạo từng trận đấu
        void createMatch(FlowLayoutPanel layout)
        {
            for (int i = 0; i < 5; i++)
            {
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna2Panel contentPanel = new Guna2Panel();
                Label resultLabel = new Label();
                Label team1Label = new Label();
                Label team2Label = new Label();
                Guna2PictureBox team1Pic = new Guna2PictureBox();
                Guna2PictureBox team2Pic = new Guna2PictureBox();
                // 
                // pnContent
                // 
                contentPanel.Controls.Add(resultLabel);
                contentPanel.Controls.Add(team1Label);
                contentPanel.Controls.Add(team2Label);
                contentPanel.Controls.Add(team1Pic);
                contentPanel.Controls.Add(team2Pic);
                contentPanel.CustomizableEdges = customizableEdges23;
                contentPanel.Location = new Point(3, 59);
                contentPanel.Name = "pnContent";
                contentPanel.ShadowDecoration.CustomizableEdges = customizableEdges24;
                contentPanel.Size = new Size(410, 60);
                contentPanel.TabIndex = 6;
                contentPanel.Click += view_Match_Click;
                // 
                // lblResult
                // 
                resultLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
                resultLabel.ForeColor = Color.White;
                resultLabel.Location = new Point(155, 14);
                resultLabel.Name = "lblResult";
                resultLabel.Size = new Size(100, 32);
                resultLabel.TabIndex = 4;
                resultLabel.Text = "00 - 00";
                resultLabel.TextAlign = ContentAlignment.MiddleCenter;
                resultLabel.Click += view_Match_Click;
                // 
                // lblTeam1
                // 
                team1Label.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
                team1Label.ForeColor = Color.White;
                team1Label.Location = new Point(60, 14);
                team1Label.Name = "lblTeam1";
                team1Label.Size = new Size(85, 32);
                team1Label.TabIndex = 2;
                team1Label.Text = "MMM";
                team1Label.TextAlign = ContentAlignment.MiddleCenter;
                team1Label.Click += view_Match_Click;
                // 
                // lblTeam2
                // 
                team2Label.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
                team2Label.ForeColor = Color.White;
                team2Label.Location = new Point(265, 14);
                team2Label.Name = "lblTeam2";
                team2Label.Size = new Size(85, 32);
                team2Label.TabIndex = 3;
                team2Label.Text = "MMM";
                team2Label.TextAlign = ContentAlignment.MiddleCenter;
                team2Label.Click += view_Match_Click;
                // 
                // picTeam1
                // 
                team1Pic.CustomizableEdges = customizableEdges21;
                team1Pic.ImageRotate = 0F;
                team1Pic.Location = new Point(5, 5);
                team1Pic.Name = "picTeam1";
                team1Pic.ShadowDecoration.CustomizableEdges = customizableEdges22;
                team1Pic.Size = new Size(50, 50);
                team1Pic.TabIndex = 0;
                team1Pic.TabStop = false;
                team1Pic.Click += view_Match_Click;
                // 
                // picTeam2
                // 
                team2Pic.CustomizableEdges = customizableEdges19;
                team2Pic.ImageRotate = 0F;
                team2Pic.Location = new Point(355, 5);
                team2Pic.Name = "picTeam2";
                team2Pic.ShadowDecoration.CustomizableEdges = customizableEdges20;
                team2Pic.Size = new Size(50, 50);
                team2Pic.TabIndex = 1;
                team2Pic.TabStop = false;
                team2Pic.Click += view_Match_Click;

                layout.Controls.Add(contentPanel);
            }
        }
    }
}
