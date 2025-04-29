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
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }
        private void txbFullName_MouseLeave(object sender, EventArgs e)
        {
            txbFullName.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbFullName_MouseHover(object sender, EventArgs e)
        {
            txbFullName.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbFullName_Leave(object sender, EventArgs e)
        {
            if (txbFullName.Text == string.Empty)
            {
                txbFullName.Text = "Full name";
                txbFullName.ForeColor = Color.Silver;
            }
        }

        private void txbFullName_Click(object sender, EventArgs e)
        {
            if (txbFullName.Text == "Full name")
            {
                txbFullName.Text = string.Empty;
                txbFullName.ForeColor = Color.FromArgb(60, 211, 252);
                txbFullName.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }

        private void txbBirthDate_MouseLeave(object sender, EventArgs e)
        {
            txbBirthDate.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbBirthDate_MouseHover(object sender, EventArgs e)
        {
            txbBirthDate.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbBirthDate_Leave(object sender, EventArgs e)
        {
            if (txbBirthDate.Text == string.Empty)
            {
                txbBirthDate.Text = "BirthDate";
                txbBirthDate.ForeColor = Color.Silver;
            }
        }

        private void txbBirthDate_Click(object sender, EventArgs e)
        {
            if (txbBirthDate.Text == "BirthDate")
            {
                txbBirthDate.Text = string.Empty;
                txbBirthDate.ForeColor = Color.FromArgb(60, 211, 252);
                txbBirthDate.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbPosition_MouseLeave(object sender, EventArgs e)
        {
            txbPosition.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbPosition_MouseHover(object sender, EventArgs e)
        {
            txbPosition.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbPosition_Leave(object sender, EventArgs e)
        {
            if (txbPosition.Text == string.Empty)
            {
                txbPosition.Text = "Position";
                txbPosition.ForeColor = Color.Silver;
            }
        }

        private void txbPosition_Click(object sender, EventArgs e)
        {
            if (txbPosition.Text == "Position")
            {
                txbPosition.Text = string.Empty;
                txbPosition.ForeColor = Color.FromArgb(60, 211, 252);
                txbPosition.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbNumber_MouseLeave(object sender, EventArgs e)
        {
            txbNumber.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbNumber_MouseHover(object sender, EventArgs e)
        {
            txbNumber.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbNumber_Leave(object sender, EventArgs e)
        {
            if (txbNumber.Text == string.Empty)
            {
                txbNumber.Text = "Number";
                txbNumber.ForeColor = Color.Silver;
            }
        }

        private void txbNumber_Click(object sender, EventArgs e)
        {
            if (txbNumber.Text == "Number")
            {
                txbNumber.Text = string.Empty;
                txbNumber.ForeColor = Color.FromArgb(60, 211, 252);
                txbNumber.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbNational_MouseLeave(object sender, EventArgs e)
        {
            txbNational.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbNational_MouseHover(object sender, EventArgs e)
        {
            txbNational.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbNational_Leave(object sender, EventArgs e)
        {
            if (txbNational.Text == string.Empty)
            {
                txbNational.Text = "National";
                txbNational.ForeColor = Color.Silver;
            }
        }

        private void txbNational_Click(object sender, EventArgs e)
        {
            if (txbNational.Text == "National")
            {
                txbNational.Text = string.Empty;
                txbNational.ForeColor = Color.FromArgb(60, 211, 252);
                txbNational.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbWeight_MouseLeave(object sender, EventArgs e)
        {
            txbWeight.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbWeight_MouseHover(object sender, EventArgs e)
        {
            txbWeight.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbWeight_Leave(object sender, EventArgs e)
        {
            if (txbWeight.Text == string.Empty)
            {
                txbWeight.Text = "Weight";
                txbWeight.ForeColor = Color.Silver;
            }
        }

        private void txbWeight_Click(object sender, EventArgs e)
        {
            if (txbWeight.Text == "Weight")
            {
                txbWeight.Text = string.Empty;
                txbWeight.ForeColor = Color.FromArgb(60, 211, 252);
                txbWeight.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbHeight_MouseLeave(object sender, EventArgs e)
        {
            txbHeight.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbHeight_MouseHover(object sender, EventArgs e)
        {
            txbHeight.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbHeight_Leave(object sender, EventArgs e)
        {
            if (txbHeight.Text == string.Empty)
            {
                txbHeight.Text = "Height";
                txbHeight.ForeColor = Color.Silver;
            }
        }

        private void txbHeight_Click(object sender, EventArgs e)
        {
            if (txbHeight.Text == "Height")
            {
                txbHeight.Text = string.Empty;
                txbHeight.ForeColor = Color.FromArgb(60, 211, 252);
                txbHeight.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbUpload_Click(object sender, EventArgs e)
        {

        }
    }
}
