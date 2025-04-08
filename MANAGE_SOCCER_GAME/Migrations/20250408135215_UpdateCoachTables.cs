﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MANAGE_SOCCER_GAME.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCoachTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Coaches",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Coaches");
        }
    }
}
