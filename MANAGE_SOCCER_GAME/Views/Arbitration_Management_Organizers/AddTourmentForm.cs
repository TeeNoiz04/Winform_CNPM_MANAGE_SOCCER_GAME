using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers
{
    public partial class AddTourmentForm : Form
    {
        private TournamentService _tournamentService;
        public AddTourmentForm(TournamentService tournamentService)
        {
            InitializeComponent();
            _tournamentService = tournamentService;

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

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateRoundInput())
                return;

            if (MessageBox.Show("Bạn có chắc chắn muốn thêm mùa giải này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            var tournament = new Tournament
            {
                Name = txbName.Text,
                Description = txbDescription.Text,
                StartDate = dtStartDate.Value.Date,
                EndDate = dtEndDate.Value.Date
            };
                try
                {
                    var create = await _tournamentService.CreateTournamentAsync(tournament);

                    AppService.ShowSuccess("Thêm mùa giải thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    AppService.ShowError("Lỗi khi thêm mùa giải: " + ex.Message);
                }
        }

        private bool ValidateRoundInput()
        {
            if (string.IsNullOrWhiteSpace(txbName.Text))
            {
                AppService.ShowError("Tên vòng đấu không được để trống.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbDescription.Text))
            {
                AppService.ShowError("Mô tả không được để trống.");
                return false;
            }

            if (dtStartDate.Value.Date > dtEndDate.Value.Date)
            {
                AppService.ShowError("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
                return false;
            }

            return true;
        }
    }
}
