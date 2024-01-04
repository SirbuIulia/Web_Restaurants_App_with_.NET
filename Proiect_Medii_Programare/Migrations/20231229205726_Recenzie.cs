using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Medii_Programare.Migrations
{
    public partial class Recenzie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecenzieID",
                table: "Restaurant",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Recenzie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comentariu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzie", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_RecenzieID",
                table: "Restaurant",
                column: "RecenzieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_Recenzie_RecenzieID",
                table: "Restaurant",
                column: "RecenzieID",
                principalTable: "Recenzie",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_Recenzie_RecenzieID",
                table: "Restaurant");

            migrationBuilder.DropTable(
                name: "Recenzie");

            migrationBuilder.DropIndex(
                name: "IX_Restaurant_RecenzieID",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "RecenzieID",
                table: "Restaurant");
        }
    }
}
