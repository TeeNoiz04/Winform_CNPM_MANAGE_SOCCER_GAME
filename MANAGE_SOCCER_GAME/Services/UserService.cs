using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MANAGE_SOCCER_GAME.Services
{
    public class UserService
    {
        private readonly UserManager<User> _userManager;
        private readonly ManageSoccerGame _context;
        public UserService(UserManager<User> userManager, ManageSoccerGame context)
        {
            _userManager = userManager;
            _context = context;
        }

        // Create
        public async Task<User> CreateUserAsync(User user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);
            if (!result.Succeeded)
                throw new Exception(string.Join("\n", result.Errors.Select(e => e.Description)));

            return user;
        }

        // Read all
        public async Task<List<User>> GetAllAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        // Read by Id
        public async Task<User> GetByIdAsync(Guid id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
            return user ?? throw new Exception("Không tìm thấy người dùng.");
        }

        // Update
        public async Task<User> UpdateAsync(User updated)
        {
            var user = await _userManager.FindByIdAsync(updated.Id.ToString());
            if (user == null) throw new Exception("Không tìm thấy người dùng.");

            user.FirstName = updated.FirstName;
            user.LastName = updated.LastName;
            user.Email = updated.Email;
            user.ProfilePicture = updated.ProfilePicture;
            user.Status = updated.Status;
            user.IsConfirmedEmail = updated.IsConfirmedEmail;
            user.UpdatedAt = DateTime.Now;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
                throw new Exception(string.Join("\n", result.Errors.Select(e => e.Description)));

            return user;
        }

        // Delete
        public async Task<bool> DeleteAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) throw new Exception("Không tìm thấy người dùng.");

            var result = await _userManager.DeleteAsync(user);
            return result.Succeeded;
        }
    }
}
