namespace BAYERPET.VIEW
{
    partial class Frmbayerpet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbayerpet));
            this.GridBayer = new System.Windows.Forms.GroupBox();
            this.horaentrada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataentrada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CarregaGrid = new System.Windows.Forms.DataGridView();
            this.Clicodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pdataentrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phoraentrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSaidass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataSaidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.horasaida = new System.Windows.Forms.TextBox();
            this.datasaida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CboPet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GridBayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarregaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GridBayer
            // 
            this.GridBayer.Controls.Add(this.horaentrada);
            this.GridBayer.Controls.Add(this.label8);
            this.GridBayer.Controls.Add(this.dataentrada);
            this.GridBayer.Controls.Add(this.label7);
            this.GridBayer.Controls.Add(this.CarregaGrid);
            this.GridBayer.Controls.Add(this.CboCliente);
            this.GridBayer.Controls.Add(this.label6);
            this.GridBayer.Controls.Add(this.horasaida);
            this.GridBayer.Controls.Add(this.datasaida);
            this.GridBayer.Controls.Add(this.label5);
            this.GridBayer.Controls.Add(this.label4);
            this.GridBayer.Controls.Add(this.CboPet);
            this.GridBayer.Controls.Add(this.label3);
            this.GridBayer.Controls.Add(this.TxtCodCliente);
            this.GridBayer.Controls.Add(this.label2);
            this.GridBayer.Location = new System.Drawing.Point(12, 12);
            this.GridBayer.Name = "GridBayer";
            this.GridBayer.Size = new System.Drawing.Size(806, 335);
            this.GridBayer.TabIndex = 0;
            this.GridBayer.TabStop = false;
            this.GridBayer.Text = "Pets";
            this.GridBayer.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // horaentrada
            // 
            this.horaentrada.Location = new System.Drawing.Point(256, 72);
            this.horaentrada.Name = "horaentrada";
            this.horaentrada.Size = new System.Drawing.Size(60, 20);
            this.horaentrada.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hora Entrada :";
            // 
            // dataentrada
            // 
            this.dataentrada.Location = new System.Drawing.Point(106, 72);
            this.dataentrada.Name = "dataentrada";
            this.dataentrada.Size = new System.Drawing.Size(70, 20);
            this.dataentrada.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Data Entrada :";
            // 
            // CarregaGrid
            // 
            this.CarregaGrid.AllowUserToAddRows = false;
            this.CarregaGrid.AllowUserToDeleteRows = false;
            this.CarregaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarregaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clicodigo,
            this.Pnome,
            this.Pdataentrada,
            this.Phoraentrada,
            this.DataSaidass,
            this.DataSaidas,
            this.Valor,
            this.Funcionario});
            this.CarregaGrid.Location = new System.Drawing.Point(0, 102);
            this.CarregaGrid.Name = "CarregaGrid";
            this.CarregaGrid.Size = new System.Drawing.Size(803, 233);
            this.CarregaGrid.TabIndex = 2;
            this.CarregaGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarregaGrid_CellContentClick);
            // 
            // Clicodigo
            // 
            this.Clicodigo.DataPropertyName = "Clicodigo";
            this.Clicodigo.HeaderText = "Codigo Cliente";
            this.Clicodigo.Name = "Clicodigo";
            this.Clicodigo.ReadOnly = true;
            // 
            // Pnome
            // 
            this.Pnome.DataPropertyName = "Pnome";
            this.Pnome.HeaderText = "Nome do Pet";
            this.Pnome.Name = "Pnome";
            this.Pnome.ReadOnly = true;
            // 
            // Pdataentrada
            // 
            this.Pdataentrada.DataPropertyName = "Pdataentrada";
            this.Pdataentrada.HeaderText = "Data Entrada";
            this.Pdataentrada.Name = "Pdataentrada";
            this.Pdataentrada.ReadOnly = true;
            // 
            // Phoraentrada
            // 
            this.Phoraentrada.DataPropertyName = "Phorasaida";
            this.Phoraentrada.HeaderText = "Hora Entrada";
            this.Phoraentrada.Name = "Phoraentrada";
            this.Phoraentrada.ReadOnly = true;
            // 
            // DataSaidass
            // 
            this.DataSaidass.HeaderText = "Data Saída";
            this.DataSaidass.Name = "DataSaidass";
            this.DataSaidass.ReadOnly = true;
            // 
            // DataSaidas
            // 
            this.DataSaidas.HeaderText = "Hora Saída";
            this.DataSaidas.Name = "DataSaidas";
            this.DataSaidas.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 60;
            // 
            // Funcionario
            // 
            this.Funcionario.HeaderText = "Funcionário";
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.ReadOnly = true;
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(309, 17);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(311, 21);
            this.CboCliente.TabIndex = 2;
            this.CboCliente.SelectedIndexChanged += new System.EventHandler(this.CboCliente_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome do Cliente :";
            // 
            // horasaida
            // 
            this.horasaida.Location = new System.Drawing.Point(560, 72);
            this.horasaida.Name = "horasaida";
            this.horasaida.Size = new System.Drawing.Size(60, 20);
            this.horasaida.TabIndex = 7;
            // 
            // datasaida
            // 
            this.datasaida.Location = new System.Drawing.Point(396, 71);
            this.datasaida.Name = "datasaida";
            this.datasaida.Size = new System.Drawing.Size(70, 20);
            this.datasaida.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hora Saída :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Saída :";
            // 
            // CboPet
            // 
            this.CboPet.FormattingEnabled = true;
            this.CboPet.Location = new System.Drawing.Point(106, 43);
            this.CboPet.Name = "CboPet";
            this.CboPet.Size = new System.Drawing.Size(350, 21);
            this.CboPet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Animal :";
            // 
            // TxtCodCliente
            // 
            this.TxtCodCliente.Location = new System.Drawing.Point(106, 17);
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.Size = new System.Drawing.Size(100, 20);
            this.TxtCodCliente.TabIndex = 0;
            this.TxtCodCliente.Leave += new System.EventHandler(this.TxtCodCliente_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo do Cliente :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor Total:";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Location = new System.Drawing.Point(720, 356);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(85, 20);
            this.TxtValorTotal.TabIndex = 0;
            this.TxtValorTotal.Text = "0,00";
            this.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtValorTotal.TextChanged += new System.EventHandler(this.TxtValorTotal_TextChanged);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(12, 353);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 1;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frmbayerpet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 388);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.TxtValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridBayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmbayerpet";
            this.Text = "Bayer Pet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmbayerpet_FormClosed);
            this.Load += new System.EventHandler(this.Frmbayerpet_Load);
            this.GridBayer.ResumeLayout(false);
            this.GridBayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarregaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GridBayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboPet;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.TextBox datasaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView CarregaGrid;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox horasaida;
        private System.Windows.Forms.TextBox horaentrada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dataentrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clicodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pdataentrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phoraentrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSaidass;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSaidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionario;
    }
}