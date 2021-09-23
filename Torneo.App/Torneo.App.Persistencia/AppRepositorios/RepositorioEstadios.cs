using System.Collections.Generic;
using Torneo.App.Dominio;
using System.Linq;


namespace Torneo.App.Persistencia
{
    public class RepositorioEstadios : IRepositorioEstadio
    {
        private readonly AppContext _appContext;
        public RepositorioEstadios(AppContext appContext)
        {
            _appContext = appContext;
        }

        Estadio IRepositorioEstadio.AddEsstadio(Estadio estadio)
        {
            var estadioAdicionado = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity;
        }

        void IRepositorioEstadio.DeleteEstadio(int idEstadio)
        {
            var estadioEncontrado = _appContext.Estadios.Find(idEstadio);
            if(estadioEncontrado == null)
            return;
            _appContext.Estadios.Remove(estadioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Estadio> IRepositorioEstadio.GetAllEstadios()
        {
            return _appContext.Estadios;
        }

        Estadio IRepositorioEstadio.GetEstadio(int idEstadio)
        {
           return _appContext.Estadios.Find(idEstadio);
        }

        Estadio IRepositorioEstadio.UpdateEstadio(Estadio estadio)
        {
            var estadioEncontrado = _appContext.Estadios.FirstOrDefault(e => e.Id == estadio.Id);
            if(estadioEncontrado != null)
            {
                estadioEncontrado.Nombre = estadio.Nombre;
                estadioEncontrado.Direccion = estadio.Direccion;

                _appContext.SaveChanges();
            }
            return estadioEncontrado;
        }
    }
}