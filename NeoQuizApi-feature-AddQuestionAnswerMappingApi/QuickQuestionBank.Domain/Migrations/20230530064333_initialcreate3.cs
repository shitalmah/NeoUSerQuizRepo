using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuickQuestionBank.Domain.Migrations
{
    public partial class initialcreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "user_Admin");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "user_Admin");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "user_Admin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "user_Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "user_Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "user_Admin",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
