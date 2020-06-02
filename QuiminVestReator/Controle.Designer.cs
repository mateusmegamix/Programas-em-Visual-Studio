namespace QuiminVestReator
{
    partial class Controle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCaldeira = new System.Windows.Forms.TextBox();
            this.TxtReator = new System.Windows.Forms.TextBox();
            this.TxtFluido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtVolDestilado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtAgitacao = new System.Windows.Forms.TextBox();
            this.TxtPressao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtAmperagem = new System.Windows.Forms.TextBox();
            this.GrdControle = new System.Windows.Forms.DataGridView();
            this.etapaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volDestiladoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caldeiraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fluidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressaoMmHgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agitacaoRpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amperagemADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.controleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.cbEtapa = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvarControle = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            
            this.txtData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etapa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora:";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(66, 45);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(66, 20);
            this.txtHora.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Caldeira:";
            // 
            // TxtCaldeira
            // 
            this.TxtCaldeira.Location = new System.Drawing.Point(83, 123);
            this.TxtCaldeira.Name = "TxtCaldeira";
            this.TxtCaldeira.Size = new System.Drawing.Size(49, 20);
            this.TxtCaldeira.TabIndex = 8;
            // 
            // TxtReator
            // 
            this.TxtReator.Location = new System.Drawing.Point(214, 123);
            this.TxtReator.Name = "TxtReator";
            this.TxtReator.Size = new System.Drawing.Size(49, 20);
            this.TxtReator.TabIndex = 9;
            // 
            // TxtFluido
            // 
            this.TxtFluido.Location = new System.Drawing.Point(342, 123);
            this.TxtFluido.Name = "TxtFluido";
            this.TxtFluido.Size = new System.Drawing.Size(49, 20);
            this.TxtFluido.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Reator:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fluído:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(403, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Volume Destilado:";
            // 
            // TxtVolDestilado
            // 
            this.TxtVolDestilado.Location = new System.Drawing.Point(533, 12);
            this.TxtVolDestilado.Name = "TxtVolDestilado";
            this.TxtVolDestilado.Size = new System.Drawing.Size(57, 20);
            this.TxtVolDestilado.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Pressão (mm Hg): ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(211, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Agitação (RPM):";
            // 
            // TxtAgitacao
            // 
            this.TxtAgitacao.Location = new System.Drawing.Point(341, 177);
            this.TxtAgitacao.Name = "TxtAgitacao";
            this.TxtAgitacao.Size = new System.Drawing.Size(49, 20);
            this.TxtAgitacao.TabIndex = 17;
            // 
            // TxtPressao
            // 
            this.TxtPressao.Location = new System.Drawing.Point(142, 177);
            this.TxtPressao.Name = "TxtPressao";
            this.TxtPressao.Size = new System.Drawing.Size(49, 20);
            this.TxtPressao.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(420, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Amperagem (A):";
            // 
            // TxtAmperagem
            // 
            this.TxtAmperagem.Location = new System.Drawing.Point(550, 177);
            this.TxtAmperagem.Name = "TxtAmperagem";
            this.TxtAmperagem.Size = new System.Drawing.Size(49, 20);
            this.TxtAmperagem.TabIndex = 20;
            // 
            // GrdControle
            // 
            this.GrdControle.AutoGenerateColumns = false;
            this.GrdControle.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrdControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdControle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etapaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.volDestiladoDataGridViewTextBoxColumn,
            this.caldeiraDataGridViewTextBoxColumn,
            this.reatorDataGridViewTextBoxColumn,
            this.fluidoDataGridViewTextBoxColumn,
            this.pressaoMmHgDataGridViewTextBoxColumn,
            this.agitacaoRpmDataGridViewTextBoxColumn,
            this.amperagemADataGridViewTextBoxColumn,
            this.BtnAlterar,
            this.BtnExcluir});
            this.GrdControle.DataSource = this.controleBindingSource;
            this.GrdControle.Location = new System.Drawing.Point(6, 226);
            this.GrdControle.Name = "GrdControle";
            this.GrdControle.Size = new System.Drawing.Size(698, 173);
            this.GrdControle.TabIndex = 24;
            this.GrdControle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdControle_CellContentClick);
            // 
            // etapaDataGridViewTextBoxColumn
            // 
            this.etapaDataGridViewTextBoxColumn.DataPropertyName = "Etapa";
            this.etapaDataGridViewTextBoxColumn.HeaderText = "Etapa";
            this.etapaDataGridViewTextBoxColumn.Name = "etapaDataGridViewTextBoxColumn";
            this.etapaDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // volDestiladoDataGridViewTextBoxColumn
            // 
            this.volDestiladoDataGridViewTextBoxColumn.DataPropertyName = "VolDestilado";
            this.volDestiladoDataGridViewTextBoxColumn.HeaderText = "VolDestilado";
            this.volDestiladoDataGridViewTextBoxColumn.Name = "volDestiladoDataGridViewTextBoxColumn";
            // 
            // caldeiraDataGridViewTextBoxColumn
            // 
            this.caldeiraDataGridViewTextBoxColumn.DataPropertyName = "Caldeira";
            this.caldeiraDataGridViewTextBoxColumn.HeaderText = "Caldeira";
            this.caldeiraDataGridViewTextBoxColumn.Name = "caldeiraDataGridViewTextBoxColumn";
            // 
            // reatorDataGridViewTextBoxColumn
            // 
            this.reatorDataGridViewTextBoxColumn.DataPropertyName = "Reator";
            this.reatorDataGridViewTextBoxColumn.HeaderText = "Reator";
            this.reatorDataGridViewTextBoxColumn.Name = "reatorDataGridViewTextBoxColumn";
            // 
            // fluidoDataGridViewTextBoxColumn
            // 
            this.fluidoDataGridViewTextBoxColumn.DataPropertyName = "Fluido";
            this.fluidoDataGridViewTextBoxColumn.HeaderText = "Fluido";
            this.fluidoDataGridViewTextBoxColumn.Name = "fluidoDataGridViewTextBoxColumn";
            // 
            // pressaoMmHgDataGridViewTextBoxColumn
            // 
            this.pressaoMmHgDataGridViewTextBoxColumn.DataPropertyName = "PressaoMmHg";
            this.pressaoMmHgDataGridViewTextBoxColumn.HeaderText = "PressaoMmHg";
            this.pressaoMmHgDataGridViewTextBoxColumn.Name = "pressaoMmHgDataGridViewTextBoxColumn";
            // 
            // agitacaoRpmDataGridViewTextBoxColumn
            // 
            this.agitacaoRpmDataGridViewTextBoxColumn.DataPropertyName = "AgitacaoRpm";
            this.agitacaoRpmDataGridViewTextBoxColumn.HeaderText = "AgitacaoRpm";
            this.agitacaoRpmDataGridViewTextBoxColumn.Name = "agitacaoRpmDataGridViewTextBoxColumn";
            // 
            // amperagemADataGridViewTextBoxColumn
            // 
            this.amperagemADataGridViewTextBoxColumn.DataPropertyName = "AmperagemA";
            this.amperagemADataGridViewTextBoxColumn.HeaderText = "AmperagemA";
            this.amperagemADataGridViewTextBoxColumn.Name = "amperagemADataGridViewTextBoxColumn";
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.DataPropertyName = "BtnAlterar";
            this.BtnAlterar.HeaderText = "Alterar";
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.ReadOnly = true;
            this.BtnAlterar.Width = 50;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.DataPropertyName = "BtnExcluir";
            this.BtnExcluir.HeaderText = "Excluir";
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.ReadOnly = true;
            this.BtnExcluir.Width = 50;
            // 
            // controleBindingSource
            // 
            this.controleBindingSource.DataMember = "controle";
            // 
            // reatorDataSet1
            // 
            // 
            // cbEtapa
            // 
            this.cbEtapa.FormattingEnabled = true;
            this.cbEtapa.Location = new System.Drawing.Point(66, 12);
            this.cbEtapa.Name = "cbEtapa";
            this.cbEtapa.Size = new System.Drawing.Size(325, 21);
            this.cbEtapa.TabIndex = 25;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(698, 317);
            this.dataGridView2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Temperatura C °";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(541, 405);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 64;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvarControle
            // 
            this.BtnSalvarControle.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarControle.Image")));
            this.BtnSalvarControle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarControle.Location = new System.Drawing.Point(460, 405);
            this.BtnSalvarControle.Name = "BtnSalvarControle";
            this.BtnSalvarControle.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarControle.TabIndex = 23;
            this.BtnSalvarControle.Text = "Salvar";
            this.BtnSalvarControle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarControle.UseVisualStyleBackColor = true;
            this.BtnSalvarControle.Click += new System.EventHandler(this.BtnSalvarControle_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(622, 405);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 22;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // controleTableAdapter
            // 
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(197, 45);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(66, 20);
            this.txtData.TabIndex = 65;
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 445);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEtapa);
            this.Controls.Add(this.GrdControle);
            this.Controls.Add(this.BtnSalvarControle);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TxtAmperagem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtPressao);
            this.Controls.Add(this.TxtAgitacao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtVolDestilado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtFluido);
            this.Controls.Add(this.TxtReator);
            this.Controls.Add(this.TxtCaldeira);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Controle";
            this.Text = "Controle";
            this.Load += new System.EventHandler(this.Controle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCaldeira;
        private System.Windows.Forms.TextBox TxtReator;
        private System.Windows.Forms.TextBox TxtFluido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtVolDestilado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtAgitacao;
        private System.Windows.Forms.TextBox TxtPressao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtAmperagem;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnSalvarControle;
        private System.Windows.Forms.DataGridView GrdControle;
        private System.Windows.Forms.BindingSource controleBindingSource;
        private System.Windows.Forms.ComboBox cbEtapa;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn BtnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn etapaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volDestiladoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caldeiraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fluidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressaoMmHgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agitacaoRpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amperagemADataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.TextBox txtData;
    }
}