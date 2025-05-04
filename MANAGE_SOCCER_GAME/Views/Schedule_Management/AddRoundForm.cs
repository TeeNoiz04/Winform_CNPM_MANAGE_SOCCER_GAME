using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.Views.Schedule_Management
{
    public partial class AddRoundForm : Form
    {
        private readonly RoundService _roundService;
        public AddRoundForm(RoundService roundService)
        {
            InitializeComponent();
            _roundService = roundService;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateRoundInput())
                return;

            if (MessageBox.Show("Bạn có chắc chắn muốn thêm vòng đấu này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var round = new Round
            {
                Name = txbRoundName.Text,
                StartDate = dtStartDate.Value.Date,
                EndDate = dtEndDate.Value.Date
            };

            try
            {
                var createdPlayer = await _roundService.CreateRoundAsync(AppService.TournamentId, round);

                AppService.ShowSuccess("Thêm vòng đấu thành công!");
                Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                AppService.ShowError("Lỗi khi thêm vòng đấu: " + ex.Message);
            }

        }

        private bool ValidateRoundInput()
        {
            if (string.IsNullOrWhiteSpace(txbRoundName.Text))
            {
                AppService.ShowError("Tên vòng đấu không được để trống.");
                return false;
            }

            if (dtStartDate.Value.Date > dtEndDate.Value.Date)
            {
                AppService.ShowError("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            this.Close();
        }

        private void Clear()
        {
            txbRoundName.Clear();
        }
    }
}
