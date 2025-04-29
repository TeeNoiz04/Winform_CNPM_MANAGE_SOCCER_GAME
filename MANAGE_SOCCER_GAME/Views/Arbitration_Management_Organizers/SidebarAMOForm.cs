using Guna.UI2.WinForms;
using MANAGE_SOCCER_GAME.Utils.Routing;
using MANAGE_SOCCER_GAME.Views.Manage_Results_Rankings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    public partial class SidebarAMOForm : Form
    {
        private Guna2Button _currentButton;
        private Router _router;
        public SidebarAMOForm()
        {
            InitializeComponent();
            _currentButton = btnEmployee;
            _router = new Router();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _router.LoadForm3(new EmployeeListForm());
                }
            }
        }

        private void btnRefereeList_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _router.LoadForm3(new RefereeListForm());
                }
            }
        }

        private void btnAssignReferee_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _router.LoadForm3(new AssignRefereeForm());
                }
            }
        }

        private void btnPlayerStats_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _router.LoadForm3(new PlayerStatsForm());
                }
            }
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _router.LoadForm3(new ManagersForm());
                }
            }
        }
    }
}
