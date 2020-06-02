namespace SICOP.VIEW
{
    partial class frmRegistrarES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarES));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trvPessoa = new System.Windows.Forms.TreeView();
            this.dtgPessoa = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.imgCamera = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.gbxCarreta = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.cbxCarreta = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnProCar = new System.Windows.Forms.Button();
            this.btnAntCar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vinculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
            this.gbxCarreta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtro:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Location = new System.Drawing.Point(66, 6);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.MaxLength = 100;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(260, 29);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "NOME",
            "CPF",
            "RG",
            "EMPRESA"});
            this.cbxFiltro.Location = new System.Drawing.Point(652, 6);
            this.cbxFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(121, 29);
            this.cbxFiltro.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrando por:";
            // 
            // trvPessoa
            // 
            this.trvPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvPessoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.trvPessoa.FullRowSelect = true;
            this.trvPessoa.Location = new System.Drawing.Point(472, 253);
            this.trvPessoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trvPessoa.Name = "trvPessoa";
            this.trvPessoa.Size = new System.Drawing.Size(300, 240);
            this.trvPessoa.TabIndex = 12;
            // 
            // dtgPessoa
            // 
            this.dtgPessoa.AllowUserToAddRows = false;
            this.dtgPessoa.AllowUserToDeleteRows = false;
            this.dtgPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgPessoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Documento,
            this.Telefone,
            this.Vinculo,
            this.Empresa});
            this.dtgPessoa.Location = new System.Drawing.Point(17, 58);
            this.dtgPessoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgPessoa.MultiSelect = false;
            this.dtgPessoa.Name = "dtgPessoa";
            this.dtgPessoa.ReadOnly = true;
            this.dtgPessoa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPessoa.Size = new System.Drawing.Size(450, 289);
            this.dtgPessoa.TabIndex = 6;
            this.dtgPessoa.SelectionChanged += new System.EventHandler(this.dtgPessoas_SelectionChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFechar.Image = global::SICOP.VIEW.Properties.Resources.ic_fechar;
            this.btnFechar.Location = new System.Drawing.Point(662, 500);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 50);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // imgCamera
            // 
            this.imgCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCamera.Location = new System.Drawing.Point(472, 58);
            this.imgCamera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgCamera.Name = "imgCamera";
            this.imgCamera.Size = new System.Drawing.Size(300, 190);
            this.imgCamera.TabIndex = 14;
            this.imgCamera.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Image = global::SICOP.VIEW.Properties.Resources.ic_limpar;
            this.btnLimpar.Location = new System.Drawing.Point(435, 6);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscar.Image = global::SICOP.VIEW.Properties.Resources.ic_buscar;
            this.btnBuscar.Location = new System.Drawing.Point(332, 6);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaida.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaida.Enabled = false;
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.ForeColor = System.Drawing.Color.Black;
            this.btnSaida.Location = new System.Drawing.Point(244, 499);
            this.btnSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(222, 50);
            this.btnSaida.TabIndex = 11;
            this.btnSaida.Text = "SAÍDA";
            this.btnSaida.UseVisualStyleBackColor = false;
            this.btnSaida.EnabledChanged += new System.EventHandler(this.btnSaida_EnabledChanged);
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEntrada.BackColor = System.Drawing.Color.Green;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(16, 499);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(222, 50);
            this.btnEntrada.TabIndex = 10;
            this.btnEntrada.Text = "ENTRADA";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.EnabledChanged += new System.EventHandler(this.btnEntrada_EnabledChanged);
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // gbxCarreta
            // 
            this.gbxCarreta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxCarreta.Controls.Add(this.btnAntCar);
            this.gbxCarreta.Controls.Add(this.btnProCar);
            this.gbxCarreta.Controls.Add(this.label13);
            this.gbxCarreta.Controls.Add(this.txtCidade);
            this.gbxCarreta.Controls.Add(this.txtTipo);
            this.gbxCarreta.Controls.Add(this.label5);
            this.gbxCarreta.Controls.Add(this.label12);
            this.gbxCarreta.Controls.Add(this.txtPlaca);
            this.gbxCarreta.Location = new System.Drawing.Point(16, 389);
            this.gbxCarreta.Name = "gbxCarreta";
            this.gbxCarreta.Size = new System.Drawing.Size(450, 104);
            this.gbxCarreta.TabIndex = 9;
            this.gbxCarreta.TabStop = false;
            this.gbxCarreta.Text = "Carreta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(80, 63);
            this.txtCidade.MaxLength = 15;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(140, 29);
            this.txtCidade.TabIndex = 5;
            // 
            // txtTipo
            // 
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.Location = new System.Drawing.Point(80, 28);
            this.txtTipo.MaxLength = 15;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(140, 29);
            this.txtTipo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(290, 28);
            this.txtPlaca.MaxLength = 8;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(140, 29);
            this.txtPlaca.TabIndex = 3;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // cbxCarreta
            // 
            this.cbxCarreta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxCarreta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCarreta.FormattingEnabled = true;
            this.cbxCarreta.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cbxCarreta.Location = new System.Drawing.Point(90, 354);
            this.cbxCarreta.Name = "cbxCarreta";
            this.cbxCarreta.Size = new System.Drawing.Size(121, 29);
            this.cbxCarreta.TabIndex = 8;
            this.cbxCarreta.SelectedIndexChanged += new System.EventHandler(this.cbxCarreta_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 21);
            this.label14.TabIndex = 7;
            this.label14.Text = "Carreta?";
            // 
            // btnProCar
            // 
            this.btnProCar.Enabled = false;
            this.btnProCar.Location = new System.Drawing.Point(400, 61);
            this.btnProCar.Name = "btnProCar";
            this.btnProCar.Size = new System.Drawing.Size(30, 30);
            this.btnProCar.TabIndex = 6;
            this.btnProCar.Text = ">";
            this.btnProCar.UseVisualStyleBackColor = true;
            this.btnProCar.Click += new System.EventHandler(this.btnProCar_Click);
            // 
            // btnAntCar
            // 
            this.btnAntCar.Enabled = false;
            this.btnAntCar.Location = new System.Drawing.Point(364, 61);
            this.btnAntCar.Name = "btnAntCar";
            this.btnAntCar.Size = new System.Drawing.Size(30, 30);
            this.btnAntCar.TabIndex = 7;
            this.btnAntCar.Text = "<";
            this.btnAntCar.UseVisualStyleBackColor = true;
            this.btnAntCar.Click += new System.EventHandler(this.btnAntCar_Click);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "PesCodigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 85;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "PesNome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 78;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "PesDocumento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 116;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "PesTelefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 94;
            // 
            // Vinculo
            // 
            this.Vinculo.DataPropertyName = "PesVinculo";
            this.Vinculo.HeaderText = "Vínculo";
            this.Vinculo.Name = "Vinculo";
            this.Vinculo.ReadOnly = true;
            this.Vinculo.Width = 87;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "PesEmpresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 95;
            // 
            // frmRegistrarES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.cbxCarreta);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gbxCarreta);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dtgPessoa);
            this.Controls.Add(this.imgCamera);
            this.Controls.Add(this.trvPessoa);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmRegistrarES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Entrada e Saída";
            this.Load += new System.EventHandler(this.frmConsultarPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).EndInit();
            this.gbxCarreta.ResumeLayout(false);
            this.gbxCarreta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView trvPessoa;
        private System.Windows.Forms.PictureBox imgCamera;
        private System.Windows.Forms.DataGridView dtgPessoa;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.GroupBox gbxCarreta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.ComboBox cbxCarreta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAntCar;
        private System.Windows.Forms.Button btnProCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vinculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
    }
}