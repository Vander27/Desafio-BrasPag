using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Projeto.Entities;
using Projeto.Repository.Persistence;
using Projeto.Services.Models;


namespace Projeto.Services.Controllers
{
    [RoutePrefix("api/taxa")]
    public class TaxaController : ApiController
    {

        [HttpPost]
        [Route("cadastrar")] //URL: /api/taxa/cadastrar
        public HttpResponseMessage Cadastrar(TaxaCadastroViewModel model)
        {
            //verificando as validações
            if (ModelState.IsValid)
            {
                try
                {
                   Taxa t = new Taxa(); //entidade..
                    t.IdClienteAdquirente = model.IdClienteAdquirente;
                    t.Bandeira = model.Bandeira;
                    t.Credito = model.Credito;
                    t.Debito = model.Debito;
                   
                    
                    TaxaRepository rep = new TaxaRepository();
                    rep.Insert(t); //gravando no banco de dados..

                    //retornar um status de sucesso.. HTTP 200
                    return Request.CreateResponse(HttpStatusCode.OK,
                        "Cartão cadastrado com sucesso.");
                }
                catch (Exception e)
                {
                    //retornar um status de erro.. HTTP 500
                    return Request.CreateResponse
                (HttpStatusCode.InternalServerError,
                            "Erro de servidor: " + e.Message);
                }
            }
            else
            {
                //retornar um status de sucesso.. HTTP 400
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                    "Ocorreram erros de validação nos campos enviados.");
            }
        }




        [HttpGet]
        [Route("consultar")] //URL: /api/taxa/consultar
        public HttpResponseMessage Consultar()
        {
            try
            {
                List<TaxaConsultaViewModel>lista = new List<TaxaConsultaViewModel>();

                TaxaRepository rep = new TaxaRepository();
                foreach (Taxa t in rep.FindAll())
                {
                    TaxaConsultaViewModel model = new TaxaConsultaViewModel();

                    model.Adquirente = t.ClienteAdquirente.Adquirente;

                    model.Bandeira = t.Bandeira;
                    
                    model.Credito = t.Credito;
                    model.Debito = t.Debito;
                
                   

                    lista.Add(model);
                }

                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode
                .InternalServerError, e.Message);
            }
        }

       


    }
}
