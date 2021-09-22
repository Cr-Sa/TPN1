using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TPN1.Domain.Entities;

namespace TPN1.AccessData.Queries
{
    public class ConsultarNumeroFuncion
    {
        public IList<Peliculas> verFunciones(int idPeli)
        {
            using (var db = new CineContext())
            {
                var funcionesPeliculas = db.Peliculas
                    .Include(p => p.Funciones)
                    .Where(p => p.PeliculaId.Equals(idPeli))
                    .ToList();
                return funcionesPeliculas;
            }
           
        }
    }
}
