using System.Collections.Generic;
using System.Linq;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia
{
    public class RepositorioJugadores : IRepositorioJugadores
    {
         private readonly AppContext _appContext;

        public RepositorioJugadores(AppContext appContext)
        {
            appContext = _appContext;
        }

        Jugador IRepositorioJugadores.AddJugador(Jugador jugador)
        {
            var jugadorAdicionado = _appContext.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }

        void IRepositorioJugadores.DeleteJugador(int idJugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (jugadorEncontrado == null)
                return;
            _appContext.Jugadores.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Jugador> IRepositorioJugadores.GetAllJugadores()
        {
            return _appContext.Jugadores;
        }

        Jugador IRepositorioJugadores.GetJugador(int idJugador)
        {
            return _appContext.Jugadores.Find(idJugador);
        }

        Jugador IRepositorioJugadores.UpdateJugador(Jugador jugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.FirstOrDefault(j => j.Id == jugador.Id);
            if(jugadorEncontrado != null)
            {
                jugadorEncontrado.NombreJugador = jugador.NombreJugador;
                jugadorEncontrado.NumeroCamiseta = jugador.NumeroCamiseta;
                jugadorEncontrado.Posicion = jugador.Posicion;

                _appContext.SaveChanges();
            }
            return jugadorEncontrado;
        }
    }
}