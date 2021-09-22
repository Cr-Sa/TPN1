using System;


namespace TPN1
{
    public class Opcion1
    {
        public void verCartelera() 
        {
            string des = null;
            Console.Clear();
            TPN1.AccessData.Queries.VerCartelera pelicula = new TPN1.AccessData.Queries.VerCartelera();
            foreach (var p in pelicula.Ver_Pelis())
            {
                 Console.WriteLine(p.PeliculaId + " " + p.Titulo);
            }
            try 
            { 
                Console.WriteLine("\n Desea visualizar la información de alguna pelicula? S/N\n ");
                des = Console.ReadLine();
                switch (des)
                {
                    case "S":
                    TPN1.AccessData.Queries.ConsultarPeli pelicula2 = new TPN1.AccessData.Queries.ConsultarPeli();
                    Console.WriteLine("\n Ingrese el número de la pelicula que desea visualizar la información\n ");
                        int v;
                        v = int.Parse(Console.ReadLine());
                        foreach (var p in pelicula2.Consultar_Info(v))
                        {
                         Console.WriteLine("\n Titulo: " + p.Titulo +
                                           "\n Poster: " + p.Poster +
                                           "\n Sinopsis: " + p.Sinopsis +
                                           "\n Trailer: " + p.Trailer);
                        }
                    Console.WriteLine("\n Presione una tecla para volver al menu principal");
                    Console.ReadKey();
                        break;
                    case "N":
                       break;

                    default:
                       Console.WriteLine("\n Opción incorrecta\n ");
                       Console.WriteLine("\n Introduzca una S o N \n");
                       Console.WriteLine("\n Presione una tecla para continuar\n ");
                       Console.ReadKey();
                       Opcion1 menu = new Opcion1();
                               menu.verCartelera();
                       break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n Ha ocurrido un error \n");
                Console.WriteLine("\n Introduzca una S o N \n");
                Console.WriteLine("\n Presione una tecla para continuar\n ");
                Console.ReadKey();
                Opcion1 menu = new Opcion1();
                        menu.verCartelera();
            }
        }
    }
}