using Microsoft.EntityFrameworkCore.Migrations;

namespace Torneo.App.Persistencia.Migrations
{
    public partial class Entidades2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrearPartidos_Jugadores_JugadorGolId",
                table: "CrearPartidos");

            migrationBuilder.RenameColumn(
                name: "JugadorGolId",
                table: "CrearPartidos",
                newName: "JugadorId");

            migrationBuilder.RenameIndex(
                name: "IX_CrearPartidos_JugadorGolId",
                table: "CrearPartidos",
                newName: "IX_CrearPartidos_JugadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CrearPartidos_Jugadores_JugadorId",
                table: "CrearPartidos",
                column: "JugadorId",
                principalTable: "Jugadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrearPartidos_Jugadores_JugadorId",
                table: "CrearPartidos");

            migrationBuilder.RenameColumn(
                name: "JugadorId",
                table: "CrearPartidos",
                newName: "JugadorGolId");

            migrationBuilder.RenameIndex(
                name: "IX_CrearPartidos_JugadorId",
                table: "CrearPartidos",
                newName: "IX_CrearPartidos_JugadorGolId");

            migrationBuilder.AddForeignKey(
                name: "FK_CrearPartidos_Jugadores_JugadorGolId",
                table: "CrearPartidos",
                column: "JugadorGolId",
                principalTable: "Jugadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
