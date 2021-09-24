using System.Collections.Generic;
using System.Linq;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia
{
    public class RepositorioPartidos : IRepositorioPartidos
    {
        private readonly AppContext _appContext = new AppContext();
        public RepositorioPartidos(AppContext appContext)
        {
            appContext = _appContext;
        }

        CrearPartido IRepositorioPartidos.AddPartidos(CrearPartido partido)
        {
             var partidoAdicionado = _appContext.CrearPartidos.Add(partido);
            _appContext.SaveChanges();
            return partidoAdicionado.Entity;
        }

        void IRepositorioPartidos.DeletePartidos(int idCrearPartido)
        {
            var partidoEncontrado = _appContext.CrearPartidos.Find(idCrearPartido);
            if (partidoEncontrado == null)
                return;
            _appContext.CrearPartidos.Remove(partidoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<CrearPartido> IRepositorioPartidos.GetAllPartidos()
        {
            return _appContext.CrearPartidos;
        }

        CrearPartido IRepositorioPartidos.GetPartido(int idCrearPartido)
        {
            return _appContext.CrearPartidos.Find(idCrearPartido);
        }

        CrearPartido IRepositorioPartidos.UpdatePartidos(CrearPartido partido)
        {
            var partidoEncontrado = _appContext.CrearPartidos.FirstOrDefault(c => c.Id == partido.Id);
            if(partidoEncontrado != null)
            {
                partidoEncontrado.estadio = partido.estadio;
                partidoEncontrado.FechaPartido = partido.FechaPartido;
                partidoEncontrado.HoraPartido = partido.HoraPartido;
                partidoEncontrado.EquipoLocal = partido.EquipoLocal;
                partidoEncontrado.MarcadorLocal = partido.MarcadorLocal;
                partidoEncontrado.EquipoVisitante = partido.EquipoVisitante;
                partidoEncontrado.MarcadorVisitante = partido.MarcadorVisitante;
                partidoEncontrado.arbitro = partido.arbitro;

                _appContext.SaveChanges();
            }
            return partidoEncontrado;
        }
    }
}