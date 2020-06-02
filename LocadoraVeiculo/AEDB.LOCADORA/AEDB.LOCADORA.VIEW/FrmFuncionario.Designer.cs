namespace AEDB.LOCADORA.VIEW
{
    partial class FrmFuncionario
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
            this.LblCodFunc = new System.Windows.Forms.Label();
            this.LblTelFunc = new System.Windows.Forms.Label();
            this.LblNomeFunc = new System.Windows.Forms.Label();
            this.LblCpfFunc = new System.Windows.Forms.Label();
            this.LblNascFunc = new System.Windows.Forms.Label();
            this.TxtCodFunc = new System.Windows.Forms.TextBox();
            this.TxtNomeFunc = new System.Windows.Forms.TextBox();
            this.TxtCpfFunc = new System.Windows.Forms.TextBox();
            this.TxtTelFunc = new System.Windows.Forms.TextBox();
            this.TxtNascFunc = new System.Windows.Forms.MaskedTextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GrdFuncionario = new System.Windows.Forms.DataGridView();
            this.CodFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NascFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodFunc
            // 
            this.LblCodFunc.AutoSize = true;
            this.LblCodFunc.Location = new System.Drawing.Point(70, 19);
            this.LblCodFunc.Name = "LblCodFunc";
            this.LblCodFunc.Size = new System.Drawing.Size(43, 13);
            this.LblCodFunc.TabIndex = 0;
            this.LblCodFunc.Text = "Código:";
            // 
            // LblTelFunc
            // 
            this.LblTelFunc.AutoSize = true;
            this.LblTelFunc.Location = new System.Drawing.Point(61, 107);
            this.LblTelFunc.Name = "LblTelFunc";
            this.LblTelFunc.Size = new System.Drawing.Size(52, 13);
            this.LblTelFunc.TabIndex = 0;
            this.LblTelFunc.Text = "Telefone:";
            // 
            // LblNomeFunc
            // 
            this.LblNomeFunc.AutoSize = true;
            this.LblNomeFunc.Location = new System.Drawing.Point(75, 46);
            this.LblNomeFunc.Name = "LblNomeFunc";
            this.LblNomeFunc.Size = new System.Drawing.Size(38, 13);
            this.LblNomeFunc.TabIndex = 0;
            this.LblNomeFunc.Text = "Nome:";
            // 
            // LblCpfFunc
            // 
            this.LblCpfFunc.AutoSize = true;
            this.LblCpfFunc.Location = new System.Drawing.Point(83, 77);
            this.LblCpfFunc.Name = "LblCpfFunc";
            this.LblCpfFunc.Size = new System.Drawing.Size(30, 13);
            this.LblCpfFunc.TabIndex = 0;
            this.LblCpfFunc.Text = "CPF:";
            // 
            // LblNascFunc
            // 
            this.LblNascFunc.AutoSize = true;
            this.LblNascFunc.Location = new System.Drawing.Point(6, 135);
            this.LblNascFunc.Name = "LblNascFunc";
            this.LblNascFunc.Size = new System.Drawing.Size(107, 13);
            this.LblNascFunc.TabIndex = 0;
            this.LblNascFunc.Text = "Data de Nascimento:";
            // 
            // TxtCodFunc
            // 
            this.TxtCodFunc.Location = new System.Drawing.Point(119, 16);
            this.TxtCodFunc.Name = "TxtCodFunc";
            this.TxtCodFunc.Size = new System.Drawing.Size(45, 20);
            this.TxtCodFunc.TabIndex = 1;
            // 
            // TxtNomeFunc
            // 
            this.TxtNomeFunc.Location = new System.Drawing.Point(119, 43);
            this.TxtNomeFunc.Name = "TxtNomeFunc";
            this.TxtNomeFunc.Size = new System.Drawing.Size(227, 20);
            this.TxtNomeFunc.TabIndex = 1;
            // 
            // TxtCpfFunc
            // 
            this.TxtCpfFunc.Location = new System.Drawing.Point(119, 74);
            this.TxtCpfFunc.Name = "TxtCpfFunc";
            this.TxtCpfFunc.Size = new System.Drawing.Size(100, 20);
            this.TxtCpfFunc.TabIndex = 1;
            // 
            // TxtTelFunc
            // 
            this.TxtTelFunc.Location = new System.Drawing.Point(119, 104);
            this.TxtTelFunc.Name = "TxtTelFunc";
            this.TxtTelFunc.Size = new System.Drawing.Size(100, 20);
            this.TxtTelFunc.TabIndex = 1;
            // 
            // TxtNascFunc
            // 
            this.TxtNascFunc.Location = new System.Drawing.Point(120, 135);
            this.TxtNascFunc.Mask = "00/00/0000";
            this.TxtNascFunc.Name = "TxtNascFunc";
            this.TxtNascFunc.Size = new System.Drawing.Size(65, 20);
            this.TxtNascFunc.TabIndex = 2;
            this.TxtNascFunc.ValidatingType = typeof(System.DateTime);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(120, 173);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(80, 39);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(229, 173);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(80, 39);
            this.BtnFechar.TabIndex = 3;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // GrdFuncionario
            // 
            this.GrdFuncionario.AllowUserToAddRows = false;
            this.GrdFuncionario.AllowUserToDeleteRows = false;
            this.GrdFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodFunc,
            this.NomeFunc,
            this.CpfFunc,
            this.TelFunc,
            this.NascFunc,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdFuncionario.Location = new System.Drawing.Point(13, 236);
            this.GrdFuncionario.Name = "GrdFuncionario";
            this.GrdFuncionario.Size = new System.Drawing.Size(794, 150);
            this.GrdFuncionario.TabIndex = 4;
            // 
            // CodFunc
            // 
            this.CodFunc.DataPropertyName = "CodFunc";
            this.CodFunc.HeaderText = "Código";
            this.CodFunc.Name = "CodFunc";
            this.CodFunc.ReadOnly = true;
            this.CodFunc.Width = 50;
            // 
            // NomeFunc
            // 
            this.NomeFunc.DataPropertyName = "NomeFunc";
            this.NomeFunc.HeaderText = "Nome";
            this.NomeFunc.Name = "NomeFunc";
            this.NomeFunc.ReadOnly = true;
            this.NomeFunc.Width = 300;
            // 
            // CpfFunc
            // 
            this.CpfFunc.DataPropertyName = "CpfFunc";
            this.CpfFunc.HeaderText = "CPF";
            this.CpfFunc.Name = "CpfFunc";
            this.CpfFunc.ReadOnly = true;
            // 
            // TelFunc
            // 
            this.TelFunc.DataPropertyName = "TelFunc";
            this.TelFunc.HeaderText = "Telefone";
            this.TelFunc.Name = "TelFunc";
            this.TelFunc.ReadOnly = true;
            // 
            // NascFunc
            // 
            this.NascFunc.DataPropertyName = "NascFunc";
            this.NascFunc.HeaderText = "Nascimento";
            this.NascFunc.Name = "NascFunc";
            this.NascFunc.ReadOnly = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DataPropertyName = "BtnAlterar";
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Width = 50;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.DataPropertyName = "BtnExcluir";
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Width = 50;
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.GrdFuncionario);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtNascFunc);
            this.Controls.Add(this.TxtTelFunc);
            this.Controls.Add(this.TxtCpfFunc);
            this.Controls.Add(this.TxtNomeFunc);
            this.Controls.Add(this.TxtCodFunc);
            this.Controls.Add(this.LblNascFunc);
            this.Controls.Add(this.LblCpfFunc);
            this.Controls.Add(this.LblNomeFunc);
            this.Controls.Add(this.LblTelFunc);
            this.Controls.Add(this.LblCodFunc);
            this.Name = "FrmFuncionario";
            this.Text = "Cadastro de Funcionário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFuncionario_FormClosed);
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodFunc;
        private System.Windows.Forms.Label LblTelFunc;
        private System.Windows.Forms.Label LblNomeFunc;
        private System.Windows.Forms.Label LblCpfFunc;
        private System.Windows.Forms.Label LblNascFunc;
        private System.Windows.Forms.TextBox TxtCodFunc;
        private System.Windows.Forms.TextBox TxtNomeFunc;
        private System.Windows.Forms.TextBox TxtCpfFunc;
        private System.Windows.Forms.TextBox TxtTelFunc;
        private System.Windows.Forms.MaskedTextBox TxtNascFunc;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataGridView GrdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NascFunc;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
    }
}