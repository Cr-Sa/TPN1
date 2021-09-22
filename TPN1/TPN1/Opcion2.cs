using System;
using System.Linq;
using TPN1.AccessData;

namespace TPN1
{
    public class Opcion2
    {
        public void crearFuncion()
        {
            Console.Clear();

            string des0 = null;
            int Id_Pelicula = 0;
            int Id_Sala = 0;
            DateTime fecha;
            DateTime hora;

            Console.WriteLine("\n Las películas disponibles en el cine son: \n");
            TPN1.AccessData.Queries.VerCartelera peliculas = new TPN1.AccessData.Queries.VerCartelera();
            foreach (var p in peliculas.Ver_Pelis())
            {
                Console.WriteLine(p.PeliculaId + "_ " + p.Titulo);
            }
            Console.WriteLine("\n Las salas disponibles en el cine son: \n");
            TPN1.AccessData.Queries.VerSalas salas = new TPN1.AccessData.Queries.VerSalas();
            foreach (var s in salas.verSala())
            {
                Console.WriteLine("\n Sala número: " + s.SalaId + "\n Capacidad de la sala: " + s.Capacidad + " personas");
            }
            try { 
                Console.WriteLine("\n Desea registrar una nueva funcón? S/N\n ");
                des0 = Console.ReadLine();
                switch (des0)
                {
                    case "S":
                        Console.WriteLine("\n Para registrar una nueva función ingrese los datos que se solicitan a continuación: \n");
                        Console.WriteLine("\n Ingrese un número de pelicula: \n");
                            Id_Pelicula = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n Ingrese un número de sala donde se proyectara la función: \n");
                            Id_Sala = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n Ingrese una fecha con el formato Año-Mes-Día en la que se proyectara la función: \n");
                            fecha = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("\n Ingrese un horario con el formato HH:MM \n");
                            hora = Convert.ToDateTime(Console.ReadLine());
                        TPN1.AccessData.Queries.ConsularSalaPorHora lisFunciones = new TPN1.AccessData.Queries.ConsularSalaPorHora();
                        bool Salavacia = !lisFunciones.ConsultarSalaHora(Id_Sala).Any();
                        if (Salavacia)
                        {
                            TPN1.CrearFuncion fun = new TPN1.CrearFuncion();
                            var db = new CineContext();
                                db.Funciones.Add(fun.crearFuncion(Id_Pelicula, Id_Sala, fecha, hora));
                                db.SaveChanges();
                            Console.WriteLine("\n Función creada exitosamente");
                            Console.WriteLine("\n Presione una tecla para seguir");
                            Console.ReadKey();
                            Opcion2 volverMenu = new Opcion2();
                                    volverMenu.crearFuncion();
                        }
                        else
                        {
                            TPN1.ValidarFunciones valfun = new TPN1.ValidarFunciones();
                            valfun.validarFunciones(Id_Sala, fecha, hora, Id_Pelicula);
                        }
                    break;

                case "N":
                    MenuPrincipal volverMenu2 = new MenuPrincipal();
                                  volverMenu2.menuPrincipal();
                    break;

                default:
                    Console.WriteLine("\n Opción incorrecta\n ");
                    Console.WriteLine("\n Introduzca una S o N \n");
                    Console.WriteLine("\n Presione una tecla para continuar \n");

                    Console.ReadKey();
                    Opcion2 menu = new Opcion2();
                            menu.crearFuncion();
                    break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n Ha ocurrido un error: Formato de datos incorrecto\n");
                Console.WriteLine("\n Presione una tecla para continuar\n ");
                Console.ReadKey();
                Opcion2 menu = new Opcion2();
                        menu.crearFuncion();
            }
        }
    }
}
