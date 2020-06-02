namespace ManutencaoQuiminvest.View
{
    partial class EntradaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdEntrada = new System.Windows.Forms.TextBox();
            this.TxtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.TxtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtResponsavelEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeMaterial = new System.Windows.Forms.Label();
            this.GrdEntrada = new System.Windows.Forms.DataGridView();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manutencaoDataSet = new ManutencaoQuiminvest.View.ManutencaoDataSet();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvarControle = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.entradaTableAdapter = new ManutencaoQuiminvest.View.ManutencaoDataSetTableAdapters.EntradaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(362, 42);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(191, 50);
            this.txtDescricao.TabIndex = 87;
            this.txtDescricao.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Descrição:";
            // 
            // cbProduto
            // 
            this.cbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduto.ForeColor = System.Drawing.Color.DarkGray;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(87, 42);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(162, 23);
            this.cbProduto.TabIndex = 1;
            this.cbProduto.Text = "Selecione";
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.cbProduto_SelectedIndexChanged);
            this.cbProduto.TextChanged += new System.EventHandler(this.cbProduto_TextChanged);
            this.cbProduto.Enter += new System.EventHandler(this.cbProduto_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 84;
            this.label8.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 82;
            this.label9.Text = "Produto:";
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(476, 400);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Responsavel:";
            // 
            // txtQtdEntrada
            // 
            this.txtQtdEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdEntrada.Location = new System.Drawing.Point(131, 404);
            this.txtQtdEntrada.Name = "txtQtdEntrada";
            this.txtQtdEntrada.Size = new System.Drawing.Size(67, 21);
            this.txtQtdEntrada.TabIndex = 3;
            // 
            // TxtHoraEntrada
            // 
            this.TxtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHoraEntrada.Location = new System.Drawing.Point(490, 373);
            this.TxtHoraEntrada.Mask = "00:00";
            this.TxtHoraEntrada.Name = "TxtHoraEntrada";
            this.TxtHoraEntrada.Size = new System.Drawing.Size(59, 21);
            this.TxtHoraEntrada.TabIndex = 4;
            this.TxtHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDataEntrada
            // 
            this.TxtDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataEntrada.Location = new System.Drawing.Point(340, 373);
            this.TxtDataEntrada.Mask = "##/##/####";
            this.TxtDataEntrada.Name = "TxtDataEntrada";
            this.TxtDataEntrada.Size = new System.Drawing.Size(90, 21);
            this.TxtDataEntrada.TabIndex = 3;
            // 
            // txtResponsavelEntrada
            // 
            this.txtResponsavelEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsavelEntrada.Location = new System.Drawing.Point(131, 371);
            this.txtResponsavelEntrada.Name = "txtResponsavelEntrada";
            this.txtResponsavelEntrada.Size = new System.Drawing.Size(146, 21);
            this.txtResponsavelEntrada.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Qtd Estoque:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Hora:";
            // 
            // TxtNomeMaterial
            // 
            this.TxtNomeMaterial.AutoSize = true;
            this.TxtNomeMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeMaterial.Location = new System.Drawing.Point(292, 373);
            this.TxtNomeMaterial.Name = "TxtNomeMaterial";
            this.TxtNomeMaterial.Size = new System.Drawing.Size(48, 20);
            this.TxtNomeMaterial.TabIndex = 75;
            this.TxtNomeMaterial.Text = "Data:";
            // 
            // GrdEntrada
            // 
            this.GrdEntrada.AutoGenerateColumns = false;
            this.GrdEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrdEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnAlterar,
            this.BtnExcluir,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.GrdEntrada.DataSource = this.entradaBindingSource;
            this.GrdEntrada.Location = new System.Drawing.Point(12, 98);
            this.GrdEntrada.Name = "GrdEntrada";
            this.GrdEntrada.Size = new System.Drawing.Size(541, 257);
            this.GrdEntrada.TabIndex = 70;
            this.GrdEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdEntrada_CellContentClick);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produtos";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "QtdEstoque";
            this.dataGridViewTextBoxColumn6.HeaderText = "QtdEstoque";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Responsavel";
            this.dataGridViewTextBoxColumn5.HeaderText = "Responsavel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn7.HeaderText = "Data";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn8.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // entradaBindingSource
            // 
            this.entradaBindingSource.DataMember = "Entrada";
            this.entradaBindingSource.DataSource = this.manutencaoDataSet;
            // 
            // manutencaoDataSet
            // 
            this.manutencaoDataSet.DataSetName = "ManutencaoDataSet";
            this.manutencaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(395, 400);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvarControle
            // 
            this.BtnSalvarControle.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarControle.Image")));
            this.BtnSalvarControle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarControle.Location = new System.Drawing.Point(233, 400);
            this.BtnSalvarControle.Name = "BtnSalvarControle";
            this.BtnSalvarControle.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarControle.TabIndex = 4;
            this.BtnSalvarControle.Text = "Entrada";
            this.BtnSalvarControle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarControle.UseVisualStyleBackColor = true;
            this.BtnSalvarControle.Click += new System.EventHandler(this.BtnSalvarControle_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(87, 71);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(162, 21);
            this.txtTipo.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(12, 98);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(91, 20);
            this.txtModelo.TabIndex = 88;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Location = new System.Drawing.Point(314, 400);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // entradaTableAdapter
            // 
            this.entradaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(388, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 20);
            this.button1.TabIndex = 93;
            this.button1.Text = "LIMPAR";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(310, 8);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 20);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.Location = new System.Drawing.Point(58, 8);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.MaxLength = 100;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 20);
            this.txtBuscar.TabIndex = 91;
            this.txtBuscar.Text = "PESQUISE UM PRODUTO";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 94;
            this.label4.Text = "Filtro:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(6, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 403);
            this.panel1.TabIndex = 95;
            this.panel1.Tag = "";
            // 
            // EntradaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdEntrada);
            this.Controls.Add(this.TxtHoraEntrada);
            this.Controls.Add(this.TxtDataEntrada);
            this.Controls.Add(this.txtResponsavelEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeMaterial);
            this.Controls.Add(this.GrdEntrada);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvarControle);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EntradaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntradaView_FormClosed);
            this.Load += new System.EventHandler(this.EntradaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manutencaoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdEntrada;
        private System.Windows.Forms.MaskedTextBox TxtHoraEntrada;
        private System.Windows.Forms.MaskedTextBox TxtDataEntrada;
        private System.Windows.Forms.TextBox txtResponsavelEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtNomeMaterial;
        private System.Windows.Forms.DataGridView GrdEntrada;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvarControle;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtModelo;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn qtdEstoqueDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn responsavelDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnImprimir;
        private ManutencaoDataSet manutencaoDataSet;
        private System.Windows.Forms.BindingSource entradaBindingSource;
        private ManutencaoDataSetTableAdapters.EntradaTableAdapter entradaTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}