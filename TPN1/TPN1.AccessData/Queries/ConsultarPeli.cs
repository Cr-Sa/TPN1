using System.Collections.Generic;
using System.Linq;
using TPN1.Domain.Entities;

namespace TPN1.AccessData.Queries
{
    public class ConsultarPeli
    {
        public IList<Peliculas> Consultar_Info(int p)
        {

            using (var db = new CineContext())
            {
                var peli = db.Peliculas
                .Where(b => b.PeliculaId == p)
                .ToList();
                return peli;
            }
        }
    }
}