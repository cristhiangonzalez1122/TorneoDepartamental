using System;

namespace Torneo.App.Dominio
{
    public class NovedadPartido : CrearPartido
    {
        public int TarjetaRoja { get; set; }
        public int TarjetaAmarilla { get; set; }
        public int Goles { get; set; }
        public string Novedades {get;set;}
        public string MinutoGol {get;set;}
        public Jugador JugadorGol {get;set;}

    }
}