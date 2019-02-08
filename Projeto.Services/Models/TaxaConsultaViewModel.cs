using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models
{
    public class TaxaConsultaViewModel
    {
        public  int IdCartaoBandeira { get; set; }
        public  string Bandeira { get; set; }
        public  string Tipo { get; set; }
        public  decimal Credito { get; set; }
        public  decimal Debito { get; set; }
        public  int IdClienteAdquirente { get; set; }
        public string Adquirente { get; set; }
    }
}