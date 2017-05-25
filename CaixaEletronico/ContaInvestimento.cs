using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDev.CaixaEletronico.Contas
{
    class ContaInvestimento : Conta, ITributavel
    {
        // Class Abstract saca Necessita ser criada toda vez que a classe for herdada da class Conta
        public override bool Saca(double valor)
        {
            if (Saldo <= 0 || Saldo < valor)
            {
                return false;
            }
            else
            {
                if (Titular.EhMaiorDeIdade())
                {
                    Saldo -= valor;
                    return true;
                }
                else
                {
                    if (valor >= 200)
                    {

                        return false;
                    }
                    else
                    {
                        Saldo -= valor;
                        return true;
                    }
                }

            }
        }
        // Class Abstract Deposita Necessita ser criada toda vez que a classe for herdada da class Conta
        public override void Deposita(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }
     
}
