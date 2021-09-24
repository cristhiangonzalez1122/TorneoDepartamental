using System.Collections.Generic;
using System.Linq;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly AppContext _appContext;
        public RepositorioDirectorTecnico(AppContext appContext)
        {
            _appContext = appContext;
        }

        DirectorTecnico IRepositorioDirectorTecnico.AddDirectorTecnico(DirectorTecnico directorTecnico)
        {
            var DirectorAdicionado = _appContext.DirectoresTecnicos.Add(directorTecnico);
            _appContext.SaveChanges();
            return DirectorAdicionado.Entity;
        }

        DirectorTecnico IRepositorioDirectorTecnico.AsignarEquipo(int idDirectorTecnico, int idEquipo)
        {
            var directorEncontrado = _appContext.DirectoresTecnicos.FirstOrDefault(d => d.Id == idDirectorTecnico);
            if (directorEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.FirstOrDefault(e => e.Id == idEquipo);
                if (equipoEncontrado != null)
                {
                    directorEncontrado.Equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return directorEncontrado;
            }
            return null;
        }

        void IRepositorioDirectorTecnico.DeleteDirectorTecnico(int idDirectorTecnico)
        {
            var directorEncontrado = _appContext.DirectoresTecnicos.Find(idDirectorTecnico);
            if(directorEncontrado == null)
            return;
            _appContext.DirectoresTecnicos.Remove(directorEncontrado);
            _appContext.SaveChanges();
            
        }

        IEnumerable<DirectorTecnico> IRepositorioDirectorTecnico.GetAllDirectorTecnico()
        {
            return _appContext.DirectoresTecnicos;
        }

        DirectorTecnico IRepositorioDirectorTecnico.GetDirectorTecnico(int idDirectorTecnico)
        {
            return _appContext.DirectoresTecnicos.Find(idDirectorTecnico);
        }

        DirectorTecnico IRepositorioDirectorTecnico.UpdateDirectorTecnico(DirectorTecnico directorTecnico)
        {
             var directorEncontrado = _appContext.DirectoresTecnicos.FirstOrDefault(d => d.Id == directorTecnico.Id);
             if(directorEncontrado != null)
             {
                 directorEncontrado.Nombre = directorTecnico.Nombre;
                 directorEncontrado.Documento = directorTecnico.Documento;
                 directorEncontrado.Telefono = directorTecnico.Telefono;
                 directorEncontrado.Equipo = directorTecnico.Equipo;

                 _appContext.SaveChanges();
             }
             return directorEncontrado;
        }
    }
}