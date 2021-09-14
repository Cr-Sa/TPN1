using System;
using System.Collections.Generic;
using TPN1.AccessData;
using TPN1.Domain.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TPN1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("\n Seleccione una opción \n");
            //Console.WriteLine(" 1- Ver Cartelera \n");
            //Console.WriteLine(" 2- Ver Funciones disponibles \n");
            //Console.WriteLine(" 3- Registrar nueva función \n");
            //Console.WriteLine(" 4- Ver Tickets disponibles \n");
            //Console.WriteLine(" 5- Obtener un Ticket \n");
            
            TPN1.AccessData.Queries.VerCartelera pelicula = new TPN1.AccessData.Queries.VerCartelera();
            foreach (var x in pelicula.Ver_Pelis())
            {
                Console.WriteLine(x.PeliculaId + " " + x.Titulo);
            }
            TPN1.AccessData.Queries.ConsultarPeli pelicula2 = new TPN1.AccessData.Queries.ConsultarPeli();
            Console.WriteLine("Ingrese el número de la pelicula que desea visualizar la información");
            int v;
            v = int.Parse(Console.ReadLine());
            foreach (var x in pelicula2.Consultar_Info(v))
            {
                Console.WriteLine("\n Titulo: " + x.Titulo +
                                    "\n Poster: " + x.Poster +
                                    "\n Sinopsis: " + x.Sinopsis +
                                   "\n Trailer: " + x.Trailer);
            }



        }

}
}