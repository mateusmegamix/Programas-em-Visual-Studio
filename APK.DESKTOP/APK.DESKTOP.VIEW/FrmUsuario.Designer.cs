namespace APK.DESKTOP.VIEW
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnCancelarUsuario = new System.Windows.Forms.Button();
            this.BtnSalvarUsuario = new System.Windows.Forms.Button();
            this.GridUsuario = new System.Windows.Forms.DataGridView();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codigoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confSenhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoUsuarioDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataNascUsuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tccDataSetUsuario = new APK.DESKTOP.VIEW.tccDataSetUsuario();
            this.TxtDateUsuario = new System.Windows.Forms.MaskedTextBox();
            this.TxtConfirmarSenhaUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbSexoUsuario = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmailUsuario = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.TxtNomeUsuario = new System.Windows.Forms.TextBox();
            this.PbImagem = new System.Windows.Forms.PictureBox();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.TxtAbrir = new System.Windows.Forms.TextBox();
            this.cadastroUsuarioTableAdapter = new APK.DESKTOP.VIEW.tccDataSetUsuarioTableAdapters.CadastroUsuarioTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(513, 413);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnCancelarUsuario
            // 
            this.BtnCancelarUsuario.Location = new System.Drawing.Point(513, 167);
            this.BtnCancelarUsuario.Name = "BtnCancelarUsuario";
            this.BtnCancelarUsuario.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarUsuario.TabIndex = 15;
            this.BtnCancelarUsuario.Text = "Cancelar";
            this.BtnCancelarUsuario.UseVisualStyleBackColor = true;
            this.BtnCancelarUsuario.Click += new System.EventHandler(this.BtnCancelarUsuario_Click);
            // 
            // BtnSalvarUsuario
            // 
            this.BtnSalvarUsuario.Location = new System.Drawing.Point(427, 167);
            this.BtnSalvarUsuario.Name = "BtnSalvarUsuario";
            this.BtnSalvarUsuario.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvarUsuario.TabIndex = 14;
            this.BtnSalvarUsuario.Text = "Salvar";
            this.BtnSalvarUsuario.UseVisualStyleBackColor = true;
            this.BtnSalvarUsuario.Click += new System.EventHandler(this.BtnSalvarUsuario_Click);
            // 
            // GridUsuario
            // 
            this.GridUsuario.AutoGenerateColumns = false;
            this.GridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnAlterar,
            this.BtnExcluir,
            this.codigoUsuarioDataGridViewTextBoxColumn,
            this.nomeUsuarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.senhaUsuarioDataGridViewTextBoxColumn,
            this.confSenhaDataGridViewTextBoxColumn,
            this.fotoUsuarioDataGridViewImageColumn,
            this.dataNascUsuaDataGridViewTextBoxColumn});
            this.GridUsuario.DataSource = this.cadastroUsuarioBindingSource;
            this.GridUsuario.Location = new System.Drawing.Point(12, 196);
            this.GridUsuario.Name = "GridUsuario";
            this.GridUsuario.Size = new System.Drawing.Size(576, 211);
            this.GridUsuario.TabIndex = 16;
            this.GridUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuario_CellContentClick);
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
            // codigoUsuarioDataGridViewTextBoxColumn
            // 
            this.codigoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "CodigoUsuario";
            this.codigoUsuarioDataGridViewTextBoxColumn.HeaderText = "CodigoUsuario";
            this.codigoUsuarioDataGridViewTextBoxColumn.Name = "codigoUsuarioDataGridViewTextBoxColumn";
            this.codigoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeUsuarioDataGridViewTextBoxColumn
            // 
            this.nomeUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NomeUsuario";
            this.nomeUsuarioDataGridViewTextBoxColumn.HeaderText = "NomeUsuario";
            this.nomeUsuarioDataGridViewTextBoxColumn.Name = "nomeUsuarioDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // senhaUsuarioDataGridViewTextBoxColumn
            // 
            this.senhaUsuarioDataGridViewTextBoxColumn.DataPropertyName = "SenhaUsuario";
            this.senhaUsuarioDataGridViewTextBoxColumn.HeaderText = "SenhaUsuario";
            this.senhaUsuarioDataGridViewTextBoxColumn.Name = "senhaUsuarioDataGridViewTextBoxColumn";
            // 
            // confSenhaDataGridViewTextBoxColumn
            // 
            this.confSenhaDataGridViewTextBoxColumn.DataPropertyName = "ConfSenha";
            this.confSenhaDataGridViewTextBoxColumn.HeaderText = "ConfSenha";
            this.confSenhaDataGridViewTextBoxColumn.Name = "confSenhaDataGridViewTextBoxColumn";
            // 
            // fotoUsuarioDataGridViewImageColumn
            // 
            this.fotoUsuarioDataGridViewImageColumn.DataPropertyName = "FotoUsuario";
            this.fotoUsuarioDataGridViewImageColumn.HeaderText = "FotoUsuario";
            this.fotoUsuarioDataGridViewImageColumn.Name = "fotoUsuarioDataGridViewImageColumn";
            // 
            // dataNascUsuaDataGridViewTextBoxColumn
            // 
            this.dataNascUsuaDataGridViewTextBoxColumn.DataPropertyName = "DataNascUsua";
            this.dataNascUsuaDataGridViewTextBoxColumn.HeaderText = "DataNascUsua";
            this.dataNascUsuaDataGridViewTextBoxColumn.Name = "dataNascUsuaDataGridViewTextBoxColumn";
            // 
            // cadastroUsuarioBindingSource
            // 
            this.cadastroUsuarioBindingSource.DataMember = "CadastroUsuario";
            this.cadastroUsuarioBindingSource.DataSource = this.tccDataSetUsuario;
            // 
            // tccDataSetUsuario
            // 
            this.tccDataSetUsuario.DataSetName = "tccDataSetUsuario";
            this.tccDataSetUsuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtDateUsuario
            // 
            this.TxtDateUsuario.Location = new System.Drawing.Point(312, 101);
            this.TxtDateUsuario.Mask = "##/##/####";
            this.TxtDateUsuario.Name = "TxtDateUsuario";
            this.TxtDateUsuario.Size = new System.Drawing.Size(70, 20);
            this.TxtDateUsuario.TabIndex = 10;
            // 
            // TxtConfirmarSenhaUsuario
            // 
            this.TxtConfirmarSenhaUsuario.Location = new System.Drawing.Point(302, 128);
            this.TxtConfirmarSenhaUsuario.Name = "TxtConfirmarSenhaUsuario";
            this.TxtConfirmarSenhaUsuario.Size = new System.Drawing.Size(126, 20);
            this.TxtConfirmarSenhaUsuario.TabIndex = 12;
            // 
            // TxtSenhaUsuario
            // 
            this.TxtSenhaUsuario.Location = new System.Drawing.Point(79, 128);
            this.TxtSenhaUsuario.Name = "TxtSenhaUsuario";
            this.TxtSenhaUsuario.Size = new System.Drawing.Size(118, 20);
            this.TxtSenhaUsuario.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(394, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Foto :";
            // 
            // CbSexoUsuario
            // 
            this.CbSexoUsuario.FormattingEnabled = true;
            this.CbSexoUsuario.Location = new System.Drawing.Point(79, 101);
            this.CbSexoUsuario.Name = "CbSexoUsuario";
            this.CbSexoUsuario.Size = new System.Drawing.Size(97, 21);
            this.CbSexoUsuario.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(205, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Confirmar Senha :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(29, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Senha :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(35, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(196, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Data de Nascimento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(36, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexo :";
            // 
            // TxtEmailUsuario
            // 
            this.TxtEmailUsuario.Location = new System.Drawing.Point(79, 75);
            this.TxtEmailUsuario.Name = "TxtEmailUsuario";
            this.TxtEmailUsuario.Size = new System.Drawing.Size(303, 20);
            this.TxtEmailUsuario.TabIndex = 3;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.ForeColor = System.Drawing.SystemColors.Window;
            this.Nome.Location = new System.Drawing.Point(32, 52);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(41, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome :";
            // 
            // TxtNomeUsuario
            // 
            this.TxtNomeUsuario.Location = new System.Drawing.Point(79, 49);
            this.TxtNomeUsuario.Name = "TxtNomeUsuario";
            this.TxtNomeUsuario.Size = new System.Drawing.Size(303, 20);
            this.TxtNomeUsuario.TabIndex = 1;
            // 
            // PbImagem
            // 
            this.PbImagem.Image = ((System.Drawing.Image)(resources.GetObject("PbImagem.Image")));
            this.PbImagem.Location = new System.Drawing.Point(434, 43);
            this.PbImagem.Name = "PbImagem";
            this.PbImagem.Size = new System.Drawing.Size(154, 105);
            this.PbImagem.TabIndex = 49;
            this.PbImagem.TabStop = false;
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Location = new System.Drawing.Point(304, 12);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(42, 20);
            this.BtnAbrir.TabIndex = 51;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // TxtAbrir
            // 
            this.TxtAbrir.Location = new System.Drawing.Point(352, 12);
            this.TxtAbrir.Name = "TxtAbrir";
            this.TxtAbrir.Size = new System.Drawing.Size(237, 20);
            this.TxtAbrir.TabIndex = 50;
            // 
            // cadastroUsuarioTableAdapter
            // 
            this.cadastroUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(601, 446);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.TxtAbrir);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCancelarUsuario);
            this.Controls.Add(this.BtnSalvarUsuario);
            this.Controls.Add(this.GridUsuario);
            this.Controls.Add(this.TxtDateUsuario);
            this.Controls.Add(this.TxtConfirmarSenhaUsuario);
            this.Controls.Add(this.TxtSenhaUsuario);
            this.Controls.Add(this.PbImagem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CbSexoUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEmailUsuario);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.TxtNomeUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tccDataSetUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnCancelarUsuario;
        private System.Windows.Forms.Button BtnSalvarUsuario;
        private System.Windows.Forms.DataGridView GridUsuario;
        private System.Windows.Forms.MaskedTextBox TxtDateUsuario;
        private System.Windows.Forms.TextBox TxtConfirmarSenhaUsuario;
        private System.Windows.Forms.TextBox TxtSenhaUsuario;
        private System.Windows.Forms.PictureBox PbImagem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CbSexoUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmailUsuario;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox TxtNomeUsuario;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.TextBox TxtAbrir;
        private tccDataSetUsuario tccDataSetUsuario;
        private System.Windows.Forms.BindingSource cadastroUsuarioBindingSource;
        private tccDataSetUsuarioTableAdapters.CadastroUsuarioTableAdapter cadastroUsuarioTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confSenhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoUsuarioDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascUsuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}