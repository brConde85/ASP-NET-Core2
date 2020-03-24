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

        public static Cliente DadosCliente(int id)
        {
            //devolve os dados do cliente selecionado
            Cliente clienteTemp = ListaCliente.Where(i => i.Id == id).FirstOrDefault();
            return clienteTemp;
        }

        public static void EditarCliente(Cliente cliente)
        {
            //editar os dados do cliente selecionado
            ListaCliente.First<Cliente>(i => i.Id == cliente.Id).Nome = cliente.Nome;
            ListaCliente.First<Cliente>(i => i.Id == cliente.Id).SobreNome = cliente.SobreNome;
            ListaCliente.First<Cliente>(i => i.Id == cliente.Id).Telefone = cliente.Telefone;
        }

        public static void ApagarCliente(int id)
        {
            //deletar o cliente selecionado
            var clienteTemp = ListaCliente.First<Cliente>(i => i.Id == id);
            ListaCliente.Remove(clienteTemp);
        }
    }
}
