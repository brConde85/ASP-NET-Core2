using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp4.ViewModels;

namespace asp4.Controllers
{
    public class HomeController : Controller
    {
        Cliente novo = new Cliente()
        {
            nome = "Bruno",
            sobreNome = "Marciano",
            telefone = "123456"

        };
        public IActionResult Index()
        {           
            return View(novo);
        }
    }
}