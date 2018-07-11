using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JeffDev.CaixaEletronico.Contas;
using JeffDev.CaixaEletronico.Clientes;

namespace JeffDev.CaixaEletronico
{
    public partial class CadastroDeContas : Form
    {
        private Form1 aplicacaoPrincipal;
        public CadastroDeContas(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void btnInserirConta_Click(object sender, EventArgs e)
        {
            string titular = txtTitular.Text;
            int numero = Convert.ToInt32(txtNumeroDaConta.Text);

            Conta conta = null;

            if (cbTipoConta.Text.Equals("Corrente"))
            {
                conta = new ContaCorrente();
            }
            else
            {
                conta = new ContaPoupanca();
            }

            conta.Numero = numero;
            conta.Titular = new Cliente() { Nome = titular };

            this.aplicacaoPrincipal.AdicionarConta(conta);
        }
    }
}
