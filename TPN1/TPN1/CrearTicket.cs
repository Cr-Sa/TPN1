using System;
using TPN1.Domain.Entities;

namespace TPN1
{
    public class CrearTicket
    {
        public Tickets crearTicket(Guid id_ticket, int id_funcion, string usuario)
        {
            var ticket = new Tickets();

            ticket.TicketId = Guid.NewGuid();
            ticket.FuncionId = id_funcion;
            ticket.Usuario = usuario;

            return ticket;
        }
    }
}
