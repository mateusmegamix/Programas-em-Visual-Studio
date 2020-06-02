namespace AEDB.LOCADORA.VIEW
{
    partial class FrmClientee
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
            this.LblCodCli = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.LblTel = new System.Windows.Forms.Label();
            this.LblDataNasc = new System.Windows.Forms.Label();
            this.TxtCodCli = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GrdClientee = new System.Windows.Forms.DataGridView();
            this.CodCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtDataNasc = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdClientee)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodCli
            // 
            this.LblCodCli.AutoSize = true;
            this.LblCodCli.Location = new System.Drawing.Point(26, 18);
            this.LblCodCli.Name = "LblCodCli";
            this.LblCodCli.Size = new System.Drawing.Size(43, 13);
            this.LblCodCli.TabIndex = 0;
            this.LblCodCli.Text = "Código:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(31, 49);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome:";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Location = new System.Drawing.Point(39, 81);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(30, 13);
            this.LblCpf.TabIndex = 2;
            this.LblCpf.Text = "CPF:";
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Location = new System.Drawing.Point(13, 113);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(56, 13);
            this.LblEndereco.TabIndex = 3;
            this.LblEndereco.Text = "Endereço:";
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Location = new System.Drawing.Point(17, 142);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(52, 13);
            this.LblTel.TabIndex = 4;
            this.LblTel.Text = "Telefone:";
            // 
            // LblDataNasc
            // 
            this.LblDataNasc.AutoSize = true;
            this.LblDataNasc.Location = new System.Drawing.Point(3, 173);
            this.LblDataNasc.Name = "LblDataNasc";
            this.LblDataNasc.Size = new System.Drawing.Size(66, 13);
            this.LblDataNasc.TabIndex = 5;
            this.LblDataNasc.Text = "Nascimento:";
            // 
            // TxtCodCli
            // 
            this.TxtCodCli.Location = new System.Drawing.Point(72, 18);
            this.TxtCodCli.MaxLength = 20;
            this.TxtCodCli.Name = "TxtCodCli";
            this.TxtCodCli.Size = new System.Drawing.Size(62, 20);
            this.TxtCodCli.TabIndex = 6;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(72, 49);
            this.TxtNome.MaxLength = 200;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(370, 20);
            this.TxtNome.TabIndex = 7;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(72, 81);
            this.TxtCpf.MaxLength = 15;
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(145, 20);
            this.TxtCpf.TabIndex = 8;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(72, 113);
            this.TxtEndereco.MaxLength = 100;
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(370, 20);
            this.TxtEndereco.TabIndex = 9;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(72, 142);
            this.TxtTel.MaxLength = 10;
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(145, 20);
            this.TxtTel.TabIndex = 10;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(72, 200);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(79, 39);
            this.BtnSalvar.TabIndex = 12;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(166, 200);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(79, 38);
            this.BtnFechar.TabIndex = 13;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // GrdClientee
            // 
            this.GrdClientee.AllowUserToAddRows = false;
            this.GrdClientee.AllowUserToDeleteRows = false;
            this.GrdClientee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdClientee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodCli,
            this.Nome,
            this.Cpf,
            this.Endereco,
            this.Tel,
            this.DataNasc,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdClientee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrdClientee.Location = new System.Drawing.Point(0, 257);
            this.GrdClientee.Name = "GrdClientee";
            this.GrdClientee.Size = new System.Drawing.Size(1100, 230);
            this.GrdClientee.TabIndex = 14;
            // 
            // CodCli
            // 
            this.CodCli.DataPropertyName = "CodCli";
            this.CodCli.HeaderText = "Código";
            this.CodCli.Name = "CodCli";
            this.CodCli.ReadOnly = true;
            this.CodCli.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Width = 300;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Telefone";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // DataNasc
            // 
            this.DataNasc.DataPropertyName = "DataNasc";
            this.DataNasc.HeaderText = "Nascimento";
            this.DataNasc.Name = "DataNasc";
            this.DataNasc.ReadOnly = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Width = 50;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Width = 50;
            // 
            // TxtDataNasc
            // 
            this.TxtDataNasc.Location = new System.Drawing.Point(72, 173);
            this.TxtDataNasc.Mask = "00/00/0000";
            this.TxtDataNasc.Name = "TxtDataNasc";
            this.TxtDataNasc.Size = new System.Drawing.Size(62, 20);
            this.TxtDataNasc.TabIndex = 15;
            this.TxtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // FrmClientee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 487);
            this.Controls.Add(this.TxtDataNasc);
            this.Controls.Add(this.GrdClientee);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtCodCli);
            this.Controls.Add(this.LblDataNasc);
            this.Controls.Add(this.LblTel);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblCodCli);
            this.Name = "FrmClientee";
            this.Text = "Cadastro de Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmClientee_FormClosed);
            this.Load += new System.EventHandler(this.FrmClientee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdClientee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodCli;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.Label LblDataNasc;
        private System.Windows.Forms.TextBox TxtCodCli;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataGridView GrdClientee;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNasc;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.MaskedTextBox TxtDataNasc;
    }
}