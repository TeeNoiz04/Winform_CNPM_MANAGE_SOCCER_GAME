using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using Microsoft.EntityFrameworkCore;

namespace MANAGE_SOCCER_GAME.Services
{
    public class CoachService
    {
        private readonly ManageSoccerGame _context;

        public CoachService(ManageSoccerGame context)
        {
            _context = context;
        }

        public async Task<List<Coach>> GetAllCoachesAsync()
        {
            return await _context.Coaches.ToListAsync();
        }

        public async Task<Coach?> GetCoachByIdAsync(Guid id)
        {
            return await _context.Coaches.FindAsync(id);
        }

        public async Task<Coach> CreateCoachAsync(Coach coach)
        {
            coach.Id = Guid.NewGuid();
            _context.Coaches.Add(coach);
            await _context.SaveChangesAsync();
            return coach;
        }

        public async Task<Coach?> UpdateCoachAsync(Guid Id, Coach coach)
        {
            var existingCoach = await _context.Coaches.FindAsync(Id);
            if (existingCoach == null)
                return null;

            existingCoach.Name = coach.Name;
            existingCoach.National = coach.National;
            existingCoach.ExpYear = coach.ExpYear;
            existingCoach.PhoneNumber = coach.PhoneNumber;
            existingCoach.Email = coach.Email;

            _context.Coaches.Update(existingCoach);
            await _context.SaveChangesAsync();
            return existingCoach;
        }

        public async Task<bool> CoachExistsAsync(Guid id)
        {
            return await _context.Coaches.AnyAsync(t => t.Id == id);
        }


    }
}
