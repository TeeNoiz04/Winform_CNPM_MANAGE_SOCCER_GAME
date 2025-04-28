using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    public partial class AddTeamForm : Form
    {
        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void txbTeamname_MouseLeave(object sender, EventArgs e)
        {
            txbTeamname.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbTeamname_MouseHover(object sender, EventArgs e)
        {
            txbTeamname.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbTeamname_Leave(object sender, EventArgs e)
        {
            if (txbTeamname.Text == string.Empty)
            {
                txbTeamname.Text = "Team name";
                txbTeamname.ForeColor = Color.Silver;
            }
        }

        private void txbTeamname_Click(object sender, EventArgs e)
        {
            if (txbTeamname.Text == "Team name")
            {
                txbTeamname.Text = string.Empty;
                txbTeamname.ForeColor = Color.FromArgb(60, 211, 252);
                txbTeamname.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }

        private void txbProvince_MouseLeave(object sender, EventArgs e)
        {
            txbProvince.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbProvince_MouseHover(object sender, EventArgs e)
        {
            txbProvince.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbProvince_Leave(object sender, EventArgs e)
        {
            if (txbProvince.Text == string.Empty)
            {
                txbProvince.Text = "Province";
                txbProvince.ForeColor = Color.Silver;
            }
        }

        private void txbProvince_Click(object sender, EventArgs e)
        {
            if (txbProvince.Text == "Province")
            {
                txbProvince.Text = string.Empty;
                txbProvince.ForeColor = Color.FromArgb(60, 211, 252);
                txbProvince.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbUpload_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
