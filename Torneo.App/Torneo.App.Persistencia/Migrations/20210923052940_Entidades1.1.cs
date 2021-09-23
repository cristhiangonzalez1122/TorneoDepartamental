using Microsoft.EntityFrameworkCore.Migrations;

namespace Torneo.App.Persistencia.Migrations
{
    public partial class Entidades11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreEstadio",
                table: "Estadios",
                newName: "Nombre");

            migrationBuilder.AddColumn<int>(
                name: "MunicipioId",
                table: "Estadios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_MunicipioId",
                table: "Estadios",
                column: "MunicipioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estadios_Municipios_MunicipioId",
                table: "Estadios",
                column: "MunicipioId",
                principalTable: "Municipios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estadios_Municipios_MunicipioId",
                table: "Estadios");

            migrationBuilder.DropIndex(
                name: "IX_Estadios_MunicipioId",
                table: "Estadios");

            migrationBuilder.DropColumn(
                name: "MunicipioId",
                table: "Estadios");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Estadios",
                newName: "NombreEstadio");
        }
    }
}
