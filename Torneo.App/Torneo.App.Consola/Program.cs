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
            Console.WriteLine("Hello Test");
            //AddMunicipio();
            //DeleteMunicipio(2);
        }

        private static void AddMunicipio()
        {
            var municipio = new Municipio
            {
                NombreMunicipio = "Cali",
            };
            _repoMunicipio.AddMunicipio(municipio);
        }

        private static void DeleteMunicipio(int idMunicipio)
        {
            _repoMunicipio.DeleteMunicipio(idMunicipio);
            System.Console.WriteLine("Se borró el municipio con id: " + idMunicipio);
        }







    }
}
