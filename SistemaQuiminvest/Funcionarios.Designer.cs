namespace SistemaQuiminvest
{
    partial class Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSalvarFuncionario = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.GrdFuncionario = new System.Windows.Forms.DataGridView();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quiminvestDataSetFuncionario = new SistemaQuiminvest.QuiminvestDataSetFuncionario();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescricaoCliente = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.TxtAbrir = new System.Windows.Forms.TextBox();
            this.PbImagem = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.TxtUfCliente = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.CbSexo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.funcionarioTableAdapter = new SistemaQuiminvest.QuiminvestDataSetFuncionarioTableAdapters.funcionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiminvestDataSetFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(657, 273);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 32;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(296, 179);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(170, 20);
            this.txtCargo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cargo:";
            // 
            // BtnSalvarFuncionario
            // 
            this.BtnSalvarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarFuncionario.Image")));
            this.BtnSalvarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarFuncionario.Location = new System.Drawing.Point(495, 273);
            this.BtnSalvarFuncionario.Name = "BtnSalvarFuncionario";
            this.BtnSalvarFuncionario.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarFuncionario.TabIndex = 31;
            this.BtnSalvarFuncionario.Text = "Salvar";
            this.BtnSalvarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarFuncionario.UseVisualStyleBackColor = true;
            this.BtnSalvarFuncionario.Click += new System.EventHandler(this.BtnSalvarFuncionario_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(738, 273);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 33;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // GrdFuncionario
            // 
            this.GrdFuncionario.AutoGenerateColumns = false;
            this.GrdFuncionario.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.GrdFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnAlterar,
            this.BtnExcluir,
            this.nomeDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn});
            this.GrdFuncionario.DataSource = this.funcionarioBindingSource;
            this.GrdFuncionario.Location = new System.Drawing.Point(3, 332);
            this.GrdFuncionario.Name = "GrdFuncionario";
            this.GrdFuncionario.Size = new System.Drawing.Size(838, 218);
            this.GrdFuncionario.TabIndex = 34;
            this.GrdFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdFuncionario_CellContentClick);
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
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.Width = 145;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this.quiminvestDataSetFuncionario;
            // 
            // quiminvestDataSetFuncionario
            // 
            this.quiminvestDataSetFuncionario.DataSetName = "QuiminvestDataSetFuncionario";
            this.quiminvestDataSetFuncionario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "UF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descrição:";
            // 
            // TxtDescricaoCliente
            // 
            this.TxtDescricaoCliente.Location = new System.Drawing.Point(87, 216);
            this.TxtDescricaoCliente.Name = "TxtDescricaoCliente";
            this.TxtDescricaoCliente.Size = new System.Drawing.Size(379, 87);
            this.TxtDescricaoCliente.TabIndex = 23;
            this.TxtDescricaoCliente.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Foto:";
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(526, 19);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(42, 20);
            this.BtnAbrir.TabIndex = 24;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click_1);
            // 
            // TxtAbrir
            // 
            this.TxtAbrir.Location = new System.Drawing.Point(574, 19);
            this.TxtAbrir.Name = "TxtAbrir";
            this.TxtAbrir.Size = new System.Drawing.Size(237, 20);
            this.TxtAbrir.TabIndex = 25;
            // 
            // PbImagem
            // 
            this.PbImagem.Image = ((System.Drawing.Image)(resources.GetObject("PbImagem.Image")));
            this.PbImagem.Location = new System.Drawing.Point(673, 51);
            this.PbImagem.Name = "PbImagem";
            this.PbImagem.Size = new System.Drawing.Size(140, 140);
            this.PbImagem.TabIndex = 89;
            this.PbImagem.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(355, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 18;
            this.label17.Text = "Telefone:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(283, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "Data de nascimento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(379, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Sexo:";
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(87, 179);
            this.TxtCPF.Mask = "###.###.###-##";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(86, 20);
            this.TxtCPF.TabIndex = 11;
            // 
            // TxtUfCliente
            // 
            this.TxtUfCliente.Location = new System.Drawing.Point(428, 149);
            this.TxtUfCliente.Name = "TxtUfCliente";
            this.TxtUfCliente.Size = new System.Drawing.Size(38, 20);
            this.TxtUfCliente.TabIndex = 21;
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(428, 85);
            this.TxtDate.Mask = "##/##/####";
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(70, 20);
            this.TxtDate.TabIndex = 17;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(428, 118);
            this.TxtTelefone.Mask = "(##)#####-####";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(86, 20);
            this.TxtTelefone.TabIndex = 19;
            // 
            // CbSexo
            // 
            this.CbSexo.FormattingEnabled = true;
            this.CbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.CbSexo.Location = new System.Drawing.Point(428, 51);
            this.CbSexo.Name = "CbSexo";
            this.CbSexo.Size = new System.Drawing.Size(97, 21);
            this.CbSexo.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(37, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "CPF:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(87, 147);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(226, 20);
            this.txtRua.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Rua:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(87, 117);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(170, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(87, 84);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(131, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cidade:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(87, 52);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Email:";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(698, 239);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(113, 20);
            this.TxtSenha.TabIndex = 30;
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(698, 213);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(113, 20);
            this.TxtLogin.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(640, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Senha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(645, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // TxtNomeFuncionario
            // 
            this.TxtNomeFuncionario.Location = new System.Drawing.Point(87, 20);
            this.TxtNomeFuncionario.Name = "TxtNomeFuncionario";
            this.TxtNomeFuncionario.Size = new System.Drawing.Size(251, 20);
            this.TxtNomeFuncionario.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Location = new System.Drawing.Point(576, 273);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 90;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 555);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSalvarFuncionario);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.GrdFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDescricaoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.TxtAbrir);
            this.Controls.Add(this.PbImagem);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.TxtUfCliente);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.CbSexo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Funcionarios_FormClosed);
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiminvestDataSetFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSalvarFuncionario;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView GrdFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TxtDescricaoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.TextBox TxtAbrir;
        private System.Windows.Forms.PictureBox PbImagem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox TxtCPF;
        private System.Windows.Forms.TextBox TxtUfCliente;
        private System.Windows.Forms.MaskedTextBox TxtDate;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.ComboBox CbSexo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeFuncionario;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImprimir;
        private QuiminvestDataSetFuncionario quiminvestDataSetFuncionario;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private QuiminvestDataSetFuncionarioTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
    }
}