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
    public partial class EditManagerForm : Form
    {
        public EditManagerForm()
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

        private void txbHeight_MouseLeave(object sender, EventArgs e)
        {
            txbEmail.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbHeight_MouseHover(object sender, EventArgs e)
        {
            txbEmail.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbHeight_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == string.Empty)
            {
                txbEmail.Text = "Email";
                txbEmail.ForeColor = Color.Silver;
            }
        }

        private void txbHeight_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "Email")
            {
                txbEmail.Text = string.Empty;
                txbEmail.ForeColor = Color.FromArgb(60, 211, 252);
                txbEmail.BorderColor = Color.FromArgb(60, 211, 252);
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
