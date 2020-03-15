using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app2.Models
{
    // Definimos a classe como estática para podermos guardar uma informção temporariamente em uma lista
    // obs: foi realizado dessa forma pois ainda não foi criado um banco para guardar essas informações permanentemente
    public static class Repositorio
    {
        // Assim que a aplicação estiver sendo executada senda a classe static será feita a instanciação da LISTA
        // Além da lista ser iniciada de forma vazia
        private static List<RespostaConvidados> LISTA = new List<RespostaConvidados>();

        // Método para criação de convidados para lista de convidados
        public static void AdicionarResposta(RespostaConvidados resposta)// esse metodo permite adicionar a lista um objeto do tipo RespostaConvidados
        {
            LISTA.Add(resposta);
        }

        // Método para buscar  as Respostas do usuário
        // uma maneira de encapsular a lista
        public static IEnumerable<RespostaConvidados>ListaFinal //OBS: IEnumerable PARA CRIAR UMA COLEÇÃO QUE POSSA SER OBJETO DE UM FOR-IT
        {
            // GET para devolver um objeto do tipo: IEnumerable<RespostaConvidados>
            get
            {
                return LISTA;
            }
        }
    }
}
