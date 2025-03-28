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

namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    public partial class SidebarMTPForm : Form
    {
        private Guna2Button _currentButton;
        private Router _router;
        public SidebarMTPForm()
        {
            InitializeComponent();
            _currentButton = btnAll;
            _router = new Router();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    //_router.LoadForm3(new AppsForm());
                }
            }
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    //_router.LoadForm3(new AppsForm("Tools"));
                }
            }
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    //_router.LoadForm3(new AppsForm("Social"));
                }
            }
        }

        private void btnWebBrowsers_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    //_router.LoadForm3(new AppsForm("Web Browser"));
                }
            }
        }
    }
}
