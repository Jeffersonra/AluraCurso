﻿using System;
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
        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
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
    }
}