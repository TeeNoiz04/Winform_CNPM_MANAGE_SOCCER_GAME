using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    public partial class AddPlayerForm : Form
    {
        private readonly PlayerService _playerService;
        private readonly CloudService _cloudService;
        private readonly ImagePlayerService _imagePlayerService;
        private readonly Guid _teamId;
        private ImagePlayer _tempImage;

        public AddPlayerForm(PlayerService playerService, CloudService cloudService, ImagePlayerService imagePlayerService, Guid teamId)
        {
            InitializeComponent();
            _playerService = playerService;
            _cloudService = cloudService;
            _imagePlayerService = imagePlayerService;
            _teamId = teamId;
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
        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (_tempImage != null)
                await _cloudService.DeleteImageAsync(_tempImage.PublicId);
            this.Close();
        }

        private async void txbUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.Title = "Chọn ảnh cầu thủ";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string altText = "Ảnh đại diện cầu thủ";

                    try
                    {
                        var imageDTO = await _cloudService.UploadImageAsync(filePath, null, altText);
                        if (imageDTO != null)
                        {
                            picAvatar.ImageLocation = imageDTO.Url;
                            _tempImage = new ImagePlayer
                            {
                                PublicId = imageDTO.PublicId,
                                Url = imageDTO.Url,
                                AltText = altText
                            };
                        }
                        else
                        {
                            MessageBox.Show("Không thể tải ảnh lên.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}");
                    }
                }
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidatePlayerInput())
                return;

            if (MessageBox.Show("Bạn có chắc chắn muốn thêm cầu thủ này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var player = new Player
            {
                Name = txbFullName.Text.Trim(),
                BirthDate = dtBirthDate.Value.Date,
                Position = txbPosition.Text.Trim(),
                Number = int.Parse(txbNumber.Text.Trim()),
                National = txbNational.Text.Trim(),
                Weight = int.Parse(txbWeight.Text.Trim()),
                Height = int.Parse(txbHeight.Text.Trim()),
                IdTeam = _teamId,
                IdImage = null,
                Status = "Đá chính"
            };

            try
            {
                var createdPlayer = await _playerService.CreatePlayerAsync(player);
                if (_tempImage != null)
                {
                    _tempImage.PlayerId = createdPlayer.Id;
                    var savedImage = await _imagePlayerService.CreateImageAsync(_tempImage);
                    createdPlayer.IdImage = savedImage.Id;
                    await _playerService.UpdatePlayerAsync(createdPlayer.Id, createdPlayer);
                }

                AppService.ShowSuccess("Thêm cầu thủ thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                if (_tempImage != null)
                    await _cloudService.DeleteImageAsync(_tempImage.PublicId);
                AppService.ShowError("Lỗi khi thêm cầu thủ: " + ex.Message);
            }
        }

         private bool ValidatePlayerInput()
        {
            if (AppService.IsEmptyInput(txbFullName, txbPosition, txbNumber, txbNational, txbHeight, txbWeight))
            {
                return false;
            }

            if (!int.TryParse(txbNumber.Text.Trim(), out int number) || number <= 0 || number > 99)
            {
                MessageBox.Show("Số áo phải là số nguyên từ 1 đến 99.");
                return false;
            }

            if (!int.TryParse(txbWeight.Text.Trim(), out int weight) || weight < 40 || weight > 150)
            {
                MessageBox.Show("Cân nặng phải là số nguyên từ 40 đến 150 kg.");
                return false;
            }

            if (!int.TryParse(txbHeight.Text.Trim(), out int height) || height < 140 || height > 220)
            {
                MessageBox.Show("Chiều cao phải là số nguyên từ 140 đến 220 cm.");
                return false;
            }

            if (dtBirthDate.Value > DateTime.Now || dtBirthDate.Value.Year < DateTime.Now.Year - 100)
            {
                MessageBox.Show("Ngày sinh không hợp lệ.");
                return false;
            }

            if (!txbNational.Text.Trim().All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Quốc tịch chỉ chứa chữ cái và số.");
                return false;
            }

            return true;
        }
    }
}
