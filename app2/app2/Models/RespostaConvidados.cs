using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app2.Models
{
    public class RespostaConvidados
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool? Presente { get; set; } 
        // bool com ponto de interrogação permite um terceiro valor:
        //"first->true, second-> false and third-> null."

        
    }
}
