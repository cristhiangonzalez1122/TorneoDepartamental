using System.Collections.Generic;
using System.Linq;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia
{
    public class RepositorioNovedadesPartido : IRepositorioNovedadesPartido
    {
        private readonly AppContext _appContext;

        public RepositorioNovedadesPartido(AppContext appContext)
        {
             _appContext = appContext;
        }

        NovedadPartido IRepositorioNovedadesPartido.AddNovedadPartido(NovedadPartido novedad)
        {
             var novedadAdicionada = _appContext.NovedadesPartido.Add(novedad);
            _appContext.SaveChanges();
            return novedadAdicionada.Entity;
        }

        void IRepositorioNovedadesPartido.DeleteNovedad(int idNovedadPartido)
        {
            var novedadEncontrada = _appContext.NovedadesPartido.Find(idNovedadPartido);
            if (novedadEncontrada == null)
                return;
            _appContext.NovedadesPartido.Remove(novedadEncontrada);
            _appContext.SaveChanges();

        }

        IEnumerable<NovedadPartido> IRepositorioNovedadesPartido.GetAllNovedades()
        {
            return _appContext.NovedadesPartido;
        }

        NovedadPartido IRepositorioNovedadesPartido.GetNovedad(int idNovedadPartido)
        {
            return _appContext.NovedadesPartido.Find(idNovedadPartido);
        }

        NovedadPartido IRepositorioNovedadesPartido.UpdateNovedadPartido(NovedadPartido novedadPartido)
        {
             var novedadEncontrada = _appContext.NovedadesPartido.FirstOrDefault(n => n.Id == novedadPartido.Id);
            if(novedadEncontrada != null)
            {
                novedadEncontrada.TarjetaRoja = novedadPartido.TarjetaRoja;
                novedadEncontrada.TarjetaAmarilla = novedadPartido.TarjetaAmarilla;
                novedadEncontrada.Goles = novedadPartido.Goles;
                novedadEncontrada.MinutoGol = novedadPartido.MinutoGol;
                novedadEncontrada.Novedades = novedadPartido.Novedades;
                novedadEncontrada.Partido =novedadPartido.Partido;
                novedadEncontrada.Equipo = novedadPartido.Equipo;
                novedadEncontrada.Jugador = novedadPartido.Jugador;

                _appContext.SaveChanges();
            }
            return novedadEncontrada;
        }
    }
}