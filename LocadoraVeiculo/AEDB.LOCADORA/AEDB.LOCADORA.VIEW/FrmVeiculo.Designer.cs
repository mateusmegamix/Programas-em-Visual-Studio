namespace AEDB.LOCADORA.VIEW
{
    partial class FrmVeiculo
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
            this.LblCodVeiculo = new System.Windows.Forms.Label();
            this.LblModelo = new System.Windows.Forms.Label();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.LblAno = new System.Windows.Forms.Label();
            this.LblCor = new System.Windows.Forms.Label();
            this.LblValor = new System.Windows.Forms.Label();
            this.TxtCodVeiculo = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtCor = new System.Windows.Forms.TextBox();
            this.TxtAno = new System.Windows.Forms.MaskedTextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GrdVeiculo = new System.Windows.Forms.DataGridView();
            this.CodVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodVeiculo
            // 
            this.LblCodVeiculo.AutoSize = true;
            this.LblCodVeiculo.Location = new System.Drawing.Point(59, 14);
            this.LblCodVeiculo.Name = "LblCodVeiculo";
            this.LblCodVeiculo.Size = new System.Drawing.Size(43, 13);
            this.LblCodVeiculo.TabIndex = 0;
            this.LblCodVeiculo.Text = "Código:";
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Location = new System.Drawing.Point(58, 43);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(45, 13);
            this.LblModelo.TabIndex = 0;
            this.LblModelo.Text = "Modelo:";
            // 
            // LblPlaca
            // 
            this.LblPlaca.AutoSize = true;
            this.LblPlaca.Location = new System.Drawing.Point(65, 73);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(37, 13);
            this.LblPlaca.TabIndex = 0;
            this.LblPlaca.Text = "Placa:";
            // 
            // LblAno
            // 
            this.LblAno.AutoSize = true;
            this.LblAno.Location = new System.Drawing.Point(73, 97);
            this.LblAno.Name = "LblAno";
            this.LblAno.Size = new System.Drawing.Size(29, 13);
            this.LblAno.TabIndex = 0;
            this.LblAno.Text = "Ano:";
            // 
            // LblCor
            // 
            this.LblCor.AutoSize = true;
            this.LblCor.Location = new System.Drawing.Point(76, 125);
            this.LblCor.Name = "LblCor";
            this.LblCor.Size = new System.Drawing.Size(26, 13);
            this.LblCor.TabIndex = 0;
            this.LblCor.Text = "Cor:";
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Location = new System.Drawing.Point(69, 154);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(34, 13);
            this.LblValor.TabIndex = 0;
            this.LblValor.Text = "Valor:";
            // 
            // TxtCodVeiculo
            // 
            this.TxtCodVeiculo.Location = new System.Drawing.Point(109, 14);
            this.TxtCodVeiculo.Name = "TxtCodVeiculo";
            this.TxtCodVeiculo.Size = new System.Drawing.Size(66, 20);
            this.TxtCodVeiculo.TabIndex = 1;
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(109, 40);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(149, 20);
            this.TxtModelo.TabIndex = 1;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(109, 70);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(66, 20);
            this.TxtPlaca.TabIndex = 1;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(109, 148);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(100, 20);
            this.TxtValor.TabIndex = 1;
            // 
            // TxtCor
            // 
            this.TxtCor.Location = new System.Drawing.Point(109, 122);
            this.TxtCor.Name = "TxtCor";
            this.TxtCor.Size = new System.Drawing.Size(100, 20);
            this.TxtCor.TabIndex = 1;
            // 
            // TxtAno
            // 
            this.TxtAno.Location = new System.Drawing.Point(109, 97);
            this.TxtAno.Mask = "0000";
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(34, 20);
            this.TxtAno.TabIndex = 2;
            this.TxtAno.ValidatingType = typeof(System.DateTime);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(63, 186);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(67, 48);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(158, 186);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(70, 48);
            this.BtnFechar.TabIndex = 3;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // GrdVeiculo
            // 
            this.GrdVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodVeiculo,
            this.Modelo,
            this.Placa,
            this.Ano,
            this.Cor,
            this.Valor,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdVeiculo.Location = new System.Drawing.Point(16, 268);
            this.GrdVeiculo.Name = "GrdVeiculo";
            this.GrdVeiculo.Size = new System.Drawing.Size(648, 150);
            this.GrdVeiculo.TabIndex = 4;
            // 
            // CodVeiculo
            // 
            this.CodVeiculo.DataPropertyName = "CodVeiculo";
            this.CodVeiculo.HeaderText = "Código";
            this.CodVeiculo.Name = "CodVeiculo";
            this.CodVeiculo.ReadOnly = true;
            this.CodVeiculo.Width = 50;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 150;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 50;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            this.Ano.Width = 50;
            // 
            // Cor
            // 
            this.Cor.DataPropertyName = "Cor";
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DataPropertyName = "BtnAlterar";
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Width = 50;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.DataPropertyName = "BtnExcluir";
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Width = 50;
            // 
            // FrmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.GrdVeiculo);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtAno);
            this.Controls.Add(this.TxtCor);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.TxtCodVeiculo);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.LblCor);
            this.Controls.Add(this.LblAno);
            this.Controls.Add(this.LblPlaca);
            this.Controls.Add(this.LblModelo);
            this.Controls.Add(this.LblCodVeiculo);
            this.Name = "FrmVeiculo";
            this.Text = "Cadastro de Veículo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVeiculo_FormClosed);
            this.Load += new System.EventHandler(this.FrmVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodVeiculo;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.Label LblAno;
        private System.Windows.Forms.Label LblCor;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.TextBox TxtCodVeiculo;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtCor;
        private System.Windows.Forms.MaskedTextBox TxtAno;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataGridView GrdVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
    }
}