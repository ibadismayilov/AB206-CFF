﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makan.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddIsLoginToUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLogin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLogin",
                table: "Users");
        }
    }
}
