using System.Collections.Generic;
using System.Linq;
using TPN1.Domain.Entities;

namespace TPN1.AccessData.Queries
{
    public class VerSalas
    {
        public IList<Salas> verSala()
        {
            using (var db = new CineContext())
            {
                var listsala = db.Salas
                    .Select(s => s)
                    .ToList();
                return listsala;
            }
        }
    }
}
