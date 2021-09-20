using System.Collections.Generic;

namespace Torneo.App.Dominio
{
    public class Equipo
    {
        public int Id { get; set; }
        public string NombreEquipo { get; set; }
        public DirectorTecnico directorTecnico { get; set; }// le asigna el tecnico

        public System.Collections.Generic.List<Jugador> Jugadores { get; set; }
    }
}
