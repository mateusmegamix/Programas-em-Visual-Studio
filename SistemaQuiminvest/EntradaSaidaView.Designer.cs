namespace SistemaQuiminvest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaSaidaView));
            this.GrdVeiculo = new System.Windows.Forms.DataGridView();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.funcionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quiminvestDataSetEntradaSaida = new SistemaQuiminvest.QuiminvestDataSetEntradaSaida();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvarEntradaSaida = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.txtKmSaida = new System.Windows.Forms.TextBox();
            this.TxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKmEntrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.entradaSaidaTableAdapter = new SistemaQuiminvest.QuiminvestDataSetEntradaSaidaTableAdapters.EntradaSaidaTableAdapter();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.txtHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaSaidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiminvestDataSetEntradaSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdVeiculo
            // 
            this.GrdVeiculo.AutoGenerateColumns = false;
            this.GrdVeiculo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.GrdVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnAlterar,
            this.BtnExcluir,
            this.funcionarioDataGridViewTextBoxColumn,
            this.veiculoDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.horaEntradaDataGridViewTextBoxColumn,
            this.horaSaidaDataGridViewTextBoxColumn,
            this.kmEntradaDataGridViewTextBoxColumn,
            this.kmSaidaDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GrdVeiculo.DataSource = this.entradaSaidaBindingSource;
            this.GrdVeiculo.Location = new System.Drawing.Point(12, 70);
            this.GrdVeiculo.Name = "GrdVeiculo";
            this.GrdVeiculo.Size = new System.Drawing.Size(787, 329);
            this.GrdVeiculo.TabIndex = 18;
            this.GrdVeiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdVeiculo_CellContentClick);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DataPropertyName = "BtnAlterar";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            this.BtnAlterar.DefaultCellStyle = dataGridViewCellStyle1;
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.ReadOnly = true;
            this.BtnAlterar.Width = 50;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.DataPropertyName = "BtnExcluir";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.BtnExcluir.DefaultCellStyle = dataGridViewCellStyle2;
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.ReadOnly = true;
            this.BtnExcluir.Width = 50;
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
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Id";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Id";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Id";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Id";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // entradaSaidaBindingSource
            // 
            this.entradaSaidaBindingSource.DataMember = "EntradaSaida";
            this.entradaSaidaBindingSource.DataSource = this.quiminvestDataSetEntradaSaida;
            // 
            // quiminvestDataSetEntradaSaida
            // 
            this.quiminvestDataSetEntradaSaida.DataSetName = "QuiminvestDataSetEntradaSaida";
            this.quiminvestDataSetEntradaSaida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(643, 405);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 20;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvarEntradaSaida
            // 
            this.BtnSalvarEntradaSaida.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarEntradaSaida.Image")));
            this.BtnSalvarEntradaSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarEntradaSaida.Location = new System.Drawing.Point(481, 405);
            this.BtnSalvarEntradaSaida.Name = "BtnSalvarEntradaSaida";
            this.BtnSalvarEntradaSaida.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarEntradaSaida.TabIndex = 19;
            this.BtnSalvarEntradaSaida.Text = "Salvar";
            this.BtnSalvarEntradaSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarEntradaSaida.UseVisualStyleBackColor = true;
            this.BtnSalvarEntradaSaida.Click += new System.EventHandler(this.BtnSalvarEntradaSaida_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(724, 405);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 21;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // txtKmSaida
            // 
            this.txtKmSaida.Location = new System.Drawing.Point(373, 35);
            this.txtKmSaida.Name = "txtKmSaida";
            this.txtKmSaida.Size = new System.Drawing.Size(55, 20);
            this.txtKmSaida.TabIndex = 13;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(226, 35);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(55, 20);
            this.TxtPlaca.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Hora de Entrada:";
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(80, 35);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(100, 20);
            this.txtVeiculo.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Funcionário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hora de Saída;";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Veículo:";
            // 
            // txtKmEntrada
            // 
            this.txtKmEntrada.Location = new System.Drawing.Point(543, 35);
            this.txtKmEntrada.Name = "txtKmEntrada";
            this.txtKmEntrada.Size = new System.Drawing.Size(54, 20);
            this.txtKmEntrada.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Km.Entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Km.Saída:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Destino:";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(678, 35);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(116, 20);
            this.txtDestino.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data:";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Location = new System.Drawing.Point(562, 405);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // entradaSaidaTableAdapter
            // 
            this.entradaSaidaTableAdapter.ClearBeforeFill = true;
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Items.AddRange(new object[] {
            "Arnaldo",
            "Glaucio",
            "Hernan",
            "Marcelino",
            "Ruy",
            "Sebastião"});
            this.cbFuncionario.Location = new System.Drawing.Point(80, 9);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(201, 21);
            this.cbFuncionario.TabIndex = 23;
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Location = new System.Drawing.Point(373, 9);
            this.txtHoraSaida.Mask = "00:00";
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(55, 20);
            this.txtHoraSaida.TabIndex = 24;
            this.txtHoraSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(542, 9);
            this.txtHoraEntrada.Mask = "00:00";
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(55, 20);
            this.txtHoraEntrada.TabIndex = 25;
            this.txtHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(678, 9);
            this.txtData.Mask = "##/##/####";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(70, 20);
            this.txtData.TabIndex = 26;
            // 
            // EntradaSaidaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 443);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.cbFuncionario);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.GrdVeiculo);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvarEntradaSaida);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.txtKmSaida);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKmEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EntradaSaidaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada e Saida de Veículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntradaSaidaView_FormClosed);
            this.Load += new System.EventHandler(this.EntradaSaidaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaSaidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiminvestDataSetEntradaSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdVeiculo;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvarEntradaSaida;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox txtKmSaida;
        private System.Windows.Forms.MaskedTextBox TxtPlaca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKmEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.Button btnImprimir;
        private QuiminvestDataSetEntradaSaida quiminvestDataSetEntradaSaida;
        private System.Windows.Forms.BindingSource entradaSaidaBindingSource;
        private QuiminvestDataSetEntradaSaidaTableAdapters.EntradaSaidaTableAdapter entradaSaidaTableAdapter;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.MaskedTextBox txtHoraSaida;
        private System.Windows.Forms.MaskedTextBox txtHoraEntrada;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.MaskedTextBox txtData;
    }
}