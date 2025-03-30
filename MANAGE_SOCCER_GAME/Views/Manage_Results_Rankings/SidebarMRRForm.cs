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

namespace MANAGE_SOCCER_GAME.Views.Manage_Results_Rankings
{
    public partial class SidebarMRRForm : Form
    {
        private Guna2Button _currentButton;
        private Router _router;
        public SidebarMRRForm()
        {
            InitializeComponent();
            _currentButton = btnRanking;
            _router = new Router();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _router.LoadForm3(new RankingForm());
                }
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                if (!button.Checked)
                {
                    _currentButton.Checked = false;
                    button.Checked = true;
                    _currentButton = button;

                    _router.LoadForm3(new MatchResultForm());
                }
            }
        }
    }
}
