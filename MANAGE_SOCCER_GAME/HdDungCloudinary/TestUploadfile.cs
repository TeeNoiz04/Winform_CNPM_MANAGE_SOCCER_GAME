using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MANAGE_SOCCER_GAME.Services;

namespace MANAGE_SOCCER_GAME.HdDungCloudinary
{
    public partial class TestUploadfile : Form
    {
        private readonly CloudService _cloudinaryService;
        public TestUploadfile()
        {
            InitializeComponent();
            _cloudinaryService = new CloudService();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Guid playerId = Guid.NewGuid();  // Giả sử bạn đã có PlayerId, hoặc lấy từ đâu đó
                    string altText = "Player profile picture";  // Ví dụ alt text

                    try
                    {
                        // Tải ảnh lên Cloudinary và lấy kết quả
                        var imageDTO = await _cloudinaryService.UploadImageAsync(filePath, playerId, altText);
                        lblResult.Text = $"Image uploaded! URL: {imageDTO.Url}\nPublicId: {imageDTO.PublicId}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error uploading image: {ex.Message}");
                    }
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string publicId = txtPublicId.Text.Trim(); // Lấy publicId từ TextBox

            if (string.IsNullOrEmpty(publicId))
            {
                MessageBox.Show("Please enter a valid Public ID.");
                return;
            }

            try
            {
                var imageInfo = await _cloudinaryService.GetImageInfoAsync(publicId);
                lblResult.Text = $"Image Info: \nURL: {imageInfo.Url}\nFormat: {imageInfo.Format}\nWidth: {imageInfo.Width}\nHeight: {imageInfo.Height}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting image info: {ex.Message}");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string publicId = txtPublicId.Text.Trim(); // Lấy publicId từ TextBox

            if (string.IsNullOrEmpty(publicId))
            {
                MessageBox.Show("Please enter a valid Public ID.");
                return;
            }

            try
            {
                bool isDeleted = await _cloudinaryService.DeleteImageAsync(publicId);
                if (isDeleted)
                {
                    lblResult.Text = "Image deleted successfully!";
                }
                else
                {
                    lblResult.Text = "Failed to delete image.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting image: {ex.Message}");
            }
        }
    }
 }

