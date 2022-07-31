using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementApplication.Migrations
{
    public partial class MG01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sectors",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectors", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    CodeSector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectorCode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.Code);
                    table.ForeignKey(
                        name: "FK_modules_sectors_SectorCode",
                        column: x => x.SectorCode,
                        principalTable: "sectors",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CodeSector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectorCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_students_sectors_SectorCode",
                        column: x => x.SectorCode,
                        principalTable: "sectors",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateIndex(
                name: "IX_modules_SectorCode",
                table: "modules",
                column: "SectorCode");

            migrationBuilder.CreateIndex(
                name: "IX_students_SectorCode",
                table: "students",
                column: "SectorCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "sectors");
        }
    }
}
