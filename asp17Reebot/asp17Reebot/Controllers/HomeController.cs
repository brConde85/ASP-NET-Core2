using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp17Reebot.Models;

namespace asp17Reebot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //para passarmos um unico cliente podemos utlizar essa estrutura
            Clientes novoCliente = new Clientes();
            novoCliente.Nome = "Bruno";
            novoCliente.Sobrenome = "Marciano";

            return View(novoCliente);
        }
    }
}