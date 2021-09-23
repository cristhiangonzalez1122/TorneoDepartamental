using System.Collections.Generic;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia
{
    public interface IRepositorioEstadio
    {
        IEnumerable<Estadio>GetAllEstadios();
        Estadio AddEsstadio(Estadio estadio);
        Estadio UpdateEstadio(Estadio estadio);
        void DeleteEstadio(int idEstadio);
        Estadio GetEstadio(int idEstadio);
        
    }
}