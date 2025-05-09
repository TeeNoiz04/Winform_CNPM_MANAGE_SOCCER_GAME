﻿using System;
using System.Collections.Generic;
using MANAGE_SOCCER_GAME.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ImagePlayer = MANAGE_SOCCER_GAME.Models.ImagePlayer;

namespace MANAGE_SOCCER_GAME.Data
{
    public class ManageSoccerGame : IdentityDbContext<User, Role, Guid, IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public ManageSoccerGame(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<ImagePlayer> ImagePlayers { get; set; }
        public DbSet<ImageCoacher> ImageCoachers { get; set; }
        public DbSet<ImageTeam> ImageTeams { get; set; }
        public DbSet<MatchdaySquad> MatchdaySquads { get; set; }
        public DbSet<MatchOfficials> MatchOfficials { get; set; }
        public DbSet<PenaltyCard> PenaltyCards { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<SoccerGame> SoccerGames { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Round> Rounds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=;Initial Catalog=Manage_soccer_game;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.User)
                    .WithMany(u => u.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();
            });

            builder.Entity<RolePermission>(rp =>
            {
                rp.HasKey(rp => new { rp.RoleId, rp.PermissionId });
                rp.HasOne(rp => rp.Role)
                    .WithMany(r => r.RolePermissions)
                    .HasForeignKey(rp => rp.RoleId)
                    .IsRequired();
                rp.HasOne(rp => rp.Permission).WithMany(p => p.RolePermissions)
                    .HasForeignKey(rp => rp.PermissionId)
                    .IsRequired();

            });

            builder.Entity<MatchdaySquad>()
                .HasKey(ms => new { ms.IdGame, ms.IdPlayer });

            builder.Entity<MatchdaySquad>().HasOne(ms => ms.Game)
                .WithMany(g => g.MatchdaySquads)
                .HasForeignKey(ms => ms.IdGame);

            builder.Entity<MatchdaySquad>().HasOne(ms => ms.Player).WithMany(p => p.MatchdaySquads)
                .HasForeignKey(ms => ms.IdPlayer);

            builder.Entity<MatchOfficials>(mathOfficial =>
            {
                mathOfficial.HasKey(m => new { m.IdGame, m.IdReferee });
                mathOfficial.HasOne(m => m.Game)
                    .WithMany(g => g.MatchOfficials)
                    .HasForeignKey(m => m.IdGame);
                mathOfficial.HasOne(m => m.Referee)
                    .WithMany(r => r.MatchOfficials)
                    .HasForeignKey(m => m.IdReferee);
            });

            builder.Entity<Team>()
               .HasOne(t => t.Coach)
               .WithOne(c => c.Team)
               .HasForeignKey<Team>(t => t.IdCoach);

            builder.Entity<Team>(tm =>
            {
                tm.HasKey(t => t.Id);
                tm.HasOne(t => t.Tournament)
                    .WithMany(t => t.Teams)
                    .HasForeignKey(t => t.IdTournament);
            }
            );

            builder.Entity<Player>(p =>
            {
                p.HasKey(p => p.Id);
                p.HasOne(p => p.Team)
                    .WithMany(t => t.Player)
                    .HasForeignKey(p => p.IdTeam);

            });

            builder.Entity<SoccerGame>()
                .HasOne(sg => sg.GoalScorer)
                .WithMany(sg => sg.SoccerGamesAsGoalscorer)
                .HasForeignKey(sg => sg.GoalScorerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<SoccerGame>()
                .HasOne(sg => sg.Assitant)
                .WithMany(sg => sg.SoccerGamesAsAssitscorer)
                .HasForeignKey(sg => sg.AssitantId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Game>()
                .HasOne(g => g.HomeTeam)
                .WithMany(g => g.HomeGames)
                .HasForeignKey(g => g.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Game>()
                .HasOne(g => g.AwayTeam)
                .WithMany(g => g.AwayGames)
                .HasForeignKey(g => g.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Tournament>()
                .HasMany(t => t.Rounds)
                .WithOne(t => t.Tournament)
                .HasForeignKey(t => t.TournamentId);

            builder.Entity<Round>()
                .HasMany(r => r.Games)
                .WithOne(r => r.Round)
                .HasForeignKey(r => r.RoundId);

            builder.Entity<Player>()
                .HasMany(r => r.PenaltyCards)
                .WithOne(r => r.Player)
                .HasForeignKey(r => r.PlayerId);
        }


    }
}
