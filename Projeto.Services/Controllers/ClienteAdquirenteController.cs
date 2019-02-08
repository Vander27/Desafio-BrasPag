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
    [RoutePrefix("api/clienteadquirente")]
    public class ClienteAdquirenteController : ApiController
    {

        [HttpPost]
        [Route("cadastrar")] //URL: /api/clienteadquirente/cadastrar
        public HttpResponseMessage Cadastrar(ClienteAdquirenteCadastroViewModel model)
        {
            //verificando as validações
            if (ModelState.IsValid)
            {
                try
                {
                    ClienteAdquirente a = new ClienteAdquirente(); //entidade..
                    a.Adquirente = model.Adquirente;
               
                    ClienteAdquirenteRepository rep = new ClienteAdquirenteRepository();
                    rep.Insert(a); //gravando no banco de dados..

                    //retornar um status de sucesso.. HTTP 200
                    return Request.CreateResponse(HttpStatusCode.OK,
                        "Adquirente cadastrado com sucesso.");
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
        [Route("consultar")] //URL: /api/clienteadquirente/consultar
        public HttpResponseMessage Consultar()
        {
            try
            {
                List<ClienteAdquirenteConsultaViewModel> lista = new List<ClienteAdquirenteConsultaViewModel>();

                ClienteAdquirenteRepository rep = new ClienteAdquirenteRepository();
                foreach (ClienteAdquirente a in rep.FindAll())
                {
                    ClienteAdquirenteConsultaViewModel model = new ClienteAdquirenteConsultaViewModel();
                   
                    model.Adquirente = a.Adquirente;
                   




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
