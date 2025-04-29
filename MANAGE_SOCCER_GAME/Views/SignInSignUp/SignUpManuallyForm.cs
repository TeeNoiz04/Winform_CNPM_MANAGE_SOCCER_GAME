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
    public partial class SignUpManuallyForm : Form
    {
        private Router _router;
        public SignUpManuallyForm()
        {
            InitializeComponent();
            _router = new Router();
            this.Dock = DockStyle.Fill;
        }

        private void lblAsk_Click(object sender, EventArgs e)
        {
            _router.LoadSignup();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _router.LoadSignin();
        }

        private void lblAsk_MouseHover(object sender, EventArgs e)
        {
            lblAsk.Cursor = Cursors.Hand;
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
        private void txbUsername_MouseLeave(object sender, EventArgs e)
        {
            txbUsername.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbUsername_MouseHover(object sender, EventArgs e)
        {
            txbUsername.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbUsername_Leave(object sender, EventArgs e)
        {
            if (txbUsername.Text == string.Empty)
            {
                txbUsername.Text = "Username";
                txbUsername.ForeColor = Color.Silver;
            }
        }

        private void txbUserName_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "Username")
            {
                txbUsername.Text = string.Empty;
                txbUsername.ForeColor = Color.FromArgb(60, 211, 252);
                txbUsername.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbPassword_MouseLeave(object sender, EventArgs e)
        {
            txbPassword.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbPassword_MouseHover(object sender, EventArgs e)
        {
            txbPassword.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == string.Empty)
            {
                txbPassword.Text = "Password";
                txbPassword.PasswordChar = '\0';
                txbPassword.ForeColor = Color.Silver;
            }
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = string.Empty;
                txbPassword.ForeColor = Color.FromArgb(60, 211, 252);
                txbPassword.BorderColor = Color.FromArgb(60, 211, 252);
                txbPassword.PasswordChar = '*';
            }
        }
        private void txbConfirmPassword_MouseLeave(object sender, EventArgs e)
        {
            txbConfirmPassword.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbConfirmPassword_MouseHover(object sender, EventArgs e)
        {
            txbConfirmPassword.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txbConfirmPassword.Text == string.Empty)
            {
                txbConfirmPassword.Text = "Confirm Password";
                txbConfirmPassword.PasswordChar = '\0';
                txbConfirmPassword.ForeColor = Color.Silver;
            }
        }

        private void txbConfirmPassword_Click(object sender, EventArgs e)
        {
            if (txbConfirmPassword.Text == "Confirm Password")
            {
                txbConfirmPassword.Text = string.Empty;
                txbConfirmPassword.ForeColor = Color.FromArgb(60, 211, 252);
                txbConfirmPassword.BorderColor = Color.FromArgb(60, 211, 252);
                txbConfirmPassword.PasswordChar = '*';
            }
        }

        private void txbFirstName_MouseLeave(object sender, EventArgs e)
        {
            txbFirstName.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbFirstName_MouseHover(object sender, EventArgs e)
        {
            txbFirstName.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbFirstName_Leave(object sender, EventArgs e)
        {
            if (txbFirstName.Text == string.Empty)
            {
                txbFirstName.Text = "First name";
                txbFirstName.ForeColor = Color.Silver;
            }
        }

        private void txbFirstName_Click(object sender, EventArgs e)
        {
            if (txbFirstName.Text == "First name")
            {
                txbFirstName.Text = string.Empty;
                txbFirstName.ForeColor = Color.FromArgb(60, 211, 252);
                txbFirstName.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbLastName_MouseLeave(object sender, EventArgs e)
        {
            txbLastName.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbLastName_MouseHover(object sender, EventArgs e)
        {
            txbLastName.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbLastName_Leave(object sender, EventArgs e)
        {
            if (txbLastName.Text == string.Empty)
            {
                txbLastName.Text = "Last name";
                txbLastName.ForeColor = Color.Silver;
            }
        }

        private void txbLastName_Click(object sender, EventArgs e)
        {
            if (txbLastName.Text == "Last name")
            {
                txbLastName.Text = string.Empty;
                txbLastName.ForeColor = Color.FromArgb(60, 211, 252);
                txbLastName.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
    }
}
