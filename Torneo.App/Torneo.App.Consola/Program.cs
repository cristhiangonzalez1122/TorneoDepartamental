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
            //GetMunicipio(4);
            //GetAllMunicipios();
            //UpdateMunicipio(4, "Jamundi");
        }

        private static void AddMunicipio()
        {
            var municipio = new Municipio
            {
                NombreMunicipio = "Cali",

            };
            _repoMunicipio.AddMunicipio(municipio);
        }

        private static void GetMunicipio(int idMunicipio)
        {
            var municipio = _repoMunicipio.GetMunicipio(idMunicipio);
            System.Console.WriteLine("Nombre del municipio encontrado: " + municipio.NombreMunicipio);
        }

        private static void GetAllMunicipios()
        {
            var municipios = _repoMunicipio.GetAllMunicipios();
            foreach (var municipio in municipios)
            {
                Console.WriteLine(municipio.NombreMunicipio);
            }

        }

        private static void DeleteMunicipio(int idMunicipio)
        {
            _repoMunicipio.DeleteMunicipio(idMunicipio);
            System.Console.WriteLine("Se borró el municipio con id: " + idMunicipio);
        }

        private static void UpdateMunicipio(int idMunicipio, string nombreNuevo)
        {
            Municipio municipioEncontrado = _repoMunicipio.GetMunicipio(idMunicipio);
            municipioEncontrado.NombreMunicipio = nombreNuevo;
            Municipio municipioUpdated = _repoMunicipio.UpdateMunicipio(municipioEncontrado);
        }









    }
}
