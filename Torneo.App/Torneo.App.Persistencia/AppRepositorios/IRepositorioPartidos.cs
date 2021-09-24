using System.Collections.Generic;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia
{
    public interface IRepositorioPartidos
    {
        IEnumerable<CrearPartido>GetAllPartidos();
        CrearPartido AddPartidos(CrearPartido partido);
        CrearPartido UpdatePartidos(CrearPartido partido);
        void DeletePartidos(int idCrearPartido);
        CrearPartido GetPartido(int idCrearPartido);
    }
}