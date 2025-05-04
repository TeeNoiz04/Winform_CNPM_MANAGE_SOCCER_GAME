using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MANAGE_SOCCER_GAME.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStatusProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Minute",
                table: "SoccerGames",
                newName: "Minute");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Games",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "Minute",
                table: "SoccerGames",
                newName: "Minutes");
        }
    }
}
