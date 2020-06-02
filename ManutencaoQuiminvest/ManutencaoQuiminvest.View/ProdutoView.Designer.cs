namespace ManutencaoQuiminvest.View
{
    partial class ProdutoView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvarProduto = new System.Windows.Forms.Button();
            this.GrdProduto = new System.Windows.Forms.DataGridView();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producaoDataSet = new ManutencaoQuiminvest.View.ProducaoDataSet();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeMaterial = new System.Windows.Forms.Label();
            this.TxtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.TxtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.produtoTableAdapter = new ManutencaoQuiminvest.View.ProducaoDataSetTableAdapters.ProdutoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(602, 398);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 14;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(521, 398);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 13;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click_1);
            // 
            // BtnSalvarProduto
            // 
            this.BtnSalvarProduto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalvarProduto.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarProduto.Image")));
            this.BtnSalvarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarProduto.Location = new System.Drawing.Point(359, 398);
            this.BtnSalvarProduto.Name = "BtnSalvarProduto";
            this.BtnSalvarProduto.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarProduto.TabIndex = 11;
            this.BtnSalvarProduto.Text = "Salvar";
            this.BtnSalvarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarProduto.UseVisualStyleBackColor = true;
            this.BtnSalvarProduto.Click += new System.EventHandler(this.BtnSalvarProduto_Click_1);
            // 
            // GrdProduto
            // 
            this.GrdProduto.AutoGenerateColumns = false;
            this.GrdProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrdProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnAlterar,
            this.BtnExcluir,
            this.idDataGridViewTextBoxColumn,
            this.produtosDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.fabricanteDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.modeloDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.GrdProduto.DataSource = this.produtoBindingSource;
            this.GrdProduto.Location = new System.Drawing.Point(19, 99);
            this.GrdProduto.Name = "GrdProduto";
            this.GrdProduto.Size = new System.Drawing.Size(655, 293);
            this.GrdProduto.TabIndex = 14;
            this.GrdProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProduto_CellContentClick_1);
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
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
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
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // produtosDataGridViewTextBoxColumn
            // 
            this.produtosDataGridViewTextBoxColumn.DataPropertyName = "Produtos";
            this.produtosDataGridViewTextBoxColumn.HeaderText = "Produtos";
            this.produtosDataGridViewTextBoxColumn.Name = "produtosDataGridViewTextBoxColumn";
            this.produtosDataGridViewTextBoxColumn.Width = 120;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // fabricanteDataGridViewTextBoxColumn
            // 
            this.fabricanteDataGridViewTextBoxColumn.DataPropertyName = "Fabricante";
            this.fabricanteDataGridViewTextBoxColumn.HeaderText = "Fabricante";
            this.fabricanteDataGridViewTextBoxColumn.Name = "fabricanteDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Forcenecedor";
            this.dataGridViewTextBoxColumn8.HeaderText = "Forcenecedor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn9.HeaderText = "Data";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn10.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.producaoDataSet;
            // 
            // producaoDataSet
            // 
            this.producaoDataSet.DataSetName = "ProducaoDataSet";
            this.producaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefone.Location = new System.Drawing.Point(96, 71);
            this.TxtTelefone.Mask = "(##)#####-####";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(124, 22);
            this.TxtTelefone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(336, 69);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(124, 21);
            this.txtModelo.TabIndex = 7;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(96, 42);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(124, 21);
            this.txtTipo.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(466, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(208, 54);
            this.txtDescricao.TabIndex = 8;
            this.txtDescricao.Text = "";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(336, 42);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(124, 21);
            this.txtFornecedor.TabIndex = 6;
            // 
            // txtFabricante
            // 
            this.txtFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFabricante.Location = new System.Drawing.Point(336, 15);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(124, 21);
            this.txtFabricante.TabIndex = 5;
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(96, 15);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(124, 21);
            this.txtProduto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fabricante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fornecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo:";
            // 
            // TxtNomeMaterial
            // 
            this.TxtNomeMaterial.AutoSize = true;
            this.TxtNomeMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeMaterial.Location = new System.Drawing.Point(21, 15);
            this.TxtNomeMaterial.Name = "TxtNomeMaterial";
            this.TxtNomeMaterial.Size = new System.Drawing.Size(69, 20);
            this.TxtNomeMaterial.TabIndex = 0;
            this.TxtNomeMaterial.Text = "Produto:";
            // 
            // TxtHoraEntrada
            // 
            this.TxtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHoraEntrada.Location = new System.Drawing.Point(217, 402);
            this.TxtHoraEntrada.Mask = "00:00";
            this.TxtHoraEntrada.Name = "TxtHoraEntrada";
            this.TxtHoraEntrada.Size = new System.Drawing.Size(59, 21);
            this.TxtHoraEntrada.TabIndex = 10;
            this.TxtHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDataEntrada
            // 
            this.TxtDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataEntrada.Location = new System.Drawing.Point(67, 402);
            this.TxtDataEntrada.Mask = "##/##/####";
            this.TxtDataEntrada.Name = "TxtDataEntrada";
            this.TxtDataEntrada.Size = new System.Drawing.Size(90, 21);
            this.TxtDataEntrada.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 79;
            this.label8.Text = "Data:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Location = new System.Drawing.Point(440, 398);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 431);
            this.panel1.TabIndex = 84;
            // 
            // ProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 451);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.TxtHoraEntrada);
            this.Controls.Add(this.TxtDataEntrada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvarProduto);
            this.Controls.Add(this.GrdProduto);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeMaterial);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProdutoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProdutoView_FormClosed);
            this.Load += new System.EventHandler(this.ProdutoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvarProduto;
        private System.Windows.Forms.DataGridView GrdProduto;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtNomeMaterial;
        //private System.Windows.Forms.BindingSource produtoBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn produtosDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.MaskedTextBox TxtHoraEntrada;
        private System.Windows.Forms.MaskedTextBox TxtDataEntrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        //private System.Windows.Forms.BindingSource produtoBindingSource2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn forcenecedorDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnImprimir;
        private ProducaoDataSet producaoDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private ProducaoDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Panel panel1;
    }
}

