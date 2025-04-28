using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MANAGE_SOCCER_GAME.Migrations
{
    /// <inheritdoc />
    public partial class Remove_TeamId_TeamId1_In_Games : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
        name: "FK_Games_Teams_TeamId",
        table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Teams_TeamId1",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_TeamId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_TeamId1",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "TeamId1",
                table: "Games");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
        name: "TeamId",
        table: "Games",
        type: "uniqueidentifier",
        nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TeamId1",
                table: "Games",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_TeamId",
                table: "Games",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_TeamId1",
                table: "Games",
                column: "TeamId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Teams_TeamId",
                table: "Games",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Teams_TeamId1",
                table: "Games",
                column: "TeamId1",
                principalTable: "Teams",
                principalColumn: "Id");
        }
    }
}
