using System;

namespace Torneo.App.Dominio
{
    public class CrearPartido
    {
        public int Id { get; set; }
        public Estadio estadio { get; set; }
        public DateTime FechaPartido { get; set; }
        public DateTime HoraPartido { get; set; }
        public Equipo EquipoLocal { get; set; }
        public int MarcadorLocal { get; set; }
        public Equipo EquipoVisitante { get; set; }
        public int MarcadorVisitante { get; set; }
        public Arbitro arbitro { get; set; }

    }
}