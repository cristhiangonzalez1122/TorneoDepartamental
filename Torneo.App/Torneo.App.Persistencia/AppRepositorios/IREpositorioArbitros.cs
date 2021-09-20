using System.Collections.Generic;
using Torneo.App.Dominio;


namespace Torneo.App.Persistencia
{
    public interface IRepositorioArbitros
    {
        IEnumerable<Arbitro> GetAllArbitros();
        Arbitro AddArbitro(Arbitro arbitro);
        Arbitro UpdateArbitro(Arbitro arbitro);
        void DeleteArbitro(int idArbitro);
        Arbitro GetArbitro(int idArbitro);
    }
}