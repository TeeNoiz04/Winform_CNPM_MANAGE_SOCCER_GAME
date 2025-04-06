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
    public class ImagePlayerService
    {
        private readonly ManageSoccerGame _context;

        public ImagePlayerService(ManageSoccerGame context)
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

        private async Task ValidateCreateAsync(ImagePlayer image)
        {
            ValidateUrl(image.Url);

            if (string.IsNullOrWhiteSpace(image.publicId))
                throw new Exception("publicId là bắt buộc.");

            var exists = await _context.ImagePlayers.AnyAsync(i => i.publicId == image.publicId);
            if (exists)
                throw new Exception("publicId đã tồn tại.");

            var playerExists = await _context.Players.AnyAsync(p => p.Id == image.PlayerId);
            if (!playerExists)
                throw new Exception("PlayerId không tồn tại.");
        }

        private async Task ValidateUpdateAsync(ImagePlayer image)
        {
            if (image.Id == Guid.Empty)
                throw new Exception("Id không hợp lệ.");

            var exists = await _context.ImagePlayers.AnyAsync(i => i.Id == image.Id);
            if (!exists)
                throw new Exception("Không tìm thấy ảnh để cập nhật.");

            await ValidateCreateAsync(image); // reuse logic
        }

        // Create
        public async Task<ImagePlayer> CreateImageAsync(ImagePlayer image)
        {
            await ValidateCreateAsync(image);

            image.Id = Guid.NewGuid();
            image.CreateAt = DateTime.Now;
            image.UpdateAt = DateTime.Now;

            _context.ImagePlayers.Add(image);
            await _context.SaveChangesAsync();
            return image;
        }

        // Read all
        public async Task<List<ImagePlayer>> GetAllImagesAsync()
        {
            return await _context.ImagePlayers
                .Include(i => i.Player)
                .ToListAsync();
        }

        // Read by Id
        public async Task<ImagePlayer> GetImageByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new Exception("Id không hợp lệ.");

            var image = await _context.ImagePlayers
                .Include(i => i.Player)
                .FirstOrDefaultAsync(i => i.Id == id);

            if (image == null)
                throw new Exception("Không tìm thấy ảnh.");

            return image;
        }

        // Update
        public async Task<bool> UpdateImageAsync(ImagePlayer updated)
        {
            await ValidateUpdateAsync(updated);

            var existing = await _context.ImagePlayers.FindAsync(updated.Id);

            existing.Url = updated.Url;
            existing.AltText = updated.AltText;
            existing.publicId = updated.publicId;
            existing.PlayerId = updated.PlayerId;
            existing.UpdateAt = DateTime.Now;

            _context.ImagePlayers.Update(existing);
            await _context.SaveChangesAsync();
            return true;
        }

        // Delete
        public async Task<bool> DeleteImageAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new Exception("Id không hợp lệ.");

            var existing = await _context.ImagePlayers.FindAsync(id);
            if (existing == null)
                throw new Exception("Không tìm thấy ảnh để xoá.");

            _context.ImagePlayers.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }

        // Get by PlayerId
        public async Task<List<ImagePlayer>> GetImagesByPlayerIdAsync(Guid playerId)
        {
            if (playerId == Guid.Empty)
                throw new Exception("PlayerId không hợp lệ.");

            var exists = await _context.Players.AnyAsync(p => p.Id == playerId);
            if (!exists)
                throw new Exception("Không tìm thấy cầu thủ.");

            return await _context.ImagePlayers
                .Where(i => i.PlayerId == playerId)
                .OrderByDescending(i => i.CreateAt)
                .ToListAsync();
        }

        // Check publicId
        public async Task<bool> ExistsByPublicIdAsync(string publicId)
        {
            if (string.IsNullOrWhiteSpace(publicId))
                throw new Exception("publicId không hợp lệ.");

            return await _context.ImagePlayers.AnyAsync(i => i.publicId == publicId);
        }
    }
}
