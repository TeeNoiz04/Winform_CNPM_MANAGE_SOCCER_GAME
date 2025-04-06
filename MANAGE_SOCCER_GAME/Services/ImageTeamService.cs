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
    public class ImageTeamService
    {
        private readonly ManageSoccerGame _context;

        public ImageTeamService(ManageSoccerGame context)
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

        private async Task ValidateCreateAsync(ImageTeam image)
        {
            ValidateUrl(image.Url);

            if (string.IsNullOrWhiteSpace(image.publicId))
                throw new Exception("publicId là bắt buộc.");

            var exists = await _context.ImageTeams.AnyAsync(i => i.publicId == image.publicId);
            if (exists)
                throw new Exception("publicId đã tồn tại.");

            var teamExists = await _context.Teams.AnyAsync(t => t.Id == image.TeamId);
            if (!teamExists)
                throw new Exception("TeamId không tồn tại.");
        }

        private async Task ValidateUpdateAsync(ImageTeam image)
        {
            if (image.Id == Guid.Empty)
                throw new Exception("Id không hợp lệ.");

            var exists = await _context.ImageTeams.AnyAsync(i => i.Id == image.Id);
            if (!exists)
                throw new Exception("Không tìm thấy ảnh để cập nhật.");

            await ValidateCreateAsync(image); // reuse logic
        }

        // Create
        public async Task<ImageTeam> CreateImageAsync(ImageTeam image)
        {
            await ValidateCreateAsync(image);

            image.Id = Guid.NewGuid();
            image.CreateAt = DateTime.Now;
            image.UpdateAt = DateTime.Now;

            _context.ImageTeams.Add(image);
            await _context.SaveChangesAsync();
            return image;
        }

        // Read all
        public async Task<List<ImageTeam>> GetAllImagesAsync()
        {
            return await _context.ImageTeams
                .Include(i => i.Team)
                .ToListAsync();
        }

        // Read by Id
        public async Task<ImageTeam> GetImageByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new Exception("Id không hợp lệ.");

            var image = await _context.ImageTeams
                .Include(i => i.Team)
                .FirstOrDefaultAsync(i => i.Id == id);

            if (image == null)
                throw new Exception("Không tìm thấy ảnh.");

            return image;
        }

        // Update
        public async Task<bool> UpdateImageAsync(ImageTeam updated)
        {
            await ValidateUpdateAsync(updated);

            var existing = await _context.ImageTeams.FindAsync(updated.Id);

            existing.Url = updated.Url;
            existing.AltText = updated.AltText;
            existing.publicId = updated.publicId;
            existing.TeamId = updated.TeamId;
            existing.UpdateAt = DateTime.Now;

            _context.ImageTeams.Update(existing);
            await _context.SaveChangesAsync();
            return true;
        }

        // Delete
        public async Task<bool> DeleteImageAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new Exception("Id không hợp lệ.");

            var existing = await _context.ImageTeams.FindAsync(id);
            if (existing == null)
                throw new Exception("Không tìm thấy ảnh để xoá.");

            _context.ImageTeams.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }

        // Get by TeamId
        public async Task<List<ImageTeam>> GetImagesByTeamIdAsync(Guid teamId)
        {
            if (teamId == Guid.Empty)
                throw new Exception("TeamId không hợp lệ.");

            var exists = await _context.Teams.AnyAsync(t => t.Id == teamId);
            if (!exists)
                throw new Exception("Không tìm thấy đội bóng.");

            return await _context.ImageTeams
                .Where(i => i.TeamId == teamId)
                .OrderByDescending(i => i.CreateAt)
                .ToListAsync();
        }

        // Check publicId
        public async Task<bool> ExistsByPublicIdAsync(string publicId)
        {
            if (string.IsNullOrWhiteSpace(publicId))
                throw new Exception("publicId không hợp lệ.");

            return await _context.ImageTeams.AnyAsync(i => i.publicId == publicId);
        }
    }
}
