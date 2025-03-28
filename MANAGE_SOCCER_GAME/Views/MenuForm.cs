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

        private void btnGames_Click(object sender, EventArgs e)
        {
            if (!btnGames.Checked)
            {
                _curentButton.Checked = false;
                btnGames.Checked = true;
                _curentButton = btnGames;
                //_router.LoadGames();
            }
        }

        private void btnApps_Click(object sender, EventArgs e)
        {
            if (!btnApps.Checked)
            {
                _curentButton.Checked = false;
                btnApps.Checked = true;
                _curentButton = btnApps;
                _router.LoadMTP();
            }
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            if (!btnShop.Checked)
            {
                _curentButton.Checked = false;
                btnShop.Checked = true;
                _curentButton = btnShop;
                //_router.LoadShop();
            }
        }

        private void btnShowPnAccount_Click(object sender, EventArgs e)
        {
            //_router.LoadAccount();
        }
    }
}
