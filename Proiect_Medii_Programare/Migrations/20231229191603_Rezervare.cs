using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Medii_Programare.Migrations
{
    public partial class Rezervare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RezervareID",
                table: "Restaurant",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rezervare",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumarPersoane = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervare", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_RezervareID",
                table: "Restaurant",
                column: "RezervareID");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_Rezervare_RezervareID",
                table: "Restaurant",
                column: "RezervareID",
                principalTable: "Rezervare",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_Rezervare_RezervareID",
                table: "Restaurant");

            migrationBuilder.DropTable(
                name: "Rezervare");

            migrationBuilder.DropIndex(
                name: "IX_Restaurant_RezervareID",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "RezervareID",
                table: "Restaurant");
        }
    }
}
