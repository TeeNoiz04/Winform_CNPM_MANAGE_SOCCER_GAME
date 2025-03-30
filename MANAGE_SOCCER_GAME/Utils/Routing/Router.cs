using MANAGE_SOCCER_GAME.Views;
using MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers;
using MANAGE_SOCCER_GAME.Views.Manage_Results_Rankings;
using MANAGE_SOCCER_GAME.Views.Management_Team_Players;
using MANAGE_SOCCER_GAME.Views.Schedule_Management;
using MANAGE_SOCCER_GAME.Views.SignInSignUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Utils.Routing
{
    internal class Router
    {
        private static Form? _Form1;
        private static Form? _Form2;
        private static Form? _Form3;
        private static Form? _Form4;

        private static Control? _Control1;
        private static Control? _Control2;
        private static Control? _Control3;
        private static Control? _Control4;

        public Router() { }

        public Router(Control control1, Control control2, Control control3, Control control4)
        {
            _Control1 = control1;
            _Control2 = control2;
            _Control3 = control3;
            _Control4 = control4;
        }

        public void LoadForm(Control ControlContent, Form FormAtion, Form FormChild)
        {
            if (FormAtion != null && !FormAtion.IsDisposed)
            {
                FormAtion.Close();
            }

            // Thiết lập form mới vào ActForm
            FormChild.TopLevel = false;
            FormChild.FormBorderStyle = FormBorderStyle.None;
            //FormChild.Dock = DockStyle.Fill;
            FormChild.AutoScaleMode = AutoScaleMode.Dpi;

            // Thêm form vào Control và hiển thị
            FormAtion = FormChild;
            ControlContent.Controls.Add(FormAtion);
            ControlContent.Tag = FormAtion;
            FormAtion.Show();
            FormAtion.BringToFront();
        }

        public void LoadForm1(Form FormChild)
        {
            if (_Form1 != null && !_Form1.IsDisposed)
            {
                _Form1.Close();
            }

            // Thiết lập form mới vào ActForm
            FormChild.TopLevel = false;
            FormChild.FormBorderStyle = FormBorderStyle.None;
            //FormChild.Dock = DockStyle.Fill;
            FormChild.AutoScaleMode = AutoScaleMode.Dpi;

            // Thêm form vào Control và hiển thị
            _Form1 = FormChild;
            _Control1.Controls.Add(_Form1);
            _Control1.Tag = _Form1;
            _Form1.Show();
            _Form1.BringToFront();
        }

        public void LoadForm2(Form FormChild)
        {
            if (_Form2 != null && !_Form2.IsDisposed)
            {
                _Form2.Close();
            }

            // Thiết lập form mới vào ActForm
            FormChild.TopLevel = false;
            FormChild.FormBorderStyle = FormBorderStyle.None;
            //FormChild.Dock = DockStyle.Fill;
            FormChild.AutoScaleMode = AutoScaleMode.Dpi;

            // Thêm form vào Control và hiển thị
            _Form2 = FormChild;
            _Control2.Controls.Add(_Form2);
            _Control2.Tag = _Form2;
            _Form2.Show();
            _Form2.BringToFront();
        }

        public void LoadForm3(Form FormChild)
        {
            if (_Form3 != null && !_Form3.IsDisposed)
            {
                _Form3.Close();
            }

            // Thiết lập form mới vào ActForm
            FormChild.TopLevel = false;
            FormChild.FormBorderStyle = FormBorderStyle.None;
            //FormChild.Dock = DockStyle.Fill;
            FormChild.AutoScaleMode = AutoScaleMode.Dpi;

            // Thêm form vào Control và hiển thị
            _Form3 = FormChild;
            _Control3.Controls.Add(_Form3);
            _Control3.Tag = _Form3;
            _Form3.Show();
            _Form3.BringToFront();
        }

        public void LoadForm4(Form FormChild)
        {
            if (_Form4 != null && !_Form4.IsDisposed)
            {
                _Form4.Close();
            }

            // Thiết lập form mới vào ActForm
            FormChild.TopLevel = false;
            FormChild.FormBorderStyle = FormBorderStyle.None;
            //FormChild.Dock = DockStyle.Fill;
            FormChild.AutoScaleMode = AutoScaleMode.Dpi;

            // Thêm form vào Control và hiển thị
            _Form4 = FormChild;
            _Control4.Controls.Add(_Form4);
            _Control4.Tag = _Form4;
            _Form4.Show();
            _Form4.BringToFront();
        }

        public void LoadSignin()
        {
            _Control1.Visible = false;
            _Control2.Visible = false;
            _Control3.Visible = true;
            _Control4.Visible = false;

            _Control3.Dock = DockStyle.None;
            _Control3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            _Control3.Size = new System.Drawing.Size(600, 1080);
            _Control3.Location = new System.Drawing.Point(660, 0);

            LoadForm3(new SignInForm());
        }

        public void LoadSignup()
        {
            _Control1.Visible = false;
            _Control2.Visible = false;
            _Control3.Visible = true;
            _Control4.Visible = false;

            _Control3.Dock = DockStyle.Fill;

            LoadForm3(new SignUpForm());
        }

        public void LoadHome()
        {
            _Control1.Visible = true;
            _Control2.Visible = false;
            _Control3.Visible = true;
            _Control4.Visible = false;

            _Control3.Dock = DockStyle.Fill;

            LoadForm1(new MenuForm());
            LoadForm3(new HomeForm());
        }

        public void LoadMTP()
        {
            _Control1.Visible = true;
            _Control2.Visible = false;
            _Control3.Visible = true;
            _Control4.Visible = false;

            _Control3.Dock = DockStyle.Fill;

            //LoadForm2(new SidebarMTPForm());
            LoadForm3(new TeamListForm());
            //LoadForm3(new TeamDetailForm());
            //LoadForm3(new PlayerDetailForm());
        }

        public void LoadSchedule()
        {
            _Control1.Visible = true;
            _Control2.Visible = false;
            _Control3.Visible = true;
            _Control4.Visible = false;

            _Control3.Dock = DockStyle.Fill;

            //LoadForm2(new SidebarMTPForm());
            LoadForm3(new MatchScheduleForm());
            //LoadForm3(new MatchDetailForm());
        }

        public void LoadResult()
        {
            _Control1.Visible = true;
            _Control2.Visible = true;
            _Control3.Visible = true;
            _Control4.Visible = false;

            _Control3.Dock = DockStyle.Fill;

            LoadForm2(new SidebarMRRForm());
            LoadForm3(new RankingForm());
            //LoadForm3(new MatchResultForm());
        }

        public void LoadOrganizer()
        {
            _Control1.Visible = true;
            _Control2.Visible = true;
            _Control3.Visible = true;
            _Control4.Visible = false;

            _Control3.Dock = DockStyle.Fill;

            LoadForm2(new SidebarAMOForm());
            LoadForm3(new EmployeeListForm());
            //LoadForm3(new RefereeListForm());
        }
    }
}
