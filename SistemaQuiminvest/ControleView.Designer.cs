namespace SistemaQuiminvest
{
    partial class ControleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEtapa = new System.Windows.Forms.ComboBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtVolDestilado = new System.Windows.Forms.TextBox();
            this.txtCaldeira = new System.Windows.Forms.TextBox();
            this.txtReator = new System.Windows.Forms.TextBox();
            this.txtFluido = new System.Windows.Forms.TextBox();
            this.txtPressao = new System.Windows.Forms.TextBox();
            this.txtAgitacao = new System.Windows.Forms.TextBox();
            this.txtAmperagem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvarControle = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.GrdControle = new System.Windows.Forms.DataGridView();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etapaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volDestiladoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caldeiraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fluidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressaoMmHgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agitacaoRpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amperagemADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quiminvestDataSetControle = new SistemaQuiminvest.QuiminvestDataSetControle();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.controleTableAdapter = new SistemaQuiminvest.QuiminvestDataSetControleTableAdapters.controleTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbAmostra = new System.Windows.Forms.ComboBox();
            this.txtQtdFormol = new System.Windows.Forms.TextBox();
            this.txtHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiminvestDataSetControle)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(21, 13);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(53, 16);
            this.Label.TabIndex = 0;
            this.Label.Text = "Etapa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Volume Destilado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Caldeira:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Reator:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fluído:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Pressão (mm Hg):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(270, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Agitação (RPM):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(488, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Amperagem (A):";
            // 
            // cbEtapa
            // 
            this.cbEtapa.FormattingEnabled = true;
            this.cbEtapa.Items.AddRange(new object[] {
            "Adição 1° parte de paraformol",
            "Adição 2° parte de paraformol",
            "Adição 3° parte de paraformol",
            "Amostra",
            "Amostra PH",
            "Carregamento Fenol",
            "Carregamento Oxálico",
            "Check List",
            "Descarga",
            "Destilação",
            "Fim Exotérmico",
            "Formol Isento",
            "Limpeza",
            "Transferência"});
            this.cbEtapa.Location = new System.Drawing.Point(80, 12);
            this.cbEtapa.Name = "cbEtapa";
            this.cbEtapa.Size = new System.Drawing.Size(355, 21);
            this.cbEtapa.TabIndex = 1;
            this.cbEtapa.SelectedIndexChanged += new System.EventHandler(this.cbEtapa_SelectedIndexChanged);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(114, 42);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(44, 20);
            this.txtHora.TabIndex = 3;
            // 
            // txtVolDestilado
            // 
            this.txtVolDestilado.Location = new System.Drawing.Point(643, 12);
            this.txtVolDestilado.Name = "txtVolDestilado";
            this.txtVolDestilado.Size = new System.Drawing.Size(45, 20);
            this.txtVolDestilado.TabIndex = 9;
            // 
            // txtCaldeira
            // 
            this.txtCaldeira.Location = new System.Drawing.Point(107, 101);
            this.txtCaldeira.Name = "txtCaldeira";
            this.txtCaldeira.Size = new System.Drawing.Size(64, 20);
            this.txtCaldeira.TabIndex = 17;
            // 
            // txtReator
            // 
            this.txtReator.Location = new System.Drawing.Point(273, 101);
            this.txtReator.Name = "txtReator";
            this.txtReator.Size = new System.Drawing.Size(64, 20);
            this.txtReator.TabIndex = 19;
            // 
            // txtFluido
            // 
            this.txtFluido.Location = new System.Drawing.Point(418, 101);
            this.txtFluido.Name = "txtFluido";
            this.txtFluido.Size = new System.Drawing.Size(64, 20);
            this.txtFluido.TabIndex = 21;
            // 
            // txtPressao
            // 
            this.txtPressao.Location = new System.Drawing.Point(168, 149);
            this.txtPressao.Name = "txtPressao";
            this.txtPressao.Size = new System.Drawing.Size(64, 20);
            this.txtPressao.TabIndex = 23;
            // 
            // txtAgitacao
            // 
            this.txtAgitacao.Location = new System.Drawing.Point(397, 149);
            this.txtAgitacao.Name = "txtAgitacao";
            this.txtAgitacao.Size = new System.Drawing.Size(64, 20);
            this.txtAgitacao.TabIndex = 25;
            // 
            // txtAmperagem
            // 
            this.txtAmperagem.Location = new System.Drawing.Point(614, 148);
            this.txtAmperagem.Name = "txtAmperagem";
            this.txtAmperagem.Size = new System.Drawing.Size(64, 20);
            this.txtAmperagem.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 318);
            this.dataGridView1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Temperatura C°";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(533, 414);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 31;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvarControle
            // 
            this.BtnSalvarControle.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarControle.Image")));
            this.BtnSalvarControle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarControle.Location = new System.Drawing.Point(371, 414);
            this.BtnSalvarControle.Name = "BtnSalvarControle";
            this.BtnSalvarControle.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarControle.TabIndex = 29;
            this.BtnSalvarControle.Text = "Salvar";
            this.BtnSalvarControle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarControle.UseVisualStyleBackColor = true;
            this.BtnSalvarControle.Click += new System.EventHandler(this.BtnSalvarControle_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(614, 414);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 32;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // GrdControle
            // 
            this.GrdControle.AutoGenerateColumns = false;
            this.GrdControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdControle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnAlterar,
            this.BtnExcluir,
            this.idDataGridViewTextBoxColumn,
            this.etapaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.volDestiladoDataGridViewTextBoxColumn,
            this.caldeiraDataGridViewTextBoxColumn,
            this.reatorDataGridViewTextBoxColumn,
            this.fluidoDataGridViewTextBoxColumn,
            this.pressaoMmHgDataGridViewTextBoxColumn,
            this.agitacaoRpmDataGridViewTextBoxColumn,
            this.amperagemADataGridViewTextBoxColumn});
            this.GrdControle.DataSource = this.controleBindingSource;
            this.GrdControle.Location = new System.Drawing.Point(12, 175);
            this.GrdControle.Name = "GrdControle";
            this.GrdControle.Size = new System.Drawing.Size(676, 233);
            this.GrdControle.TabIndex = 28;
            this.GrdControle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdControle_CellContentClick);
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // etapaDataGridViewTextBoxColumn
            // 
            this.etapaDataGridViewTextBoxColumn.DataPropertyName = "Etapa";
            this.etapaDataGridViewTextBoxColumn.HeaderText = "Etapa";
            this.etapaDataGridViewTextBoxColumn.Name = "etapaDataGridViewTextBoxColumn";
            this.etapaDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // volDestiladoDataGridViewTextBoxColumn
            // 
            this.volDestiladoDataGridViewTextBoxColumn.DataPropertyName = "VolDestilado";
            this.volDestiladoDataGridViewTextBoxColumn.HeaderText = "VolDestilado";
            this.volDestiladoDataGridViewTextBoxColumn.Name = "volDestiladoDataGridViewTextBoxColumn";
            // 
            // caldeiraDataGridViewTextBoxColumn
            // 
            this.caldeiraDataGridViewTextBoxColumn.DataPropertyName = "Caldeira";
            this.caldeiraDataGridViewTextBoxColumn.HeaderText = "Caldeira";
            this.caldeiraDataGridViewTextBoxColumn.Name = "caldeiraDataGridViewTextBoxColumn";
            // 
            // reatorDataGridViewTextBoxColumn
            // 
            this.reatorDataGridViewTextBoxColumn.DataPropertyName = "Reator";
            this.reatorDataGridViewTextBoxColumn.HeaderText = "Reator";
            this.reatorDataGridViewTextBoxColumn.Name = "reatorDataGridViewTextBoxColumn";
            // 
            // fluidoDataGridViewTextBoxColumn
            // 
            this.fluidoDataGridViewTextBoxColumn.DataPropertyName = "Fluido";
            this.fluidoDataGridViewTextBoxColumn.HeaderText = "Fluido";
            this.fluidoDataGridViewTextBoxColumn.Name = "fluidoDataGridViewTextBoxColumn";
            // 
            // pressaoMmHgDataGridViewTextBoxColumn
            // 
            this.pressaoMmHgDataGridViewTextBoxColumn.DataPropertyName = "PressaoMmHg";
            this.pressaoMmHgDataGridViewTextBoxColumn.HeaderText = "PressaoMmHg";
            this.pressaoMmHgDataGridViewTextBoxColumn.Name = "pressaoMmHgDataGridViewTextBoxColumn";
            // 
            // agitacaoRpmDataGridViewTextBoxColumn
            // 
            this.agitacaoRpmDataGridViewTextBoxColumn.DataPropertyName = "AgitacaoRpm";
            this.agitacaoRpmDataGridViewTextBoxColumn.HeaderText = "AgitacaoRpm";
            this.agitacaoRpmDataGridViewTextBoxColumn.Name = "agitacaoRpmDataGridViewTextBoxColumn";
            // 
            // amperagemADataGridViewTextBoxColumn
            // 
            this.amperagemADataGridViewTextBoxColumn.DataPropertyName = "AmperagemA";
            this.amperagemADataGridViewTextBoxColumn.HeaderText = "AmperagemA";
            this.amperagemADataGridViewTextBoxColumn.Name = "amperagemADataGridViewTextBoxColumn";
            // 
            // controleBindingSource
            // 
            this.controleBindingSource.DataMember = "controle";
            this.controleBindingSource.DataSource = this.quiminvestDataSetControle;
            // 
            // quiminvestDataSetControle
            // 
            this.quiminvestDataSetControle.DataSetName = "QuiminvestDataSetControle";
            this.quiminvestDataSetControle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Location = new System.Drawing.Point(452, 414);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // controleTableAdapter
            // 
            this.controleTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(180, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Hora Fim:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(450, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "N° de Amostra  Retiradas:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(462, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Qtd de Formol Utilizado:";
            // 
            // cbAmostra
            // 
            this.cbAmostra.FormattingEnabled = true;
            this.cbAmostra.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbAmostra.Location = new System.Drawing.Point(643, 37);
            this.cbAmostra.Name = "cbAmostra";
            this.cbAmostra.Size = new System.Drawing.Size(45, 21);
            this.cbAmostra.TabIndex = 11;
            // 
            // txtQtdFormol
            // 
            this.txtQtdFormol.Location = new System.Drawing.Point(643, 64);
            this.txtQtdFormol.Name = "txtQtdFormol";
            this.txtQtdFormol.Size = new System.Drawing.Size(45, 20);
            this.txtQtdFormol.TabIndex = 13;
            this.txtQtdFormol.VisibleChanged += new System.EventHandler(this.txtQtdFormol_VisibleChanged);
            // 
            // txtHoraFim
            // 
            this.txtHoraFim.Location = new System.Drawing.Point(261, 42);
            this.txtHoraFim.Mask = "00:00";
            this.txtHoraFim.Name = "txtHoraFim";
            this.txtHoraFim.Size = new System.Drawing.Size(44, 20);
            this.txtHoraFim.TabIndex = 5;
            this.txtHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(371, 42);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(64, 20);
            this.txtData.TabIndex = 7;
            // 
            // ControleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.txtHoraFim);
            this.Controls.Add(this.txtQtdFormol);
            this.Controls.Add(this.cbAmostra);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.GrdControle);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvarControle);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAmperagem);
            this.Controls.Add(this.txtAgitacao);
            this.Controls.Add(this.txtPressao);
            this.Controls.Add(this.txtFluido);
            this.Controls.Add(this.txtReator);
            this.Controls.Add(this.txtCaldeira);
            this.Controls.Add(this.txtVolDestilado);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.cbEtapa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControleView_FormClosed);
            this.Load += new System.EventHandler(this.Controle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiminvestDataSetControle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbEtapa;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtVolDestilado;
        private System.Windows.Forms.TextBox txtCaldeira;
        private System.Windows.Forms.TextBox txtReator;
        private System.Windows.Forms.TextBox txtFluido;
        private System.Windows.Forms.TextBox txtPressao;
        private System.Windows.Forms.TextBox txtAgitacao;
        private System.Windows.Forms.TextBox txtAmperagem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvarControle;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView GrdControle;
        private System.Windows.Forms.Button btnImprimir;
        private QuiminvestDataSetControle quiminvestDataSetControle;
        private System.Windows.Forms.BindingSource controleBindingSource;
        private QuiminvestDataSetControleTableAdapters.controleTableAdapter controleTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etapaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volDestiladoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caldeiraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fluidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressaoMmHgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agitacaoRpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amperagemADataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbAmostra;
        private System.Windows.Forms.TextBox txtQtdFormol;
        private System.Windows.Forms.MaskedTextBox txtHoraFim;
        private System.Windows.Forms.TextBox txtData;
    }
}