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
    public partial class SignUpForm : Form
    {
        private Router _router;
        public SignUpForm()
        {
            InitializeComponent();
            _router = new Router();
            this.Dock = DockStyle.Fill;
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            //_action.LoadForm3(new LoginForm());
            _router.LoadSignin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _router.LoadForm3(new SignUpManuallyForm());
        }

        private void lblLogin_MouseHover(object sender, EventArgs e)
        {
            lblLogin.Cursor = Cursors.Hand;
        }
    }
}
