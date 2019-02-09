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
        public List<Taxa> ClienteAdquirente(int idClienteAdquirente)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Taxa.Where(t => t.IdClienteAdquirente == idClienteAdquirente).ToList();
            }
        }


    }
}
