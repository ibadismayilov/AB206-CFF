using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makan.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveConfirmPasswordFromUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConfirmPassword",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
