using MANAGE_SOCCER_GAME.Utils.Routing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGE_SOCCER_GAME.Views
{
    public partial class MainForm : Form
    {
        private Router _router;
        public MainForm()
        {
            InitializeComponent();
            _router = new Router(pnContent1, pnContent2, pnContent3, pnContent4);
            _router.LoadSignin();
        }

    }
}
