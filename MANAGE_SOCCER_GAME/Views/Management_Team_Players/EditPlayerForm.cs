using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    public partial class EditPlayerForm : Form
    {
        private readonly PlayerService _playerService;
        private readonly Guid _id;
        public EditPlayerForm(PlayerService playerService, Guid id)
        {
            InitializeComponent();
            _playerService = playerService;
            _id = id;
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

        //private void txbBirthDate_MouseLeave(object sender, EventArgs e)
        //{
        //    txbBirthDate.BorderColor = Color.FromArgb(52, 52, 116);
        //}

        //private void txbBirthDate_MouseHover(object sender, EventArgs e)
        //{
        //    txbBirthDate.BorderColor = Color.FromArgb(60, 211, 252);
        //}

        //private void txbBirthDate_Leave(object sender, EventArgs e)
        //{
        //    if (txbBirthDate.Text == string.Empty)
        //    {
        //        txbBirthDate.Text = "BirthDate";
        //        txbBirthDate.ForeColor = Color.Silver;
        //    }
        //}

        //private void txbBirthDate_Click(object sender, EventArgs e)
        //{
        //    if (txbBirthDate.Text == "BirthDate")
        //    {
        //        txbBirthDate.Text = string.Empty;
        //        txbBirthDate.ForeColor = Color.FromArgb(60, 211, 252);
        //        txbBirthDate.BorderColor = Color.FromArgb(60, 211, 252);
        //    }
        //}
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
        private void txbNumber_MouseLeave(object sender, EventArgs e)
        {
            txbNumber.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbNumber_MouseHover(object sender, EventArgs e)
        {
            txbNumber.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbNumber_Leave(object sender, EventArgs e)
        {
            if (txbNumber.Text == string.Empty)
            {
                txbNumber.Text = "Number";
                txbNumber.ForeColor = Color.Silver;
            }
        }

        private void txbNumber_Click(object sender, EventArgs e)
        {
            if (txbNumber.Text == "Number")
            {
                txbNumber.Text = string.Empty;
                txbNumber.ForeColor = Color.FromArgb(60, 211, 252);
                txbNumber.BorderColor = Color.FromArgb(60, 211, 252);
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
        private void txbWeight_MouseLeave(object sender, EventArgs e)
        {
            txbWeight.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbWeight_MouseHover(object sender, EventArgs e)
        {
            txbWeight.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbWeight_Leave(object sender, EventArgs e)
        {
            if (txbWeight.Text == string.Empty)
            {
                txbWeight.Text = "Weight";
                txbWeight.ForeColor = Color.Silver;
            }
        }

        private void txbWeight_Click(object sender, EventArgs e)
        {
            if (txbWeight.Text == "Weight")
            {
                txbWeight.Text = string.Empty;
                txbWeight.ForeColor = Color.FromArgb(60, 211, 252);
                txbWeight.BorderColor = Color.FromArgb(60, 211, 252);
            }
        }
        private void txbHeight_MouseLeave(object sender, EventArgs e)
        {
            txbHeight.BorderColor = Color.FromArgb(52, 52, 116);
        }

        private void txbHeight_MouseHover(object sender, EventArgs e)
        {
            txbHeight.BorderColor = Color.FromArgb(60, 211, 252);
        }

        private void txbHeight_Leave(object sender, EventArgs e)
        {
            if (txbHeight.Text == string.Empty)
            {
                txbHeight.Text = "Height";
                txbHeight.ForeColor = Color.Silver;
            }
        }

        private void txbHeight_Click(object sender, EventArgs e)
        {
            if (txbHeight.Text == "Height")
            {
                txbHeight.Text = string.Empty;
                txbHeight.ForeColor = Color.FromArgb(60, 211, 252);
                txbHeight.BorderColor = Color.FromArgb(60, 211, 252);
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
            if (!ValidatePlayerInput())
                return;

            if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin cầu thủ này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var player = new Player
            {
                Name = txbFullName.Text.Trim(),
                BirthDate = dtBirthDate.Value.Date,
                Position = txbPosition.Text.Trim(),
                Number = int.Parse(txbNumber.Text.Trim()),
                National = txbNational.Text,
                Weight = int.Parse(txbWeight.Text.Trim()),
                Height = int.Parse(txbHeight.Text.Trim()),
                IdImage = null,
            };

            try
            {
                var saved = await _playerService.UpdatePlayerAsync(_id, player);

                AppService.ShowSuccess("Cập nhật thông tin cầu thủ thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                AppService.ShowError("Lỗi khi cập nhât thông tin cầu thủ: " + ex.Message);
            }
        }

        private async Task LoadData()
        {
            var player = await _playerService.GetPlayerByIdAsync(_id);
            if (player == null)
            {
                MessageBox.Show("Player not found");
                return;
            }
            txbFullName.Text = player.Name;
            dtBirthDate.Value = player.BirthDate;
            txbPosition.Text = player.Position;
            txbNumber.Text = player.Number.ToString();
            txbNational.Text = player.National;
            txbWeight.Text = player.Weight.ToString();
            txbHeight.Text = player.Height.ToString();
        }

        private async void EditPlayerForm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private bool ValidatePlayerInput()
        {
            if (AppService.IsEmptyInput(txbFullName, txbPosition, txbNumber, txbNational, txbHeight, txbWeight))
                return false;

            return true;
        }
    }
}
