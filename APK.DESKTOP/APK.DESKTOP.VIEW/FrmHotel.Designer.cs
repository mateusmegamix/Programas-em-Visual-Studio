namespace APK.DESKTOP.VIEW
{
    partial class FrmHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHotel));
            this.TxtClienteH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCepH = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ValorH = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnCancelarH = new System.Windows.Forms.Button();
            this.BtnSalvarH = new System.Windows.Forms.Button();
            this.GridHotel = new System.Windows.Forms.DataGridView();
            this.cadastroHotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.TxtUfH = new System.Windows.Forms.TextBox();
            this.TxtDescricaoH = new System.Windows.Forms.RichTextBox();
            this.TxtDateH = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTelefoneH = new System.Windows.Forms.MaskedTextBox();
            this.TxtRuaH = new System.Windows.Forms.TextBox();
            this.TxtBairroH = new System.Windows.Forms.TextBox();
            this.TxtCidadeH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbCategoriaH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.TxtReferenciaH = new System.Windows.Forms.TextBox();
            this.PbImagem = new System.Windows.Forms.PictureBox();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.TxtAbrir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnLocalizacao = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tccDataSetHotell = new APK.DESKTOP.VIEW.tccDataSetHotell();
            this.cadastroHotelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroHotelTableAdapter = new APK.DESKTOP.VIEW.tccDataSetHotellTableAdapters.CadastroHotelTableAdapter();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroHotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetHotell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroHotelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtClienteH
            // 
            this.TxtClienteH.Location = new System.Drawing.Point(62, 34);
            this.TxtClienteH.Name = "TxtClienteH";
            this.TxtClienteH.Size = new System.Drawing.Size(180, 20);
            this.TxtClienteH.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(11, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cliente :";
            // 
            // TxtCepH
            // 
            this.TxtCepH.Location = new System.Drawing.Point(246, 93);
            this.TxtCepH.Mask = "#####-###";
            this.TxtCepH.Name = "TxtCepH";
            this.TxtCepH.Size = new System.Drawing.Size(70, 20);
            this.TxtCepH.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(206, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "CEP :";
            // 
            // ValorH
            // 
            this.ValorH.Location = new System.Drawing.Point(489, 249);
            this.ValorH.Mask = "$000,00";
            this.ValorH.Name = "ValorH";
            this.ValorH.Size = new System.Drawing.Size(56, 20);
            this.ValorH.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(446, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Valor :";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(713, 496);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 30;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnCancelarH
            // 
            this.BtnCancelarH.Location = new System.Drawing.Point(711, 273);
            this.BtnCancelarH.Name = "BtnCancelarH";
            this.BtnCancelarH.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarH.TabIndex = 28;
            this.BtnCancelarH.Text = "Cancelar";
            this.BtnCancelarH.UseVisualStyleBackColor = true;
            this.BtnCancelarH.Click += new System.EventHandler(this.BtnCancelarH_Click);
            // 
            // BtnSalvarH
            // 
            this.BtnSalvarH.Location = new System.Drawing.Point(625, 273);
            this.BtnSalvarH.Name = "BtnSalvarH";
            this.BtnSalvarH.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvarH.TabIndex = 27;
            this.BtnSalvarH.Text = "Salvar";
            this.BtnSalvarH.UseVisualStyleBackColor = true;
            this.BtnSalvarH.Click += new System.EventHandler(this.BtnSalvarH_Click);
            // 
            // GridHotel
            // 
            this.GridHotel.AutoGenerateColumns = false;
            this.GridHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnAlterar,
            this.BtnExcluir,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.telefoneDataGridViewTextBoxColumn});
            this.GridHotel.DataSource = this.cadastroHotelBindingSource1;
            this.GridHotel.Location = new System.Drawing.Point(12, 304);
            this.GridHotel.Name = "GridHotel";
            this.GridHotel.Size = new System.Drawing.Size(776, 188);
            this.GridHotel.TabIndex = 29;
            this.GridHotel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridHotel_CellContentClick);
            // 
            // cadastroHotelBindingSource
            // 
            this.cadastroHotelBindingSource.DataMember = "CadastroHotel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(321, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "UF :";
            // 
            // TxtUfH
            // 
            this.TxtUfH.Location = new System.Drawing.Point(354, 93);
            this.TxtUfH.Name = "TxtUfH";
            this.TxtUfH.Size = new System.Drawing.Size(29, 20);
            this.TxtUfH.TabIndex = 11;
            // 
            // TxtDescricaoH
            // 
            this.TxtDescricaoH.Location = new System.Drawing.Point(10, 222);
            this.TxtDescricaoH.Name = "TxtDescricaoH";
            this.TxtDescricaoH.Size = new System.Drawing.Size(406, 76);
            this.TxtDescricaoH.TabIndex = 19;
            this.TxtDescricaoH.Text = "";
            // 
            // TxtDateH
            // 
            this.TxtDateH.Location = new System.Drawing.Point(313, 66);
            this.TxtDateH.Mask = "##/##/####";
            this.TxtDateH.Name = "TxtDateH";
            this.TxtDateH.Size = new System.Drawing.Size(70, 20);
            this.TxtDateH.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(428, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Telefone :";
            // 
            // TxtTelefoneH
            // 
            this.TxtTelefoneH.Location = new System.Drawing.Point(489, 275);
            this.TxtTelefoneH.Mask = "(##)#####-####";
            this.TxtTelefoneH.Name = "TxtTelefoneH";
            this.TxtTelefoneH.Size = new System.Drawing.Size(86, 20);
            this.TxtTelefoneH.TabIndex = 26;
            // 
            // TxtRuaH
            // 
            this.TxtRuaH.Location = new System.Drawing.Point(87, 145);
            this.TxtRuaH.Name = "TxtRuaH";
            this.TxtRuaH.Size = new System.Drawing.Size(219, 20);
            this.TxtRuaH.TabIndex = 15;
            // 
            // TxtBairroH
            // 
            this.TxtBairroH.Location = new System.Drawing.Point(87, 119);
            this.TxtBairroH.Name = "TxtBairroH";
            this.TxtBairroH.Size = new System.Drawing.Size(155, 20);
            this.TxtBairroH.TabIndex = 13;
            // 
            // TxtCidadeH
            // 
            this.TxtCidadeH.Location = new System.Drawing.Point(87, 93);
            this.TxtCidadeH.Name = "TxtCidadeH";
            this.TxtCidadeH.Size = new System.Drawing.Size(109, 20);
            this.TxtCidadeH.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(496, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Evento :";
            // 
            // CbCategoriaH
            // 
            this.CbCategoriaH.FormattingEnabled = true;
            this.CbCategoriaH.Location = new System.Drawing.Point(489, 222);
            this.CbCategoriaH.Name = "CbCategoriaH";
            this.CbCategoriaH.Size = new System.Drawing.Size(38, 21);
            this.CbCategoriaH.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(219, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data do Evento :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(9, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descrição do Evento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(425, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Categoria :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(41, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bairro :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(35, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(48, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rua :";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.ForeColor = System.Drawing.SystemColors.Window;
            this.Nome.Location = new System.Drawing.Point(16, 176);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(65, 13);
            this.Nome.TabIndex = 16;
            this.Nome.Text = "Referencia :";
            // 
            // TxtReferenciaH
            // 
            this.TxtReferenciaH.Location = new System.Drawing.Point(87, 171);
            this.TxtReferenciaH.Name = "TxtReferenciaH";
            this.TxtReferenciaH.Size = new System.Drawing.Size(296, 20);
            this.TxtReferenciaH.TabIndex = 17;
            // 
            // PbImagem
            // 
            this.PbImagem.Image = ((System.Drawing.Image)(resources.GetObject("PbImagem.Image")));
            this.PbImagem.Location = new System.Drawing.Point(549, 34);
            this.PbImagem.Name = "PbImagem";
            this.PbImagem.Size = new System.Drawing.Size(240, 209);
            this.PbImagem.TabIndex = 84;
            this.PbImagem.TabStop = false;
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(504, 8);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(42, 20);
            this.BtnAbrir.TabIndex = 86;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // TxtAbrir
            // 
            this.TxtAbrir.Location = new System.Drawing.Point(552, 8);
            this.TxtAbrir.Name = "TxtAbrir";
            this.TxtAbrir.Size = new System.Drawing.Size(237, 20);
            this.TxtAbrir.TabIndex = 85;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(10, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 130;
            this.label8.Text = "Mapa :";
            // 
            // BtnLocalizacao
            // 
            this.BtnLocalizacao.Location = new System.Drawing.Point(62, 58);
            this.BtnLocalizacao.Name = "BtnLocalizacao";
            this.BtnLocalizacao.Size = new System.Drawing.Size(119, 27);
            this.BtnLocalizacao.TabIndex = 129;
            this.BtnLocalizacao.Text = "Adicionar Localização";
            this.BtnLocalizacao.UseVisualStyleBackColor = true;
            this.BtnLocalizacao.Click += new System.EventHandler(this.BtnLocalizacao_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tccDataSetHotell
            // 
            this.tccDataSetHotell.DataSetName = "tccDataSetHotell";
            this.tccDataSetHotell.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroHotelBindingSource1
            // 
            this.cadastroHotelBindingSource1.DataMember = "CadastroHotel";
            this.cadastroHotelBindingSource1.DataSource = this.tccDataSetHotell;
            // 
            // cadastroHotelTableAdapter
            // 
            this.cadastroHotelTableAdapter.ClearBeforeFill = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DataPropertyName = "BtnAlterar";
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.ReadOnly = true;
            this.BtnAlterar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnAlterar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.DataPropertyName = "BtnExcluir";
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoHotel";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoHotel";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ruah";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ruah";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Bairroh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Bairroh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cidadeh";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cidadeh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ufh";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ufh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DescricaoHotel";
            this.dataGridViewTextBoxColumn6.HeaderText = "DescricaoHotel";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn7.HeaderText = "NomeCliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DescricaoCliente";
            this.dataGridViewTextBoxColumn8.HeaderText = "DescricaoCliente";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "FotoHotel";
            this.dataGridViewImageColumn1.HeaderText = "FotoHotel";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn9.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Valorh";
            this.dataGridViewTextBoxColumn10.HeaderText = "Valorh";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LocalizacaoH";
            this.dataGridViewTextBoxColumn11.HeaderText = "LocalizacaoH";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ReferenciaH";
            this.dataGridViewTextBoxColumn12.HeaderText = "ReferenciaH";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // FrmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(801, 522);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnLocalizacao);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.TxtAbrir);
            this.Controls.Add(this.TxtClienteH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtCepH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ValorH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCancelarH);
            this.Controls.Add(this.BtnSalvarH);
            this.Controls.Add(this.GridHotel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtUfH);
            this.Controls.Add(this.TxtDescricaoH);
            this.Controls.Add(this.TxtDateH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtTelefoneH);
            this.Controls.Add(this.TxtRuaH);
            this.Controls.Add(this.TxtBairroH);
            this.Controls.Add(this.TxtCidadeH);
            this.Controls.Add(this.PbImagem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CbCategoriaH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.TxtReferenciaH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHotel";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.FrmHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroHotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetHotell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroHotelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtClienteH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox TxtCepH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox ValorH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnCancelarH;
        private System.Windows.Forms.Button BtnSalvarH;
        private System.Windows.Forms.DataGridView GridHotel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtUfH;
        private System.Windows.Forms.RichTextBox TxtDescricaoH;
        private System.Windows.Forms.MaskedTextBox TxtDateH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox TxtTelefoneH;
        private System.Windows.Forms.TextBox TxtRuaH;
        private System.Windows.Forms.TextBox TxtBairroH;
        private System.Windows.Forms.TextBox TxtCidadeH;
        private System.Windows.Forms.PictureBox PbImagem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbCategoriaH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox TxtReferenciaH;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.TextBox TxtAbrir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnLocalizacao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        
        private System.Windows.Forms.BindingSource cadastroHotelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairrohDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadehDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoHotelDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizacaoHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaHDataGridViewTextBoxColumn;
        private tccDataSetHotell tccDataSetHotell;
        private System.Windows.Forms.BindingSource cadastroHotelBindingSource1;
        private tccDataSetHotellTableAdapters.CadastroHotelTableAdapter cadastroHotelTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}