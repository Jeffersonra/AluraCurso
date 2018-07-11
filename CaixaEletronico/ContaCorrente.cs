using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffDev.CaixaEletronico.Contas
{
    class ContaCorrente : Conta
    {
        public override void Atualiza(double taxa)
        {
            base.Atualiza(2 * taxa);
        }

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
            catch
            {
                return false;
            }
            
        }

        public override void Deposita(double valor)
        {
            if (valor > 0)
              {
                Saldo += valor;
             }
        }

        public void transferi(double valor)
        {
            var teste = "teste";
        }
         
    }
}
