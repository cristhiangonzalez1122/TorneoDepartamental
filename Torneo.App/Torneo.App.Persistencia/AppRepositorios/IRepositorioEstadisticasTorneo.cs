using System.Collections.Generic;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia
{
    public interface IRepositorioEstadisticasTorneo
    {
        IEnumerable<EstadisticaTorneo>GetAllEstadisticas();
        EstadisticaTorneo AddEstadisticas(EstadisticaTorneo estadisticaTorneo);
        EstadisticaTorneo UpdateEstadisticas(EstadisticaTorneo estadisticaTorneo);
        void DeleteEstadisticas(int idEstadisticasTorneo);
        EstadisticaTorneo GetEstadisticaTorneo(int idEstadisticasTorneo);
    }
}