using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp18.Models;

namespace asp18.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // view de entrada que apresente um titulo, a lista de clientes ou a mensagem 
            //indicando que não existem clientes

            return View(Dados.TodosOsClientes());
        }

        // Criação de dois métodos uma para apresentar um formulário e o outro para pocessar os dados que vem do formulário
        public IActionResult NovoCliente()
        {
            // Apresenta um formulário para um novo cliente 
            return View();
        }
        [HttpPost]
        // Metodo para redirecionar para ação a Index
        public IActionResult NovoCliente(Cliente item)
        {
            //Pede ao Model que adicione um novo cliente para a coleção... caso seja possivel(caso o cliente não exista no sistema)
            Dados.AdicionarCliente(item);
            // Esse metodo faz com que ao salvar um novo cliente nos iremos retornar a Index principal
            return RedirectToAction("Index");
        }
        
        // formulário está relacionada com o model
        public IActionResult Apagar(int id)
        {
            // realizar uma requisição ao model solicitando a ação de deletar o cliente informado
            Dados.ApagarCliente(id);

            return RedirectToAction("Index");
        }
        //Metodo para Update do cliente carregando todos os seus dados para atualização 
        public IActionResult Editar(int id)
        {
            // apresentar um aview
            return View(Dados.DadosCliente(id));
        }
        [HttpPost]
        //Criado para alterar os dados do cliente
        public IActionResult Editar(Cliente c)
        {
            Dados.EditarCliente(c);
            return RedirectToAction("Index");
        }
    }
}