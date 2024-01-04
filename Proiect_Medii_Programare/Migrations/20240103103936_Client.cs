using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Medii_Programare.Migrations
{
    public partial class Client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_Recenzie_RecenzieID",
                table: "Restaurant");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_Rezervare_RezervareID",
                table: "Restaurant");

            migrationBuilder.DropIndex(
                name: "IX_Restaurant_RecenzieID",
                table: "Restaurant");

            migrationBuilder.DropIndex(
                name: "IX_Restaurant_RezervareID",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "RecenzieID",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "RezervareID",
                table: "Restaurant");

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Rezervare",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantID",
                table: "Rezervare",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Recenzie",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantID",
                table: "Recenzie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prenume = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NumeFamilie = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    NrTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervare_ClientID",
                table: "Rezervare",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervare_RestaurantID",
                table: "Rezervare",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzie_ClientID",
                table: "Recenzie",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzie_RestaurantID",
                table: "Recenzie",
                column: "RestaurantID");

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzie_Client_ClientID",
                table: "Recenzie",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzie_Restaurant_RestaurantID",
                table: "Recenzie",
                column: "RestaurantID",
                principalTable: "Restaurant",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervare_Client_ClientID",
                table: "Rezervare",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervare_Restaurant_RestaurantID",
                table: "Rezervare",
                column: "RestaurantID",
                principalTable: "Restaurant",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recenzie_Client_ClientID",
                table: "Recenzie");

            migrationBuilder.DropForeignKey(
                name: "FK_Recenzie_Restaurant_RestaurantID",
                table: "Recenzie");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervare_Client_ClientID",
                table: "Rezervare");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervare_Restaurant_RestaurantID",
                table: "Rezervare");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Rezervare_ClientID",
                table: "Rezervare");

            migrationBuilder.DropIndex(
                name: "IX_Rezervare_RestaurantID",
                table: "Rezervare");

            migrationBuilder.DropIndex(
                name: "IX_Recenzie_ClientID",
                table: "Recenzie");

            migrationBuilder.DropIndex(
                name: "IX_Recenzie_RestaurantID",
                table: "Recenzie");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Rezervare");

            migrationBuilder.DropColumn(
                name: "RestaurantID",
                table: "Rezervare");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Recenzie");

            migrationBuilder.DropColumn(
                name: "RestaurantID",
                table: "Recenzie");

            migrationBuilder.AddColumn<int>(
                name: "RecenzieID",
                table: "Restaurant",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RezervareID",
                table: "Restaurant",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_RecenzieID",
                table: "Restaurant",
                column: "RecenzieID");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_RezervareID",
                table: "Restaurant",
                column: "RezervareID");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_Recenzie_RecenzieID",
                table: "Restaurant",
                column: "RecenzieID",
                principalTable: "Recenzie",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_Rezervare_RezervareID",
                table: "Restaurant",
                column: "RezervareID",
                principalTable: "Rezervare",
                principalColumn: "ID");
        }
    }
}
