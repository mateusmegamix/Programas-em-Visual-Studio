namespace APK.DESKTOP.VIEW
{
    partial class FrmFesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFesta));
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnCancelarF = new System.Windows.Forms.Button();
            this.BtnSalvarF = new System.Windows.Forms.Button();
            this.GridFesta = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtUfF = new System.Windows.Forms.TextBox();
            this.TxtDescricaoF = new System.Windows.Forms.RichTextBox();
            this.TxtDateF = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTelefoneF = new System.Windows.Forms.MaskedTextBox();
            this.TxtRuaF = new System.Windows.Forms.TextBox();
            this.TxtBairroF = new System.Windows.Forms.TextBox();
            this.TxtCidadeF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbLoteF = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.TxtReferenciaF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ValorF = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCepF = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtClienteF = new System.Windows.Forms.TextBox();
            this.PbImagem = new System.Windows.Forms.PictureBox();
            this.TxtTipoFesta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnLocalizacao = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.TxtAbrir = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tccDataSetFest = new APK.DESKTOP.VIEW.tccDataSetFest();
            this.cadastroFestaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroFestaTableAdapter = new APK.DESKTOP.VIEW.tccDataSetFestTableAdapters.CadastroFestaTableAdapter();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codigoFestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizacaofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairrofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotofDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridFesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetFest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFestaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(714, 500);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 30;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnCancelarF
            // 
            this.BtnCancelarF.Location = new System.Drawing.Point(712, 277);
            this.BtnCancelarF.Name = "BtnCancelarF";
            this.BtnCancelarF.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarF.TabIndex = 28;
            this.BtnCancelarF.Text = "Cancelar";
            this.BtnCancelarF.UseVisualStyleBackColor = true;
            this.BtnCancelarF.Click += new System.EventHandler(this.BtnCancelarF_Click);
            // 
            // BtnSalvarF
            // 
            this.BtnSalvarF.Location = new System.Drawing.Point(626, 277);
            this.BtnSalvarF.Name = "BtnSalvarF";
            this.BtnSalvarF.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvarF.TabIndex = 27;
            this.BtnSalvarF.Text = "Salvar";
            this.BtnSalvarF.UseVisualStyleBackColor = true;
            this.BtnSalvarF.Click += new System.EventHandler(this.BtnSalvarF_Click);
            // 
            // GridFesta
            // 
            this.GridFesta.AutoGenerateColumns = false;
            this.GridFesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnAlterar,
            this.BtnExcluir,
            this.codigoFestaDataGridViewTextBoxColumn,
            this.localizacaofDataGridViewTextBoxColumn,
            this.ruafDataGridViewTextBoxColumn,
            this.bairrofDataGridViewTextBoxColumn,
            this.cidadefDataGridViewTextBoxColumn,
            this.uffDataGridViewTextBoxColumn,
            this.cepfDataGridViewTextBoxColumn,
            this.fotofDataGridViewImageColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.datafDataGridViewTextBoxColumn,
            this.descricaoEventoDataGridViewTextBoxColumn,
            this.valorfDataGridViewTextBoxColumn,
            this.lotefDataGridViewTextBoxColumn,
            this.descricaoClienteDataGridViewTextBoxColumn,
            this.referenciaFDataGridViewTextBoxColumn,
            this.tipoFDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.GridFesta.DataSource = this.cadastroFestaBindingSource;
            this.GridFesta.Location = new System.Drawing.Point(13, 306);
            this.GridFesta.Name = "GridFesta";
            this.GridFesta.Size = new System.Drawing.Size(776, 188);
            this.GridFesta.TabIndex = 29;
            this.GridFesta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFesta_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(322, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "UF :";
            // 
            // TxtUfF
            // 
            this.TxtUfF.Location = new System.Drawing.Point(355, 95);
            this.TxtUfF.Name = "TxtUfF";
            this.TxtUfF.Size = new System.Drawing.Size(29, 20);
            this.TxtUfF.TabIndex = 11;
            // 
            // TxtDescricaoF
            // 
            this.TxtDescricaoF.Location = new System.Drawing.Point(11, 224);
            this.TxtDescricaoF.Name = "TxtDescricaoF";
            this.TxtDescricaoF.Size = new System.Drawing.Size(406, 76);
            this.TxtDescricaoF.TabIndex = 19;
            this.TxtDescricaoF.Text = "";
            // 
            // TxtDateF
            // 
            this.TxtDateF.Location = new System.Drawing.Point(314, 68);
            this.TxtDateF.Mask = "##/##/####";
            this.TxtDateF.Name = "TxtDateF";
            this.TxtDateF.Size = new System.Drawing.Size(70, 20);
            this.TxtDateF.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(423, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Telefone :";
            // 
            // TxtTelefoneF
            // 
            this.TxtTelefoneF.Location = new System.Drawing.Point(484, 277);
            this.TxtTelefoneF.Mask = "(##)#####-####";
            this.TxtTelefoneF.Name = "TxtTelefoneF";
            this.TxtTelefoneF.Size = new System.Drawing.Size(86, 20);
            this.TxtTelefoneF.TabIndex = 26;
            // 
            // TxtRuaF
            // 
            this.TxtRuaF.Location = new System.Drawing.Point(88, 147);
            this.TxtRuaF.Name = "TxtRuaF";
            this.TxtRuaF.Size = new System.Drawing.Size(219, 20);
            this.TxtRuaF.TabIndex = 15;
            // 
            // TxtBairroF
            // 
            this.TxtBairroF.Location = new System.Drawing.Point(88, 121);
            this.TxtBairroF.Name = "TxtBairroF";
            this.TxtBairroF.Size = new System.Drawing.Size(155, 20);
            this.TxtBairroF.TabIndex = 13;
            // 
            // TxtCidadeF
            // 
            this.TxtCidadeF.Location = new System.Drawing.Point(88, 95);
            this.TxtCidadeF.Name = "TxtCidadeF";
            this.TxtCidadeF.Size = new System.Drawing.Size(109, 20);
            this.TxtCidadeF.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(463, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Evento :";
            // 
            // CbLoteF
            // 
            this.CbLoteF.FormattingEnabled = true;
            this.CbLoteF.Location = new System.Drawing.Point(484, 224);
            this.CbLoteF.Name = "CbLoteF";
            this.CbLoteF.Size = new System.Drawing.Size(38, 21);
            this.CbLoteF.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(220, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data do Evento :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(10, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descrição do Evento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(441, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Lote :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(42, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bairro :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(36, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(49, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rua :";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.ForeColor = System.Drawing.SystemColors.Window;
            this.Nome.Location = new System.Drawing.Point(17, 178);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(65, 13);
            this.Nome.TabIndex = 16;
            this.Nome.Text = "Referencia :";
            // 
            // TxtReferenciaF
            // 
            this.TxtReferenciaF.Location = new System.Drawing.Point(88, 173);
            this.TxtReferenciaF.Name = "TxtReferenciaF";
            this.TxtReferenciaF.Size = new System.Drawing.Size(296, 20);
            this.TxtReferenciaF.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(441, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Valor :";
            // 
            // ValorF
            // 
            this.ValorF.Location = new System.Drawing.Point(484, 251);
            this.ValorF.Mask = "$000,00";
            this.ValorF.Name = "ValorF";
            this.ValorF.Size = new System.Drawing.Size(56, 20);
            this.ValorF.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(207, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "CEP :";
            // 
            // TxtCepF
            // 
            this.TxtCepF.Location = new System.Drawing.Point(247, 95);
            this.TxtCepF.Mask = "#####-###";
            this.TxtCepF.Name = "TxtCepF";
            this.TxtCepF.Size = new System.Drawing.Size(70, 20);
            this.TxtCepF.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(12, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cliente :";
            // 
            // TxtClienteF
            // 
            this.TxtClienteF.Location = new System.Drawing.Point(63, 31);
            this.TxtClienteF.Name = "TxtClienteF";
            this.TxtClienteF.Size = new System.Drawing.Size(180, 20);
            this.TxtClienteF.TabIndex = 1;
            // 
            // PbImagem
            // 
            this.PbImagem.Image = ((System.Drawing.Image)(resources.GetObject("PbImagem.Image")));
            this.PbImagem.Location = new System.Drawing.Point(466, 50);
            this.PbImagem.Name = "PbImagem";
            this.PbImagem.Size = new System.Drawing.Size(321, 160);
            this.PbImagem.TabIndex = 49;
            this.PbImagem.TabStop = false;
            // 
            // TxtTipoFesta
            // 
            this.TxtTipoFesta.Location = new System.Drawing.Point(282, 31);
            this.TxtTipoFesta.Name = "TxtTipoFesta";
            this.TxtTipoFesta.Size = new System.Drawing.Size(135, 20);
            this.TxtTipoFesta.TabIndex = 126;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(248, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 125;
            this.label16.Text = "Tipo :";
            // 
            // BtnLocalizacao
            // 
            this.BtnLocalizacao.Location = new System.Drawing.Point(88, 57);
            this.BtnLocalizacao.Name = "BtnLocalizacao";
            this.BtnLocalizacao.Size = new System.Drawing.Size(119, 27);
            this.BtnLocalizacao.TabIndex = 127;
            this.BtnLocalizacao.Text = "Adicionar Localização";
            this.BtnLocalizacao.UseVisualStyleBackColor = true;
            this.BtnLocalizacao.Click += new System.EventHandler(this.BtnLocalizacao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(36, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 128;
            this.label8.Text = "Mapa :";
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(465, 12);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(42, 20);
            this.BtnAbrir.TabIndex = 130;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // TxtAbrir
            // 
            this.TxtAbrir.Location = new System.Drawing.Point(513, 12);
            this.TxtAbrir.Name = "TxtAbrir";
            this.TxtAbrir.Size = new System.Drawing.Size(237, 20);
            this.TxtAbrir.TabIndex = 129;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tccDataSetFest
            // 
            this.tccDataSetFest.DataSetName = "tccDataSetFest";
            this.tccDataSetFest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroFestaBindingSource
            // 
            this.cadastroFestaBindingSource.DataMember = "CadastroFesta";
            this.cadastroFestaBindingSource.DataSource = this.tccDataSetFest;
            // 
            // cadastroFestaTableAdapter
            // 
            this.cadastroFestaTableAdapter.ClearBeforeFill = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DataPropertyName = "BtnAlterar";
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.ReadOnly = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.DataPropertyName = "BtnExcluir";
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.ReadOnly = true;
            // 
            // codigoFestaDataGridViewTextBoxColumn
            // 
            this.codigoFestaDataGridViewTextBoxColumn.DataPropertyName = "CodigoFesta";
            this.codigoFestaDataGridViewTextBoxColumn.HeaderText = "CodigoFesta";
            this.codigoFestaDataGridViewTextBoxColumn.Name = "codigoFestaDataGridViewTextBoxColumn";
            this.codigoFestaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localizacaofDataGridViewTextBoxColumn
            // 
            this.localizacaofDataGridViewTextBoxColumn.DataPropertyName = "Localizacaof";
            this.localizacaofDataGridViewTextBoxColumn.HeaderText = "Localizacaof";
            this.localizacaofDataGridViewTextBoxColumn.Name = "localizacaofDataGridViewTextBoxColumn";
            // 
            // ruafDataGridViewTextBoxColumn
            // 
            this.ruafDataGridViewTextBoxColumn.DataPropertyName = "Ruaf";
            this.ruafDataGridViewTextBoxColumn.HeaderText = "Ruaf";
            this.ruafDataGridViewTextBoxColumn.Name = "ruafDataGridViewTextBoxColumn";
            // 
            // bairrofDataGridViewTextBoxColumn
            // 
            this.bairrofDataGridViewTextBoxColumn.DataPropertyName = "Bairrof";
            this.bairrofDataGridViewTextBoxColumn.HeaderText = "Bairrof";
            this.bairrofDataGridViewTextBoxColumn.Name = "bairrofDataGridViewTextBoxColumn";
            // 
            // cidadefDataGridViewTextBoxColumn
            // 
            this.cidadefDataGridViewTextBoxColumn.DataPropertyName = "Cidadef";
            this.cidadefDataGridViewTextBoxColumn.HeaderText = "Cidadef";
            this.cidadefDataGridViewTextBoxColumn.Name = "cidadefDataGridViewTextBoxColumn";
            // 
            // uffDataGridViewTextBoxColumn
            // 
            this.uffDataGridViewTextBoxColumn.DataPropertyName = "Uff";
            this.uffDataGridViewTextBoxColumn.HeaderText = "Uff";
            this.uffDataGridViewTextBoxColumn.Name = "uffDataGridViewTextBoxColumn";
            // 
            // cepfDataGridViewTextBoxColumn
            // 
            this.cepfDataGridViewTextBoxColumn.DataPropertyName = "Cepf";
            this.cepfDataGridViewTextBoxColumn.HeaderText = "Cepf";
            this.cepfDataGridViewTextBoxColumn.Name = "cepfDataGridViewTextBoxColumn";
            // 
            // fotofDataGridViewImageColumn
            // 
            this.fotofDataGridViewImageColumn.DataPropertyName = "Fotof";
            this.fotofDataGridViewImageColumn.HeaderText = "Fotof";
            this.fotofDataGridViewImageColumn.Name = "fotofDataGridViewImageColumn";
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            // 
            // datafDataGridViewTextBoxColumn
            // 
            this.datafDataGridViewTextBoxColumn.DataPropertyName = "Dataf";
            this.datafDataGridViewTextBoxColumn.HeaderText = "Dataf";
            this.datafDataGridViewTextBoxColumn.Name = "datafDataGridViewTextBoxColumn";
            // 
            // descricaoEventoDataGridViewTextBoxColumn
            // 
            this.descricaoEventoDataGridViewTextBoxColumn.DataPropertyName = "DescricaoEvento";
            this.descricaoEventoDataGridViewTextBoxColumn.HeaderText = "DescricaoEvento";
            this.descricaoEventoDataGridViewTextBoxColumn.Name = "descricaoEventoDataGridViewTextBoxColumn";
            // 
            // valorfDataGridViewTextBoxColumn
            // 
            this.valorfDataGridViewTextBoxColumn.DataPropertyName = "Valorf";
            this.valorfDataGridViewTextBoxColumn.HeaderText = "Valorf";
            this.valorfDataGridViewTextBoxColumn.Name = "valorfDataGridViewTextBoxColumn";
            // 
            // lotefDataGridViewTextBoxColumn
            // 
            this.lotefDataGridViewTextBoxColumn.DataPropertyName = "Lotef";
            this.lotefDataGridViewTextBoxColumn.HeaderText = "Lotef";
            this.lotefDataGridViewTextBoxColumn.Name = "lotefDataGridViewTextBoxColumn";
            // 
            // descricaoClienteDataGridViewTextBoxColumn
            // 
            this.descricaoClienteDataGridViewTextBoxColumn.DataPropertyName = "DescricaoCliente";
            this.descricaoClienteDataGridViewTextBoxColumn.HeaderText = "DescricaoCliente";
            this.descricaoClienteDataGridViewTextBoxColumn.Name = "descricaoClienteDataGridViewTextBoxColumn";
            // 
            // referenciaFDataGridViewTextBoxColumn
            // 
            this.referenciaFDataGridViewTextBoxColumn.DataPropertyName = "ReferenciaF";
            this.referenciaFDataGridViewTextBoxColumn.HeaderText = "ReferenciaF";
            this.referenciaFDataGridViewTextBoxColumn.Name = "referenciaFDataGridViewTextBoxColumn";
            // 
            // tipoFDataGridViewTextBoxColumn
            // 
            this.tipoFDataGridViewTextBoxColumn.DataPropertyName = "TipoF";
            this.tipoFDataGridViewTextBoxColumn.HeaderText = "TipoF";
            this.tipoFDataGridViewTextBoxColumn.Name = "tipoFDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // FrmFesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(799, 531);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.TxtAbrir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnLocalizacao);
            this.Controls.Add(this.TxtTipoFesta);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtClienteF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtCepF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ValorF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCancelarF);
            this.Controls.Add(this.BtnSalvarF);
            this.Controls.Add(this.GridFesta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtUfF);
            this.Controls.Add(this.TxtDescricaoF);
            this.Controls.Add(this.TxtDateF);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtTelefoneF);
            this.Controls.Add(this.TxtRuaF);
            this.Controls.Add(this.TxtBairroF);
            this.Controls.Add(this.TxtCidadeF);
            this.Controls.Add(this.PbImagem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CbLoteF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.TxtReferenciaF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFesta";
            this.Text = "Festa";
            this.Load += new System.EventHandler(this.FrmFesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridFesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetFest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFestaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnCancelarF;
        private System.Windows.Forms.Button BtnSalvarF;
        private System.Windows.Forms.DataGridView GridFesta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtUfF;
        private System.Windows.Forms.RichTextBox TxtDescricaoF;
        private System.Windows.Forms.MaskedTextBox TxtDateF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox TxtTelefoneF;
        private System.Windows.Forms.TextBox TxtRuaF;
        private System.Windows.Forms.TextBox TxtBairroF;
        private System.Windows.Forms.TextBox TxtCidadeF;
        private System.Windows.Forms.PictureBox PbImagem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbLoteF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox TxtReferenciaF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox ValorF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox TxtCepF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtClienteF;
        private System.Windows.Forms.TextBox TxtTipoFesta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnLocalizacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.TextBox TxtAbrir;
        
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private tccDataSetFest tccDataSetFest;
        private System.Windows.Forms.BindingSource cadastroFestaBindingSource;
        private tccDataSetFestTableAdapters.CadastroFestaTableAdapter cadastroFestaTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoFestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizacaofDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairrofDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotofDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}