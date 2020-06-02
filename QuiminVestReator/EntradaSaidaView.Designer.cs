namespace QuiminVestReator
{
    partial class EntradaSaidaView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaSaidaView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoraSaida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKmEntrada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.txtKmSaida = new System.Windows.Forms.TextBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvarEntradaSaida = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.GrdVeiculo = new System.Windows.Forms.DataGridView();
            this.entradaSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.funcionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaSaidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino:";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(672, 38);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(116, 20);
            this.txtDestino.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Km.Saída:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Km.Entrada:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(672, 12);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(77, 20);
            this.txtData.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Placa:";
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Location = new System.Drawing.Point(367, 12);
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(70, 20);
            this.txtHoraSaida.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Veículo:";
            // 
            // txtKmEntrada
            // 
            this.txtKmEntrada.Location = new System.Drawing.Point(537, 38);
            this.txtKmEntrada.Name = "txtKmEntrada";
            this.txtKmEntrada.Size = new System.Drawing.Size(70, 20);
            this.txtKmEntrada.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hora de Saída;";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Funcionário:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hora de Entrada:";
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(74, 38);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtVeiculo.TabIndex = 16;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(220, 38);
            this.TxtPlaca.Mask = "###-####";
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(55, 20);
            this.TxtPlaca.TabIndex = 40;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(537, 12);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(70, 20);
            this.txtHoraEntrada.TabIndex = 41;
            // 
            // txtKmSaida
            // 
            this.txtKmSaida.Location = new System.Drawing.Point(367, 38);
            this.txtKmSaida.Name = "txtKmSaida";
            this.txtKmSaida.Size = new System.Drawing.Size(70, 20);
            this.txtKmSaida.TabIndex = 42;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(637, 408);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 66;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvarEntradaSaida
            // 
            this.BtnSalvarEntradaSaida.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarEntradaSaida.Image")));
            this.BtnSalvarEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarEntradaSaida.Location = new System.Drawing.Point(556, 408);
            this.BtnSalvarEntradaSaida.Name = "BtnSalvarEntradaSaida";
            this.BtnSalvarEntradaSaida.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarEntradaSaida.TabIndex = 65;
            this.BtnSalvarEntradaSaida.Text = "Salvar";
            this.BtnSalvarEntradaSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarEntradaSaida.UseVisualStyleBackColor = true;
            this.BtnSalvarEntradaSaida.Click += new System.EventHandler(this.BtnSalvarEntradaSaida_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(718, 408);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 64;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(74, 12);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(201, 21);
            this.cbFuncionario.TabIndex = 67;
            // 
            // GrdVeiculo
            // 
            this.GrdVeiculo.AutoGenerateColumns = false;
            this.GrdVeiculo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrdVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.BtnAlterar,
            this.Excluir,
            this.funcionarioDataGridViewTextBoxColumn,
            this.veiculoDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.horaEntradaDataGridViewTextBoxColumn,
            this.horaSaidaDataGridViewTextBoxColumn,
            this.kmEntradaDataGridViewTextBoxColumn,
            this.kmSaidaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn});
            this.GrdVeiculo.DataSource = this.entradaSaidaBindingSource;
            this.GrdVeiculo.Location = new System.Drawing.Point(6, 73);
            this.GrdVeiculo.Name = "GrdVeiculo";
            this.GrdVeiculo.Size = new System.Drawing.Size(787, 329);
            this.GrdVeiculo.TabIndex = 68;
            this.GrdVeiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdVeiculo_CellContentClick);
            // 
            // reatorDataSet2
            // 
            // 
            // entradaSaidaBindingSource
            // 
            this.entradaSaidaBindingSource.DataMember = "EntradaSaida";
            // 
            // entradaSaidaTableAdapter
            // 
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DataPropertyName = "BtnAlterar";
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.ReadOnly = true;
            this.BtnAlterar.Width = 50;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Width = 50;
            // 
            // funcionarioDataGridViewTextBoxColumn
            // 
            this.funcionarioDataGridViewTextBoxColumn.DataPropertyName = "Funcionario";
            this.funcionarioDataGridViewTextBoxColumn.HeaderText = "Funcionario";
            this.funcionarioDataGridViewTextBoxColumn.Name = "funcionarioDataGridViewTextBoxColumn";
            // 
            // veiculoDataGridViewTextBoxColumn
            // 
            this.veiculoDataGridViewTextBoxColumn.DataPropertyName = "Veiculo";
            this.veiculoDataGridViewTextBoxColumn.HeaderText = "Veiculo";
            this.veiculoDataGridViewTextBoxColumn.Name = "veiculoDataGridViewTextBoxColumn";
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            // 
            // horaEntradaDataGridViewTextBoxColumn
            // 
            this.horaEntradaDataGridViewTextBoxColumn.DataPropertyName = "HoraEntrada";
            this.horaEntradaDataGridViewTextBoxColumn.HeaderText = "HoraEntrada";
            this.horaEntradaDataGridViewTextBoxColumn.Name = "horaEntradaDataGridViewTextBoxColumn";
            // 
            // horaSaidaDataGridViewTextBoxColumn
            // 
            this.horaSaidaDataGridViewTextBoxColumn.DataPropertyName = "HoraSaida";
            this.horaSaidaDataGridViewTextBoxColumn.HeaderText = "HoraSaida";
            this.horaSaidaDataGridViewTextBoxColumn.Name = "horaSaidaDataGridViewTextBoxColumn";
            // 
            // kmEntradaDataGridViewTextBoxColumn
            // 
            this.kmEntradaDataGridViewTextBoxColumn.DataPropertyName = "KmEntrada";
            this.kmEntradaDataGridViewTextBoxColumn.HeaderText = "KmEntrada";
            this.kmEntradaDataGridViewTextBoxColumn.Name = "kmEntradaDataGridViewTextBoxColumn";
            // 
            // kmSaidaDataGridViewTextBoxColumn
            // 
            this.kmSaidaDataGridViewTextBoxColumn.DataPropertyName = "KmSaida";
            this.kmSaidaDataGridViewTextBoxColumn.HeaderText = "KmSaida";
            this.kmSaidaDataGridViewTextBoxColumn.Name = "kmSaidaDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            // 
            // EntradaSaidaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrdVeiculo);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvarEntradaSaida);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.txtKmSaida);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKmEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EntradaSaidaView";
            this.Text = "Entrada e Saída de Veiculos";
            this.Load += new System.EventHandler(this.EntradaSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaSaidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoraSaida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKmEntrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.MaskedTextBox TxtPlaca;
        private System.Windows.Forms.TextBox txtHoraEntrada;
        private System.Windows.Forms.TextBox txtKmSaida;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvarEntradaSaida;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.DataGridView GrdVeiculo;
        private System.Windows.Forms.BindingSource entradaSaidaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
    }
}