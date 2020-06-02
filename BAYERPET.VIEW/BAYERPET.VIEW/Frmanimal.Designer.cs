namespace BAYERPET.VIEW
{
    partial class Frmanimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmanimal));
            this.TxtCor = new System.Windows.Forms.TextBox();
            this.TxtEspecie = new System.Windows.Forms.TextBox();
            this.TxtNomeAnimal = new System.Windows.Forms.TextBox();
            this.Lblnomeanimal = new System.Windows.Forms.Label();
            this.LblSexoanimal = new System.Windows.Forms.Label();
            this.Lblcoranimal = new System.Windows.Forms.Label();
            this.Lblespecieanimal = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.Lbldonoanimal = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.CheckF = new System.Windows.Forms.CheckBox();
            this.CheckM = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInformaçao = new System.Windows.Forms.RichTextBox();
            this.TxtCodCliente = new System.Windows.Forms.TextBox();
            this.Lblcodigoanimal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDataEntrada = new System.Windows.Forms.TextBox();
            this.TxtHoraEntrada = new System.Windows.Forms.TextBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCor
            // 
            this.TxtCor.Location = new System.Drawing.Point(105, 88);
            this.TxtCor.Name = "TxtCor";
            this.TxtCor.Size = new System.Drawing.Size(46, 20);
            this.TxtCor.TabIndex = 13;
            // 
            // TxtEspecie
            // 
            this.TxtEspecie.Location = new System.Drawing.Point(105, 62);
            this.TxtEspecie.Name = "TxtEspecie";
            this.TxtEspecie.Size = new System.Drawing.Size(113, 20);
            this.TxtEspecie.TabIndex = 11;
            this.TxtEspecie.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtNomeAnimal
            // 
            this.TxtNomeAnimal.Location = new System.Drawing.Point(105, 36);
            this.TxtNomeAnimal.Name = "TxtNomeAnimal";
            this.TxtNomeAnimal.Size = new System.Drawing.Size(113, 20);
            this.TxtNomeAnimal.TabIndex = 5;
            // 
            // Lblnomeanimal
            // 
            this.Lblnomeanimal.AutoSize = true;
            this.Lblnomeanimal.Location = new System.Drawing.Point(9, 36);
            this.Lblnomeanimal.Name = "Lblnomeanimal";
            this.Lblnomeanimal.Size = new System.Drawing.Size(90, 13);
            this.Lblnomeanimal.TabIndex = 4;
            this.Lblnomeanimal.Text = "Nome do Animal :";
            // 
            // LblSexoanimal
            // 
            this.LblSexoanimal.AutoSize = true;
            this.LblSexoanimal.Location = new System.Drawing.Point(285, 91);
            this.LblSexoanimal.Name = "LblSexoanimal";
            this.LblSexoanimal.Size = new System.Drawing.Size(37, 13);
            this.LblSexoanimal.TabIndex = 14;
            this.LblSexoanimal.Text = "Sexo :";
            // 
            // Lblcoranimal
            // 
            this.Lblcoranimal.AutoSize = true;
            this.Lblcoranimal.Location = new System.Drawing.Point(70, 91);
            this.Lblcoranimal.Name = "Lblcoranimal";
            this.Lblcoranimal.Size = new System.Drawing.Size(29, 13);
            this.Lblcoranimal.TabIndex = 12;
            this.Lblcoranimal.Text = "Cor :";
            // 
            // Lblespecieanimal
            // 
            this.Lblespecieanimal.AutoSize = true;
            this.Lblespecieanimal.Location = new System.Drawing.Point(48, 65);
            this.Lblespecieanimal.Name = "Lblespecieanimal";
            this.Lblespecieanimal.Size = new System.Drawing.Size(51, 13);
            this.Lblespecieanimal.TabIndex = 10;
            this.Lblespecieanimal.Text = "Especie :";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(384, 245);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 20;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(75, 245);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(75, 23);
            this.BtnIncluir.TabIndex = 18;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // Lbldonoanimal
            // 
            this.Lbldonoanimal.AutoSize = true;
            this.Lbldonoanimal.Location = new System.Drawing.Point(231, 9);
            this.Lbldonoanimal.Name = "Lbldonoanimal";
            this.Lbldonoanimal.Size = new System.Drawing.Size(91, 13);
            this.Lbldonoanimal.TabIndex = 2;
            this.Lbldonoanimal.Text = "Nome do Cliente :";
            this.Lbldonoanimal.Click += new System.EventHandler(this.Lbldonoanimal_Click);
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(328, 6);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(196, 21);
            this.CboCliente.TabIndex = 3;
            this.CboCliente.SelectedIndexChanged += new System.EventHandler(this.CboCliente_SelectedIndexChanged);
            // 
            // CheckF
            // 
            this.CheckF.AutoSize = true;
            this.CheckF.Location = new System.Drawing.Point(395, 90);
            this.CheckF.Name = "CheckF";
            this.CheckF.Size = new System.Drawing.Size(55, 17);
            this.CheckF.TabIndex = 16;
            this.CheckF.Text = "fêmea";
            this.CheckF.UseVisualStyleBackColor = true;
            // 
            // CheckM
            // 
            this.CheckM.AutoSize = true;
            this.CheckM.Location = new System.Drawing.Point(327, 90);
            this.CheckM.Name = "CheckM";
            this.CheckM.Size = new System.Drawing.Size(58, 17);
            this.CheckM.TabIndex = 15;
            this.CheckM.Text = "macho";
            this.CheckM.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Informações adicionais sobre o animal";
            // 
            // TxtInformaçao
            // 
            this.TxtInformaçao.Location = new System.Drawing.Point(12, 141);
            this.TxtInformaçao.Name = "TxtInformaçao";
            this.TxtInformaçao.Size = new System.Drawing.Size(682, 98);
            this.TxtInformaçao.TabIndex = 17;
            this.TxtInformaçao.Text = "";
            // 
            // TxtCodCliente
            // 
            this.TxtCodCliente.Location = new System.Drawing.Point(105, 6);
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.Size = new System.Drawing.Size(113, 20);
            this.TxtCodCliente.TabIndex = 1;
            this.TxtCodCliente.TextChanged += new System.EventHandler(this.TxtCodCliente_TextChanged);
            this.TxtCodCliente.Leave += new System.EventHandler(this.TxtCodCliente_Leave);
            // 
            // Lblcodigoanimal
            // 
            this.Lblcodigoanimal.AutoSize = true;
            this.Lblcodigoanimal.Location = new System.Drawing.Point(3, 9);
            this.Lblcodigoanimal.Name = "Lblcodigoanimal";
            this.Lblcodigoanimal.Size = new System.Drawing.Size(96, 13);
            this.Lblcodigoanimal.TabIndex = 0;
            this.Lblcodigoanimal.Text = "Codigo do Cliente :";
            this.Lblcodigoanimal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data Entrada :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora Entrada :";
            // 
            // TxtDataEntrada
            // 
            this.TxtDataEntrada.Location = new System.Drawing.Point(328, 33);
            this.TxtDataEntrada.Name = "TxtDataEntrada";
            this.TxtDataEntrada.Size = new System.Drawing.Size(83, 20);
            this.TxtDataEntrada.TabIndex = 7;
            // 
            // TxtHoraEntrada
            // 
            this.TxtHoraEntrada.Location = new System.Drawing.Point(327, 59);
            this.TxtHoraEntrada.Name = "TxtHoraEntrada";
            this.TxtHoraEntrada.Size = new System.Drawing.Size(83, 20);
            this.TxtHoraEntrada.TabIndex = 9;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(233, 245);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 19;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Serializar  Json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Deseserializar Json";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frmanimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 278);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.TxtHoraEntrada);
            this.Controls.Add(this.TxtDataEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtInformaçao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckM);
            this.Controls.Add(this.CheckF);
            this.Controls.Add(this.CboCliente);
            this.Controls.Add(this.TxtCor);
            this.Controls.Add(this.TxtCodCliente);
            this.Controls.Add(this.TxtEspecie);
            this.Controls.Add(this.TxtNomeAnimal);
            this.Controls.Add(this.Lbldonoanimal);
            this.Controls.Add(this.Lblnomeanimal);
            this.Controls.Add(this.LblSexoanimal);
            this.Controls.Add(this.Lblcodigoanimal);
            this.Controls.Add(this.Lblcoranimal);
            this.Controls.Add(this.Lblespecieanimal);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnIncluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmanimal";
            this.Text = "Cadastrar Animal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmanimal_FormClosed);
            this.Load += new System.EventHandler(this.Frmanimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtCor;
        private System.Windows.Forms.TextBox TxtEspecie;
        private System.Windows.Forms.TextBox TxtNomeAnimal;
        private System.Windows.Forms.Label Lblnomeanimal;
        private System.Windows.Forms.Label LblSexoanimal;
        private System.Windows.Forms.Label Lblcoranimal;
        private System.Windows.Forms.Label Lblespecieanimal;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Label Lbldonoanimal;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.CheckBox CheckF;
        private System.Windows.Forms.CheckBox CheckM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TxtInformaçao;
        private System.Windows.Forms.TextBox TxtCodCliente;
        private System.Windows.Forms.Label Lblcodigoanimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDataEntrada;
        private System.Windows.Forms.TextBox TxtHoraEntrada;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}