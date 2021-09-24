using System.Collections.Generic;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia
{
    public interface IRepositorioNovedadesPartido
    {
        IEnumerable<NovedadPartido>GetAllNovedades();
        NovedadPartido AddNovedadPartido(NovedadPartido novedad);
        NovedadPartido UpdateNovedadPartido(NovedadPartido novedadPartido);
        void DeleteNovedad(int idNovedadPartido);
        NovedadPartido GetNovedad(int idNovedadPartido);
    }
}