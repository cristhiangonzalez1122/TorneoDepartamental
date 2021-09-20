using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Torneo.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arbitros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColegioArbitro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectoresTecnicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoresTecnicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstadio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEquipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    directorTecnicoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_DirectoresTecnicos_directorTecnicoId",
                        column: x => x.directorTecnicoId,
                        principalTable: "DirectoresTecnicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreJugador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroCamiseta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipoPerteneceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_EquipoPerteneceId",
                        column: x => x.EquipoPerteneceId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equipoId = table.Column<int>(type: "int", nullable: true),
                    estadiosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipios_Equipos_equipoId",
                        column: x => x.equipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Municipios_Estadios_estadiosId",
                        column: x => x.estadiosId,
                        principalTable: "Estadios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrearPartidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estadioId = table.Column<int>(type: "int", nullable: true),
                    FechaPartido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraPartido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipoLocalId = table.Column<int>(type: "int", nullable: true),
                    MarcadorLocal = table.Column<int>(type: "int", nullable: false),
                    EquipoVisitanteId = table.Column<int>(type: "int", nullable: true),
                    MarcadorVisitante = table.Column<int>(type: "int", nullable: false),
                    arbitroId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartidosJugados = table.Column<int>(type: "int", nullable: true),
                    PartidosGanados = table.Column<int>(type: "int", nullable: true),
                    PartidosEmpatados = table.Column<int>(type: "int", nullable: true),
                    GolesFavor = table.Column<int>(type: "int", nullable: true),
                    GolesEnContra = table.Column<int>(type: "int", nullable: true),
                    Puntos = table.Column<int>(type: "int", nullable: true),
                    TarjetaRoja = table.Column<int>(type: "int", nullable: true),
                    TarjetaAmarilla = table.Column<int>(type: "int", nullable: true),
                    Goles = table.Column<int>(type: "int", nullable: true),
                    Novedades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinutoGol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JugadorGolId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrearPartidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrearPartidos_Arbitros_arbitroId",
                        column: x => x.arbitroId,
                        principalTable: "Arbitros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrearPartidos_Equipos_EquipoLocalId",
                        column: x => x.EquipoLocalId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrearPartidos_Equipos_EquipoVisitanteId",
                        column: x => x.EquipoVisitanteId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrearPartidos_Estadios_estadioId",
                        column: x => x.estadioId,
                        principalTable: "Estadios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CrearPartidos_Jugadores_JugadorGolId",
                        column: x => x.JugadorGolId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CrearPartidos_arbitroId",
                table: "CrearPartidos",
                column: "arbitroId");

            migrationBuilder.CreateIndex(
                name: "IX_CrearPartidos_EquipoLocalId",
                table: "CrearPartidos",
                column: "EquipoLocalId");

            migrationBuilder.CreateIndex(
                name: "IX_CrearPartidos_EquipoVisitanteId",
                table: "CrearPartidos",
                column: "EquipoVisitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_CrearPartidos_estadioId",
                table: "CrearPartidos",
                column: "estadioId");

            migrationBuilder.CreateIndex(
                name: "IX_CrearPartidos_JugadorGolId",
                table: "CrearPartidos",
                column: "JugadorGolId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_directorTecnicoId",
                table: "Equipos",
                column: "directorTecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_EquipoPerteneceId",
                table: "Jugadores",
                column: "EquipoPerteneceId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_equipoId",
                table: "Municipios",
                column: "equipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_estadiosId",
                table: "Municipios",
                column: "estadiosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrearPartidos");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Arbitros");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "DirectoresTecnicos");
        }
    }
}
