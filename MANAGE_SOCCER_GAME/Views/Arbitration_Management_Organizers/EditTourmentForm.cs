using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    public partial class EditTourmentForm : Form
    {
        public EditTourmentForm()
        {
            InitializeComponent();
        }
        private void txbFullName_MouseLeave(object sender, EventArgs e)
        {
            txbName.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbFullName_MouseHover(object sender, EventArgs e)
        {
            txbName.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbFullName_Leave(object sender, EventArgs e)
        {
            if (txbName.Text == string.Empty)
            {
                txbName.Text = "Name";
                txbName.ForeColor = Color.Silver;
            }
        }

        private void txbFullName_Click(object sender, EventArgs e)
        {
            if (txbName.Text == "Name")
            {
                txbName.Text = string.Empty;
                txbName.ForeColor = Color.FromArgb(60, 211, 252);
                txbName.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }

        private void txbBirthDate_MouseLeave(object sender, EventArgs e)
        {
            txbDayStart.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbBirthDate_MouseHover(object sender, EventArgs e)
        {
            txbDayStart.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbBirthDate_Leave(object sender, EventArgs e)
        {
            if (txbDayStart.Text == string.Empty)
            {
                txbDayStart.Text = "Day Start";
                txbDayStart.ForeColor = Color.Silver;
            }
        }

        private void txbBirthDate_Click(object sender, EventArgs e)
        {
            if (txbDayStart.Text == "Day Start")
            {
                txbDayStart.Text = string.Empty;
                txbDayStart.ForeColor = Color.FromArgb(60, 211, 252);
                txbDayStart.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbPosition_MouseLeave(object sender, EventArgs e)
        {
            txbDayEnd.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbPosition_MouseHover(object sender, EventArgs e)
        {
            txbDayEnd.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbPosition_Leave(object sender, EventArgs e)
        {
            if (txbDayEnd.Text == string.Empty)
            {
                txbDayEnd.Text = "Day End";
                txbDayEnd.ForeColor = Color.Silver;
            }
        }

        private void txbPosition_Click(object sender, EventArgs e)
        {
            if (txbDayEnd.Text == "Day End")
            {
                txbDayEnd.Text = string.Empty;
                txbDayEnd.ForeColor = Color.FromArgb(60, 211, 252);
                txbDayEnd.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbNumber_MouseLeave(object sender, EventArgs e)
        {
            txbDescription.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbNumber_MouseHover(object sender, EventArgs e)
        {
            txbDescription.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbNumber_Leave(object sender, EventArgs e)
        {
            if (txbDescription.Text == string.Empty)
            {
                txbDescription.Text = "Description";
                txbDescription.ForeColor = Color.Silver;
            }
        }

        private void txbNumber_Click(object sender, EventArgs e)
        {
            if (txbDescription.Text == "Description")
            {
                txbDescription.Text = string.Empty;
                txbDescription.ForeColor = Color.FromArgb(60, 211, 252);
                txbDescription.BorderColor = Color.FromArgb(60, 211, 252);
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
