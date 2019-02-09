using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Repository.Context;


namespace Projeto.Repository.Generics
{


    /// <summary>
    /// Criando uma classe que implemente um CRUD (Create, Read, Update 
    /// e Delete) em banco de dados para qualquer entidade do projeto.
    /// </summary>

    public class GenericRepository<T> where T : class
    {

        public virtual void Insert(T obj)
        {
            using (DataContext ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }


       
        public virtual List<T> FindAll()
        {
            using (DataContext ctx = new DataContext())
            {
                return ctx.Set<T>().ToList();
            }
        }

       



    }
}
