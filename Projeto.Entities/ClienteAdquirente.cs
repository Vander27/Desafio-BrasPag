using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
   public class ClienteAdquirente
   {
        public  int IdClienteAdquirente { get; set; }
        public  string Adquirente { get; set; }
       
        #region Relacionamento
        public List<Taxa> Taxas { get; set; }
        #endregion

    }
}
