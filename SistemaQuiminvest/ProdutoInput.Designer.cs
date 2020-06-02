namespace SistemaQuiminvest
{
    partial class ProdutoInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoInput));
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdEntrada = new System.Windows.Forms.TextBox();
            this.txtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.TxtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtResponsavelEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeMaterial = new System.Windows.Forms.Label();
            this.GrdEntrada = new System.Windows.Forms.DataGridView();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvarControle = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Responsavel:";
            // 
            // txtQtdEntrada
            // 
            this.txtQtdEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdEntrada.Location = new System.Drawing.Point(202, 366);
            this.txtQtdEntrada.Name = "txtQtdEntrada";
            this.txtQtdEntrada.Size = new System.Drawing.Size(67, 21);
            this.txtQtdEntrada.TabIndex = 4;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraEntrada.Location = new System.Drawing.Point(471, 340);
            this.txtHoraEntrada.Mask = "00:00";
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(70, 21);
            this.txtHoraEntrada.TabIndex = 8;
            this.txtHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDataEntrada
            // 
            this.TxtDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataEntrada.Location = new System.Drawing.Point(341, 341);
            this.TxtDataEntrada.Mask = "##/##/####";
            this.TxtDataEntrada.Name = "TxtDataEntrada";
            this.TxtDataEntrada.Size = new System.Drawing.Size(70, 21);
            this.TxtDataEntrada.TabIndex = 6;
            // 
            // txtResponsavelEntrada
            // 
            this.txtResponsavelEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsavelEntrada.Location = new System.Drawing.Point(123, 339);
            this.txtResponsavelEntrada.Name = "txtResponsavelEntrada";
            this.txtResponsavelEntrada.Size = new System.Drawing.Size(146, 21);
            this.txtResponsavelEntrada.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade em estoque:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hora:";
            // 
            // TxtNomeMaterial
            // 
            this.TxtNomeMaterial.AutoSize = true;
            this.TxtNomeMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeMaterial.Location = new System.Drawing.Point(287, 339);
            this.TxtNomeMaterial.Name = "TxtNomeMaterial";
            this.TxtNomeMaterial.Size = new System.Drawing.Size(48, 20);
            this.TxtNomeMaterial.TabIndex = 5;
            this.TxtNomeMaterial.Text = "Data:";
            // 
            // GrdEntrada
            // 
            this.GrdEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdEntrada.Location = new System.Drawing.Point(4, 66);
            this.GrdEntrada.Name = "GrdEntrada";
            this.GrdEntrada.Size = new System.Drawing.Size(541, 257);
            this.GrdEntrada.TabIndex = 0;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(385, 384);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 10;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvarControle
            // 
            this.BtnSalvarControle.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarControle.Image")));
            this.BtnSalvarControle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarControle.Location = new System.Drawing.Point(304, 384);
            this.BtnSalvarControle.Name = "BtnSalvarControle";
            this.BtnSalvarControle.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarControle.TabIndex = 9;
            this.BtnSalvarControle.Text = "Entrada";
            this.BtnSalvarControle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarControle.UseVisualStyleBackColor = true;
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(466, 384);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 35;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(79, 10);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(162, 23);
            this.cbProduto.TabIndex = 39;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(79, 39);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(162, 21);
            this.txtTipo.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Produto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(354, 10);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(191, 50);
            this.txtDescricao.TabIndex = 51;
            this.txtDescricao.Text = "";
            // 
            // ProdutoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 421);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdEntrada);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.TxtDataEntrada);
            this.Controls.Add(this.txtResponsavelEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeMaterial);
            this.Controls.Add(this.GrdEntrada);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvarControle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProdutoInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProdutoInput_FormClosed);
            this.Load += new System.EventHandler(this.ProdutoInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdEntrada;
        private System.Windows.Forms.MaskedTextBox txtHoraEntrada;
        private System.Windows.Forms.MaskedTextBox TxtDataEntrada;
        private System.Windows.Forms.TextBox txtResponsavelEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtNomeMaterial;
        private System.Windows.Forms.DataGridView GrdEntrada;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvarControle;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtDescricao;
    }
}