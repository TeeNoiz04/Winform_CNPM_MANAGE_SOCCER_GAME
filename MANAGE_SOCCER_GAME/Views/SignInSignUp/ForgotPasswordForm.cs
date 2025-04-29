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

namespace MANAGE_SOCCER_GAME.Views.SignInSignUp
{
    public partial class ForgotPasswordForm : Form
    {
        private Router _router;
        public ForgotPasswordForm()
        {
            InitializeComponent();

            _router = new Router();
        }

        private void lblAsk_Click(object sender, EventArgs e)
        {
            _router.LoadForm3(new SignInForm());
        }
        private void txbEmail_MouseLeave(object sender, EventArgs e)
        {
            txbEmail.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbEmail_MouseHover(object sender, EventArgs e)
        {
            txbEmail.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == string.Empty)
            {
                txbEmail.Text = "Email Address";
                txbEmail.ForeColor = Color.Silver;
                txbEmail.BorderColor = Color.FromArgb(52, 52, 116);
            }
        }

        private void txbEmail_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "Email Address")
            {
                txbEmail.Text = string.Empty;
                txbEmail.ForeColor = Color.FromArgb(60, 211, 252);
                txbEmail.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
    }
}
