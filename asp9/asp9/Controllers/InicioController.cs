using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp9.Controllers
{
    public class InicioController : Controller
    {
        public string Index()
        {
            return "InicioController - Index";
        }
        public string Arranque(int id)
        {
            /*
             * Caminho para execução aplicação:
             * https://localhost:44376/inicio/arranque/
             * Pode ser inserido um valor ao final para que ele seja exibido na tela
             * ex.: https://localhost:44376/inicio/arranque/1000                                     
             */
            return "HomeController - Arranque valor: " + id.ToString();
        }
    }
}