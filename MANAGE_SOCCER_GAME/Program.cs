using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.HdDungCloudinary;
using MANAGE_SOCCER_GAME.Services;
using MANAGE_SOCCER_GAME.Views;
using MANAGE_SOCCER_GAME.Views.Arbitration_Management_Organizers;
using MANAGE_SOCCER_GAME.Views.Manage_Results_Rankings;
using MANAGE_SOCCER_GAME.Views.Management_Team_Players;
using MANAGE_SOCCER_GAME.Views.Schedule_Management;
using MANAGE_SOCCER_GAME.Views.SignInSignUp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MANAGE_SOCCER_GAME
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ManageSoccerGame>(options =>
             options.UseSqlServer("Data Source=;Initial Catalog=Manage_soccer_game;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"));

            services.AddScoped<TournamentService>();
            services.AddScoped<CoachService>();
            services.AddScoped<TeamService>();
            services.AddScoped<PlayerService>();
            services.AddScoped<UserService>();
            services.AddScoped<GameService>();
            services.AddScoped<CloudService>();
            services.AddScoped<ImagePlayerService>();
            services.AddScoped<ImageCoacherService>();
            services.AddScoped<ImageTeamService>();
            services.AddScoped<RefereeService>();
            services.AddScoped<RoundService>();
            services.AddScoped<SoccerGameService>();
            services.AddScoped<MatchOfficialService>();

            services.AddScoped<MainForm>();
            services.AddScoped<TeamListForm>();
            services.AddScoped<TeamDetailForm>();
            services.AddScoped<AddTeamForm>();
            services.AddScoped<PlayerDetailForm>();
            services.AddScoped<AddPlayerForm>();
            services.AddScoped<SignInForm>();
            services.AddScoped<SignUpForm>();
            services.AddScoped<HomeForm>();
            services.AddScoped<MatchScheduleForm>();
            services.AddScoped<RankingForm>();
            services.AddScoped<EmployeeListForm>();
            services.AddScoped<RefereeListForm>();
            services.AddScoped<SidebarAMOForm>();
            services.AddScoped<AssignRefereeForm>();
            services.AddScoped<PlayerStatsForm>();
            services.AddScoped<ManagersForm>();
            services.AddScoped<ForgotPasswordForm>();
            services.AddScoped<MatchDetailForm>();
            services.AddScoped<TourmentForm>();
            services.AddScoped<MatchResultForm>();
            services.AddScoped<AddRefereeForm>();
            services.AddScoped<EditRefereeForm>();
            services.AddScoped<SignUpManuallyForm>();
            services.AddScoped<AddManagerForm>();
            services.AddScoped<AddRoundForm>();
            services.AddScoped<AddScheduleForm>();
            services.AddScoped<UpdateResultForm>();
            services.AddScoped<AddTourmentForm>();
            services.AddScoped<AddAssignReferee>();
            services.AddScoped<TestTournamentForm>();

            services.AddScoped<Func<TeamService, PlayerService, Guid, TeamDetailForm>>(
              serviceProvider => (t, p, i) =>
                  new TeamDetailForm(t, p, i)
            );

            services.AddScoped<Func<PlayerService, CloudService, ImagePlayerService, Guid, AddPlayerForm>>(
            serviceProvider => (p, c, im, i) =>
                new AddPlayerForm(p, c, im, i)
            );

            services.AddScoped<Func<TournamentService, TeamService, CoachService, CloudService, ImageTeamService, Guid, EditTeamForm>>(
              serviceProvider => (t, te, c, cl, im, i) =>
                  new EditTeamForm(t, te, c, cl, im, i)
            );

            services.AddScoped<Func<PlayerService, Guid, PlayerDetailForm>>(
              serviceProvider => (p, i) =>
                  new PlayerDetailForm(p, i)
            );

            services.AddScoped<Func<PlayerService, CloudService, ImagePlayerService, Guid, EditPlayerForm>>(
             serviceProvider => (p, c, im, i) =>
                 new EditPlayerForm(p, c, im, i)
            );


            services.AddScoped<Func<RefereeService, Guid, EditRefereeForm>>(
             serviceProvider => (r, g) =>
                 new EditRefereeForm(r, g)
            );

            services.AddScoped<Func<GameService, Guid, MatchDetailForm>>(
             serviceProvider => (r, g) =>
                 new MatchDetailForm(r, g)
            );

            services.AddScoped<Func<RoundService, TeamService, GameService, Guid, EditScheduleForm>>(
             serviceProvider => (r, t, g, id) =>
                 new EditScheduleForm(r, t, g, id)
            );

            services.AddScoped<Func<PlayerService, TeamService, SoccerGameService, Guid, UpdateResultForm>>(
             serviceProvider => (p, t, s, id) =>
                 new UpdateResultForm(p, t, s, id)
            );

            services.AddScoped<Func<PlayerService, TeamService, SoccerGameService, Guid, EditResultForm>>(
            serviceProvider => (p, t, s, id) =>
                new EditResultForm(p, t, s, id)
           );

            // Tạo service provider
            AppService.ServiceProvider = services.BuildServiceProvider();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Add other services to the container as needed


            Application.Run(AppService.ServiceProvider.GetRequiredService<MainForm>());
        }
    }
}