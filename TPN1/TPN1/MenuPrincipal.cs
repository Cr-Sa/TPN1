using System;

namespace TPN1
{
    public class MenuPrincipal
    {
        public void menuPrincipal()
        {
        int x = 0;
            try
            {
                do
            {
                Console.Clear();
                Console.WriteLine(  "\n                             -----------------------" +
                                    "\n                            | Seleccione una opción |" +
                                    "\n                             -----------------------   \n" +
                                   "\n |1| Ver Cartelera \n" +
                                   //Sub opcion ---> Ver información de una pelicula
                                   "\n |2| Registrar nueva función \n" +
                                   "\n |3| Obtener un Ticket \n" +
                                   //" Sub opcion ---> Ver Funciones disponibles de una pelicula\n" +
                                   //" Sub Sub opcion ---> Ver Tickets disponibles para una función \n" +
                                   "\n |4| Salir \n");

                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Opcion1 opcion1 = new Opcion1();
                                opcion1.verCartelera();  
                        break;
                    case 2:
                        Opcion2 opcion2 = new Opcion2();
                                opcion2.crearFuncion();
                        break;
                    case 3:
                        Opcion3 opcion3 = new Opcion3();
                                opcion3.obtenerTicket();
                        break;
                    case 4:
                        
                        break;      
                    default:
                        Console.WriteLine("\n Opción incorrecta\n ");
                        Console.WriteLine("\n Presione una tecla para continuar \n");
                        Console.ReadKey();
                        break;
                }
            } while (x != 4) ;
            }
            catch (Exception)
            {
                Console.WriteLine("\n Ha ocurrido un error \n");
                Console.WriteLine("\n Introduzca un valor numérico dentro del rango indicado \n");
                Console.WriteLine("\n Presione una tecla para continuar\n ");
                Console.ReadKey();
                MenuPrincipal menu = new MenuPrincipal();
                menu.menuPrincipal();
            }
        }
    }
}