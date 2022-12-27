using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
   
    
    public class Produto
    {
        private int _quantidade { get; set; }
        private string? _nome { get; set; }
        private double _preco { get; }

        public string GetNome()
        {
            return _nome;
        }

        public string SetNome(string nome)
        {
            return _nome = nome;
        }
    }
}
