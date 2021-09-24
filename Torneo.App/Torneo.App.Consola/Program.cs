using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;
namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipios _repoMunicipio = new RepositorioMunicipios(new Persistencia.AppContext());
        private static IRepositorioArbitros _repoArbitro = new RepositorioArbitros(new Persistencia.AppContext());



        static void Main(string[] args)
        {
            Console.WriteLine("Hello Test");
            //CRUD MUNICIPIO***********////
            //AddMunicipio();
            //DeleteMunicipio(2);
            //GetMunicipio(4);
            //GetAllMunicipios();
            //UpdateMunicipio(4, "Jamundi");

            //CRUD ARBITRO******************************
            //ddArbitro();
            //GetArbitro(1);
            //GetAllArbitros();
            //DeleteArbitro(1);
            //UpdateArbitro(2,"Ricardo Ortiz", "94.125.661", "3215521245", "Escuela De Arbitros LTDA");

            //****** Director TEcnico
            AddDirectorTecnico();
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

        //***********CRUD ARBITROS***************************************************//////////////////


        private static void AddArbitro()
        {
            var arbitro = new Arbitro
            {
                Nombre = "Raul Lopez",
                Documento = "16.978.885",
                Telefono = "3128854112",
                ColegioArbitro = "Escuela oficial de Arbitraje",
            };
            _repoArbitro.AddArbitro(arbitro);
        
        }

        private static void GetArbitro(int idArbitro)
        {
            var arbitro = _repoArbitro.GetArbitro(idArbitro);
            System.Console.WriteLine("ARBITRO encontrado: " + arbitro.Nombre + " Telefeno: " + arbitro.Telefono);
        }

        private static void GetAllArbitros()
        {
            var arbitros = _repoArbitro.GetAllArbitros();
            foreach (var arbitro in arbitros)
            {
                Console.WriteLine(arbitro.Nombre +" "+ arbitro.Telefono);
            }

        }

        private static void DeleteArbitro(int idArbitro)
        {
            _repoArbitro.DeleteArbitro(idArbitro);
            Console.WriteLine("Se borro con exito El Id.arbitro: " + idArbitro);
        }

        private static void UpdateArbitro(int idArbitro, string nombreNuevo, string documentoNuevo, string telefonoNuevo, string colegioNuevo)
        {
            Arbitro arbitroEncontrado = _repoArbitro.GetArbitro(idArbitro);
            arbitroEncontrado.Nombre= nombreNuevo;
            arbitroEncontrado.Documento = documentoNuevo;
            arbitroEncontrado.Telefono = telefonoNuevo;
            arbitroEncontrado.ColegioArbitro = colegioNuevo;
            Arbitro arbitroUpdated = _repoArbitro.UpdateArbitro(arbitroEncontrado);
        }


        //****************  CRUD DE EQUIPOS ********************************************************

        private static void AddDirectorTecnico()
        {
            var directorTecnico = new DirectorTecnico
            {
                Nombre = "Luis Carlos Velez",
                Documento = "16.789.852",
                Telefono = "3215524152",
                
            };
        }









    }
}
