using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class TotalizadorDeContas
    {
        public double Total { get; private set; }

        public void Adiciona(Conta c)
        {
            this.Total += c.Saldo;
        }

        public void Adiciona(ContaPoupanca c)
        {
            this.Total += c.Saldo;
            //c.CalculaRendimento(c.Saldo);
        }
    }
}
