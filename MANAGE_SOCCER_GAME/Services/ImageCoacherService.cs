using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;

using Microsoft.EntityFrameworkCore;

namespace MANAGE_SOCCER_GAME.Services
{
    public class ImageCoacherService
    {
        private readonly ManageSoccerGame _context;

        public ImageCoacherService(ManageSoccerGame context)
        {
            _context = context;
        }

        private void ValidateUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new Exception("URL không được để trống.");
            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                throw new Exception("URL không hợp lệ.");
        }

        private async Task ValidateCreateAsync(ImageCoacher image)
        {
            ValidateUrl(image.Url);

            if (string.IsNullOrWhiteSpace(image.PublicId))
                throw new Exception("publicId là bắt buộc.");

            var exists = await _context.ImageCoachers.AnyAsync(i => i.PublicId == image.PublicId);
            if (exists)
                throw new Exception("publicId đã tồn tại.");

            var coachExists = await _context.Coaches.AnyAsync(c => c.Id == image.CoachId);
            if (!coachExists)
                throw new Exception("CoachId không tồn tại.");
        }

        private async Task ValidateUpdateAsync(ImageCoacher image)
        {
            if (image.Id == Guid.Empty)
                throw new Exception("Id không hợp lệ.");

            var exists = await _context.ImageCoachers.AnyAsync(i => i.Id == image.Id);
            if (!exists)
                throw new Exception("Không tìm thấy ảnh để cập nhật.");

            await ValidateCreateAsync(image); // reuse validate logic
        }

        public async Task<ImageCoacher> CreateImageAsync(ImageCoacher image)
        {
            await ValidateCreateAsync(image);

            image.Id = Guid.NewGuid();
            image.CreateAt = DateTime.Now;
            image.UpdateAt = DateTime.Now;

            _context.ImageCoachers.Add(image);
            await _context.SaveChangesAsync();
            return image;
        }

        public async Task<List<ImageCoacher>> GetAllImagesAsync()
        {
            return await _context.ImageCoachers
                .Include(i => i.Coach)
                .ToListAsync();
        }

        // Read by Id
        public async Task<ImageCoacher> GetImageByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new Exception("Id không hợp lệ.");

            var image = await _context.ImageCoachers
                .Include(i => i.Coach)
                .FirstOrDefaultAsync(i => i.Id == id);

            if (image == null)
                throw new Exception("Không tìm thấy ảnh.");

            return image;
        }
        public async Task<bool> UpdateImageAsync(ImageCoacher updated)
        {
            await ValidateUpdateAsync(updated);

            var existing = await _context.ImageCoachers.FindAsync(updated.Id);

            existing.Url = updated.Url;
            existing.AltText = updated.AltText;
            existing.PublicId = updated.PublicId;
            existing.CoachId = updated.CoachId;
            existing.UpdateAt = DateTime.Now;

            _context.ImageCoachers.Update(existing);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteImageAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new Exception("Id không hợp lệ.");

            var existing = await _context.ImageCoachers.FindAsync(id);
            if (existing == null)
                throw new Exception("Không tìm thấy ảnh để xoá.");

            _context.ImageCoachers.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<List<ImageCoacher>> GetImagesByCoachIdAsync(Guid coachId)
        {
            if (coachId == Guid.Empty)
                throw new Exception("CoachId không hợp lệ.");

            var exists = await _context.Coaches.AnyAsync(c => c.Id == coachId);
            if (!exists)
                throw new Exception("Không tìm thấy huấn luyện viên.");

            return await _context.ImageCoachers
                .Where(i => i.CoachId == coachId)
                .OrderByDescending(i => i.CreateAt)
                .ToListAsync();
        }
        public async Task<bool> ExistsByPublicIdAsync(string publicId)
        {
            if (string.IsNullOrWhiteSpace(publicId))
                throw new Exception("publicId không hợp lệ.");

            return await _context.ImageCoachers.AnyAsync(i => i.PublicId == publicId);
        }
    }
}
