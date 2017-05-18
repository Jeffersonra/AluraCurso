using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    abstract class Conta
    {

        public Conta()
        {
            Conta.TotalDeContas++;
        }

        public static int TotalDeContas { get; private set; }

        public Cliente Titular { get; set; }

        public double Saldo { get; protected set; }

        public int Numero { get; set; }

        public int agencia { get; set; }

        public int tipo { get; set; } // 1 = corrente & 2 = poupança

        // metodo saca
        public abstract bool Saca(double valor);

        // metodo deposita
        public abstract void Deposita(Double valor);
        

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

        //Proximo Numero da conta
        public static int ProximoNumeroConta()
        {
            return Conta.TotalDeContas + 1;
        }
    
    }
}
