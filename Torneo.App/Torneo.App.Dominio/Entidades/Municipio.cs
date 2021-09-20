namespace Torneo.App.Dominio
{
    public class Municipio
    {
        public int Id { get; set; }
        public string NombreMunicipio { get; set; }
        public Equipo equipo { get; set; }
        public Estadio estadios { get; set; }
    }
}