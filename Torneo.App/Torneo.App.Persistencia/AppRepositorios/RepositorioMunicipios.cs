using System.Collections.Generic;
using System.Linq;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioMunicipios : IRepositorioMunicipios
    {
        private readonly AppContext _appContext;
        public RepositorioMunicipios(AppContext appContext)
        {
            _appContext = appContext;
        }

        Municipio IRepositorioMunicipios.AddMunicipio(Municipio municipio)
        {
            var municipioAdicionado = _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return municipioAdicionado.Entity;
        }

        void IRepositorioMunicipios.DeleteMunicipio(int idMunicipio)
        {
            var municipioEncontrado = _appContext.Municipios.Find(idMunicipio);
            if (municipioEncontrado == null)
                return;
            _appContext.Municipios.Remove(municipioEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Municipio> IRepositorioMunicipios.GetAllMunicipios()
        {
            return _appContext.Municipios;
        }

        Municipio IRepositorioMunicipios.GetMunicipio(int idMunicipio)
        {
            return _appContext.Municipios.Find(idMunicipio);
        }

        Municipio IRepositorioMunicipios.UpdateMunicipio(Municipio municipio)
        {
            var municipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.Id == municipio.Id);
            if(municipioEncontrado != null)
            {
                municipioEncontrado.NombreMunicipio = municipio.NombreMunicipio;

                _appContext.SaveChanges();
            }
            return municipioEncontrado;
        }
    }
}
