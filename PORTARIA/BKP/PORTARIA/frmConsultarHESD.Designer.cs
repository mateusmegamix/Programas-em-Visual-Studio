namespace PORTARIA
{
    partial class frmConsultarHESD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarHESD));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgES = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgCamera = new System.Windows.Forms.PictureBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPessoa = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBuscar = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscar.Image = global::PORTARIA.Properties.Resources.ic_buscar;
            this.btnBuscar.Location = new System.Drawing.Point(307, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 49);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data:";
            // 
            // dtgES
            // 
            this.dtgES.AllowUserToAddRows = false;
            this.dtgES.AllowUserToDeleteRows = false;
            this.dtgES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CodPessoa,
            this.Datae,
            this.HoraEntrada,
            this.HoraSaida});
            this.dtgES.Location = new System.Drawing.Point(16, 92);
            this.dtgES.MultiSelect = false;
            this.dtgES.Name = "dtgES";
            this.dtgES.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgES.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgES.Size = new System.Drawing.Size(495, 316);
            this.dtgES.TabIndex = 5;
            this.dtgES.SelectionChanged += new System.EventHandler(this.dtgPessoa_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 84;
            // 
            // CodPessoa
            // 
            this.CodPessoa.DataPropertyName = "CodPessoa";
            this.CodPessoa.HeaderText = "Código Pessoa";
            this.CodPessoa.Name = "CodPessoa";
            this.CodPessoa.ReadOnly = true;
            this.CodPessoa.Width = 129;
            // 
            // Datae
            // 
            this.Datae.DataPropertyName = "Datae";
            this.Datae.HeaderText = "Data";
            this.Datae.Name = "Datae";
            this.Datae.ReadOnly = true;
            this.Datae.Width = 69;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.DataPropertyName = "HoraEntrada";
            this.HoraEntrada.HeaderText = "Hora da Entrada";
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.ReadOnly = true;
            this.HoraEntrada.Width = 139;
            // 
            // HoraSaida
            // 
            this.HoraSaida.DataPropertyName = "HoraSaida";
            this.HoraSaida.HeaderText = "Hora da Saída";
            this.HoraSaida.Name = "HoraSaida";
            this.HoraSaida.ReadOnly = true;
            this.HoraSaida.Width = 124;
            // 
            // imgCamera
            // 
            this.imgCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCamera.Location = new System.Drawing.Point(776, 92);
            this.imgCamera.Name = "imgCamera";
            this.imgCamera.Size = new System.Drawing.Size(220, 140);
            this.imgCamera.TabIndex = 6;
            this.imgCamera.TabStop = false;
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.BackColor = System.Drawing.Color.LightBlue;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtInfo.Location = new System.Drawing.Point(776, 260);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(220, 148);
            this.txtInfo.TabIndex = 6;
            this.txtInfo.Text = "";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFechar.Image = global::PORTARIA.Properties.Resources.ic_fechar;
            this.btnFechar.Location = new System.Drawing.Point(886, 414);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 49);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Image = global::PORTARIA.Properties.Resources.ic_limpar;
            this.btnLimpar.Location = new System.Drawing.Point(411, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 49);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(774, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Motorista e Veículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pessoa:";
            // 
            // txtPessoa
            // 
            this.txtPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPessoa.BackColor = System.Drawing.Color.Khaki;
            this.txtPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPessoa.Location = new System.Drawing.Point(517, 92);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.ReadOnly = true;
            this.txtPessoa.Size = new System.Drawing.Size(251, 316);
            this.txtPessoa.TabIndex = 11;
            this.txtPessoa.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Histórico de Entradas e Saídas:";
            // 
            // dtpBuscar
            // 
            this.dtpBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscar.Location = new System.Drawing.Point(66, 23);
            this.dtpBuscar.Name = "dtpBuscar";
            this.dtpBuscar.Size = new System.Drawing.Size(235, 29);
            this.dtpBuscar.TabIndex = 13;
            this.dtpBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpBuscar_KeyPress);
            // 
            // frmConsultarHESD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 475);
            this.Controls.Add(this.dtpBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPessoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.imgCamera);
            this.Controls.Add(this.dtgES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultarHESD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Entradas e Saídas por Data";
            this.Load += new System.EventHandler(this.frmConsultarPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgES;
        private System.Windows.Forms.PictureBox imgCamera;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtPessoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datae;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSaida;
        private System.Windows.Forms.DateTimePicker dtpBuscar;
    }
}