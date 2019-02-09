using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Services.Models
{
    public class OperacaoViewModel
    {
        public decimal Valor { get; set; }
        public string Adquirente { get; set; }
        public string Bandeira { get; set; }
        public string Tipo { get; set; }

        public decimal Valor_liquido { get; set; }
    }
}