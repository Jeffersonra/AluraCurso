using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaCorrente : Conta
    {
        public override void Atualiza(double taxa)
        {
            base.Atualiza(2 * taxa);
        }

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

        public override void Deposita(double valor)
        {
            if (valor > 0)
              {
                Saldo += valor;
             }
        }

    }
}
