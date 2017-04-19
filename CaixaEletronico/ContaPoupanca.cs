using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaPoupanca : Conta
    {
        // saca poupança
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
                    Saldo -= valor + 0.1;
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
                        Saldo -= valor + 0.1;
                        return true;
                    }
                }

            }

        }
        //deposita
        public override void Deposita(Double valor)
        {
            if (valor > 0)
            {
                Saldo += valor + 0.1;
            }

        }
    }
}
