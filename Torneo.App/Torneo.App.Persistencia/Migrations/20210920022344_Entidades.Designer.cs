// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Torneo.App.Persistencia;

namespace Torneo.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210920022344_Entidades")]
    partial class Entidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("CrearPartido");
                });

            modelBuilder.Entity("Torneo.App.Dominio.DirectorTecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DirectoresTecnicos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreEquipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("directorTecnicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("directorTecnicoId");

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

                    b.Property<string>("NombreEstadio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estadios");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EquipoPerteneceId")
                        .HasColumnType("int");

                    b.Property<string>("NombreJugador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCamiseta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoPerteneceId");

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

                    b.Property<int?>("equipoId")
                        .HasColumnType("int");

                    b.Property<int?>("estadiosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("equipoId");

                    b.HasIndex("estadiosId");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("Torneo.App.Dominio.EstadisticaTorneo", b =>
                {
                    b.HasBaseType("Torneo.App.Dominio.CrearPartido");

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

                    b.HasDiscriminator().HasValue("EstadisticaTorneo");
                });

            modelBuilder.Entity("Torneo.App.Dominio.NovedadPartido", b =>
                {
                    b.HasBaseType("Torneo.App.Dominio.CrearPartido");

                    b.Property<int>("Goles")
                        .HasColumnType("int");

                    b.Property<int?>("JugadorGolId")
                        .HasColumnType("int");

                    b.Property<string>("MinutoGol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Novedades")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TarjetaAmarilla")
                        .HasColumnType("int");

                    b.Property<int>("TarjetaRoja")
                        .HasColumnType("int");

                    b.HasIndex("JugadorGolId");

                    b.HasDiscriminator().HasValue("NovedadPartido");
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

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.HasOne("Torneo.App.Dominio.DirectorTecnico", "directorTecnico")
                        .WithMany()
                        .HasForeignKey("directorTecnicoId");

                    b.Navigation("directorTecnico");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Jugador", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "EquipoPertenece")
                        .WithMany("Jugadores")
                        .HasForeignKey("EquipoPerteneceId");

                    b.Navigation("EquipoPertenece");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Municipio", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "equipo")
                        .WithMany()
                        .HasForeignKey("equipoId");

                    b.HasOne("Torneo.App.Dominio.Estadio", "estadios")
                        .WithMany()
                        .HasForeignKey("estadiosId");

                    b.Navigation("equipo");

                    b.Navigation("estadios");
                });

            modelBuilder.Entity("Torneo.App.Dominio.NovedadPartido", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Jugador", "JugadorGol")
                        .WithMany()
                        .HasForeignKey("JugadorGolId");

                    b.Navigation("JugadorGol");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.Navigation("Jugadores");
                });
#pragma warning restore 612, 618
        }
    }
}
