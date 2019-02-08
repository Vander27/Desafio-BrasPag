using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Services.Models
{
    public class ClienteAdquirenteCadastroViewModel
    {

        [Required(ErrorMessage = "Por favor, informe o Adquirente.")]
        public  string Adquirente { get; set; }

      
    }
}