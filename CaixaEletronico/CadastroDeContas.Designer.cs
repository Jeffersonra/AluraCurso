namespace JeffDev.CaixaEletronico
{
    partial class CadastroDeContas
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
            this.btnInserirConta = new System.Windows.Forms.Button();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtNumeroDaConta = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblNumeroConta = new System.Windows.Forms.Label();
            this.cbTipoConta = new System.Windows.Forms.ComboBox();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInserirConta
            // 
            this.btnInserirConta.Location = new System.Drawing.Point(59, 205);
            this.btnInserirConta.Name = "btnInserirConta";
            this.btnInserirConta.Size = new System.Drawing.Size(75, 23);
            this.btnInserirConta.TabIndex = 0;
            this.btnInserirConta.Text = "Inserir";
            this.btnInserirConta.UseVisualStyleBackColor = true;
            this.btnInserirConta.Click += new System.EventHandler(this.btnInserirConta_Click);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(25, 67);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 1;
            // 
            // txtNumeroDaConta
            // 
            this.txtNumeroDaConta.Location = new System.Drawing.Point(25, 114);
            this.txtNumeroDaConta.Name = "txtNumeroDaConta";
            this.txtNumeroDaConta.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDaConta.TabIndex = 2;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(25, 48);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // lblNumeroConta
            // 
            this.lblNumeroConta.AutoSize = true;
            this.lblNumeroConta.Location = new System.Drawing.Point(25, 98);
            this.lblNumeroConta.Name = "lblNumeroConta";
            this.lblNumeroConta.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroConta.TabIndex = 4;
            this.lblNumeroConta.Text = "Numero da Conta";
            // 
            // cbTipoConta
            // 
            this.cbTipoConta.FormattingEnabled = true;
            this.cbTipoConta.Items.AddRange(new object[] {
            "Corrente",
            "Pupança"});
            this.cbTipoConta.Location = new System.Drawing.Point(25, 155);
            this.cbTipoConta.Name = "cbTipoConta";
            this.cbTipoConta.Size = new System.Drawing.Size(121, 21);
            this.cbTipoConta.TabIndex = 5;
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Location = new System.Drawing.Point(25, 137);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(76, 13);
            this.lblTipoConta.TabIndex = 6;
            this.lblTipoConta.Text = "Tipo De Conta";
            // 
            // CadastroDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTipoConta);
            this.Controls.Add(this.cbTipoConta);
            this.Controls.Add(this.lblNumeroConta);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.txtNumeroDaConta);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.btnInserirConta);
            this.Name = "CadastroDeContas";
            this.Text = "CadastroDeContas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserirConta;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtNumeroDaConta;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblNumeroConta;
        private System.Windows.Forms.ComboBox cbTipoConta;
        private System.Windows.Forms.Label lblTipoConta;
    }
}