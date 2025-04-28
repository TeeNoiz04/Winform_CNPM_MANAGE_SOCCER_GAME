using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MANAGE_SOCCER_GAME.Migrations
{
    /// <inheritdoc />
    public partial class Update_SoccerGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberAssitant",
                table: "SoccerGames");

            migrationBuilder.AlterColumn<Guid>(
                name: "AssitantId",
                table: "SoccerGames",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "AssitantId",
                table: "SoccerGames",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberAssitant",
                table: "SoccerGames",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
