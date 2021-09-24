using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioEquipos : IRepositorioEquipos
    {
         private readonly AppContext _appContext;
        public RepositorioEquipos(AppContext appContext)
        {
            _appContext = appContext;
        }

        Equipo IRepositorioEquipos.AddEquipo(Equipo equipo)
        {
            var equipoAdicionado =_appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity;
        }

        void IRepositorioEquipos.DeleteEquipo(int idEquipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if(equipoEncontrado != null)
            return;
            _appContext.Remove(equipoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Equipo> IRepositorioEquipos.GetallEquipos()
        {
            return _appContext.Equipos;
        }

        Equipo IRepositorioEquipos.GetEquipo(int idEquipo)
        {
            return _appContext.Equipos.Find(idEquipo);
        }

        Equipo IRepositorioEquipos.UpdateEquipo(Equipo equipo)
        {
            var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == equipo.Id);
            if(equipoEncontrado != null)
            {
                equipoEncontrado.NombreEquipo = equipo.NombreEquipo;
                equipoEncontrado.Municipio = equipo.Municipio;
                
                _appContext.SaveChanges();
            }
            return equipoEncontrado;

        }
    }
}