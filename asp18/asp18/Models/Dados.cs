using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp18.Models
{
    // Criada para simular um database
    public static class Dados
    {
        //para praticar criamos uma lista estatica simulando um database
        private static List<Cliente> ListaCliente = new List<Cliente>();

        //metodo para termos acesso aos dados da lista de clientes (IEnumerable)     
        public static IEnumerable<Cliente> TodosOsClientes()
        {
            return ListaCliente;
        }
        // metodo para adicionar uma novo Cliente
        public static void AdicionarCliente(Cliente item)
        {
            // Atribuir Id ao item
            /*
             * item.Id
             * item.Nome
             * item.Telefone
             */
            item.Id = 0;
            if (ListaCliente.Count != 0)
            {
                // LAST para devolver o ultimo elemento de uma sequencia
                item.Id = ListaCliente.Last<Cliente>().Id + 1;/* essa expressão captura o ultimo id adicionado
                e incrementa mais um, para evitar problemas de duplicidade de id.*/
            }
            ListaCliente.Add(item);
        }
        //metodo para deletar um cliente
        public static void ApagarCliente(int id)
        {
            // Solicitando o primeiro cliente que esteja dentro da seguite expressão
            var item = ListaCliente.First<Cliente>(i => i.Id == id); // id precisa ser igual ao id fornecido
            ListaCliente.Remove(item);
        }

        // metodo para pegar os dados de um cliente espcifico e devolve para ao controller para usa atualização
        public static Cliente DadosCliente(int id)
        {
            // Selecionar de uma lista o id que é igual ao id informado
            var cliente = ListaCliente.Where(i => i.Id == id).FirstOrDefault();
            return cliente;
        }
        // Metodo para edtar clientes(Utilizando a linguagem link)
        public static void EditarCliente(Cliente c)
        {
            // Primeiro devemos buscar o cliente selecionado e depois informar o novo estado dele
            ListaCliente.Where(i => i.Id == c.Id).First().Nome = c.Nome;//Com isso pegamos os valores do clinte C e bustituimos apos comparação 
            ListaCliente.Where(i => i.Id == c.Id).First().Telefone = c.Telefone;
        }

    }
}
