using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //importando..
using System.Data.Entity.ModelConfiguration; //ORM..


namespace Projeto.Repository.Mappings
{
    //Classe de mapeamento para a entidade ClienteAdquirente..
    public class ClienteAdquirenteMap : EntityTypeConfiguration<ClienteAdquirente>
    {
        //construtor [ctor] + 2x[tab]
        public ClienteAdquirenteMap()
        {
            //nome da tabela..
            ToTable("CLIENTEADQUIRENTE");

            //chave primária..
            HasKey(a => a.IdClienteAdquirente);

            //mapear os campos da tabela..
            Property(a => a.IdClienteAdquirente)
                .HasColumnName("IDCLIENTEADQUIRENTE")
                .IsRequired();

            Property(a => a.Adquirente)
                .HasColumnName("ADQUIRENTE")
                .HasMaxLength(50)
                .IsRequired();


        }

    }
}
