using System;
using TPN1.AccessData;

namespace TPN1
{
    class ValidarFunciones
    {
        public void validarFunciones(int Id_Sala, DateTime fecha, DateTime hora, int Id_Pelicula)
        {
            TPN1.AccessData.Queries.ConsularSalaPorHora listFuncionesHora = new TPN1.AccessData.Queries.ConsularSalaPorHora();
            foreach (var lfh in listFuncionesHora.ConsultarSalaHora(Id_Sala))
            {
                DateTime fecha2;
                         fecha2 = Convert.ToDateTime(lfh.Fecha.ToString());
                DateTime hora2;
                         hora2 = Convert.ToDateTime(lfh.Horario.ToString());                    
                if (int.Parse(lfh.SalaId.ToString()) == Id_Sala && fecha2 == fecha)
                {
                    var hora2aux = hora2.AddHours(2.5);
                    if (hora >= hora2aux || hora <= hora2aux)
                    {
                        hora = hora.AddHours(2.5);
                            Console.WriteLine("\n Hay una función en ese horario \n");
                            Console.WriteLine("\n Los horarios de las funciones que ya se encuentran en esta sala son: \n");
                        foreach (var lfh2 in listFuncionesHora.ConsultarSalaHora(Id_Sala))
                            { 
                                Console.WriteLine(lfh2.Horario.ToShortTimeString());
                            }
                            Console.WriteLine("\n Presione una tecla para crear otra función");
                            Console.ReadKey();
             break;

                    }
                    else
                    {
                        TPN1.CrearFuncion fun = new TPN1.CrearFuncion();
                        var db = new CineContext();
                            db.Funciones.Add(fun.crearFuncion(Id_Pelicula, Id_Sala, fecha, hora));
                            db.SaveChanges();
                        Console.WriteLine("\n Función creada exitosamente!!");
                        Console.WriteLine("\n Presione una tecla para continuar");
                        Console.ReadKey();
                        break;
                    }

                }
                else
                {
                    TPN1.CrearFuncion fun = new TPN1.CrearFuncion();
                    var db = new CineContext();
                        db.Funciones.Add(fun.crearFuncion(Id_Pelicula, Id_Sala, fecha, hora));
                        db.SaveChanges();
                    Console.WriteLine("\n Función creada exitosamente!!");
                    Console.WriteLine("\n Presione una tecla para continuar");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
