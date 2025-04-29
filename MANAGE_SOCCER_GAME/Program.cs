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

            services.AddScoped<MainForm>();
            services.AddScoped<AddTeamForm>();
            services.AddScoped<AddPlayerForm>();
            services.AddScoped<TeamListForm>();
            services.AddScoped<PlayerDetailForm>();
            services.AddScoped<TeamDetailForm>();
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


            services.AddScoped<Func<TournamentService, CoachService, AddTeamForm>>(
              serviceProvider => (t, c) =>
                  new AddTeamForm(t, c)
            );


            // Tạo service provider
            AppService.ServiceProvider = services.BuildServiceProvider();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Add other services to the container as needed


            Application.Run(AppService.ServiceProvider.GetRequiredService<MainForm>());
            //Application.Run(new TestTournamentForm(context));
        }
    }
}