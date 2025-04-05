using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using MANAGE_SOCCER_GAME.Dtos;

namespace MANAGE_SOCCER_GAME.Services
{
    
    public  class CloudService
    {
        private readonly Cloudinary _cloudinary;
        public CloudService()
        {
            var cloudinaryConfig = new Account(
                 "dqp5kvzi1",            
                 "611761596872118" ,
                 "AdX5vAQVHg-8lhY4NNhChB0_cK4"
            );

            _cloudinary = new Cloudinary(cloudinaryConfig);
        }
        public async Task<ImageResponeDTO> UploadImageAsync(string filePath, Guid foreignKeyId, string altText)
        {
            try
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(filePath)
                };

                var uploadResult = await _cloudinary.UploadAsync(uploadParams);

               
                return new ImageResponeDTO
                {
                    Url = uploadResult.Url.ToString(),
                    PublicId = uploadResult.PublicId,  // add public_id here
                    foreignKeyId = foreignKeyId,
                    AltText = altText
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to upload image: {ex.Message}");
            }
        }
        public async Task<GetResourceResult> GetImageInfoAsync(string publicId)
        {
            try
            {
                var result = await _cloudinary.GetResourceAsync(new GetResourceParams(publicId));
                return result; // Trả về thông tin của hình ảnh
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get image info: {ex.Message}");
            }
        }


        public async Task<bool> DeleteImageAsync(string publicId)
        {
            try
            {
                var deleteParams = new DeletionParams(publicId);
                var result = await _cloudinary.DestroyAsync(deleteParams);
                return result.Result == "ok"; // Trả về true nếu xóa thành công
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete image: {ex.Message}");
            }
        }

    }
}
