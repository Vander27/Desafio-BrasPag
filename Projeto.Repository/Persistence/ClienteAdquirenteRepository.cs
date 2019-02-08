using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Repository.Context;
using Projeto.Entities;
using Projeto.Repository.Generics;
using System.Data.Entity; //entityframework



namespace Projeto.Repository.Persistence
{
   public class ClienteAdquirenteRepository : GenericRepository<ClienteAdquirente>
    {

        //método que retorne a quantidade de Taxas
        //de um determinado Adquirente..
        public int QtdTaxas(int idClienteAdquirente)
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Taxa
                          .Where(t => t.IdClienteAdquirente == idClienteAdquirente)
                          .Count();
            }
        }

    }
}
