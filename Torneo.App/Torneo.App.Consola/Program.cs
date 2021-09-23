using System;
using System.Collections.Generic;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;
namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipios _repoMunicipio = new RepositorioMunicipios(new Persistencia.AppContext());



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void AddMunicipio()
        {
            var municipio = new Municipio
            {
                NombreMunicipio = "Palmira"
            };
            _repoMunicipio.AddMunicipio(municipio);
        }


        



        
    }
}
