
using Guna.UI2.WinForms;
using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    public partial class AddManagerForm : Form
    {
        private readonly CoachService _coachService;
        public AddManagerForm(CoachService coachService)
        {
            InitializeComponent();
            _coachService = coachService;
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
            txbExpYear.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbNumber_MouseHover(object sender, EventArgs e)
        {
            txbExpYear.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbNumber_Leave(object sender, EventArgs e)
        {
            if (txbExpYear.Text == string.Empty)
            {
                txbExpYear.Text = "Number";
                txbExpYear.ForeColor = Color.Silver;
            }
        }

        private void txbNumber_Click(object sender, EventArgs e)
        {
            if (txbExpYear.Text == "Number")
            {
                txbExpYear.Text = string.Empty;
                txbExpYear.ForeColor = Color.FromArgb(60, 211, 252);
                txbExpYear.BorderColor = Color.FromArgb(60, 211, 252);
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
            Clear();
            this.Close();
        }

        private void txbUpload_Click(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm huấn luyện viên này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            if (ValidateCoachInput(txbFullName, txbEmail, txbNational, txbExpYear, txbPhone, out Coach newCoach))
            {
                try
                {
                    var createCoach = await _coachService.CreateCoachAsync(newCoach);

                    AppService.ShowSuccess("Thêm huấn luyện viên thành công!");
                    Clear();
                    this.Close();
                }
                catch (Exception ex)
                {
                    AppService.ShowError("Lỗi khi thêm huấn luyện viên: " + ex.Message);
                }
            }
        }

        private void Clear()
        {
            txbFullName.Clear();
            txbEmail.Clear();
            txbNational.Clear();
            txbExpYear.Clear();
            txbExpYear.Clear();
        }

        private bool ValidateCoachInput(
            Guna2TextBox txbFullName,
            Guna2TextBox txbEmail,
            Guna2TextBox txbNational,
            Guna2TextBox txbExpYear,
            Guna2TextBox txbPhone,
            out Coach coach)
        {
            coach = null;

            string name = txbFullName.Text.Trim();
            string email = txbEmail.Text.Trim();
            string national = txbNational.Text.Trim();
            string expYearText = txbExpYear.Text.Trim();
            string phone = txbPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(national) ||
                string.IsNullOrWhiteSpace(expYearText) ||
                string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!new EmailAddressAttribute().IsValid(email))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(expYearText, out int expYear) || expYear < 0 || expYear > 100)
            {
                MessageBox.Show("Số năm kinh nghiệm không hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(phone, @"^\d{9,11}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (phải từ 9–11 chữ số).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            coach = new Coach
            {
                Name = txbFullName.Text.Trim(),
                Email = txbEmail.Text.Trim(),
                National = txbNational.Text.Trim(),
                ExpYear = int.Parse(txbExpYear.Text.Trim()),
                PhoneNumber = txbPhone.Text.Trim(),
                IdImage = null,
                IsDeleted = false,
            };

            return true;
        }
    }
}
