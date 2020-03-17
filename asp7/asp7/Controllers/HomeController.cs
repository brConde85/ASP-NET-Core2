using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //este exercício vai nos mostrar como um valor vai passar pela View e vamos transforma-lo na View
            ViewData["valor"] = 100; // ViewData funciona como um dicionário por isso é necessário utilizar uma string como chave

            return View();
        }
    }
}