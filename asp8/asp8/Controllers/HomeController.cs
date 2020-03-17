using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp8.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace asp8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Criar um homem, inserindo e preenchendo os atributos
            Humano homem= new Humano()
            {
                nome = "Bruno", sobrenome = "Marciano", idade = 34
            };

            // Criar um carro, inserindo e preenchendo os atributos 
            Automovel carro = new Automovel() 
            {
                marca ="Ford", cor = "Preto", ano = "1996"
            };

            // Inserindo homem e carro dentro da classe ou pacote para podermos exibilos dentro da view
            Bag data = new Bag()
            {
                humano = homem, automovel = carro
            };

            // Passando "data" como parametro como retorno para que assim possamos carregar os atributos na view/index
            
            return View(data);
        }
    }
}