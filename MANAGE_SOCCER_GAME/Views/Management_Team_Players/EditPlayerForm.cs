using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Services;
using System.Net;
using System.IO;

namespace MANAGE_SOCCER_GAME.Views.Management_Team_Players
{
    public partial class EditPlayerForm : Form
    {
        private readonly CloudService _cloudService;
        private readonly PlayerService _playerService;
        private readonly ImagePlayerService _imagePlayerService;
        private readonly Guid _id;
        private Guid? _uploadedImageId = null;
        private Guid? _existingPlayerImageId = null;
        private ImagePlayer _tempImage = null; 


        public EditPlayerForm(PlayerService playerService,CloudService cloudService, ImagePlayerService imagePlayerService,Guid id)
        {
            InitializeComponent();
            _playerService = playerService;
            _cloudService = cloudService;
            _imagePlayerService = imagePlayerService;
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
                        var imageDTO = await _cloudService.UploadImageAsync(filePath, _id, altText);
                        if (imageDTO != null)
                        {
                            picAvatar.ImageLocation = imageDTO.Url;
                            _uploadedImageId = Guid.NewGuid();

                            _tempImage = new ImagePlayer
                            {
                                PlayerId = _id,
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
                IdImage = _existingPlayerImageId // nếu có upload mới thì dùng
            };

            try
            {
                if (_tempImage != null)
                {
                    var savedImage = await _imagePlayerService.CreateImageAsync(_tempImage);
                    player.IdImage = savedImage.Id;
                }

                var saved = await _playerService.UpdatePlayerAsync(_id, player);

                AppService.ShowSuccess("Cập nhật thông tin cầu thủ thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                if (_tempImage != null)
                    await _cloudService.DeleteImageAsync(_tempImage.PublicId);
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
            _existingPlayerImageId = player.IdImage;
            if (!string.IsNullOrEmpty(player.Image?.Url))
                AppService.LoadImageFromUrl(player?.Image.Url, picAvatar);
        }

        private async void EditPlayerForm_Load(object sender, EventArgs e)
        {
            await LoadData();
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
