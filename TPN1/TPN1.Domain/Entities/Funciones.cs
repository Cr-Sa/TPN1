﻿using System;
using System.Collections.Generic;

namespace TPN1.Domain.Entities
{
    public class Funciones
    {
        public int FuncionId { get; set; }
        public int PeliculaId { get; set; }
        public int SalaId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Horario { get; set; }
        public Peliculas PeliculasNavigator { get; set; }
        public Salas SalasNavigator { get; set; }
        public ICollection<Tickets> TicketsNavigator { get; set; }
    }
}