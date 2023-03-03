using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Pessoa
    {
        public string NomePessoa { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nomePessoa, int idade)
        {
            NomePessoa = nomePessoa;
            Idade = idade;
        }

        public Pessoa()
        {

        }
    }
}
