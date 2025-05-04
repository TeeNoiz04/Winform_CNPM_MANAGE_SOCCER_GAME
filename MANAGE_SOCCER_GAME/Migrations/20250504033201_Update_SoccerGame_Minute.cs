using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MANAGE_SOCCER_GAME.Migrations
{
    /// <inheritdoc />
    public partial class Update_SoccerGame_Minute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "SoccerGames");

            migrationBuilder.AddColumn<int>(
                name: "Minute",
                table: "SoccerGames",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Minute",
                table: "SoccerGames");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "SoccerGames",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0));
        }

    }
}
