using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MANAGE_SOCCER_GAME.Migrations
{
    /// <inheritdoc />
    public partial class Adjust_SoccerGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoccerGames_Players_GoalScorerId",
                table: "SoccerGames");

            migrationBuilder.AddColumn<Guid>(
                name: "AssitantId",
                table: "SoccerGames",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PlayerId",
                table: "SoccerGames",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SoccerGames_AssitantId",
                table: "SoccerGames",
                column: "AssitantId");

            migrationBuilder.CreateIndex(
                name: "IX_SoccerGames_PlayerId",
                table: "SoccerGames",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SoccerGames_Players_AssitantId",
                table: "SoccerGames",
                column: "AssitantId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SoccerGames_Players_GoalScorerId",
                table: "SoccerGames",
                column: "GoalScorerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SoccerGames_Players_PlayerId",
                table: "SoccerGames",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoccerGames_Players_AssitantId",
                table: "SoccerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_SoccerGames_Players_GoalScorerId",
                table: "SoccerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_SoccerGames_Players_PlayerId",
                table: "SoccerGames");

            migrationBuilder.DropIndex(
                name: "IX_SoccerGames_AssitantId",
                table: "SoccerGames");

            migrationBuilder.DropIndex(
                name: "IX_SoccerGames_PlayerId",
                table: "SoccerGames");

            migrationBuilder.DropColumn(
                name: "AssitantId",
                table: "SoccerGames");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "SoccerGames");

            migrationBuilder.AddForeignKey(
                name: "FK_SoccerGames_Players_GoalScorerId",
                table: "SoccerGames",
                column: "GoalScorerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
