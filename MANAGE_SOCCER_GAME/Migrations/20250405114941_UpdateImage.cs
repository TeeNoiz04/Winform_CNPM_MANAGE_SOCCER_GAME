using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MANAGE_SOCCER_GAME.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "publicId",
                table: "ImageTeams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "publicId",
                table: "ImagePlayers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "publicId",
                table: "ImageCoachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "publicId",
                table: "ImageTeams");

            migrationBuilder.DropColumn(
                name: "publicId",
                table: "ImagePlayers");

            migrationBuilder.DropColumn(
                name: "publicId",
                table: "ImageCoachers");
        }
    }
}
