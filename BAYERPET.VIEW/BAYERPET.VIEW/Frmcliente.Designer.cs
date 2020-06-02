namespace BAYERPET.VIEW
{
    partial class Frmcliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcliente));
            this.TxtCodCliente = new System.Windows.Forms.TextBox();
            this.TxtEndereço = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtIdade = new System.Windows.Forms.TextBox();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtNomeCliente = new System.Windows.Forms.TextBox();
            this.Lblnomecli = new System.Windows.Forms.Label();
            this.Lblendereçocli = new System.Windows.Forms.Label();
            this.Lblcodigocli = new System.Windows.Forms.Label();
            this.Lblnacimentocli = new System.Windows.Forms.Label();
            this.Lbltelefonecli = new System.Windows.Forms.Label();
            this.Lblcpfcli = new System.Windows.Forms.Label();
            this.Lblidentidadecli = new System.Windows.Forms.Label();
            this.Lblbairrocli = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.Lblsexocli = new System.Windows.Forms.Label();
            this.Lblcidadecli = new System.Windows.Forms.Label();
            this.TxtRG = new System.Windows.Forms.TextBox();
            this.Lbldatacadastrocli = new System.Windows.Forms.Label();
            this.TxtDataCadastro = new System.Windows.Forms.TextBox();
            this.CheckM = new System.Windows.Forms.CheckBox();
            this.CheckF = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCodCliente
            // 
            this.TxtCodCliente.Location = new System.Drawing.Point(113, 12);
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.Size = new System.Drawing.Size(82, 20);
            this.TxtCodCliente.TabIndex = 1;
            this.TxtCodCliente.TextChanged += new System.EventHandler(this.TxtCodCliente_TextChanged);
            this.TxtCodCliente.Leave += new System.EventHandler(this.TxtCodCliente_Leave);
            // 
            // TxtEndereço
            // 
            this.TxtEndereço.Location = new System.Drawing.Point(113, 128);
            this.TxtEndereço.Name = "TxtEndereço";
            this.TxtEndereço.Size = new System.Drawing.Size(351, 20);
            this.TxtEndereço.TabIndex = 7;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(113, 153);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(137, 20);
            this.TxtBairro.TabIndex = 8;
            // 
            // TxtIdade
            // 
            this.TxtIdade.Location = new System.Drawing.Point(113, 100);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(25, 20);
            this.TxtIdade.TabIndex = 5;
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(308, 179);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(132, 20);
            this.TxtCPF.TabIndex = 11;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(308, 153);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(156, 20);
            this.TxtCidade.TabIndex = 9;
            this.TxtCidade.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(227, 100);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(87, 20);
            this.TxtTelefone.TabIndex = 6;
            // 
            // TxtNomeCliente
            // 
            this.TxtNomeCliente.Location = new System.Drawing.Point(113, 46);
            this.TxtNomeCliente.Name = "TxtNomeCliente";
            this.TxtNomeCliente.Size = new System.Drawing.Size(201, 20);
            this.TxtNomeCliente.TabIndex = 2;
            // 
            // Lblnomecli
            // 
            this.Lblnomecli.AutoSize = true;
            this.Lblnomecli.Location = new System.Drawing.Point(16, 49);
            this.Lblnomecli.Name = "Lblnomecli";
            this.Lblnomecli.Size = new System.Drawing.Size(91, 13);
            this.Lblnomecli.TabIndex = 17;
            this.Lblnomecli.Text = "Nome do Cliente :";
            // 
            // Lblendereçocli
            // 
            this.Lblendereçocli.AutoSize = true;
            this.Lblendereçocli.Location = new System.Drawing.Point(51, 131);
            this.Lblendereçocli.Name = "Lblendereçocli";
            this.Lblendereçocli.Size = new System.Drawing.Size(59, 13);
            this.Lblendereçocli.TabIndex = 21;
            this.Lblendereçocli.Text = "Endereço :";
            // 
            // Lblcodigocli
            // 
            this.Lblcodigocli.AutoSize = true;
            this.Lblcodigocli.Location = new System.Drawing.Point(11, 19);
            this.Lblcodigocli.Name = "Lblcodigocli";
            this.Lblcodigocli.Size = new System.Drawing.Size(96, 13);
            this.Lblcodigocli.TabIndex = 0;
            this.Lblcodigocli.Text = "Codigo do Cliente :";
            // 
            // Lblnacimentocli
            // 
            this.Lblnacimentocli.AutoSize = true;
            this.Lblnacimentocli.Location = new System.Drawing.Point(70, 103);
            this.Lblnacimentocli.Name = "Lblnacimentocli";
            this.Lblnacimentocli.Size = new System.Drawing.Size(40, 13);
            this.Lblnacimentocli.TabIndex = 19;
            this.Lblnacimentocli.Text = "Idade :";
            // 
            // Lbltelefonecli
            // 
            this.Lbltelefonecli.AutoSize = true;
            this.Lbltelefonecli.Location = new System.Drawing.Point(166, 103);
            this.Lbltelefonecli.Name = "Lbltelefonecli";
            this.Lbltelefonecli.Size = new System.Drawing.Size(55, 13);
            this.Lbltelefonecli.TabIndex = 20;
            this.Lbltelefonecli.Text = "Telefone :";
            // 
            // Lblcpfcli
            // 
            this.Lblcpfcli.AutoSize = true;
            this.Lblcpfcli.Location = new System.Drawing.Point(269, 182);
            this.Lblcpfcli.Name = "Lblcpfcli";
            this.Lblcpfcli.Size = new System.Drawing.Size(33, 13);
            this.Lblcpfcli.TabIndex = 12;
            this.Lblcpfcli.Text = "CPF :";
            // 
            // Lblidentidadecli
            // 
            this.Lblidentidadecli.AutoSize = true;
            this.Lblidentidadecli.Location = new System.Drawing.Point(78, 182);
            this.Lblidentidadecli.Name = "Lblidentidadecli";
            this.Lblidentidadecli.Size = new System.Drawing.Size(29, 13);
            this.Lblidentidadecli.TabIndex = 23;
            this.Lblidentidadecli.Text = "RG :";
            // 
            // Lblbairrocli
            // 
            this.Lblbairrocli.AutoSize = true;
            this.Lblbairrocli.Location = new System.Drawing.Point(67, 156);
            this.Lblbairrocli.Name = "Lblbairrocli";
            this.Lblbairrocli.Size = new System.Drawing.Size(40, 13);
            this.Lblbairrocli.TabIndex = 22;
            this.Lblbairrocli.Text = "Bairro :";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(389, 215);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 14;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(258, 215);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 13;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(120, 215);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(75, 23);
            this.BtnIncluir.TabIndex = 12;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // Lblsexocli
            // 
            this.Lblsexocli.AutoSize = true;
            this.Lblsexocli.Location = new System.Drawing.Point(70, 75);
            this.Lblsexocli.Name = "Lblsexocli";
            this.Lblsexocli.Size = new System.Drawing.Size(37, 13);
            this.Lblsexocli.TabIndex = 18;
            this.Lblsexocli.Text = "Sexo :";
            // 
            // Lblcidadecli
            // 
            this.Lblcidadecli.AutoSize = true;
            this.Lblcidadecli.Location = new System.Drawing.Point(256, 156);
            this.Lblcidadecli.Name = "Lblcidadecli";
            this.Lblcidadecli.Size = new System.Drawing.Size(46, 13);
            this.Lblcidadecli.TabIndex = 11;
            this.Lblcidadecli.Text = "Cidade :";
            // 
            // TxtRG
            // 
            this.TxtRG.Location = new System.Drawing.Point(113, 179);
            this.TxtRG.Name = "TxtRG";
            this.TxtRG.Size = new System.Drawing.Size(129, 20);
            this.TxtRG.TabIndex = 10;
            this.TxtRG.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Lbldatacadastrocli
            // 
            this.Lbldatacadastrocli.AutoSize = true;
            this.Lbldatacadastrocli.Location = new System.Drawing.Point(320, 15);
            this.Lbldatacadastrocli.Name = "Lbldatacadastrocli";
            this.Lbldatacadastrocli.Size = new System.Drawing.Size(93, 13);
            this.Lbldatacadastrocli.TabIndex = 15;
            this.Lbldatacadastrocli.Text = "Data do Cadasto :";
            // 
            // TxtDataCadastro
            // 
            this.TxtDataCadastro.Location = new System.Drawing.Point(419, 12);
            this.TxtDataCadastro.Name = "TxtDataCadastro";
            this.TxtDataCadastro.Size = new System.Drawing.Size(67, 20);
            this.TxtDataCadastro.TabIndex = 16;
            // 
            // CheckM
            // 
            this.CheckM.AutoSize = true;
            this.CheckM.Location = new System.Drawing.Point(113, 74);
            this.CheckM.Name = "CheckM";
            this.CheckM.Size = new System.Drawing.Size(74, 17);
            this.CheckM.TabIndex = 3;
            this.CheckM.Text = "Masculino";
            this.CheckM.UseVisualStyleBackColor = true;
            // 
            // CheckF
            // 
            this.CheckF.AutoSize = true;
            this.CheckF.Location = new System.Drawing.Point(193, 74);
            this.CheckF.Name = "CheckF";
            this.CheckF.Size = new System.Drawing.Size(68, 17);
            this.CheckF.TabIndex = 4;
            this.CheckF.Text = "Feminino";
            this.CheckF.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Deseserializar Json";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Serializar  Json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 250);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckM);
            this.Controls.Add(this.CheckF);
            this.Controls.Add(this.TxtCodCliente);
            this.Controls.Add(this.TxtEndereço);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtDataCadastro);
            this.Controls.Add(this.TxtIdade);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.TxtRG);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtNomeCliente);
            this.Controls.Add(this.Lblsexocli);
            this.Controls.Add(this.Lblnomecli);
            this.Controls.Add(this.Lblendereçocli);
            this.Controls.Add(this.Lblcodigocli);
            this.Controls.Add(this.Lbldatacadastrocli);
            this.Controls.Add(this.Lblnacimentocli);
            this.Controls.Add(this.Lbltelefonecli);
            this.Controls.Add(this.Lblcpfcli);
            this.Controls.Add(this.Lblcidadecli);
            this.Controls.Add(this.Lblidentidadecli);
            this.Controls.Add(this.Lblbairrocli);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnIncluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmcliente";
            this.Text = "Cadastrar Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmcliente_FormClosed);
            this.Load += new System.EventHandler(this.Frmcliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodCliente;
        private System.Windows.Forms.TextBox TxtEndereço;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtIdade;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.TextBox TxtNomeCliente;
        private System.Windows.Forms.Label Lblnomecli;
        private System.Windows.Forms.Label Lblendereçocli;
        private System.Windows.Forms.Label Lblcodigocli;
        private System.Windows.Forms.Label Lblnacimentocli;
        private System.Windows.Forms.Label Lbltelefonecli;
        private System.Windows.Forms.Label Lblcpfcli;
        private System.Windows.Forms.Label Lblidentidadecli;
        private System.Windows.Forms.Label Lblbairrocli;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Label Lblsexocli;
        private System.Windows.Forms.Label Lblcidadecli;
        private System.Windows.Forms.TextBox TxtRG;
        private System.Windows.Forms.Label Lbldatacadastrocli;
        private System.Windows.Forms.TextBox TxtDataCadastro;
        private System.Windows.Forms.CheckBox CheckM;
        private System.Windows.Forms.CheckBox CheckF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}