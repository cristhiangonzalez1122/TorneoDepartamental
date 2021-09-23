using System;

namespace Torneo.App.Dominio
{
    public class NovedadPartido
    {
        public int Id {get;set;}
        public int TarjetaRoja { get; set; }
        public int TarjetaAmarilla { get; set; }
        public int Goles { get; set; }
        public string MinutoGol {get;set;}
        public string Novedades {get;set;}
        public CrearPartido Partido { get; set;}
        public Equipo Equipo{ get; set;} //Para saber el jugador del equipo
        public Jugador Jugador{ get; set;}
        
    }
}