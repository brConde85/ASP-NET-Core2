using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp17.Models;

namespace asp17.Controlles
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Clientes> ListaClientes = new List<Clientes>();
            ListaClientes.Add(new Clientes() { Nome = "Joao",  Sobrenome = "Ribeiro" });
            ListaClientes.Add(new Clientes() { Nome = "Bruno", Sobrenome = "Marciano" });
            ListaClientes.Add(new Clientes() { Nome = "Carlos", Sobrenome = "Eduardo" });
            ListaClientes.Add(new Clientes() { Nome = "Ana", Sobrenome = "Flávia" });

            return View(ListaClientes);
        }
    }
}