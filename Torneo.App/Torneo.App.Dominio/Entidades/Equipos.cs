using System.Collections.Generic;

namespace Torneo.App.Dominio
{
    public class Equipo
    {
        public int Id { get; set; }
        public string NombreEquipo { get; set; }
        public Municipio Municipio {get;set;}
        
}
}
