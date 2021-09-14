using System.Collections.Generic;
using System.Linq;
using TPN1.Domain.Entities;


namespace TPN1.AccessData.Queries
{
    public class VerCartelera
    {
        public IList<Peliculas> Ver_Pelis()
        {

            using (var db = new CineContext())
            {
                var peli = db.Peliculas
                .Select(b => b)
                .ToList();
                return peli;
            }
        }
    }
}