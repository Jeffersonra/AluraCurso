namespace CaixaEletronico
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.textNumeroConta = new System.Windows.Forms.TextBox();
            this.Depositar = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textAgencia = new System.Windows.Forms.TextBox();
            this.Sacar = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboTransfere = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTranfere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(97, 77);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(211, 20);
            this.textTitular.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caixa Eletônico - Alura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Títular: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Conta: ";
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(97, 129);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(211, 20);
            this.textSaldo.TabIndex = 9;
            // 
            // textNumeroConta
            // 
            this.textNumeroConta.Location = new System.Drawing.Point(97, 103);
            this.textNumeroConta.Name = "textNumeroConta";
            this.textNumeroConta.Size = new System.Drawing.Size(211, 20);
            this.textNumeroConta.TabIndex = 10;
            // 
            // Depositar
            // 
            this.Depositar.Location = new System.Drawing.Point(7, 323);
            this.Depositar.Name = "Depositar";
            this.Depositar.Size = new System.Drawing.Size(105, 32);
            this.Depositar.TabIndex = 11;
            this.Depositar.Text = "Depositar";
            this.Depositar.UseVisualStyleBackColor = true;
            this.Depositar.Click += new System.EventHandler(this.Depositar_Click);
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(7, 297);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(105, 20);
            this.textValor.TabIndex = 12;
            this.textValor.Text = "0";
            this.textValor.TextChanged += new System.EventHandler(this.textValor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor:  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Agência: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textAgencia
            // 
            this.textAgencia.Location = new System.Drawing.Point(97, 155);
            this.textAgencia.Name = "textAgencia";
            this.textAgencia.Size = new System.Drawing.Size(211, 20);
            this.textAgencia.TabIndex = 15;
            // 
            // Sacar
            // 
            this.Sacar.Location = new System.Drawing.Point(118, 323);
            this.Sacar.Name = "Sacar";
            this.Sacar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sacar.Size = new System.Drawing.Size(105, 32);
            this.Sacar.TabIndex = 16;
            this.Sacar.Text = "Sacar";
            this.Sacar.UseVisualStyleBackColor = true;
            this.Sacar.Click += new System.EventHandler(this.Sacar_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(97, 181);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(211, 21);
            this.comboContas.TabIndex = 17;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(35, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Titular: ";
            // 
            // comboTransfere
            // 
            this.comboTransfere.FormattingEnabled = true;
            this.comboTransfere.Location = new System.Drawing.Point(60, 252);
            this.comboTransfere.Name = "comboTransfere";
            this.comboTransfere.Size = new System.Drawing.Size(211, 21);
            this.comboTransfere.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(4, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Para:  ";
            // 
            // btnTranfere
            // 
            this.btnTranfere.Location = new System.Drawing.Point(277, 245);
            this.btnTranfere.Name = "btnTranfere";
            this.btnTranfere.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTranfere.Size = new System.Drawing.Size(92, 32);
            this.btnTranfere.TabIndex = 21;
            this.btnTranfere.Text = "Transferir";
            this.btnTranfere.UseVisualStyleBackColor = true;
            this.btnTranfere.Click += new System.EventHandler(this.btnTranfere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 368);
            this.Controls.Add(this.btnTranfere);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboTransfere);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.Sacar);
            this.Controls.Add(this.textAgencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.Depositar);
            this.Controls.Add(this.textNumeroConta);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTitular);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Caixa Eletrônico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.TextBox textNumeroConta;
        private System.Windows.Forms.Button Depositar;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAgencia;
        private System.Windows.Forms.Button Sacar;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTransfere;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTranfere;
    }
}

