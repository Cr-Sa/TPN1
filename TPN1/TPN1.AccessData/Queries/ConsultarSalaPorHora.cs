using System.Collections.Generic;
using System.Linq;
using TPN1.Domain.Entities;

namespace TPN1.AccessData.Queries
{
    public class ConsularSalaPorHora
    {
        public IList<Funciones> ConsultarSalaHora(int slid)
        {
            using (var db = new CineContext())
            {
                var listHora = db.Funciones
                    .Where(f => f.SalaId == slid)
                    .ToList();
                return listHora;
            }
        }
    }
}