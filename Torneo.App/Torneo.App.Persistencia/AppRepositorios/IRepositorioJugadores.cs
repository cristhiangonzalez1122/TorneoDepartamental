using System.Collections.Generic;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia
{
    public interface IRepositorioJugadores
    {
        IEnumerable<Jugador>GetAllJugadores();
        Jugador AddJugador(Jugador jugador);
        Jugador UpdateJugador(Jugador jugador);
        void DeleteJugador(int idJugador);
        Jugador GetJugador(int idJugador);
    }
}