using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class TaxaCadastroViewModel
    {
        [Required(ErrorMessage = "Por favor, informe a Bandeira.")]
        public  string Bandeira { get; set; }

        [Required(ErrorMessage = "Por favor, o valor da porcentagem.")]
        public  decimal Credito { get; set; }

        [Required(ErrorMessage = "Por favor, o valor da porcentagem.")]
        public  decimal Debito { get; set; }

        public int IdClienteAdquirente { get; set; }

    }
}