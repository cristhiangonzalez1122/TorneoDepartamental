

using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioArbitros : IRepositorioArbitros
    {
        private readonly AppContext _appContext;
        public RepositorioArbitros(AppContext appContext)
        {
            _appContext = appContext;
        }

        Arbitro IRepositorioArbitros.AddArbitro(Arbitro arbitro)
        {
            var arbitroAdicionado = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity;
        }

        void IRepositorioArbitros.DeleteArbitro(int idArbitro)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Arbitro> IRepositorioArbitros.GetAllArbitros()
        {
            throw new System.NotImplementedException();
        }

        Arbitro IRepositorioArbitros.GetArbitro(int idArbitro)
        {
            throw new System.NotImplementedException();
        }

        Arbitro IRepositorioArbitros.UpdateArbitro(Arbitro arbitro)
        {
            throw new System.NotImplementedException();
        }
    }
}