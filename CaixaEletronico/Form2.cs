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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Conta[] contas;

        private void Form2_Load(object sender, EventArgs e)
        {
            //contas = new Conta[3];

            //Conta contaDoVictor = new Conta();
            //contaDoVictor.Titular.Nome = "Victor";
            //contaDoVictor.Numero = 1;
            //contas[0] = contaDoVictor;

            //Conta contaDoGuilherme = new Conta();
            //contaDoGuilherme.Titular.Nome = "Guilherme";
            //contaDoGuilherme.Numero = 2;
            //contas[1] = contaDoGuilherme;

            //Conta contaDoMauricio = new Conta();
            //contaDoMauricio.Titular.Nome = "Mauricio";
            //contaDoMauricio.Numero = 3;
            //contas[2] = contaDoMauricio;

            //foreach (Conta c in contas)
            //{
            //    comboContas.Items.Add(c.Titular);
            //}
        }
    }
}
