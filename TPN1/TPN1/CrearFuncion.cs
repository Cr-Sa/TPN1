using System;
using TPN1.Domain.Entities;

namespace TPN1
{
    public class CrearFuncion 
    {
         public Funciones crearFuncion(int id_pelicula, int id_sala, DateTime fecha, DateTime horario)
            {
                var funciondto = new Funciones();

                funciondto.PeliculaId = id_pelicula;
                funciondto.SalaId = id_sala;
                funciondto.Fecha = fecha;
                funciondto.Horario = horario;

            return funciondto;
            }
        
            }

    }

