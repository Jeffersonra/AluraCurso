using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente
    {
        
        public string Nome;

        public string rg;

        public string cpf;

        public string endereco;

        public int idade;

        public bool EhMaiorDeIdade()
        {
            return idade >= 18; 
        }

        
        // construtor
        public Cliente(string nome)
        {
            Nome = nome;
        }

        public Cliente() { }
    }
}
