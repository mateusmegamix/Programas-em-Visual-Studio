namespace SistemaQuiminvest
{
    partial class Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvarProduto = new System.Windows.Forms.Button();
            this.TxtNomeMaterial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.GrdProduto = new System.Windows.Forms.DataGridView();
            this.BtnSair = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(533, 398);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 14;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvarProduto
            // 
            this.BtnSalvarProduto.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarProduto.Image")));
            this.BtnSalvarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarProduto.Location = new System.Drawing.Point(452, 398);
            this.BtnSalvarProduto.Name = "BtnSalvarProduto";
            this.BtnSalvarProduto.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarProduto.TabIndex = 13;
            this.BtnSalvarProduto.Text = "Salvar";
            this.BtnSalvarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarProduto.UseVisualStyleBackColor = true;
            // 
            // TxtNomeMaterial
            // 
            this.TxtNomeMaterial.AutoSize = true;
            this.TxtNomeMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeMaterial.Location = new System.Drawing.Point(37, 15);
            this.TxtNomeMaterial.Name = "TxtNomeMaterial";
            this.TxtNomeMaterial.Size = new System.Drawing.Size(69, 20);
            this.TxtNomeMaterial.TabIndex = 0;
            this.TxtNomeMaterial.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fornecedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fabricante:";
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(112, 17);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(124, 21);
            this.txtProduto.TabIndex = 1;
            // 
            // txtFabricante
            // 
            this.txtFabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFabricante.Location = new System.Drawing.Point(352, 17);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(124, 21);
            this.txtFabricante.TabIndex = 5;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(352, 44);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(124, 21);
            this.txtFornecedor.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(482, 39);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(208, 54);
            this.txtDescricao.TabIndex = 11;
            this.txtDescricao.Text = "";
            // 
            // GrdProduto
            // 
            this.GrdProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdProduto.Location = new System.Drawing.Point(3, 99);
            this.GrdProduto.Name = "GrdProduto";
            this.GrdProduto.Size = new System.Drawing.Size(687, 293);
            this.GrdProduto.TabIndex = 12;
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(614, 398);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 34;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(112, 44);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(124, 21);
            this.txtTipo.TabIndex = 35;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(352, 71);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(124, 21);
            this.txtMarca.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Telefone:";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefone.Location = new System.Drawing.Point(112, 73);
            this.TxtTelefone.Mask = "(##)#####-####";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(124, 22);
            this.TxtTelefone.TabIndex = 39;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 433);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.GrdProduto);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNomeMaterial);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvarProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Produto_FormClosed);
            this.Load += new System.EventHandler(this.Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvarProduto;
        private System.Windows.Forms.Label TxtNomeMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.DataGridView GrdProduto;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
    }
}