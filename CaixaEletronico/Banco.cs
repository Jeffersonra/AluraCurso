using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Banco
    {
        //string[] banco = new string[5];

        //public void adiciona(string valor)
        //{
        //    banco[0] = valor
        //}

        private Conta[] contas = new Conta[10];

        public int quantidade;

        public void adiciona(Conta conta)
        {
            this.contas[this.quantidade] = conta;
            this.quantidade++;
        }
    }
}
