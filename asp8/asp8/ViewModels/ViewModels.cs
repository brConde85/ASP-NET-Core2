using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp8.ViewModels
{
    // aqui foi criado um ficheiro para conter as classes
    public class Humano
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
    }
    public class Automovel
    {
        public string Ano { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }

    }
    // Criação de um aglutinador para carregar os atributos gerais
    public class Bag 
    { 
       public Humano Humano { get; set; }
       public Automovel Automovel { get; set; }
    };
}
