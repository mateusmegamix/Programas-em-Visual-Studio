namespace BAYERPET.VIEW
{
    partial class Frmfuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmfuncionario));
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.Lblbairro = new System.Windows.Forms.Label();
            this.Lblendereço = new System.Windows.Forms.Label();
            this.Lblcodigo = new System.Windows.Forms.Label();
            this.Lblnome = new System.Windows.Forms.Label();
            this.Lblrg = new System.Windows.Forms.Label();
            this.Lblcpf = new System.Windows.Forms.Label();
            this.Lblidade = new System.Windows.Forms.Label();
            this.TxtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.TxtRG = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtEndereço = new System.Windows.Forms.TextBox();
            this.TxtCodFuncionario = new System.Windows.Forms.TextBox();
            this.TxtCPF = new System.Windows.Forms.TextBox();
            this.Lbltelefone = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtIdade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.CheckM = new System.Windows.Forms.CheckBox();
            this.CheckF = new System.Windows.Forms.CheckBox();
            this.Lblsexocli = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(125, 174);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(75, 23);
            this.BtnIncluir.TabIndex = 12;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(249, 174);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 13;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(381, 174);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 14;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // Lblbairro
            // 
            this.Lblbairro.AutoSize = true;
            this.Lblbairro.Location = new System.Drawing.Point(23, 104);
            this.Lblbairro.Name = "Lblbairro";
            this.Lblbairro.Size = new System.Drawing.Size(40, 13);
            this.Lblbairro.TabIndex = 20;
            this.Lblbairro.Text = "Bairro :";
            // 
            // Lblendereço
            // 
            this.Lblendereço.AutoSize = true;
            this.Lblendereço.Location = new System.Drawing.Point(4, 78);
            this.Lblendereço.Name = "Lblendereço";
            this.Lblendereço.Size = new System.Drawing.Size(59, 13);
            this.Lblendereço.TabIndex = 19;
            this.Lblendereço.Text = "Endereço :";
            // 
            // Lblcodigo
            // 
            this.Lblcodigo.AutoSize = true;
            this.Lblcodigo.Location = new System.Drawing.Point(17, 9);
            this.Lblcodigo.Name = "Lblcodigo";
            this.Lblcodigo.Size = new System.Drawing.Size(119, 13);
            this.Lblcodigo.TabIndex = 0;
            this.Lblcodigo.Text = "Codigo do Funcionario :";
            this.Lblcodigo.Click += new System.EventHandler(this.Lblcodigo_Click);
            // 
            // Lblnome
            // 
            this.Lblnome.AutoSize = true;
            this.Lblnome.Location = new System.Drawing.Point(246, 9);
            this.Lblnome.Name = "Lblnome";
            this.Lblnome.Size = new System.Drawing.Size(41, 13);
            this.Lblnome.TabIndex = 15;
            this.Lblnome.Text = "Nome :";
            this.Lblnome.Click += new System.EventHandler(this.Lblnome_Click);
            // 
            // Lblrg
            // 
            this.Lblrg.AutoSize = true;
            this.Lblrg.Location = new System.Drawing.Point(34, 130);
            this.Lblrg.Name = "Lblrg";
            this.Lblrg.Size = new System.Drawing.Size(29, 13);
            this.Lblrg.TabIndex = 22;
            this.Lblrg.Text = "RG :";
            // 
            // Lblcpf
            // 
            this.Lblcpf.AutoSize = true;
            this.Lblcpf.Location = new System.Drawing.Point(234, 130);
            this.Lblcpf.Name = "Lblcpf";
            this.Lblcpf.Size = new System.Drawing.Size(33, 13);
            this.Lblcpf.TabIndex = 23;
            this.Lblcpf.Text = "CPF :";
            // 
            // Lblidade
            // 
            this.Lblidade.AutoSize = true;
            this.Lblidade.Location = new System.Drawing.Point(23, 52);
            this.Lblidade.Name = "Lblidade";
            this.Lblidade.Size = new System.Drawing.Size(40, 13);
            this.Lblidade.TabIndex = 16;
            this.Lblidade.Text = "Idade :";
            // 
            // TxtNomeFuncionario
            // 
            this.TxtNomeFuncionario.Location = new System.Drawing.Point(293, 6);
            this.TxtNomeFuncionario.Name = "TxtNomeFuncionario";
            this.TxtNomeFuncionario.Size = new System.Drawing.Size(345, 20);
            this.TxtNomeFuncionario.TabIndex = 2;
            // 
            // TxtRG
            // 
            this.TxtRG.Location = new System.Drawing.Point(69, 127);
            this.TxtRG.Name = "TxtRG";
            this.TxtRG.Size = new System.Drawing.Size(156, 20);
            this.TxtRG.TabIndex = 10;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(69, 101);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(156, 20);
            this.TxtBairro.TabIndex = 8;
            // 
            // TxtEndereço
            // 
            this.TxtEndereço.Location = new System.Drawing.Point(69, 75);
            this.TxtEndereço.Name = "TxtEndereço";
            this.TxtEndereço.Size = new System.Drawing.Size(465, 20);
            this.TxtEndereço.TabIndex = 7;
            // 
            // TxtCodFuncionario
            // 
            this.TxtCodFuncionario.Location = new System.Drawing.Point(143, 6);
            this.TxtCodFuncionario.Name = "TxtCodFuncionario";
            this.TxtCodFuncionario.Size = new System.Drawing.Size(82, 20);
            this.TxtCodFuncionario.TabIndex = 1;
            this.TxtCodFuncionario.Leave += new System.EventHandler(this.TxtCodFuncionario_Leave);
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(273, 127);
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(129, 20);
            this.TxtCPF.TabIndex = 11;
            // 
            // Lbltelefone
            // 
            this.Lbltelefone.AutoSize = true;
            this.Lbltelefone.Location = new System.Drawing.Point(129, 52);
            this.Lbltelefone.Name = "Lbltelefone";
            this.Lbltelefone.Size = new System.Drawing.Size(55, 13);
            this.Lbltelefone.TabIndex = 17;
            this.Lbltelefone.Text = "Telefone :";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(190, 49);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(85, 20);
            this.TxtTelefone.TabIndex = 4;
            // 
            // TxtIdade
            // 
            this.TxtIdade.Location = new System.Drawing.Point(69, 49);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(23, 20);
            this.TxtIdade.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cidade :";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(311, 101);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(127, 20);
            this.TxtCidade.TabIndex = 9;
            // 
            // CheckM
            // 
            this.CheckM.AutoSize = true;
            this.CheckM.Location = new System.Drawing.Point(364, 51);
            this.CheckM.Name = "CheckM";
            this.CheckM.Size = new System.Drawing.Size(74, 17);
            this.CheckM.TabIndex = 5;
            this.CheckM.Text = "Masculino";
            this.CheckM.UseVisualStyleBackColor = true;
            // 
            // CheckF
            // 
            this.CheckF.AutoSize = true;
            this.CheckF.Location = new System.Drawing.Point(444, 51);
            this.CheckF.Name = "CheckF";
            this.CheckF.Size = new System.Drawing.Size(68, 17);
            this.CheckF.TabIndex = 6;
            this.CheckF.Text = "Feminino";
            this.CheckF.UseVisualStyleBackColor = true;
            // 
            // Lblsexocli
            // 
            this.Lblsexocli.AutoSize = true;
            this.Lblsexocli.Location = new System.Drawing.Point(321, 52);
            this.Lblsexocli.Name = "Lblsexocli";
            this.Lblsexocli.Size = new System.Drawing.Size(37, 13);
            this.Lblsexocli.TabIndex = 18;
            this.Lblsexocli.Text = "Sexo :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Deseserializar Json";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Serializar  Json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frmfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 215);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckM);
            this.Controls.Add(this.CheckF);
            this.Controls.Add(this.Lblsexocli);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodFuncionario);
            this.Controls.Add(this.TxtEndereço);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtIdade);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.TxtRG);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtNomeFuncionario);
            this.Controls.Add(this.Lblnome);
            this.Controls.Add(this.Lblendereço);
            this.Controls.Add(this.Lblcodigo);
            this.Controls.Add(this.Lblidade);
            this.Controls.Add(this.Lbltelefone);
            this.Controls.Add(this.Lblcpf);
            this.Controls.Add(this.Lblrg);
            this.Controls.Add(this.Lblbairro);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnIncluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmfuncionario";
            this.Text = "Cadastrar Funcionario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmfuncionario_FormClosed);
            this.Load += new System.EventHandler(this.Frmfuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label Lblbairro;
        private System.Windows.Forms.Label Lblendereço;
        private System.Windows.Forms.Label Lblcodigo;
        private System.Windows.Forms.Label Lblnome;
        private System.Windows.Forms.Label Lblrg;
        private System.Windows.Forms.Label Lblcpf;
        private System.Windows.Forms.Label Lblidade;
        private System.Windows.Forms.TextBox TxtNomeFuncionario;
        private System.Windows.Forms.TextBox TxtRG;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtEndereço;
        private System.Windows.Forms.TextBox TxtCodFuncionario;
        private System.Windows.Forms.TextBox TxtCPF;
        private System.Windows.Forms.Label Lbltelefone;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.TextBox TxtIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.CheckBox CheckM;
        private System.Windows.Forms.CheckBox CheckF;
        private System.Windows.Forms.Label Lblsexocli;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}