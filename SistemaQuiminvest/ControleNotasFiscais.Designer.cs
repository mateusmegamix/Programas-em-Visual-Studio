namespace SistemaQuiminvest
{
    partial class ControleNotasFiscais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleNotasFiscais));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecebimento = new System.Windows.Forms.TextBox();
            this.GrdNotas = new System.Windows.Forms.DataGridView();
            this.ctrlNotasFiscaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quiminvestDataSet = new SistemaQuiminvest.QuiminvestDataSet();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvarControleNF = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtDataNF = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraNF = new System.Windows.Forms.MaskedTextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.ctrlNotasFiscaisTableAdapter = new SistemaQuiminvest.QuiminvestDataSetTableAdapters.CtrlNotasFiscaisTableAdapter();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlNotasFiscaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiminvestDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(386, 41);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(36, 16);
            this.txtData.TabIndex = 10;
            this.txtData.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hora:";
            // 
            // txtEntrega
            // 
            this.txtEntrega.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrega.Location = new System.Drawing.Point(138, 66);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(170, 22);
            this.txtEntrega.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entregue Para:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(305, 9);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(205, 22);
            this.txtFornecedor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fornecedor:";
            // 
            // txtNF
            // 
            this.txtNF.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNF.Location = new System.Drawing.Point(138, 9);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(82, 22);
            this.txtNF.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Número Nota Fiscal:";
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(138, 37);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(237, 22);
            this.txtProduto.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Recebido Por:";
            // 
            // txtRecebimento
            // 
            this.txtRecebimento.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecebimento.Location = new System.Drawing.Point(138, 94);
            this.txtRecebimento.Name = "txtRecebimento";
            this.txtRecebimento.Size = new System.Drawing.Size(170, 22);
            this.txtRecebimento.TabIndex = 9;
            // 
            // GrdNotas
            // 
            this.GrdNotas.AutoGenerateColumns = false;
            this.GrdNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnAlterar,
            this.BtnExcluir,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.GrdNotas.DataSource = this.ctrlNotasFiscaisBindingSource;
            this.GrdNotas.Location = new System.Drawing.Point(10, 135);
            this.GrdNotas.Name = "GrdNotas";
            this.GrdNotas.Size = new System.Drawing.Size(500, 268);
            this.GrdNotas.TabIndex = 16;
            this.GrdNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdNotas_CellContentClick);
            // 
            // ctrlNotasFiscaisBindingSource
            // 
            this.ctrlNotasFiscaisBindingSource.DataMember = "CtrlNotasFiscais";
            this.ctrlNotasFiscaisBindingSource.DataSource = this.quiminvestDataSet;
            // 
            // quiminvestDataSet
            // 
            this.quiminvestDataSet.DataSetName = "QuiminvestDataSet";
            this.quiminvestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(354, 409);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 15;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvarControleNF
            // 
            this.BtnSalvarControleNF.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarControleNF.Image")));
            this.BtnSalvarControleNF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarControleNF.Location = new System.Drawing.Point(354, 90);
            this.BtnSalvarControleNF.Name = "BtnSalvarControleNF";
            this.BtnSalvarControleNF.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarControleNF.TabIndex = 14;
            this.BtnSalvarControleNF.Text = "Salvar";
            this.BtnSalvarControleNF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarControleNF.UseVisualStyleBackColor = true;
            this.BtnSalvarControleNF.Click += new System.EventHandler(this.BtnSalvarControleNF_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(435, 409);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 17;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TxtDataNF
            // 
            this.TxtDataNF.Location = new System.Drawing.Point(440, 37);
            this.TxtDataNF.Mask = "##/##/####";
            this.TxtDataNF.Name = "TxtDataNF";
            this.TxtDataNF.Size = new System.Drawing.Size(70, 20);
            this.TxtDataNF.TabIndex = 11;
            // 
            // txtHoraNF
            // 
            this.txtHoraNF.Location = new System.Drawing.Point(440, 65);
            this.txtHoraNF.Mask = "00:00";
            this.txtHoraNF.Name = "txtHoraNF";
            this.txtHoraNF.Size = new System.Drawing.Size(70, 20);
            this.txtHoraNF.TabIndex = 13;
            this.txtHoraNF.ValidatingType = typeof(System.DateTime);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Location = new System.Drawing.Point(435, 90);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // ctrlNotasFiscaisTableAdapter
            // 
            this.ctrlNotasFiscaisTableAdapter.ClearBeforeFill = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DataPropertyName = "BtnAlterar";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine;
            this.BtnAlterar.DefaultCellStyle = dataGridViewCellStyle1;
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.ReadOnly = true;
            this.BtnAlterar.Width = 50;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.DataPropertyName = "BtnExcluir";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.BtnExcluir.DefaultCellStyle = dataGridViewCellStyle2;
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.ReadOnly = true;
            this.BtnExcluir.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NumeroNF";
            this.dataGridViewTextBoxColumn8.HeaderText = "NumeroNF";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Entrega";
            this.dataGridViewTextBoxColumn4.HeaderText = "Entrega";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Recebido";
            this.dataGridViewTextBoxColumn5.HeaderText = "Recebido";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn7.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // ControleNotasFiscais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 443);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtHoraNF);
            this.Controls.Add(this.TxtDataNF);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvarControleNF);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.GrdNotas);
            this.Controls.Add(this.txtRecebimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEntrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControleNotasFiscais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Entrada de Notas Fiscais";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControleNotasFiscais_FormClosed);
            this.Load += new System.EventHandler(this.ControleNotasFiscais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlNotasFiscaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiminvestDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecebimento;
        private System.Windows.Forms.DataGridView GrdNotas;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvarControleNF;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.MaskedTextBox TxtDataNF;
        private System.Windows.Forms.MaskedTextBox txtHoraNF;
        private System.Windows.Forms.Button btnImprimir;
        private QuiminvestDataSet quiminvestDataSet;
        private System.Windows.Forms.BindingSource ctrlNotasFiscaisBindingSource;
        private QuiminvestDataSetTableAdapters.CtrlNotasFiscaisTableAdapter ctrlNotasFiscaisTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}