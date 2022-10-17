using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DashBoardAPI.Migrations
{
    public partial class CreateCaseDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateRep = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CountryExp = table.Column<string>(type: "TEXT", nullable: true),
                    ConfCases = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cases");
        }
    }
}
