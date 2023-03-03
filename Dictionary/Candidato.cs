using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Candidato
    {
        public string Nome { get; set; }
        public int Votos { get; set; }
        public int Urna { get; set; }

        public Candidato(string nome, int votos, int urna)
        {
            Nome = nome;
            Votos = votos;
            Urna = urna;
        }

        public Candidato()
        {

        }
    }
}
