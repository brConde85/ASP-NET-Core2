using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp10.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("home")]
        [Route("home/index")]
        public string Index()
        {
            return "Estou no index";
        }

        // para informar uma nova rota nesse caso onde esamos precisando de um id        
        /* Obs: Desta forma foi informando ao sistema que irá ser inserido um id 
         * no browser caso ele não seja informado a pag não irá carregar {id}*/
         /*Caso seja inserido dessa forma {id?} ele não será obrigatorio.*/
        [Route("home/post2/{id?}")]
        public string acao1(int id)
        {
            // não foi necesario inserir .ToString() após o id porque inicialmente foi definido na classe
            return "Estou na ação 1, id: " + id;
        }
        // Definindo uma diretiva Route para seguir uma caminho predeterminado
        [Route("home/post")]
        public string acao2()
        {
            return "Estou na ação 2 Nova ";

        }

        [Route("home/adicionar/{nome?}/{sobrenome?}")]
        // Passando como parâmetro o id para inserção no browser 
        public string add(string nome, string sobrenome)
        {
            //Ex.:https://localhost:44399/home/adicionar/Bruno/Marciano 
            return ("Estou adicionando meu nome: "+ nome + " " + sobrenome );
        }
        // Adicionando route para receber valores e apresentar sua soma
        [Route("home/parcela/{x?}/{y?}")]
        public string parcel(int x, int y)
        {
            //Ex.: https://localhost:44399/home/parcela/12/15
            return "Soma das parcelas: " + x +" + "+ y + " = "+ (x + y).ToString();
        }
    }
}