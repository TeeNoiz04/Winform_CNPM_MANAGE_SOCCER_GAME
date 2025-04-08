using MANAGE_SOCCER_GAME.Data;
using MANAGE_SOCCER_GAME.HdDungCloudinary;
using MANAGE_SOCCER_GAME.Views;
using Microsoft.EntityFrameworkCore;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var option = new DbContextOptionsBuilder<ManageSoccerGame>()
                        .UseSqlServer("Data Source=TEENOIZ04;Initial Catalog=Manage_soccer_game;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            var context = new ManageSoccerGame(option.Options);


            Application.Run(new MainForm());
            //Application.Run(new TestTournamentForm(context));
        }
    }
}