﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Torneo.App.Persistencia;

namespace Torneo.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Torneo.App.Dominio.Arbitro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ColegioArbitro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Arbitros");
                });

            modelBuilder.Entity("Torneo.App.Dominio.CrearPartido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EquipoLocalId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoVisitanteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPartido")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraPartido")
                        .HasColumnType("datetime2");

                    b.Property<int>("MarcadorLocal")
                        .HasColumnType("int");

                    b.Property<int>("MarcadorVisitante")
                        .HasColumnType("int");

                    b.Property<int?>("arbitroId")
                        .HasColumnType("int");

                    b.Property<int?>("estadioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoLocalId");

                    b.HasIndex("EquipoVisitanteId");

                    b.HasIndex("arbitroId");

                    b.HasIndex("estadioId");

                    b.ToTable("CrearPartidos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.DirectorTecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("DirectoresTecnicos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("NombreEquipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Estadios");
                });

            modelBuilder.Entity("Torneo.App.Dominio.EstadisticaTorneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("GolesEnContra")
                        .HasColumnType("int");

                    b.Property<int>("GolesFavor")
                        .HasColumnType("int");

                    b.Property<int>("PartidosEmpatados")
                        .HasColumnType("int");

                    b.Property<int>("PartidosGanados")
                        .HasColumnType("int");

                    b.Property<int>("PartidosJugados")
                        .HasColumnType("int");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("EstadisticasTorneo");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("NombreJugador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCamiseta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreMunicipio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("Torneo.App.Dominio.NovedadPartido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("Goles")
                        .HasColumnType("int");

                    b.Property<int?>("JugadorId")
                        .HasColumnType("int");

                    b.Property<string>("MinutoGol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Novedades")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartidoId")
                        .HasColumnType("int");

                    b.Property<int>("TarjetaAmarilla")
                        .HasColumnType("int");

                    b.Property<int>("TarjetaRoja")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.HasIndex("JugadorId");

                    b.HasIndex("PartidoId");

                    b.ToTable("NovedadesPartido");
                });

            modelBuilder.Entity("Torneo.App.Dominio.CrearPartido", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "EquipoLocal")
                        .WithMany()
                        .HasForeignKey("EquipoLocalId");

                    b.HasOne("Torneo.App.Dominio.Equipo", "EquipoVisitante")
                        .WithMany()
                        .HasForeignKey("EquipoVisitanteId");

                    b.HasOne("Torneo.App.Dominio.Arbitro", "arbitro")
                        .WithMany()
                        .HasForeignKey("arbitroId");

                    b.HasOne("Torneo.App.Dominio.Estadio", "estadio")
                        .WithMany()
                        .HasForeignKey("estadioId");

                    b.Navigation("arbitro");

                    b.Navigation("EquipoLocal");

                    b.Navigation("EquipoVisitante");

                    b.Navigation("estadio");
                });

            modelBuilder.Entity("Torneo.App.Dominio.DirectorTecnico", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Estadio", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Torneo.App.Dominio.EstadisticaTorneo", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Jugador", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("Torneo.App.Dominio.NovedadPartido", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId");

                    b.HasOne("Torneo.App.Dominio.Jugador", "Jugador")
                        .WithMany()
                        .HasForeignKey("JugadorId");

                    b.HasOne("Torneo.App.Dominio.CrearPartido", "Partido")
                        .WithMany("NovedadesDelPartido")
                        .HasForeignKey("PartidoId");

                    b.Navigation("Equipo");

                    b.Navigation("Jugador");

                    b.Navigation("Partido");
                });

            modelBuilder.Entity("Torneo.App.Dominio.CrearPartido", b =>
                {
                    b.Navigation("NovedadesDelPartido");
                });
#pragma warning restore 612, 618
        }
    }
}
