using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDev.CaixaEletronico.Clientes
{
    public class Cliente
    {
        
        public string Nome;

        public string rg;

        public string cpf;

        public string endereco;

        public int idade;

        public bool EEmancipado { get; set; }

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

        public bool PodeAbrirConta()
        {
            var maiorDeIdade = (this.idade >= 18);
            var emancipado = (this.EEmancipado);
            var temCpf = !string.IsNullOrEmpty(this.cpf);

            return (maiorDeIdade || emancipado) && temCpf;
        }
    }
}
