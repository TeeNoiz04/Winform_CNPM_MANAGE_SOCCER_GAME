using MANAGE_SOCCER_GAME.Dtos;
using MANAGE_SOCCER_GAME.Models;

namespace MANAGE_SOCCER_GAME.Services
{
    public class LeagueTableService
    {
        public List<LeagueTableEntry> CalculateLeagueTable(Guid tournamentId, List<Team> teams, List<Game> games)
        {
            var table = new List<LeagueTableEntry>();

            foreach (var team in teams.Where(t => t.IdTournament == tournamentId && !t.IsDeleted))
            {
                var entry = new LeagueTableEntry { TeamName = team.Name };

                var teamGames = games.Where(g => !g.IsDeleted && (g.HomeTeamId == team.Id || g.AwayTeamId == team.Id)).ToList();

                foreach (var game in teamGames)
                {
                    bool isHomeTeam = game.HomeTeamId == team.Id;
                    int goalsFor = isHomeTeam ? game.HomeScore : game.AwayScore;
                    int goalsAgainst = isHomeTeam ? game.AwayScore : game.HomeScore;

                    entry.Played++;
                    entry.GoalsFor += goalsFor;
                    entry.GoalsAgainst += goalsAgainst;

                    if (goalsFor > goalsAgainst)
                        entry.Won++;
                    else if (goalsFor == goalsAgainst)
                        entry.Drawn++;
                    else
                        entry.Lost++;
                }

                entry.GoalDifference = entry.GoalsFor - entry.GoalsAgainst;
                entry.Points = (entry.Won * 3) + (entry.Drawn * 1);

                var recentGames = teamGames
                    .OrderByDescending(g => g.DateStart)
                    .ThenByDescending(g => g.TimeStart)
                    .Take(5)
                    .ToList();

                entry.Form = string.Join("-", recentGames.Select(g =>
                {
                    bool isHomeTeam = g.HomeTeamId == team.Id;
                    int goalsFor = isHomeTeam ? g.HomeScore : g.AwayScore;
                    int goalsAgainst = isHomeTeam ? g.AwayScore : g.HomeScore;
                    if (goalsFor > goalsAgainst) return "W";
                    else if (goalsFor == goalsAgainst) return "D";
                    else return "L";
                }));

                table.Add(entry);
            }

            table = table.OrderByDescending(t => t.Points)
                         .ThenByDescending(t => t.GoalDifference)
                         .ToList();

            for (int i = 0; i < table.Count; i++)
            {
                table[i].Rank = i + 1;
            }

            return table;
        }
    }
}