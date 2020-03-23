using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp19.Models;

namespace asp19.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Apresneta a menu inicial
            return View();
        }
        public IActionResult ListaClientes()
        {
            //Apresenta a lista de Clientes da aplicação
            return View(Dados.TodosClientes());
        }
        public IActionResult AdicionarCliente()
        {
            //Adicionar novo cliente
            return View();
        }
        // metodo para guardar o cliente adicionado na view para inserção no Model
        [HttpPost]
        public IActionResult AdicionarCliente(Cliente cliente)
        {   //depois dos dados tratados pela variavel será carregado o mesmo formulario para adição de novos clientes 
            //guardar os dados do nosso cliente
            Dados.AdicionarCliente(cliente);
            return RedirectToAction("AdicionarCliente");
        }
        // Metodo para pegar o id do cliente que será usado em nossa view para edição de Clientes
        public IActionResult EditarCliente(int id)
        {

        }
    }
}