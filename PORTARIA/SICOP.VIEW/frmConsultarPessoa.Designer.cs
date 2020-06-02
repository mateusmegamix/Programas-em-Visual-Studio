namespace SICOP.VIEW
{
    partial class frmConsultarPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPessoa));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trvPessoa = new System.Windows.Forms.TreeView();
            this.dtgPessoa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vinculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.imgCamera = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 7;
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
            this.txtBuscar.TabIndex = 8;
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
            this.cbxFiltro.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 11;
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
            this.trvPessoa.TabIndex = 13;
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
            this.Empresa,
            this.Alterar,
            this.Excluir});
            this.dtgPessoa.Location = new System.Drawing.Point(17, 58);
            this.dtgPessoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgPessoa.MultiSelect = false;
            this.dtgPessoa.Name = "dtgPessoa";
            this.dtgPessoa.ReadOnly = true;
            this.dtgPessoa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPessoa.Size = new System.Drawing.Size(450, 435);
            this.dtgPessoa.TabIndex = 15;
            this.dtgPessoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPessoa_CellClick);
            this.dtgPessoa.SelectionChanged += new System.EventHandler(this.dtgPessoas_SelectionChanged);
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
            // Alterar
            // 
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.Name = "Alterar";
            this.Alterar.ReadOnly = true;
            this.Alterar.Text = "✔";
            this.Alterar.UseColumnTextForButtonValue = true;
            this.Alterar.Width = 63;
            // 
            // Excluir
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            this.Excluir.DefaultCellStyle = dataGridViewCellStyle1;
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Text = "✖";
            this.Excluir.UseColumnTextForButtonValue = true;
            this.Excluir.Width = 61;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReport.Image = global::SICOP.VIEW.Properties.Resources.ic_report;
            this.btnReport.Location = new System.Drawing.Point(546, 500);
            this.btnReport.Name = "btnReport";
            this.btnReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReport.Size = new System.Drawing.Size(110, 50);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "FICHA";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFechar.Image = global::SICOP.VIEW.Properties.Resources.ic_fechar;
            this.btnFechar.Location = new System.Drawing.Point(662, 500);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 50);
            this.btnFechar.TabIndex = 17;
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
            this.btnLimpar.TabIndex = 10;
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
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmConsultarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnReport);
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
            this.Name = "frmConsultarPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Pessoas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultarPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vinculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.Button btnReport;
    }
}