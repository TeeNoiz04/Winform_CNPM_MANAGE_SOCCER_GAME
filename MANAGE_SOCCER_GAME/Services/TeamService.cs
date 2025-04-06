using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANAGE_SOCCER_GAME.Services
{
    public class TeamService
    {
        private readonly ManageSoccerGame _context;
        private readonly TournamentService _tournamentService;

        // cách làm khác
        //public TeamService(ManageSoccerGame context, TournamentService tournamentService)
        //{
        //    _context = context;
        //    _tournamentService = tournamentService;
        //}

        public TeamService(ManageSoccerGame context)
        {
            _context = context;
            _tournamentService = new TournamentService(_context);
        }

        public async Task<Team> CreateAsync(Team team)
        {
            var tournamentExist = await _tournamentService.TournamentExistsAsync(team.IdTournament);
            if (!tournamentExist)
            {
                throw new Exception("Tournament not found");
            }

            var teamExist = await _context.Teams.AnyAsync(t => t.Name == team.Name);
            if (teamExist)
            {
                throw new Exception("A team with the same name already exists.");
            }

            team.Id = Guid.NewGuid();
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
            return team;
        }



        
    }
}
