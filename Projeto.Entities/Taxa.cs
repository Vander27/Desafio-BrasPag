using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
  public  class Taxa
  {


        public  int IdTaxa { get; set; }
        public  string Bandeira { get; set; }
        public  decimal Credito { get; set; }
        public  decimal Debito { get; set; }
        public int IdClienteAdquirente { get; set; }

        public ClienteAdquirente ClienteAdquirente { get; set; }
        
    }
}
