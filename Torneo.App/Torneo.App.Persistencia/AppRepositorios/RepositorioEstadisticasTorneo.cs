using System.Collections.Generic;
using System.Linq;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia
{
    public class RepositorioEstadisticasTorneo : IRepositorioEstadisticasTorneo
    {
        private readonly AppContext _appContext;
        public RepositorioEstadisticasTorneo(AppContext appContext)
        {
            _appContext = appContext;
        }

        EstadisticaTorneo IRepositorioEstadisticasTorneo.AddEstadisticas(EstadisticaTorneo estadistica)
        {
            var estadisticaAdicionada = _appContext.EstadisticasTorneo.Add(estadistica);
            _appContext.SaveChanges();
            return estadisticaAdicionada.Entity;
        }

        void IRepositorioEstadisticasTorneo.DeleteEstadisticas(int idEstadisticasTorneo)
        {
            var estadisticaEncontrada = _appContext.EstadisticasTorneo.Find(idEstadisticasTorneo);
            if (estadisticaEncontrada == null)
                return;
            _appContext.EstadisticasTorneo.Remove(estadisticaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<EstadisticaTorneo> IRepositorioEstadisticasTorneo.GetAllEstadisticas()
        {
            return _appContext.EstadisticasTorneo;
        }

        EstadisticaTorneo IRepositorioEstadisticasTorneo.GetEstadisticaTorneo(int idEstadisticasTorneo)
        {
            return _appContext.EstadisticasTorneo.Find(idEstadisticasTorneo);
        }

        EstadisticaTorneo IRepositorioEstadisticasTorneo.UpdateEstadisticas(EstadisticaTorneo estadistica)
        {
            var estadisticaEncontrada = _appContext.EstadisticasTorneo.FirstOrDefault(t => t.Id == estadistica.Id);
            if(estadisticaEncontrada != null)
            {
                estadisticaEncontrada.PartidosJugados = estadistica.PartidosJugados;
                estadisticaEncontrada.PartidosGanados = estadistica.PartidosGanados;
                estadisticaEncontrada.PartidosEmpatados = estadistica.PartidosEmpatados;
                estadisticaEncontrada.GolesFavor = estadistica.GolesFavor;
                estadisticaEncontrada.GolesEnContra = estadistica.GolesEnContra;
                estadisticaEncontrada.Puntos = estadistica.Puntos;
                estadisticaEncontrada.Equipo = estadistica.Equipo;

                _appContext.SaveChanges();
            }
            return estadisticaEncontrada;
        }
    }
}