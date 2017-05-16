using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public Cliente Titular { get; set; }

        public double Saldo { get; protected set; }

        public int Numero { get; set; }

        public int agencia { get; set; }

        public int tipo { get; set; } // 1 = corrente & 2 = poupança

        // metodo saca
        public virtual bool Saca(double valor)
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

        // metodo deposita
        public virtual void Deposita(Double valor)
        {
            if(valor > 0)
            {
                Saldo += valor;
            }
            
        }

        // metodo transfere
        public virtual bool Transfere(double valor, Conta destino)
        {
            
            bool saque = this.Saca(valor);

            if (saque)
            {
                destino.Deposita(valor);
                return true;
            }
            else
            {
                return false;
            }
        }

        // metodo calcula rendimento
        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = Saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - Saldo;

            return rendimento;
        }

        //atualiza conta
        public virtual void Atualiza(double taxa)
        {
            this.Saldo += this.Saldo * taxa;
        }
    }
}
