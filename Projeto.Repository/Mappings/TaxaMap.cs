using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //importando..
using System.Data.Entity.ModelConfiguration; //ORM..


namespace Projeto.Repository.Mappings
{
    //Classe de mapeamento para a entidade Taxa..
    public class TaxaMap : EntityTypeConfiguration<Taxa>
    {
        //construtor [ctor] + 2x[tab]
        public TaxaMap()
        {
            //nome da tabela..
            ToTable("TAXA");

            //chave primária..
            HasKey(t => t.IdTaxa);

            //mapeando os campos..
            Property(t => t.IdTaxa)
                .HasColumnName("IDTAXA")
                .IsRequired();

            Property(t => t.Bandeira)
                .HasColumnName("BANDEIRA")
                .HasMaxLength(50)
                .IsRequired();


            Property(t => t.Credito)
                 .HasColumnName("CREDITO");


            Property(t => t.Debito)
                 .HasColumnName("DEBITO");
               

            Property(t => t.IdClienteAdquirente)
               .HasColumnName("IDCLIENTEADQUIRENTE")
               .IsRequired();


            //Mapear a chave estrangeira com a 
            //tabela de Adquirente..
            HasRequired(t => t.ClienteAdquirente) //Taxa TEM 1 Cliente
                .WithMany(a => a.Taxas) //Cliente TEM Muitos Taxas
                .HasForeignKey(t => t.IdClienteAdquirente) //Chave estrangeira
                .WillCascadeOnDelete(false);


        }
    }

}

