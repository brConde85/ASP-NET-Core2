using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp17Foreach.Models;

namespace asp17Foreach.Controllers
{
    public class HomeController : Controller
    {
        // Definição da lista de dados
        List<Clientes> ListaCliente;
        // Criação de um método construtor para homeController
        public HomeController()
        {
            ListaCliente = new List<Clientes>()
            {
                new Clientes(){ Id = 0, Nome = "Bruno", SobreNome = "Marciano"},
                new Clientes(){ Id = 1, Nome = "Bruna", SobreNome = "Coelho"},
                new Clientes(){ Id = 2, Nome = "Leonardo", SobreNome = "Granola"},
                new Clientes(){ Id = 3, Nome = "Loire", SobreNome = "Carmem"},
                new Clientes(){ Id = 4, Nome = "Abner", SobreNome = "Marciano"}
            };

        }
        public IActionResult Index()
        {                
            return View(ListaCliente);
        }
        public ViewResult Detalhes(int id)
        {
            return View(ListaCliente[id]);
        }
    }
}