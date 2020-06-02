namespace QuiminVestReator
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
            this.TxtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.TxtUfCliente = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.CbSexo = new System.Windows.Forms.ComboBox();
            this.TxtIdadeFuncionario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.TxtAbrir = new System.Windows.Forms.TextBox();
            this.PbImagem = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescricaoCliente = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrdFuncionario = new System.Windows.Forms.DataGridView();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnSalvarFuncionario = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNomeFuncionario
            // 
            this.TxtNomeFuncionario.Location = new System.Drawing.Point(77, 13);
            this.TxtNomeFuncionario.Name = "TxtNomeFuncionario";
            this.TxtNomeFuncionario.Size = new System.Drawing.Size(251, 20);
            this.TxtNomeFuncionario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(635, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Login:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(630, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Senha:";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(688, 172);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(113, 20);
            this.TxtLogin.TabIndex = 15;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(688, 198);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(113, 20);
            this.TxtSenha.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(77, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(77, 77);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(131, 20);
            this.txtCidade.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(77, 110);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(170, 20);
            this.txtBairro.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Rua:";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(77, 140);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(226, 20);
            this.txtRua.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 35;
            this.label13.Text = "CPF:";
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(77, 172);
            this.TxtCPF.Mask = "###.###.###-##";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(86, 20);
            this.TxtCPF.TabIndex = 41;
            // 
            // TxtUfCliente
            // 
            this.TxtUfCliente.Location = new System.Drawing.Point(418, 142);
            this.TxtUfCliente.Name = "TxtUfCliente";
            this.TxtUfCliente.Size = new System.Drawing.Size(38, 20);
            this.TxtUfCliente.TabIndex = 40;
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(418, 78);
            this.TxtDate.Mask = "##/##/####";
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(70, 20);
            this.TxtDate.TabIndex = 38;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(418, 111);
            this.TxtTelefone.Mask = "(##)#####-####";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(86, 20);
            this.TxtTelefone.TabIndex = 39;
            // 
            // CbSexo
            // 
            this.CbSexo.FormattingEnabled = true;
            this.CbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.CbSexo.Location = new System.Drawing.Point(418, 44);
            this.CbSexo.Name = "CbSexo";
            this.CbSexo.Size = new System.Drawing.Size(97, 21);
            this.CbSexo.TabIndex = 37;
            // 
            // TxtIdadeFuncionario
            // 
            this.TxtIdadeFuncionario.Location = new System.Drawing.Point(418, 13);
            this.TxtIdadeFuncionario.Name = "TxtIdadeFuncionario";
            this.TxtIdadeFuncionario.Size = new System.Drawing.Size(38, 20);
            this.TxtIdadeFuncionario.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(365, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Idade:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(369, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 43;
            this.label15.Text = "Sexo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(273, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "Data de nascimento:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(345, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 45;
            this.label17.Text = "Telefone:";
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(516, 12);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(42, 20);
            this.BtnAbrir.TabIndex = 53;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // TxtAbrir
            // 
            this.TxtAbrir.Location = new System.Drawing.Point(564, 12);
            this.TxtAbrir.Name = "TxtAbrir";
            this.TxtAbrir.Size = new System.Drawing.Size(237, 20);
            this.TxtAbrir.TabIndex = 52;
            // 
            // PbImagem
            // 
            this.PbImagem.Image = ((System.Drawing.Image)(resources.GetObject("PbImagem.Image")));
            this.PbImagem.Location = new System.Drawing.Point(647, 57);
            this.PbImagem.Name = "PbImagem";
            this.PbImagem.Size = new System.Drawing.Size(154, 99);
            this.PbImagem.TabIndex = 51;
            this.PbImagem.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Foto:";
            // 
            // TxtDescricaoCliente
            // 
            this.TxtDescricaoCliente.Location = new System.Drawing.Point(77, 209);
            this.TxtDescricaoCliente.Name = "TxtDescricaoCliente";
            this.TxtDescricaoCliente.Size = new System.Drawing.Size(379, 87);
            this.TxtDescricaoCliente.TabIndex = 55;
            this.TxtDescricaoCliente.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "Descrção:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "UF:";
            // 
            // GrdFuncionario
            // 
            this.GrdFuncionario.AutoGenerateColumns = false;
            this.GrdFuncionario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrdFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnAlterar,
            this.BtnExcluir,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.GrdFuncionario.DataSource = this.funcionarioBindingSource;
            this.GrdFuncionario.Location = new System.Drawing.Point(3, 302);
            this.GrdFuncionario.Name = "GrdFuncionario";
            this.GrdFuncionario.Size = new System.Drawing.Size(838, 218);
            this.GrdFuncionario.TabIndex = 58;
            this.GrdFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdFuncionario_CellContentClick);
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
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            // 
            // reatorDataSet
            // 
            // 
            // funcionarioTableAdapter
            //
            // 
            // BtnSalvarFuncionario
            // 
            this.BtnSalvarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarFuncionario.Image")));
            this.BtnSalvarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarFuncionario.Location = new System.Drawing.Point(566, 266);
            this.BtnSalvarFuncionario.Name = "BtnSalvarFuncionario";
            this.BtnSalvarFuncionario.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarFuncionario.TabIndex = 60;
            this.BtnSalvarFuncionario.Text = "Salvar";
            this.BtnSalvarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarFuncionario.UseVisualStyleBackColor = true;
            this.BtnSalvarFuncionario.Click += new System.EventHandler(this.BtnSalvarFuncionario_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(728, 266);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 59;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(286, 172);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(170, 20);
            this.txtCargo.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 61;
            this.label5.Text = "Cargo:";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(647, 266);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 63;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 520);
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
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.TxtUfCliente);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.CbSexo);
            this.Controls.Add(this.TxtIdadeFuncionario);
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
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNomeFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox TxtCPF;
        private System.Windows.Forms.TextBox TxtUfCliente;
        private System.Windows.Forms.MaskedTextBox TxtDate;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.ComboBox CbSexo;
        private System.Windows.Forms.TextBox TxtIdadeFuncionario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.TextBox TxtAbrir;
        private System.Windows.Forms.PictureBox PbImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TxtDescricaoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView GrdFuncionario;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnSalvarFuncionario;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}