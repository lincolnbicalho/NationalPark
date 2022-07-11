using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalPark.Migrations
{
    public partial class ThirdTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    StartedOn = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false),
                    IsOpen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
