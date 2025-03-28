using Guna.UI2.WinForms;
using MANAGE_SOCCER_GAME.Utils.Routing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace MANAGE_SOCCER_GAME.Views
{
    public partial class MenuForm : Form
    {
        private Router _router;
        private Guna2Button _curentButton;
        public MenuForm()
        {
            InitializeComponent();
            _router = new Router();
            _curentButton = btnHome;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!btnHome.Checked)
            {
                _curentButton.Checked = false;
                btnHome.Checked = true;
                _curentButton = btnHome;
                _router.LoadHome();
            }
        }

        private void btnShowPnAccount_Click(object sender, EventArgs e)
        {
            //_router.LoadAccount();
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            if (!btnTeam.Checked)
            {
                _curentButton.Checked = false;
                btnTeam.Checked = true;
                _curentButton = btnTeam;
                _router.LoadMTP();
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (!btnSchedule.Checked)
            {
                _curentButton.Checked = false;
                btnSchedule.Checked = true;
                _curentButton = btnSchedule;
                _router.LoadSchedule();
            }
        }

        private void btnResultRanking_Click(object sender, EventArgs e)
        {
            if (!btnResultRanking.Checked)
            {
                _curentButton.Checked = false;
                btnResultRanking.Checked = true;
                _curentButton = btnResultRanking;
                _router.LoadResult();
            }
        }

        private void btnOrganizer_Click(object sender, EventArgs e)
        {
            if (!btnOrganizer.Checked)
            {
                _curentButton.Checked = false;
                btnOrganizer.Checked = true;
                _curentButton = btnOrganizer;
                _router.LoadOrganizer();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
