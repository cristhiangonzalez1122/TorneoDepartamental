using System;

namespace Torneo.App.Dominio
{
    public class EstadisticaTorneo : CrearPartido
    {
        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosEmpatados { get; set; }
        public int GolesFavor { get; set; }
        public int GolesEnContra { get; set; }
        public int Puntos { get; set; }
    }
}