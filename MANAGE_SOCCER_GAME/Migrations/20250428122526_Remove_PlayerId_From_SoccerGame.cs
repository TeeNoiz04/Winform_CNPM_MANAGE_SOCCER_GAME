using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MANAGE_SOCCER_GAME.Migrations
{
    /// <inheritdoc />
    public partial class Remove_PlayerId_From_SoccerGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
       name: "FK_SoccerGames_Players_PlayerId",  // nếu có FK cũ
       table: "SoccerGames");

            migrationBuilder.DropIndex(
                name: "IX_SoccerGames_PlayerId",         // nếu có Index cũ
                table: "SoccerGames");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "SoccerGames");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
       name: "PlayerId",
       table: "SoccerGames",
       type: "uniqueidentifier",
       nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SoccerGames_PlayerId",
                table: "SoccerGames",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SoccerGames_Players_PlayerId",
                table: "SoccerGames",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }
    }
}
