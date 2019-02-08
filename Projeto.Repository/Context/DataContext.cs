using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.Repository.Mappings;
using System.Configuration;
using System.Data.Entity;

namespace Projeto.Repository.Context
{
    //REGRA 1) HERDAR DbContext
    public class DataContext : DbContext
    {
        //REGRA 2) CONSTRUTOR PARA RECEBER A CONNECTIONSTRING
        public DataContext()
            : base(ConfigurationManager
            .ConnectionStrings["teste"].ConnectionString)
        {



        }

        //REGRA 3) SOBRESCREVER O MÉTODO OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //adicionar as classes de mapeamento..
            modelBuilder.Configurations.Add(new TaxaMap());
            modelBuilder.Configurations.Add(new ClienteAdquirenteMap());
          
        }

        //REGRA 4) DECLARAR UMA PROPRIEDADE SET/GET PARA CADA ENTIDADE
        //DO TIPO DbSet (PERMITIR A REALIZAÇÃO DAS OPERAÇÕES DE CRUD)
        public DbSet<Taxa> Taxa { get; set; }
        public DbSet<ClienteAdquirente> ClienteAdquirente { get; set; }
       
    }
}
