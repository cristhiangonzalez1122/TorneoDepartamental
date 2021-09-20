using System;
using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Arbitro> Arbitros { get; set; }
        public DbSet<DirectorTecnico> DirectoresTecnicos { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Estadio> Estadios { get; set; }
        public DbSet<EstadisticaTorneo> EstadisticasTorneo { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<NovedadPartido> NovedadesPartido { get; set; }
        public DbSet<CrearPartido> CrearPartidos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.
                UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = TorneoDepartamental");

            }
        }

        
    }
}