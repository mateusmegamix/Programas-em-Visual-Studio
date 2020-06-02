namespace APK.DESKTOP.VIEW
{
    partial class FrmJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJogo));
            this.TxtClienteJ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCepJ = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ValorJ = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnCancelarJ = new System.Windows.Forms.Button();
            this.BtnSalvarJ = new System.Windows.Forms.Button();
            this.GridJogo = new System.Windows.Forms.DataGridView();
            this.cadastroJogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.TxtUfJ = new System.Windows.Forms.TextBox();
            this.TxtDescricaoJ = new System.Windows.Forms.RichTextBox();
            this.TxtDateJ = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTelefoneJ = new System.Windows.Forms.MaskedTextBox();
            this.TxtRuaJ = new System.Windows.Forms.TextBox();
            this.TxtBairroJ = new System.Windows.Forms.TextBox();
            this.TxtCidadeJ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.TxtReferenciaJ = new System.Windows.Forms.TextBox();
            this.PbImagem = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtMembros = new System.Windows.Forms.TextBox();
            this.TxtObjetos = new System.Windows.Forms.TextBox();
            this.TxtPessoas = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtTipoJogo = new System.Windows.Forms.TextBox();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.TxtAbrir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnLocalizacao = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tccDataSetJogos = new APK.DESKTOP.VIEW.tccDataSetJogos();
            this.cadastroJogoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroJogoTableAdapter = new APK.DESKTOP.VIEW.tccDataSetJogosTableAdapters.CadastroJogoTableAdapter();
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
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridJogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroJogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetJogos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroJogoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtClienteJ
            // 
            this.TxtClienteJ.Location = new System.Drawing.Point(63, 42);
            this.TxtClienteJ.Name = "TxtClienteJ";
            this.TxtClienteJ.Size = new System.Drawing.Size(180, 20);
            this.TxtClienteJ.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(12, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cliente :";
            // 
            // TxtCepJ
            // 
            this.TxtCepJ.Location = new System.Drawing.Point(247, 101);
            this.TxtCepJ.Mask = "#####-###";
            this.TxtCepJ.Name = "TxtCepJ";
            this.TxtCepJ.Size = new System.Drawing.Size(70, 20);
            this.TxtCepJ.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(207, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "CEP :";
            // 
            // ValorJ
            // 
            this.ValorJ.Location = new System.Drawing.Point(490, 257);
            this.ValorJ.Mask = "$000,00";
            this.ValorJ.Name = "ValorJ";
            this.ValorJ.Size = new System.Drawing.Size(56, 20);
            this.ValorJ.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(447, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Valor :";
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(714, 504);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 28;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnCancelarJ
            // 
            this.BtnCancelarJ.Location = new System.Drawing.Point(712, 281);
            this.BtnCancelarJ.Name = "BtnCancelarJ";
            this.BtnCancelarJ.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarJ.TabIndex = 26;
            this.BtnCancelarJ.Text = "Cancelar";
            this.BtnCancelarJ.UseVisualStyleBackColor = true;
            this.BtnCancelarJ.Click += new System.EventHandler(this.BtnCancelarJ_Click);
            // 
            // BtnSalvarJ
            // 
            this.BtnSalvarJ.Location = new System.Drawing.Point(626, 281);
            this.BtnSalvarJ.Name = "BtnSalvarJ";
            this.BtnSalvarJ.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvarJ.TabIndex = 25;
            this.BtnSalvarJ.Text = "Salvar";
            this.BtnSalvarJ.UseVisualStyleBackColor = true;
            this.BtnSalvarJ.Click += new System.EventHandler(this.BtnSalvarJ_Click);
            // 
            // GridJogo
            // 
            this.GridJogo.AutoGenerateColumns = false;
            this.GridJogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridJogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.telefoneDataGridViewTextBoxColumn});
            this.GridJogo.DataSource = this.cadastroJogoBindingSource1;
            this.GridJogo.Location = new System.Drawing.Point(13, 312);
            this.GridJogo.Name = "GridJogo";
            this.GridJogo.Size = new System.Drawing.Size(776, 188);
            this.GridJogo.TabIndex = 27;
            this.GridJogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridJogo_CellContentClick);
            // 
            // cadastroJogoBindingSource
            // 
            this.cadastroJogoBindingSource.DataMember = "CadastroJogo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(322, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "UF :";
            // 
            // TxtUfJ
            // 
            this.TxtUfJ.Location = new System.Drawing.Point(355, 101);
            this.TxtUfJ.Name = "TxtUfJ";
            this.TxtUfJ.Size = new System.Drawing.Size(29, 20);
            this.TxtUfJ.TabIndex = 11;
            // 
            // TxtDescricaoJ
            // 
            this.TxtDescricaoJ.Location = new System.Drawing.Point(11, 230);
            this.TxtDescricaoJ.Name = "TxtDescricaoJ";
            this.TxtDescricaoJ.Size = new System.Drawing.Size(406, 76);
            this.TxtDescricaoJ.TabIndex = 19;
            this.TxtDescricaoJ.Text = "";
            // 
            // TxtDateJ
            // 
            this.TxtDateJ.Location = new System.Drawing.Point(314, 74);
            this.TxtDateJ.Mask = "##/##/####";
            this.TxtDateJ.Name = "TxtDateJ";
            this.TxtDateJ.Size = new System.Drawing.Size(70, 20);
            this.TxtDateJ.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(429, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Telefone :";
            // 
            // TxtTelefoneJ
            // 
            this.TxtTelefoneJ.Location = new System.Drawing.Point(490, 283);
            this.TxtTelefoneJ.Mask = "(##)#####-####";
            this.TxtTelefoneJ.Name = "TxtTelefoneJ";
            this.TxtTelefoneJ.Size = new System.Drawing.Size(86, 20);
            this.TxtTelefoneJ.TabIndex = 24;
            // 
            // TxtRuaJ
            // 
            this.TxtRuaJ.Location = new System.Drawing.Point(88, 153);
            this.TxtRuaJ.Name = "TxtRuaJ";
            this.TxtRuaJ.Size = new System.Drawing.Size(219, 20);
            this.TxtRuaJ.TabIndex = 15;
            // 
            // TxtBairroJ
            // 
            this.TxtBairroJ.Location = new System.Drawing.Point(88, 127);
            this.TxtBairroJ.Name = "TxtBairroJ";
            this.TxtBairroJ.Size = new System.Drawing.Size(155, 20);
            this.TxtBairroJ.TabIndex = 13;
            // 
            // TxtCidadeJ
            // 
            this.TxtCidadeJ.Location = new System.Drawing.Point(88, 101);
            this.TxtCidadeJ.Name = "TxtCidadeJ";
            this.TxtCidadeJ.Size = new System.Drawing.Size(109, 20);
            this.TxtCidadeJ.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(497, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Evento :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(220, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data do Evento :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(10, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descrição do Evento :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(42, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bairro :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(36, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cidade :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(49, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rua :";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.ForeColor = System.Drawing.SystemColors.Window;
            this.Nome.Location = new System.Drawing.Point(17, 184);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(65, 13);
            this.Nome.TabIndex = 16;
            this.Nome.Text = "Referencia :";
            // 
            // TxtReferenciaJ
            // 
            this.TxtReferenciaJ.Location = new System.Drawing.Point(88, 179);
            this.TxtReferenciaJ.Name = "TxtReferenciaJ";
            this.TxtReferenciaJ.Size = new System.Drawing.Size(296, 20);
            this.TxtReferenciaJ.TabIndex = 17;
            // 
            // PbImagem
            // 
            this.PbImagem.Image = ((System.Drawing.Image)(resources.GetObject("PbImagem.Image")));
            this.PbImagem.Location = new System.Drawing.Point(550, 42);
            this.PbImagem.Name = "PbImagem";
            this.PbImagem.Size = new System.Drawing.Size(240, 202);
            this.PbImagem.TabIndex = 116;
            this.PbImagem.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(383, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 117;
            this.label5.Text = "Add Membros :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(390, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 118;
            this.label14.Text = "Qtd Pessoas :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(390, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 119;
            this.label15.Text = "Add Objetos :";
            // 
            // TxtMembros
            // 
            this.TxtMembros.Location = new System.Drawing.Point(467, 127);
            this.TxtMembros.Name = "TxtMembros";
            this.TxtMembros.Size = new System.Drawing.Size(61, 20);
            this.TxtMembros.TabIndex = 120;
            // 
            // TxtObjetos
            // 
            this.TxtObjetos.Location = new System.Drawing.Point(467, 153);
            this.TxtObjetos.Name = "TxtObjetos";
            this.TxtObjetos.Size = new System.Drawing.Size(61, 20);
            this.TxtObjetos.TabIndex = 121;
            // 
            // TxtPessoas
            // 
            this.TxtPessoas.Location = new System.Drawing.Point(467, 179);
            this.TxtPessoas.Name = "TxtPessoas";
            this.TxtPessoas.Size = new System.Drawing.Size(61, 20);
            this.TxtPessoas.TabIndex = 122;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(249, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 123;
            this.label16.Text = "Tipo :";
            // 
            // TxtTipoJogo
            // 
            this.TxtTipoJogo.Location = new System.Drawing.Point(283, 42);
            this.TxtTipoJogo.Name = "TxtTipoJogo";
            this.TxtTipoJogo.Size = new System.Drawing.Size(178, 20);
            this.TxtTipoJogo.TabIndex = 124;
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(502, 12);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(42, 20);
            this.BtnAbrir.TabIndex = 126;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // TxtAbrir
            // 
            this.TxtAbrir.Location = new System.Drawing.Point(550, 12);
            this.TxtAbrir.Name = "TxtAbrir";
            this.TxtAbrir.Size = new System.Drawing.Size(237, 20);
            this.TxtAbrir.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(11, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 130;
            this.label8.Text = "Mapa :";
            // 
            // BtnLocalizacao
            // 
            this.BtnLocalizacao.Location = new System.Drawing.Point(63, 70);
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
            // tccDataSetJogos
            // 
            this.tccDataSetJogos.DataSetName = "tccDataSetJogos";
            this.tccDataSetJogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroJogoBindingSource1
            // 
            this.cadastroJogoBindingSource1.DataMember = "CadastroJogo";
            this.cadastroJogoBindingSource1.DataSource = this.tccDataSetJogos;
            // 
            // cadastroJogoTableAdapter
            // 
            this.cadastroJogoTableAdapter.ClearBeforeFill = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DataPropertyName = "CodigoJogo";
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.ReadOnly = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.DataPropertyName = "CodigoJogo";
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoJogo";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoJogo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LocalizacaoJ";
            this.dataGridViewTextBoxColumn2.HeaderText = "LocalizacaoJ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RuaJ";
            this.dataGridViewTextBoxColumn3.HeaderText = "RuaJ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Bairroj";
            this.dataGridViewTextBoxColumn4.HeaderText = "Bairroj";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cidadej";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cidadej";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ufj";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ufj";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "QtdPessoas";
            this.dataGridViewTextBoxColumn7.HeaderText = "QtdPessoas";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Dataj";
            this.dataGridViewTextBoxColumn8.HeaderText = "Dataj";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "AddMembrosj";
            this.dataGridViewTextBoxColumn9.HeaderText = "AddMembrosj";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DescricaoJ";
            this.dataGridViewTextBoxColumn10.HeaderText = "DescricaoJ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "FotoJ";
            this.dataGridViewImageColumn1.HeaderText = "FotoJ";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Valorj";
            this.dataGridViewTextBoxColumn11.HeaderText = "Valorj";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "AddObjeto";
            this.dataGridViewTextBoxColumn12.HeaderText = "AddObjeto";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "TipoJ";
            this.dataGridViewTextBoxColumn13.HeaderText = "TipoJ";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(802, 537);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnLocalizacao);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.TxtAbrir);
            this.Controls.Add(this.TxtTipoJogo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtPessoas);
            this.Controls.Add(this.TxtObjetos);
            this.Controls.Add(this.TxtMembros);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtClienteJ);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtCepJ);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ValorJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCancelarJ);
            this.Controls.Add(this.BtnSalvarJ);
            this.Controls.Add(this.GridJogo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtUfJ);
            this.Controls.Add(this.TxtDescricaoJ);
            this.Controls.Add(this.TxtDateJ);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtTelefoneJ);
            this.Controls.Add(this.TxtRuaJ);
            this.Controls.Add(this.TxtBairroJ);
            this.Controls.Add(this.TxtCidadeJ);
            this.Controls.Add(this.PbImagem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.TxtReferenciaJ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmJogo";
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.FrmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridJogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroJogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetJogos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroJogoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtClienteJ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox TxtCepJ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox ValorJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnCancelarJ;
        private System.Windows.Forms.Button BtnSalvarJ;
        private System.Windows.Forms.DataGridView GridJogo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtUfJ;
        private System.Windows.Forms.RichTextBox TxtDescricaoJ;
        private System.Windows.Forms.MaskedTextBox TxtDateJ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox TxtTelefoneJ;
        private System.Windows.Forms.TextBox TxtRuaJ;
        private System.Windows.Forms.TextBox TxtBairroJ;
        private System.Windows.Forms.TextBox TxtCidadeJ;
        private System.Windows.Forms.PictureBox PbImagem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox TxtReferenciaJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtMembros;
        private System.Windows.Forms.TextBox TxtObjetos;
        private System.Windows.Forms.TextBox TxtPessoas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtTipoJogo;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.TextBox TxtAbrir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnLocalizacao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
       
        private System.Windows.Forms.BindingSource cadastroJogoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoJogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizacaoJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadejDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdPessoasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addMembrosjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoJDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addObjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoJDataGridViewTextBoxColumn;
        private tccDataSetJogos tccDataSetJogos;
        private System.Windows.Forms.BindingSource cadastroJogoBindingSource1;
        private tccDataSetJogosTableAdapters.CadastroJogoTableAdapter cadastroJogoTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}