using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        private Conta conta;

        private void MostraConta()
        {
            textTitular.Text = conta.Titular.Nome;
            textNumeroConta.Text = Convert.ToString(conta.Numero);
            textSaldo.Text = Convert.ToString(conta.Saldo);
            textAgencia.Text = Convert.ToString(conta.agencia);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region testebutton
            //Conta jose = new Conta();
            //Conta romero = new Conta();

            //jose.saldo = 1500;
            //romero.saldo = 2000;

            ////saca
            //jose.Saca(200);
            //MessageBox.Show("Saca - Saldo jose: " + jose.saldo);

            ////deposita
            //jose.Deposita(200);
            //MessageBox.Show("Deposita - Saldo jose: " + jose.saldo);

            ////transfere
            //jose.Transfere(200, romero);
            //MessageBox.Show("Transfere - Saldo jose: " + jose.saldo + "\nTransfere - Saldo romero: " + romero.saldo);

            //Conta conta = new Conta();

            //Cliente cliente = new Cliente();
            //conta.Titular = cliente;


            //cliente.nome = "Jefferson Rodrigues";
            //conta.Titular.rg = "47227937-3";
            //cliente.idade = 17;

            //conta.Deposita(500);
            //conta.Saca(20);

            //MessageBox.Show("Nome cliente: " + conta.Titular.nome + "\nRG: " + cliente.rg +"\nSaldo: " + conta.Saldo);


            //Conta conta2 = new Conta();

            //Cliente clienteAndresa = new Cliente();

            //conta2.Titular = clienteAndresa;

            //clienteAndresa.nome = "Andresa Soad";
            //clienteAndresa.rg = "12345678-9";
            //cliente.idade = 25;
            //conta2.Deposita(150);
            //conta2.Saca(150);

            //MessageBox.Show("Nome cliente: " + conta2.Titular.nome + "\nRG: " + clienteAndresa.rg + "\nSaldo: " + conta2.Saldo);

            //Conta contaGuilherme = new Conta();
            //contaGuilherme.Numero = 1;
            //contaGuilherme.Deposita(1500.0);

            //Cliente clienteGuilherme = new Cliente();
            //clienteGuilherme.nome = "Guilherme";
            //clienteGuilherme.idade = 17;

            //contaGuilherme.Titular = clienteGuilherme;

            //bool sacou = contaGuilherme.Saca(300.0);//testando idade
            //if (sacou)
            //{
            //    MessageBox.Show("Saldo da Conta do Guilherme após saque: " + contaGuilherme.Saldo);
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possível sacar da conta do Guilherme");
            //}


            //Cliente cliente = new Cliente("Jefferson") { rg = "47227937-3", idade = 25, cpf = "358526778-50", endereco = "Taboão da serra" };


            //MessageBox.Show("Cliente: " + cliente.Nome + "\nRG: " + cliente.rg + "\nCPF: " + cliente.cpf + "\nIdade: " + cliente.idade + "\nEndereço: " + cliente.endereco);

            //ContaPoupanca cp = new ContaPoupanca() { Numero = 100 };

            //cp.Deposita(200);

            //MessageBox.Show(Convert.ToString("Saldo conta poupança: " + cp.Saldo));

            //Conta c1 = new ContaPoupanca();
            //c1.Titular = new Cliente("Jeff") { idade = 18 };
            //c1.Deposita(100.0);
            //c1.Saca(50.0);
            //MessageBox.Show("conta poupança = " + c1.Saldo);

            //Conta c2 = new Conta();
            //c2.Titular = new Cliente("Jeffs") { idade = 18 };
            //c2.Deposita(100.0);
            //c2.Saca(50.0);
            //MessageBox.Show("conta = " + c2.Saldo);


            //Conta c1 = new Conta();
            //c1.Deposita(10);

            //TotalizadorDeContas t = new TotalizadorDeContas();
            //t.Adiciona(c1);

            //MessageBox.Show("Totalizador é " + t.Total);

            //ContaPoupanca c2 = new ContaPoupanca();
            //c2.Deposita(15);

            //t.Adiciona(c2);
            //MessageBox.Show("Totalizador é " + t.Total);

            //Conta c = new Conta();
            //ContaCorrente cc = new ContaCorrente();
            //ContaPoupanca cp = new ContaPoupanca();

            //c.Deposita(1000.0);
            //cc.Deposita(1000.0);
            //cp.Deposita(1000.0);

            //AtualizadorDeContas atualizador = new AtualizadorDeContas(0.01);
            //atualizador.Roda(c);
            //atualizador.Roda(cc);
            //atualizador.Roda(cp);

            //MessageBox.Show("c = " + c.Saldo);
            //MessageBox.Show("cc = " + cc.Saldo);
            //MessageBox.Show("cp = " + cp.Saldo);
            #endregion testebutton


            //int[] numeoros = new int[5];
            //numeoros[0] = 55;
            //numeoros[1] = 1;
            //numeoros[2] = 10;
            //numeoros[3] = 20;
            //numeoros[4] = 30;

            //for (int i = 0; i <= 4; i++)
            //    {
            //        MessageBox.Show("numero da Array; " + numeoros[i]);
            //    }

            //Conta[] contas = new Conta[2];
            //contas[0] = new Conta();
            //contas[1] = new ContaPoupanca();

            //contas[0].Deposita(100);
            //contas[1].Deposita(150);

            ////for (int i = 0; i < contas.Length; i++)
            ////{
            ////    MessageBox.Show("o Saldo da conta é: " + contas[i].Saldo);
            ////}


            //foreach(Conta conta in contas) // O foreach - passa por todos os elementos
            //{
            //    MessageBox.Show("o Saldo da conta é: " + conta.Saldo);
            //}


            //Conta[] banco = new Conta[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    banco[i] = new Conta();
            //    banco[i].Numero = (i + 1) * 100;
            //    Console.WriteLine(banco[i].Numero);
            //}

            //string[] nomes = new string[] { "mauricio", "mario", "victor", "william", "guilherme" };
            //string concatenacao = "";
            //foreach (string nome in nomes)
            //{
            //    concatenacao += " " + nome;
            //}
            //MessageBox.Show(concatenacao);


            Banco banco = new Banco();

            banco.adiciona(conta);
            banco.adiciona(conta);
            banco.adiciona(conta);
            banco.adiciona(conta);

            MessageBox.Show(banco.quantidade.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            conta = new Conta() { Numero = 010197543, agencia = 2225 };
            conta.Titular = new Cliente("Jefferson Rodrigues");
            MostraConta();

        }

        private void Depositar_Click(object sender, EventArgs e)
        {

            conta.Deposita(Convert.ToDouble(textValor.Text));
            MessageBox.Show("Deposito Realizado!");
            textValor.Text = "";
            MostraConta();

        }

        #region Form

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }



        #endregion Form

        private void Sacar_Click(object sender, EventArgs e)
        {
            bool saque = conta.Saca(Convert.ToDouble(textValor.Text));

            if (saque)
            {
                MessageBox.Show("Saque Realizado!");
                textValor.Text = "";
            }
            else
            {
                MessageBox.Show("Não foi possível sacar da conta do " + conta.Titular.Nome);
                textValor.Text = "";
            }

            MostraConta();
        }

        private void textValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
