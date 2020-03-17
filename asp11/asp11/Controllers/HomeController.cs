using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp11.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            // o nome dentro do retorno deve ser o msm da Views/Home/menu_inicial
            return View("menu_inicial");
        }

        // para vericação de um Request do tipo Get
        //Obs.: GET é enviada como string anexada a URL ,
        // Apesar do caminho ser o msm, o sistema interpreta a prioridade e o tipo de função será executada
        [HttpGet("home/NovoCliente")]// com o tipo Get o interpretador verifica que não houve nenhuma submissão de formulario
        public ViewResult NovoClienteFrm()
        {
            return View();
        }

        // POST é encapsulada junto ao corpo da requisição HTTP e não pode ser vista
        // pelo fato de ser um formulário o request do tipo post será executado
        // ou seja como o sistema ao apertar o botão irá gravar ele irá priorizar o post
        [HttpPost("home/NovoCliente")]
        public string Novo_Cliente_gravar()
        {
            // todo o mecanismo de gravação dos dados do cliente na db.
            return "Novo Cliente gravado, com sucesso.";
        }
    }
}