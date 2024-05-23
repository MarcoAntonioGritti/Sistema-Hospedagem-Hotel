using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSistemaHospedagem.Common
{
    public class Pessoa
    {
        
        private string nome;
        private string sobrenome;

        public string Nome{get;set;}

        public Pessoa(string N)
        {
            Nome = N;
        }
    }
}
