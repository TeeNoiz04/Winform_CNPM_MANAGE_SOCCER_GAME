using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using Microsoft.EntityFrameworkCore;

namespace MANAGE_SOCCER_GAME.Services
{
    public class RefereeService
    {
        private readonly ManageSoccerGame _context;
        public RefereeService(ManageSoccerGame context)
        {
            _context = context;
        }
        public async Task<List<Referee>> GetAllRefereesAsync()
        {
            return await _context.Referees.ToListAsync();
        }
        public async Task<Referee?> GetRefereeByIdAsync(Guid id)
        {
            return await _context.Referees.FindAsync(id);
        }
        public async Task<Referee> CreateRefereeAsync(Referee referee)
        {
            await ValidateRefereeAsync(referee);

            if (await _context.Referees.AnyAsync(r => r.Name == referee.Name && r.DateOfBirth == referee.DateOfBirth))
            {
                throw new ArgumentException("A referee with the same name and date of birth already exists.", nameof(referee));
            }

            referee.Id = Guid.NewGuid();
            _context.Referees.Add(referee);
            await _context.SaveChangesAsync();
            return referee;
        }

        public async Task<Referee> UpdateRefereeAsync(Guid id, Referee updatedReferee)
        {
            var referee = await GetRefereeByIdAsync(id);
            if (referee == null)
            {
                throw new KeyNotFoundException("Referee not found.");
            }

            await ValidateRefereeAsync(updatedReferee);

            if (await RefereeNameExistsAsync(id, updatedReferee))
            {
                throw new ArgumentException("A referee with the same name already exists.", nameof(updatedReferee));
            }

            referee.Name = updatedReferee.Name;
            referee.DateOfBirth = updatedReferee.DateOfBirth;
            referee.Position = updatedReferee.Position;
            referee.National = updatedReferee.National;
            referee.YearOfExperience = updatedReferee.YearOfExperience;

            _context.Referees.Update(referee);
            await _context.SaveChangesAsync();
            return referee;
        }

        private async Task<bool> RefereeNameExistsAsync(Guid id, Referee updatedReferee)
        {
            return await _context.Referees.AnyAsync(r => r.Id != id && r.Name == updatedReferee.Name);
        }

        public async Task DeleteRefereeAsync(Guid id)
        {
            var referee = await GetRefereeByIdAsync(id);
            if (referee == null)
            {
                throw new KeyNotFoundException("Referee not found.");
            }

            _context.Referees.Remove(referee);
            await _context.SaveChangesAsync();
        }


        private async Task ValidateRefereeAsync(Referee referee)
        {
            if (referee == null)
            {
                throw new ArgumentNullException(nameof(referee), "Referee object cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(referee.Name))
            {
                throw new ArgumentException("Referee name is required.", nameof(referee.Name));
            }

            if (referee.DateOfBirth == default || referee.DateOfBirth > DateTime.Now.AddYears(-18))
            {
                throw new ArgumentException("Referee must be at least 18 years old.", nameof(referee.DateOfBirth));
            }

            var validPositions = new List<string> { "Main Referee", "Assistant Referee", "VAR", "Line referee" };
            if (string.IsNullOrWhiteSpace(referee.Position) || !validPositions.Contains(referee.Position))
            {
                throw new ArgumentException("Invalid or missing referee position.(\"Main Referee\", \"Assistant Referee\", \"VAR\", \"Line referee\")", nameof(referee.Position));
            }

            if (string.IsNullOrWhiteSpace(referee.National))
            {
                throw new ArgumentException("Nationality is required.", nameof(referee.National));
            }

            if (referee.YearOfExperience < 0)
            {
                throw new ArgumentException("Years of experience cannot be negative.", nameof(referee.YearOfExperience));
            }

        }
    }
}
