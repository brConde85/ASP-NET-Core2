using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp19.Models
{
    public static class Dados
    {
        //Dados da aplicação(simulando um database)
        private static List<Cliente> ListaCliente = new List<Cliente>();

        public static List<Cliente> TodosClientes()
        {
            //todos os clientes da apliacação
            return ListaCliente;
        }
        //Metodo pérmite guardar os clientes na database
        public static void AdicionarCliente(Cliente clienteTemp)
        {
            //buscar o id disponível DO CLIENTE sendo que vamos pegar o ultimo id e acrescentar e somar mais 1 para não repetir o id
            int id = 0;
            if (ListaCliente.Count != 0)
            {
                id = ListaCliente.Last<Cliente>().Id + 1;
            }
            //guardar os dados do novo cliente
            clienteTemp.Id = id;
            ListaCliente.Add(clienteTemp);           
        }
    }
}
