using System.Collections.Generic;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia
{
    public interface IRepositorioEquipos
    {
        IEnumerable<Equipo> GetallEquipos();
        Equipo AddEquipo(Equipo equipo);
        Equipo UpdateEquipo(Equipo equipo);
        void DeleteEquipo(int idEquipo);
        Equipo GetEquipo(int idEquipo);
    }
}