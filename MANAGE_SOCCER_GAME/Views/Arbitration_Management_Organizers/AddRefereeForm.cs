
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    public partial class AddRefereeForm : Form
    {
        private readonly RefereeService _refereeService;
        public AddRefereeForm(RefereeService refereeService)
        {
            InitializeComponent();
            _refereeService = refereeService;
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
            txbExperience.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbHeight_MouseHover(object sender, EventArgs e)
        {
            txbExperience.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbHeight_Leave(object sender, EventArgs e)
        {
            if (txbExperience.Text == string.Empty)
            {
                txbExperience.Text = "Experience";
                txbExperience.ForeColor = Color.Silver;
            }
        }

        private void txbHeight_Click(object sender, EventArgs e)
        {
            if (txbExperience.Text == "Experience")
            {
                txbExperience.Text = string.Empty;
                txbExperience.ForeColor = Color.FromArgb(60, 211, 252);
                txbExperience.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (AppService.IsEmptyInput(txbFullName, txbExperience, txbPosition, txbExperience, txbNational))
                return;
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm trọng tài này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var referee = new Referee
            {
                Name = txbFullName.Text.Trim(),
                DateOfBirth = dtBirthDate.Value.Date,
                Position = txbPosition.Text.Trim(),
                National = txbNational.Text.Trim(),
                YearOfExperience = int.Parse(txbExperience.Text.Trim())
            };

            try
            {
                var createdReferee = await _refereeService.CreateRefereeAsync(referee);

                AppService.ShowSuccess("Thêm trọng tài thành công!");
                Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                AppService.ShowError("Lỗi khi thêm trọng tài: " + ex.Message);
            }
        }

        private void Clear()
        {
            txbExperience.Clear();
            txbFullName.Clear();
            txbNational.Clear();
            txbPosition.Clear();
            dtBirthDate.Value = DateTime.Now;
        }
    }
}
