using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGE_SOCCER_GAME.HdDungCloudinary
{
    public partial class testCoachForm : Form
    {
        private readonly ManageSoccerGame _context;
        private readonly CoachService _coachService;
        private Guid guid;
        public testCoachForm(ManageSoccerGame context)
        {
            InitializeComponent();
            _context = context;
            _coachService = new CoachService(_context);
        }

        private async Task LoadCoaches()
        {
            var coaches = await _coachService.GetAllCoachesAsync();
            if (coaches == null || !coaches.Any())
            {
                MessageBox.Show("No coaches found.");
                return;
            }
            lvCoach.Items.Clear();

            foreach (var coach in coaches)
            {
                var listItem = new ListViewItem(coach.Id.ToString());
                listItem.SubItems.Add(coach.Name);
                listItem.SubItems.Add(coach.National);
                listItem.SubItems.Add(coach.ExpYear.ToString());
                listItem.SubItems.Add(coach.PhoneNumber);
                listItem.SubItems.Add(coach.Email);

                lvCoach.Items.Add(listItem);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtExpYear.Text, out int expYear))
                {
                    MessageBox.Show("Experience year must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var coach = new Coach
                {
                    Name = txtName.Text,
                    National = txtNational.Text,
                    ExpYear = expYear,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text
                };

                await _coachService.CreateCoachAsync(coach);
                MessageBox.Show("Created!");
                await LoadCoaches();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtExpYear.Text, out int expYear))
                {
                    MessageBox.Show("Experience year must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Coach coach = new Coach
                {
                    Name = txtName.Text,
                    National = txtNational.Text,
                    ExpYear = expYear,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text
                };

                var s = await _coachService.UpdateCoachAsync(guid, coach);
                if (s == null)
                {
                    MessageBox.Show("Update failed.");
                    return;
                }
                MessageBox.Show("Updated!");
                await LoadCoaches();

                btnUpdate.Enabled = false;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void testCoachForm_Load(object sender, EventArgs e)
        {
            await LoadCoaches();
        }

        private void lvCoach_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = lvCoach.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private async void LoadCoach(object sender, EventArgs e)
        {
            if (lvCoach.SelectedItems.Count > 0)
            {
                string coachId = lvCoach.SelectedItems[0].SubItems[0].Text;

                var coach = await _coachService.GetCoachByIdAsync(Guid.Parse(coachId));
                if (coach == null)
                {
                    MessageBox.Show("Coach not found.");
                    return;
                }

                txtName.Text = coach.Name;
                txtNational.Text = coach.National;
                txtExpYear.Text = coach.ExpYear.ToString();
                txtPhoneNumber.Text = coach.PhoneNumber;
                txtEmail.Text = coach.Email;
                guid = coach.Id;
                btnUpdate.Enabled = true;
                MessageBox.Show("Selected coach: " + guid);

            }
            else
            {
                MessageBox.Show("Chưa chọn dòng nào.");
                btnUpdate.Enabled = false;

            }
        }
    }
}
