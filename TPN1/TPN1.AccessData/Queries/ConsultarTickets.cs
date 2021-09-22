using System.Collections.Generic;
using System.Linq;
using TPN1.Domain.Entities;

namespace TPN1.AccessData.Queries
{
    public class ConsultarTickets
    {
        public IList<Tickets> Ver_Tickets(int ticket)
        {
            using (var db = new CineContext())
            {
                var tickets = db.Tickets
                    .Where(p => p.FuncionId.Equals(ticket))
                    .ToList();
                return tickets;

            }
        }
    }   
}