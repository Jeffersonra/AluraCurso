using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDev.CaixaEletronico.Contas
{
    class ContaPoupanca : Conta, ITributavel
    {
        // saca poupança
        public override bool Saca(double valor)
        {
            try
            {
                if (valor < 0)
                {
                    throw new Exception();
                }
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
            catch
            {
                return false;
            }
            

        }
        //deposita
        public override void Deposita(Double valor)
        {
            if (valor > 0)
            {
                Saldo += valor - 0.1;
            }

        }

        // calcula rendimento
        public void CalculaRendimento()
        {
            this.Saldo += 100;
        }

        public override void Atualiza(double taxa)
        {
           base.Atualiza(3 * taxa);
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }

    }
}
