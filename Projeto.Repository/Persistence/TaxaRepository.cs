using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.Repository.Generics;
using Projeto.Repository.Context;
using System.Data.Entity; //entityframework


namespace Projeto.Repository.Persistence
{
   public class TaxaRepository : GenericRepository<Taxa>
    {
        public override List<Taxa> FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Taxa
                          .Include(t => t.ClienteAdquirente) //JOIN
                          .ToList();
            }
        }

    }
}
