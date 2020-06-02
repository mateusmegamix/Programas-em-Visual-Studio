namespace SistemaQuiminvest
{
    partial class ProdutoOutput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoOutput));
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdSaida = new System.Windows.Forms.TextBox();
            this.txtHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.TxtDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtRespSaida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeMaterial = new System.Windows.Forms.Label();
            this.GrdSaida = new System.Windows.Forms.DataGridView();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvarControle = new System.Windows.Forms.Button();
            this.txtMotivoSaida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQtdEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRespEntrada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Responsavel:";
            // 
            // txtQtdSaida
            // 
            this.txtQtdSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdSaida.Location = new System.Drawing.Point(159, 372);
            this.txtQtdSaida.Name = "txtQtdSaida";
            this.txtQtdSaida.Size = new System.Drawing.Size(49, 21);
            this.txtQtdSaida.TabIndex = 4;
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraSaida.Location = new System.Drawing.Point(471, 372);
            this.txtHoraSaida.Mask = "00:00";
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(70, 21);
            this.txtHoraSaida.TabIndex = 8;
            this.txtHoraSaida.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDataSaida
            // 
            this.TxtDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataSaida.Location = new System.Drawing.Point(341, 372);
            this.TxtDataSaida.Mask = "##/##/####";
            this.TxtDataSaida.Name = "TxtDataSaida";
            this.TxtDataSaida.Size = new System.Drawing.Size(70, 21);
            this.TxtDataSaida.TabIndex = 6;
            // 
            // txtRespSaida
            // 
            this.txtRespSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespSaida.Location = new System.Drawing.Point(124, 399);
            this.txtRespSaida.Name = "txtRespSaida";
            this.txtRespSaida.Size = new System.Drawing.Size(146, 21);
            this.txtRespSaida.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade Saída:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hora:";
            // 
            // TxtNomeMaterial
            // 
            this.TxtNomeMaterial.AutoSize = true;
            this.TxtNomeMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeMaterial.Location = new System.Drawing.Point(287, 370);
            this.TxtNomeMaterial.Name = "TxtNomeMaterial";
            this.TxtNomeMaterial.Size = new System.Drawing.Size(48, 20);
            this.TxtNomeMaterial.TabIndex = 5;
            this.TxtNomeMaterial.Text = "Data:";
            // 
            // GrdSaida
            // 
            this.GrdSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdSaida.Location = new System.Drawing.Point(4, 95);
            this.GrdSaida.Name = "GrdSaida";
            this.GrdSaida.Size = new System.Drawing.Size(536, 269);
            this.GrdSaida.TabIndex = 0;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(385, 428);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 12;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvarControle
            // 
            this.BtnSalvarControle.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarControle.Image")));
            this.BtnSalvarControle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarControle.Location = new System.Drawing.Point(304, 428);
            this.BtnSalvarControle.Name = "BtnSalvarControle";
            this.BtnSalvarControle.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarControle.TabIndex = 11;
            this.BtnSalvarControle.Text = "Entrada";
            this.BtnSalvarControle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarControle.UseVisualStyleBackColor = true;
            // 
            // txtMotivoSaida
            // 
            this.txtMotivoSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoSaida.Location = new System.Drawing.Point(341, 399);
            this.txtMotivoSaida.Name = "txtMotivoSaida";
            this.txtMotivoSaida.Size = new System.Drawing.Size(200, 21);
            this.txtMotivoSaida.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Motivo:";
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(466, 428);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 36;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(350, 12);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(191, 50);
            this.txtDescricao.TabIndex = 57;
            this.txtDescricao.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Descrição:";
            // 
            // cbProduto
            // 
            this.cbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(84, 12);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(156, 23);
            this.cbProduto.TabIndex = 55;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(84, 41);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(122, 21);
            this.txtTipo.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Produto:";
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.Enabled = false;
            this.txtQtdEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdEstoque.Location = new System.Drawing.Point(462, 68);
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.Size = new System.Drawing.Size(78, 21);
            this.txtQtdEstoque.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Quatidade Estoque:";
            // 
            // txtRespEntrada
            // 
            this.txtRespEntrada.Enabled = false;
            this.txtRespEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespEntrada.Location = new System.Drawing.Point(182, 68);
            this.txtRespEntrada.Name = "txtRespEntrada";
            this.txtRespEntrada.Size = new System.Drawing.Size(78, 21);
            this.txtRespEntrada.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Responsavel Entrada:";
            // 
            // ProdutoOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(546, 460);
            this.Controls.Add(this.txtRespEntrada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQtdEstoque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.txtMotivoSaida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdSaida);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.TxtDataSaida);
            this.Controls.Add(this.txtRespSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeMaterial);
            this.Controls.Add(this.GrdSaida);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvarControle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProdutoOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProdutoOutput_FormClosed);
            this.Load += new System.EventHandler(this.ProdutoOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdSaida;
        private System.Windows.Forms.MaskedTextBox txtHoraSaida;
        private System.Windows.Forms.MaskedTextBox TxtDataSaida;
        private System.Windows.Forms.TextBox txtRespSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtNomeMaterial;
        private System.Windows.Forms.DataGridView GrdSaida;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvarControle;
        private System.Windows.Forms.TextBox txtMotivoSaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQtdEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRespEntrada;
        private System.Windows.Forms.Label label6;
    }
}