using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using MANAGE_SOCCER_GAME.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Image = MANAGE_SOCCER_GAME.Models.Image;

namespace MANAGE_SOCCER_GAME.Data
{
    public class ManageSoccerGame : IdentityDbContext<User, Role, Guid, IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public ManageSoccerGame(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<MatchdaySquad> MatchdaySquads { get; set; }
        public DbSet<MatchOfficials> MatchOfficials { get; set; }
        public DbSet<MatchSchedule> MatchSchedules { get; set; }
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=TEENOIZ04;Initial Catalog=Manage_soccer_game;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
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
            builder.Entity<RolePermission>(rp => {
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


            builder.Entity<MatchSchedule>(math =>
            {
                math.HasKey(m => new { m.IdTeam, m.IdGame });
                math.HasOne(m => m.Team)
                    .WithMany(g => g.MatchSchedules)
                    .HasForeignKey(m => m.IdTeam);

                math.HasOne(m => m.Game)
                    .WithMany(r => r.MatchSchedules)
                    .HasForeignKey(m => m.IdGame);
            });
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
           
        }


    }
}
