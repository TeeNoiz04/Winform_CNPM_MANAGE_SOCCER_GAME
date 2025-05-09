﻿using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;
using MANAGE_SOCCER_GAME.Utils.InputValidators;
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
            return await _context.Coaches.Where(x => x.IsDeleted == false).ToListAsync();
        }

        public async Task<List<CoachDTO>> GetAllCoacheDTOsAsync()
        {
            var coaches = await _context.Coaches.Include(x => x.Team).Where(x => x.IsDeleted == false).ToListAsync();

            if (!coaches.Any())
                return new List<CoachDTO>();

            var dtos = coaches.Select(c => new CoachDTO
            {
                Name = c.Name,
                National = c.National,
                TeamName = c.Team != null ? c.Team.Name : "No team",
                PhoneNumber = c.PhoneNumber,
            }).ToList();

            return dtos;
        }

        public async Task<Coach?> GetCoachByIdAsync(Guid id)
        {
            return await _context.Coaches.FindAsync(id);
        }

        public async Task<Coach> CreateCoachAsync(Coach coach)
        {
            ValidateCoachAsync(coach);

            if (await _context.Coaches.AnyAsync(x => x.Name == coach.Name))
            {
                throw new ArgumentException("Coach name already exists.", nameof(coach.Name));
            }
            if (await _context.Coaches.AnyAsync(x => x.PhoneNumber == coach.PhoneNumber))
            {
                throw new ArgumentException("Coach phone number already exists.", nameof(coach.PhoneNumber));
            }

            if (await _context.Coaches.AnyAsync(x => x.Email == coach.Email))
            {
                throw new ArgumentException("Coach email already exists.", nameof(coach.Email));
            }

            coach.Id = Guid.NewGuid();
            coach.IsDeleted = false;

            _context.Coaches.Add(coach);
            await _context.SaveChangesAsync();
            return coach;
        }

        public async Task<Coach?> UpdateCoachAsync(Guid Id, Coach coach)
        {
            var existingCoach = await _context.Coaches.FindAsync(Id);
            if (existingCoach == null)
                return null;

            ValidateCoachAsync(coach);


            if (await _context.Coaches.AnyAsync(x => x.Name == coach.Name && x.Id != Id))
            {
                throw new ArgumentException("Coach name already exists.", nameof(coach.Name));
            }
            if (await _context.Coaches.AnyAsync(x => x.PhoneNumber == coach.PhoneNumber && x.Id != Id))
            {
                throw new ArgumentException("Coach phone number already exists.", nameof(coach.PhoneNumber));
            }

            if (await _context.Coaches.AnyAsync(x => x.Email == coach.Email && x.Id != Id))
            {
                throw new ArgumentException("Coach email already exists.", nameof(coach.Email));
            }

            existingCoach.Name = coach.Name;
            existingCoach.National = coach.National;
            existingCoach.ExpYear = coach.ExpYear;
            existingCoach.PhoneNumber = coach.PhoneNumber;
            existingCoach.Email = coach.Email;

            await _context.SaveChangesAsync();
            return existingCoach;
        }

        public async Task<bool> CoachExistsAsync(Guid id)
        {
            return await _context.Coaches.AnyAsync(t => t.Id == id);
        }

        public async Task<Coach?> DeleteCoachAsync(Guid Id)
        {
            var existingCoach = await _context.Coaches.FindAsync(Id);
            if (existingCoach == null)
                return null;

            existingCoach.IsDeleted = true;

            await _context.SaveChangesAsync();
            return existingCoach;
        }

        private void ValidateCoachAsync(Coach coach)
        {
            if (coach == null)
            {
                throw new ArgumentException(nameof(coach));
            }

            if (!InputValidator.IsValidString(coach.Name))
            {
                throw new ArgumentException("Coach name must contain only letters and spaces, and cannot be empty.", nameof(coach.Name));
            }

            if (!InputValidator.IsValidString(coach.National))
            {
                throw new ArgumentException("Coach national must contain only letters and spaces, and cannot be empty.", nameof(coach.National));
            }

            if (!InputValidator.IsValidPhoneNumber(coach.PhoneNumber))
            {
                throw new ArgumentException("Coach phone number must contain only digits and cannot be empty.", nameof(coach.PhoneNumber));
            }

            if (!InputValidator.IsValidEmail(coach.Email))
            {
                throw new ArgumentException("Coach email must be a valid email address.", nameof(coach.Email));
            }

            if (!InputValidator.IsValidNumber(coach.ExpYear.ToString()))
            {
                throw new ArgumentException("Coach experience year must be a valid number.", nameof(coach.ExpYear));
            }

        }

    }
}
