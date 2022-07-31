using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementApplication.Migrations
{
    public partial class m04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_sectors_SectorCode",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_SectorCode",
                table: "students");

            migrationBuilder.DropColumn(
                name: "SectorCode",
                table: "students");

            migrationBuilder.AddColumn<string>(
                name: "CodeSector",
                table: "students",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_students_CodeSector",
                table: "students",
                column: "CodeSector");

            migrationBuilder.AddForeignKey(
                name: "FK_students_sectors_CodeSector",
                table: "students",
                column: "CodeSector",
                principalTable: "sectors",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_sectors_CodeSector",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_CodeSector",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CodeSector",
                table: "students");

            migrationBuilder.AddColumn<string>(
                name: "SectorCode",
                table: "students",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_SectorCode",
                table: "students",
                column: "SectorCode");

            migrationBuilder.AddForeignKey(
                name: "FK_students_sectors_SectorCode",
                table: "students",
                column: "SectorCode",
                principalTable: "sectors",
                principalColumn: "Code");
        }
    }
}
