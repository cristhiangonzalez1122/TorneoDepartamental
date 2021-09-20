using System;
namespace Torneo.App.Dominio
{
    public class Jugador
    {
        public int Id { get; set; }
        public string NombreJugador { get; set; }
        public string NumeroCamiseta { get; set; }
        public string Posicion { get; set; }
        public Equipo EquipoPertenece {get;set;}
    }
}