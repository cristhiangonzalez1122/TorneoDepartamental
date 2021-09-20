using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query;
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
            var arbitroEncontrado = _appContext.Arbitros.Find(idArbitro);
            if (arbitroEncontrado == null)
                return;
            _appContext.Arbitros.Remove(arbitroEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Arbitro> IRepositorioArbitros.GetAllArbitros()
        {
            return _appContext.Arbitros;
        }

        Arbitro IRepositorioArbitros.GetArbitro(int idArbitro)
        {
            return _appContext.Arbitros.Find(idArbitro);
        }

        Arbitro IRepositorioArbitros.UpdateArbitro(Arbitro arbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.FirstOrDefault(a => a.Id == arbitro.Id);
            if(arbitroEncontrado != null)
            {
                arbitroEncontrado.Nombre = arbitro.Nombre;
                arbitroEncontrado.Documento = arbitro.Documento;
                arbitroEncontrado.Telefono = arbitro.Telefono;
                arbitroEncontrado.ColegioArbitro = arbitro.ColegioArbitro;

                _appContext.SaveChanges();
            }
            return arbitroEncontrado;
        }
        
    }
}