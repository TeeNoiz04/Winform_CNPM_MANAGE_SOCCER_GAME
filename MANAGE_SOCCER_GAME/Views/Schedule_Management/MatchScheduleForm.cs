using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using MANAGE_SOCCER_GAME.Utils.Routing;
using MANAGE_SOCCER_GAME.Views.Management_Team_Players;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    public partial class MatchScheduleForm : Form
    {
        private Router _router;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        public MatchScheduleForm()
        {
            InitializeComponent();
            //_bookSoldService = new BookSoldService();
            _router = new Router();



        }


        private async void btnTimKiem_ClickAsync(object sender, EventArgs e)
        {

        }

        private async void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

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

        }

        private void MatchScheduleForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Guna2Panel guna2Panel1 = new Guna2Panel();
                Label lblTime = new Label();
                Label lblTeam1 = new Label();
                Label lblTeam2 = new Label();
                Guna2PictureBox guna2PictureBox1 = new Guna2PictureBox();
                Guna2PictureBox guna2PictureBox2 = new Guna2PictureBox();

                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
                // 
                // guna2Panel1
                // 
                guna2Panel1.Controls.Add(lblTime);
                guna2Panel1.Controls.Add(lblTeam2);
                guna2Panel1.Controls.Add(lblTeam1);
                guna2Panel1.Controls.Add(guna2PictureBox2);
                guna2Panel1.Controls.Add(guna2PictureBox1);
                guna2Panel1.CustomizableEdges = customizableEdges21;
                guna2Panel1.Location = new Point(16, 14 * i);
                guna2Panel1.Name = "guna2Panel1";
                guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges22;
                guna2Panel1.Size = new Size(410, 60);
                guna2Panel1.TabIndex = 0;
                // 
                // lblTime
                // 
                lblTime.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
                lblTime.ForeColor = Color.White;
                lblTime.Location = new Point(155, 14);
                lblTime.Name = "lblTime";
                lblTime.Size = new Size(100, 32);
                lblTime.TabIndex = 4;
                lblTime.Text = "00 - " + i.ToString();
                lblTime.TextAlign = ContentAlignment.MiddleCenter;
                // 
                // lblTeam2
                // 
                lblTeam2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
                lblTeam2.ForeColor = Color.White;
                lblTeam2.Location = new Point(265, 14);
                lblTeam2.Name = "lblTeam2";
                lblTeam2.Size = new Size(85, 32);
                lblTeam2.TabIndex = 3;
                lblTeam2.Text = "MMM";
                lblTeam2.TextAlign = ContentAlignment.MiddleCenter;
                // 
                // lblTeam1
                // 
                lblTeam1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
                lblTeam1.ForeColor = Color.White;
                lblTeam1.Location = new Point(60, 14);
                lblTeam1.Name = "lblTeam1";
                lblTeam1.Size = new Size(85, 32);
                lblTeam1.TabIndex = 2;
                lblTeam1.Text = "MMM";
                lblTeam1.TextAlign = ContentAlignment.MiddleCenter;
                // 
                // guna2PictureBox2
                // 
                guna2PictureBox2.CustomizableEdges = customizableEdges17;
                guna2PictureBox2.ImageRotate = 0F;
                guna2PictureBox2.Location = new Point(355, 5);
                guna2PictureBox2.Name = "guna2PictureBox2";
                guna2PictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges18;
                guna2PictureBox2.Size = new Size(50, 50);
                guna2PictureBox2.TabIndex = 1;
                guna2PictureBox2.TabStop = false;
                // 
                // guna2PictureBox1
                // 
                guna2PictureBox1.CustomizableEdges = customizableEdges19;
                guna2PictureBox1.ImageRotate = 0F;
                guna2PictureBox1.Location = new Point(5, 5);
                guna2PictureBox1.Name = "guna2PictureBox1";
                guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges20;
                guna2PictureBox1.Size = new Size(50, 50);
                guna2PictureBox1.TabIndex = 0;
                guna2PictureBox1.TabStop = false;

                pnLayout.Controls.Add(guna2Panel1);
                //pnContent.Controls.Add(guna2Panel1);
            }
        }
    }
}
