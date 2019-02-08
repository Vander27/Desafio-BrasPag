using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class ClienteAdquirenteCadastroViewModel
    {

        public decimal Valor { get; set; }
        public  string Adquirente { get; set; }
        public string Bandeira{ get; set; }
        public string Tipo { get; set; }
        


    }
}