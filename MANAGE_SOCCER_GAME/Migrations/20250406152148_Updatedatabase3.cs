using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MANAGE_SOCCER_GAME.Migrations
{
    /// <inheritdoc />
    public partial class Updatedatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Isdeleted",
                table: "Tournaments",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Isdeleted",
                table: "Teams",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Isdeleted",
                table: "Players",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Isdeleted",
                table: "MatchSchedules",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "publicId",
                table: "ImageTeams",
                newName: "PublicId");

            migrationBuilder.RenameColumn(
                name: "publicId",
                table: "ImagePlayers",
                newName: "PublicId");

            migrationBuilder.RenameColumn(
                name: "publicId",
                table: "ImageCoachers",
                newName: "PublicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Tournaments",
                newName: "Isdeleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Teams",
                newName: "Isdeleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Players",
                newName: "Isdeleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "MatchSchedules",
                newName: "Isdeleted");

            migrationBuilder.RenameColumn(
                name: "PublicId",
                table: "ImageTeams",
                newName: "publicId");

            migrationBuilder.RenameColumn(
                name: "PublicId",
                table: "ImagePlayers",
                newName: "publicId");

            migrationBuilder.RenameColumn(
                name: "PublicId",
                table: "ImageCoachers",
                newName: "publicId");
        }
    }
}
