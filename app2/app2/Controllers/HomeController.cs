using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app2.Models;

namespace app2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            return View("inicio");
        }
        [HttpGet] //Permite a passagem de parâmetros via URL, REQUEST PARA CLICAR EM PAGINA DE INTERNET
        public ViewResult Formulario()
        {
            return View("formulario");
        }

        // Haverá uma submissão entre os dois métodos onde o formlário que será executado será o HttpPost

        [HttpPost] // Para validação de um formulário
        //ViewResult para devolver uma nova view contendo os resultados do formulário        
        // Foi realizada a inserção de um parâmetro onde será injetado em formulario o conjunto das respostas informadas pelo usuário em Models: RepostaConvidados 
        public ViewResult Formulario(RespostaConvidados resposta)
        {
            //chamando classe estática repositorio de model para utilizar o método AdicionarResposta
            //para utilizarmos o formulario depois que ele for submetido
            Repositorio.AdicionarResposta(resposta);// o objeto resposta vem do formulario apos ele ser preenchido
            //Retorno de uma tela de agradecimento
            return View("Obrigado", resposta);
        }

        public ViewResult ListaConvidados()
        {
            // retornando uma lista completa com a a condicional where mostrando apenas os convidados que confirmaram a presença
            return View("ListaFinal",Repositorio.ListaFinal.Where(c => c.Presente == true));
        }
    }
}
