using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp8.ViewModels
{
    // aqui foi criado um ficheiro para conter as classes
    public class Humano
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public int idade { get; set; }
    }
    public class Automovel
    {
        public string ano { get; set; }
        public string marca { get; set; }
        public string cor { get; set; }

    }
    // Criação de um aglutinador para carregar os atributos gerais
    public class Bag 
    { 
       public Humano humano { get; set; }
       public Automovel automovel { get; set; }
    };
}
