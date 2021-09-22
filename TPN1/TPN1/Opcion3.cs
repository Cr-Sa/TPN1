using System;
using System.Linq;
using TPN1.AccessData;
using TPN1.Domain.Entities;

namespace TPN1
{
    public class Opcion3
    {
        public void obtenerTicket()
        {
            Console.Clear();
            string des0 = null;
            string des = null;
            int num_Sala = 0;

            Console.WriteLine("\n Las peliculas disponibles en el cine son: \n");
            TPN1.AccessData.Queries.VerCartelera peliculas = new TPN1.AccessData.Queries.VerCartelera();
            foreach (var p in peliculas.Ver_Pelis())
            {
                Console.WriteLine(p.PeliculaId + "_ " + p.Titulo);
            }
            TPN1.AccessData.Queries.ConsultarFunciones funciones = new TPN1.AccessData.Queries.ConsultarFunciones();
            Console.WriteLine("\n Ingrese el número de la película que desea visualizar las funciones \n ");
                int pf;
                    pf = int.Parse(Console.ReadLine());
            bool vacia = !funciones.Consultar_Fun_Peli(pf).Any();
            if (vacia)
            {
                Console.WriteLine("\n No hay funciones disponibles \n ");
                Console.WriteLine("\n Presione una tecla para volver a consultar");
                Console.ReadKey();
                Opcion3 menu = new Opcion3();
                        menu.obtenerTicket();
            }
            else
            {
                foreach (var p2f in funciones.Consultar_Fun_Peli(pf))
                {
                    Console.WriteLine("\n Datos de la función: \n" + "\n Número de la funcion: " + p2f.FuncionId +
                        "\n Número de la pelicula: " + p2f.PeliculaId +
                        "\n Número de sala: " + p2f.SalaId +
                        "\n Fecha de la función: " + p2f.Fecha.ToShortDateString() +
                        "\n Hora de la función: " + p2f.Horario.ToShortTimeString());
                    num_Sala = int.Parse(p2f.SalaId.ToString());

                }
            }
            try 
            { 
                Console.WriteLine("\n Desea consultar si hay Tickets disponibles para una función? S/N\n ");
                des0 = Console.ReadLine();
                switch (des0)
                {
                    case "S":
                        TPN1.AccessData.Queries.ConsultarTickets tickets = new TPN1.AccessData.Queries.ConsultarTickets();
                        TPN1.AccessData.Queries.ConsularSala salas = new TPN1.AccessData.Queries.ConsularSala();
                        TPN1.AccessData.Queries.ConsultarNumeroFuncion fun = new TPN1.AccessData.Queries.ConsultarNumeroFuncion();
                        Console.WriteLine("\n Ingrese el número de la función: \n");
                        int num_Funcion = int.Parse(Console.ReadLine());
                            foreach (var p2f in fun.verFunciones(pf))
                            {
                                var nomPeli = p2f.Titulo;
                                Funciones funcion = (from c in p2f.Funciones where c.FuncionId == num_Funcion select c).FirstOrDefault();
                                if (funcion != null)
                                {
                                    int tickets_restantes = 0;
                                    int tickets_vendidos = 0;
                                    bool vacia2 = !tickets.Ver_Tickets(num_Funcion).Any();
                                    if (vacia2)
                                    {
                                        Console.WriteLine("\n La función esta vacia, puede proseguir con su compra \n ");
                                    }
                                    else
                                    {
                                        foreach (var t in tickets.Ver_Tickets(num_Funcion))
                                        {
                                            tickets_vendidos = tickets_vendidos + 1;
                                            foreach (var s in salas.ConsultarSala(num_Sala))
                                            {
                                                int capacidad_sala = int.Parse(s.Capacidad.ToString());
                                                if (tickets_vendidos == capacidad_sala)
                                                {
                                                    Console.WriteLine("\n Función completa \n");
                                                    Console.WriteLine("\n Presione una tecla para seleccionar otra función \n ");
                                                    Console.ReadKey();
                                                    Opcion3 volvermenu = new Opcion3();
                                                    volvermenu.obtenerTicket();
                                                }
                                                else
                                                {
                                                    tickets_restantes = capacidad_sala - tickets_vendidos;

                                                }
                                            }
                                        }
                                        Console.WriteLine("\n La cantidad de tickets sin vender es: " + tickets_restantes + "\n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\n No hay funcion número " + num_Funcion + " para la pelicula "+ pf + "_ " + nomPeli +"\n" );
                                    Console.WriteLine("\n Presione una tecla para volver a consultar\n ");
                                    Console.ReadKey();
                                    Opcion3 menuMenu = new Opcion3();
                                    menuMenu.obtenerTicket();
                                }
                            }

                        Console.WriteLine("\n Desea obtener un Ticket? S/N\n ");
                        des = Console.ReadLine();
                        switch (des)
                        {
                            case "S":
                                Console.WriteLine("\n Para obtener un ticket para una función ingrese los datos que se solicitan a continuación: \n");
                                Console.WriteLine("\n Ingrese un número de función: \n");
                                Guid TicketId;
                                TicketId = Guid.NewGuid();
                                int Id_Funcion;
                                Id_Funcion = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n Ingrese su nombre: \n");
                                string usuario;
                                usuario = Console.ReadLine();
                                TPN1.CrearTicket tick = new TPN1.CrearTicket();
                                var dbt = new CineContext();
                                dbt.Tickets.Add(tick.crearTicket(TicketId, Id_Funcion, usuario));
                                dbt.SaveChanges();
                                Console.WriteLine("\n Ticket obtenido exitosamente!!\n ");
                                Console.WriteLine("\n Presione una tecla para volver al menu principal\n ");
                                Console.ReadKey();
                                break;
                            case "N":
                                    MenuPrincipal menu3 = new MenuPrincipal();
                                    menu3.menuPrincipal();
                                break;

                            default:
                                Console.WriteLine("\n Opción incorrecta\n ");
                                Console.WriteLine("\n Introduzca una S o N \n");
                                Console.WriteLine("\n Presione una tecla para continuar \n");

                                Console.ReadKey();
                                Opcion3 menu2 = new Opcion3();
                                        menu2.obtenerTicket();
                                break;
                        }
                        break;

                    case "N":
                        break;

                    default:
                        Console.WriteLine("\n Opción incorrecta\n ");
                        Console.WriteLine("\n Introduzca una S o N \n");
                        Console.WriteLine("\n Presione una tecla para continuar \n");

                        Console.ReadKey();
                        Opcion3 menu = new Opcion3();
                                menu.obtenerTicket();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n Ha ocurrido un error: Formato de datos incorrecto\n");
                Console.WriteLine("\n Presione una tecla para continuar\n ");
                Console.ReadKey();
                Opcion3 menu = new Opcion3();
                        menu.obtenerTicket();
            }
        }
    }
}
