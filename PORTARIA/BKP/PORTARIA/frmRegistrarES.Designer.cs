namespace PORTARIA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarES));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgPessoa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.imgCamera = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dados pessoais:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Foto:";
            // 
            // btnSaida
            // 
            this.btnSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaida.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaida.Enabled = false;
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.ForeColor = System.Drawing.Color.Black;
            this.btnSaida.Location = new System.Drawing.Point(274, 418);
            this.btnSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(254, 81);
            this.btnSaida.TabIndex = 12;
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
            this.btnEntrada.Location = new System.Drawing.Point(15, 418);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(254, 81);
            this.btnEntrada.TabIndex = 11;
            this.btnEntrada.Text = "ENTRADA";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.EnabledChanged += new System.EventHandler(this.btnEntrada_EnabledChanged);
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Motorista e Veículo:";
            // 
            // dtgPessoa
            // 
            this.dtgPessoa.AllowUserToAddRows = false;
            this.dtgPessoa.AllowUserToDeleteRows = false;
            this.dtgPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Categoria,
            this.Nome,
            this.Documento,
            this.Tel,
            this.Empresa});
            this.dtgPessoa.Location = new System.Drawing.Point(14, 99);
            this.dtgPessoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgPessoa.MultiSelect = false;
            this.dtgPessoa.Name = "dtgPessoa";
            this.dtgPessoa.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgPessoa.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPessoa.Size = new System.Drawing.Size(518, 312);
            this.dtgPessoa.TabIndex = 7;
            this.dtgPessoa.SelectionChanged += new System.EventHandler(this.dtgPessoa_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 84;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 103;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 76;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 117;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Telefone";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 96;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "Empresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtro:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(63, 24);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.MaxLength = 100;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(259, 26);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            this.cbxFiltro.Location = new System.Drawing.Point(645, 24);
            this.cbxFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(121, 28);
            this.cbxFiltro.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrando por:";
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.BackColor = System.Drawing.Color.LightBlue;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtInfo.Location = new System.Drawing.Point(541, 264);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(220, 148);
            this.txtInfo.TabIndex = 10;
            this.txtInfo.Text = "";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::PORTARIA.Properties.Resources.ic_limpar;
            this.btnLimpar.Location = new System.Drawing.Point(431, 12);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 50);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFechar.Image = global::PORTARIA.Properties.Resources.ic_fechar;
            this.btnFechar.Location = new System.Drawing.Point(651, 449);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.imgCamera.Location = new System.Drawing.Point(541, 99);
            this.imgCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgCamera.Name = "imgCamera";
            this.imgCamera.Size = new System.Drawing.Size(220, 140);
            this.imgCamera.TabIndex = 21;
            this.imgCamera.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::PORTARIA.Properties.Resources.ic_buscar;
            this.btnBuscar.Location = new System.Drawing.Point(328, 12);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 50);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmRegistrarES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.imgCamera);
            this.Controls.Add(this.dtgPessoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistrarES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Entrada e Saída de Pessoal";
            this.Load += new System.EventHandler(this.frmConsultarPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox imgCamera;
        private System.Windows.Forms.DataGridView dtgPessoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
    }
}