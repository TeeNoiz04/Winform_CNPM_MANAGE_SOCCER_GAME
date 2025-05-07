using System;
using MANAGE_SOCCER_GAME.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ManageSoccerGame>
{
    public ManageSoccerGame CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ManageSoccerGame>();
        optionsBuilder.UseSqlServer("Data Source=ELYSIA\\SQLEXPRESS;Initial Catalog=Manage_soccer_game;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

        return new ManageSoccerGame(optionsBuilder.Options);
    }
}
