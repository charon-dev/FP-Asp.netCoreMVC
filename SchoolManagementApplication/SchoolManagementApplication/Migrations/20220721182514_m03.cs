using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementApplication.Migrations
{
    public partial class m03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_modules_sectors_SectorCode",
                table: "modules");

            migrationBuilder.RenameColumn(
                name: "SectorCode",
                table: "modules",
                newName: "CodeSector");

            migrationBuilder.RenameIndex(
                name: "IX_modules_SectorCode",
                table: "modules",
                newName: "IX_modules_CodeSector");

            migrationBuilder.AddForeignKey(
                name: "FK_modules_sectors_CodeSector",
                table: "modules",
                column: "CodeSector",
                principalTable: "sectors",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_modules_sectors_CodeSector",
                table: "modules");

            migrationBuilder.RenameColumn(
                name: "CodeSector",
                table: "modules",
                newName: "SectorCode");

            migrationBuilder.RenameIndex(
                name: "IX_modules_CodeSector",
                table: "modules",
                newName: "IX_modules_SectorCode");

            migrationBuilder.AddForeignKey(
                name: "FK_modules_sectors_SectorCode",
                table: "modules",
                column: "SectorCode",
                principalTable: "sectors",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
