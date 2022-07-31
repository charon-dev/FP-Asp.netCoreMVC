using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementApplication.Migrations
{
    public partial class M02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeSector",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CodeSector",
                table: "modules");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodeSector",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CodeSector",
                table: "modules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
