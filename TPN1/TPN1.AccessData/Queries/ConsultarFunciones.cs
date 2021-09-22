using System.Collections.Generic;
using System.Linq;
using TPN1.Domain.Entities;

namespace TPN1.AccessData.Queries
{
    public class ConsultarFunciones
    {
        public IList<Funciones> Consultar_Fun_Peli(int p)
        {
            using (var db = new CineContext())
            {
                var cfp = db.Funciones
                .Where(b => b.PeliculaId == p)
                .ToList();
                return cfp;
            }
        }
    }
}