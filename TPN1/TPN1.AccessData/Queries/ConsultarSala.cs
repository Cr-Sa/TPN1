using System.Collections.Generic;
using System.Linq;
using TPN1.Domain.Entities;

namespace TPN1.AccessData.Queries
{
    public class ConsularSala
    {
        public IList<Salas> ConsultarSala(int id_sala)
        {
            using (var db = new CineContext())
            {
                var listsala = db.Salas
                    .Where(f => f.SalaId == id_sala)
                    .ToList();
                return listsala;
            }
        }
    }
}