namespace SistemaQuiminvest
{
    partial class OrdemProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdemProducao));
            this.BtnSair = new System.Windows.Forms.Button();
            this.txtLoteProducao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProducao = new System.Windows.Forms.ComboBox();
            this.txtDataOP = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraOP = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbO1 = new System.Windows.Forms.ComboBox();
            this.cbO3 = new System.Windows.Forms.ComboBox();
            this.cbO2 = new System.Windows.Forms.ComboBox();
            this.ho1 = new System.Windows.Forms.MaskedTextBox();
            this.ho2 = new System.Windows.Forms.MaskedTextBox();
            this.ho3 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ha3 = new System.Windows.Forms.MaskedTextBox();
            this.ha2 = new System.Windows.Forms.MaskedTextBox();
            this.ha1 = new System.Windows.Forms.MaskedTextBox();
            this.cbA2 = new System.Windows.Forms.ComboBox();
            this.cbA3 = new System.Windows.Forms.ComboBox();
            this.cbA1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cbM1 = new System.Windows.Forms.ComboBox();
            this.cbM2 = new System.Windows.Forms.ComboBox();
            this.cbM3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLoteM1 = new System.Windows.Forms.TextBox();
            this.txtLoteM2 = new System.Windows.Forms.TextBox();
            this.txtLoteM3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQtd1 = new System.Windows.Forms.TextBox();
            this.txtQtd3 = new System.Windows.Forms.TextBox();
            this.txtQtd2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.GrdOrdemProducao = new System.Windows.Forms.DataGridView();
            this.btnImprimirOP = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSalvarOP = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOrdemProducao)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(356, 512);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 30);
            this.BtnSair.TabIndex = 46;
            this.BtnSair.Text = "Fechar";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // txtLoteProducao
            // 
            this.txtLoteProducao.Location = new System.Drawing.Point(65, 65);
            this.txtLoteProducao.Name = "txtLoteProducao";
            this.txtLoteProducao.Size = new System.Drawing.Size(167, 20);
            this.txtLoteProducao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            // 
            // cbProducao
            // 
            this.cbProducao.FormattingEnabled = true;
            this.cbProducao.Items.AddRange(new object[] {
            "RESINA QUIMIFEN N290"});
            this.cbProducao.Location = new System.Drawing.Point(65, 32);
            this.cbProducao.Name = "cbProducao";
            this.cbProducao.Size = new System.Drawing.Size(167, 21);
            this.cbProducao.TabIndex = 1;
            this.cbProducao.SelectedIndexChanged += new System.EventHandler(this.cbProducao_SelectedIndexChanged);
            // 
            // txtDataOP
            // 
            this.txtDataOP.Location = new System.Drawing.Point(307, 32);
            this.txtDataOP.Mask = "##/##/####";
            this.txtDataOP.Name = "txtDataOP";
            this.txtDataOP.Size = new System.Drawing.Size(70, 20);
            this.txtDataOP.TabIndex = 39;
            // 
            // txtHoraOP
            // 
            this.txtHoraOP.Location = new System.Drawing.Point(307, 65);
            this.txtHoraOP.Mask = "00:00";
            this.txtHoraOP.Name = "txtHoraOP";
            this.txtHoraOP.Size = new System.Drawing.Size(55, 20);
            this.txtHoraOP.TabIndex = 41;
            this.txtHoraOP.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operadores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lote N°:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(205, 127);
            this.dataGridView1.TabIndex = 5;
            // 
            // cbO1
            // 
            this.cbO1.FormattingEnabled = true;
            this.cbO1.Location = new System.Drawing.Point(27, 154);
            this.cbO1.Name = "cbO1";
            this.cbO1.Size = new System.Drawing.Size(125, 21);
            this.cbO1.TabIndex = 7;
            // 
            // cbO3
            // 
            this.cbO3.FormattingEnabled = true;
            this.cbO3.Location = new System.Drawing.Point(27, 208);
            this.cbO3.Name = "cbO3";
            this.cbO3.Size = new System.Drawing.Size(125, 21);
            this.cbO3.TabIndex = 12;
            // 
            // cbO2
            // 
            this.cbO2.FormattingEnabled = true;
            this.cbO2.Location = new System.Drawing.Point(27, 181);
            this.cbO2.Name = "cbO2";
            this.cbO2.Size = new System.Drawing.Size(125, 21);
            this.cbO2.TabIndex = 10;
            // 
            // ho1
            // 
            this.ho1.Location = new System.Drawing.Point(173, 156);
            this.ho1.Mask = "00:00";
            this.ho1.Name = "ho1";
            this.ho1.Size = new System.Drawing.Size(35, 20);
            this.ho1.TabIndex = 9;
            this.ho1.ValidatingType = typeof(System.DateTime);
            // 
            // ho2
            // 
            this.ho2.Location = new System.Drawing.Point(173, 182);
            this.ho2.Mask = "00:00";
            this.ho2.Name = "ho2";
            this.ho2.Size = new System.Drawing.Size(35, 20);
            this.ho2.TabIndex = 11;
            this.ho2.ValidatingType = typeof(System.DateTime);
            // 
            // ho3
            // 
            this.ho3.Location = new System.Drawing.Point(173, 208);
            this.ho3.Mask = "00:00";
            this.ho3.Name = "ho3";
            this.ho3.Size = new System.Drawing.Size(35, 20);
            this.ho3.TabIndex = 13;
            this.ho3.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Matérias Primas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Auxiliares";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Turno:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Turno:";
            // 
            // ha3
            // 
            this.ha3.Location = new System.Drawing.Point(384, 208);
            this.ha3.Mask = "00:00";
            this.ha3.Name = "ha3";
            this.ha3.Size = new System.Drawing.Size(35, 20);
            this.ha3.TabIndex = 23;
            this.ha3.ValidatingType = typeof(System.DateTime);
            // 
            // ha2
            // 
            this.ha2.Location = new System.Drawing.Point(384, 182);
            this.ha2.Mask = "00:00";
            this.ha2.Name = "ha2";
            this.ha2.Size = new System.Drawing.Size(35, 20);
            this.ha2.TabIndex = 21;
            this.ha2.ValidatingType = typeof(System.DateTime);
            // 
            // ha1
            // 
            this.ha1.Location = new System.Drawing.Point(384, 156);
            this.ha1.Mask = "00:00";
            this.ha1.Name = "ha1";
            this.ha1.Size = new System.Drawing.Size(35, 20);
            this.ha1.TabIndex = 19;
            this.ha1.ValidatingType = typeof(System.DateTime);
            // 
            // cbA2
            // 
            this.cbA2.FormattingEnabled = true;
            this.cbA2.Location = new System.Drawing.Point(238, 181);
            this.cbA2.Name = "cbA2";
            this.cbA2.Size = new System.Drawing.Size(125, 21);
            this.cbA2.TabIndex = 20;
            // 
            // cbA3
            // 
            this.cbA3.FormattingEnabled = true;
            this.cbA3.Location = new System.Drawing.Point(238, 208);
            this.cbA3.Name = "cbA3";
            this.cbA3.Size = new System.Drawing.Size(125, 21);
            this.cbA3.TabIndex = 22;
            // 
            // cbA1
            // 
            this.cbA1.FormattingEnabled = true;
            this.cbA1.Location = new System.Drawing.Point(238, 154);
            this.cbA1.Name = "cbA1";
            this.cbA1.Size = new System.Drawing.Size(125, 21);
            this.cbA1.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nome:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(226, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(205, 127);
            this.dataGridView2.TabIndex = 15;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(15, 276);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(416, 121);
            this.dataGridView3.TabIndex = 25;
            // 
            // cbM1
            // 
            this.cbM1.FormattingEnabled = true;
            this.cbM1.Location = new System.Drawing.Point(27, 313);
            this.cbM1.Name = "cbM1";
            this.cbM1.Size = new System.Drawing.Size(125, 21);
            this.cbM1.TabIndex = 27;
            // 
            // cbM2
            // 
            this.cbM2.FormattingEnabled = true;
            this.cbM2.Location = new System.Drawing.Point(27, 340);
            this.cbM2.Name = "cbM2";
            this.cbM2.Size = new System.Drawing.Size(125, 21);
            this.cbM2.TabIndex = 32;
            // 
            // cbM3
            // 
            this.cbM3.FormattingEnabled = true;
            this.cbM3.Location = new System.Drawing.Point(27, 367);
            this.cbM3.Name = "cbM3";
            this.cbM3.Size = new System.Drawing.Size(125, 21);
            this.cbM3.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Matérias:";
            // 
            // txtLoteM1
            // 
            this.txtLoteM1.Location = new System.Drawing.Point(173, 314);
            this.txtLoteM1.Name = "txtLoteM1";
            this.txtLoteM1.Size = new System.Drawing.Size(125, 20);
            this.txtLoteM1.TabIndex = 29;
            // 
            // txtLoteM2
            // 
            this.txtLoteM2.Location = new System.Drawing.Point(173, 340);
            this.txtLoteM2.Name = "txtLoteM2";
            this.txtLoteM2.Size = new System.Drawing.Size(125, 20);
            this.txtLoteM2.TabIndex = 33;
            // 
            // txtLoteM3
            // 
            this.txtLoteM3.Location = new System.Drawing.Point(173, 367);
            this.txtLoteM3.Name = "txtLoteM3";
            this.txtLoteM3.Size = new System.Drawing.Size(125, 20);
            this.txtLoteM3.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(170, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Lote N°:";
            // 
            // txtQtd1
            // 
            this.txtQtd1.Location = new System.Drawing.Point(320, 314);
            this.txtQtd1.Name = "txtQtd1";
            this.txtQtd1.Size = new System.Drawing.Size(84, 20);
            this.txtQtd1.TabIndex = 31;
            // 
            // txtQtd3
            // 
            this.txtQtd3.Location = new System.Drawing.Point(320, 367);
            this.txtQtd3.Name = "txtQtd3";
            this.txtQtd3.Size = new System.Drawing.Size(84, 20);
            this.txtQtd3.TabIndex = 37;
            // 
            // txtQtd2
            // 
            this.txtQtd2.Location = new System.Drawing.Point(320, 340);
            this.txtQtd2.Name = "txtQtd2";
            this.txtQtd2.Size = new System.Drawing.Size(84, 20);
            this.txtQtd2.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Quantidade - Kg:";
            // 
            // GrdOrdemProducao
            // 
            this.GrdOrdemProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdOrdemProducao.Location = new System.Drawing.Point(437, 5);
            this.GrdOrdemProducao.Name = "GrdOrdemProducao";
            this.GrdOrdemProducao.Size = new System.Drawing.Size(440, 545);
            this.GrdOrdemProducao.TabIndex = 42;
            this.GrdOrdemProducao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdOrdemProducao_CellContentClick);
            // 
            // btnImprimirOP
            // 
            this.btnImprimirOP.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirOP.Image")));
            this.btnImprimirOP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirOP.Location = new System.Drawing.Point(194, 512);
            this.btnImprimirOP.Name = "btnImprimirOP";
            this.btnImprimirOP.Size = new System.Drawing.Size(75, 30);
            this.btnImprimirOP.TabIndex = 44;
            this.btnImprimirOP.Text = "Imprimir";
            this.btnImprimirOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirOP.UseVisualStyleBackColor = true;
            this.btnImprimirOP.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.Image")));
            this.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLimpar.Location = new System.Drawing.Point(275, 512);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 30);
            this.BtnLimpar.TabIndex = 45;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSalvarOP
            // 
            this.BtnSalvarOP.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarOP.Image")));
            this.BtnSalvarOP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarOP.Location = new System.Drawing.Point(113, 512);
            this.BtnSalvarOP.Name = "BtnSalvarOP";
            this.BtnSalvarOP.Size = new System.Drawing.Size(75, 30);
            this.BtnSalvarOP.TabIndex = 43;
            this.BtnSalvarOP.Text = "Salvar";
            this.BtnSalvarOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarOP.UseVisualStyleBackColor = true;
            this.BtnSalvarOP.Click += new System.EventHandler(this.BtnSalvarOP_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(16, 419);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(415, 87);
            this.txtObservacao.TabIndex = 47;
            this.txtObservacao.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 405);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Observação";
            // 
            // OrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 554);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.btnImprimirOP);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvarOP);
            this.Controls.Add(this.GrdOrdemProducao);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtQtd2);
            this.Controls.Add(this.txtQtd3);
            this.Controls.Add(this.txtQtd1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLoteM3);
            this.Controls.Add(this.txtLoteM2);
            this.Controls.Add(this.txtLoteM1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbM3);
            this.Controls.Add(this.cbM2);
            this.Controls.Add(this.cbM1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ho3);
            this.Controls.Add(this.ho2);
            this.Controls.Add(this.ho1);
            this.Controls.Add(this.cbO2);
            this.Controls.Add(this.cbO3);
            this.Controls.Add(this.cbO1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoraOP);
            this.Controls.Add(this.txtDataOP);
            this.Controls.Add(this.cbProducao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoteProducao);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ha3);
            this.Controls.Add(this.ha2);
            this.Controls.Add(this.ha1);
            this.Controls.Add(this.cbA2);
            this.Controls.Add(this.cbA3);
            this.Controls.Add(this.cbA1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OrdemProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Produção";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdemProducao_FormClosed);
            this.Load += new System.EventHandler(this.OrdemProducao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdOrdemProducao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.TextBox txtLoteProducao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProducao;
        private System.Windows.Forms.MaskedTextBox txtDataOP;
        private System.Windows.Forms.MaskedTextBox txtHoraOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbO1;
        private System.Windows.Forms.ComboBox cbO3;
        private System.Windows.Forms.ComboBox cbO2;
        private System.Windows.Forms.MaskedTextBox ho1;
        private System.Windows.Forms.MaskedTextBox ho2;
        private System.Windows.Forms.MaskedTextBox ho3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox ha3;
        private System.Windows.Forms.MaskedTextBox ha2;
        private System.Windows.Forms.MaskedTextBox ha1;
        private System.Windows.Forms.ComboBox cbA2;
        private System.Windows.Forms.ComboBox cbA3;
        private System.Windows.Forms.ComboBox cbA1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox cbM1;
        private System.Windows.Forms.ComboBox cbM2;
        private System.Windows.Forms.ComboBox cbM3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLoteM1;
        private System.Windows.Forms.TextBox txtLoteM2;
        private System.Windows.Forms.TextBox txtLoteM3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQtd1;
        private System.Windows.Forms.TextBox txtQtd3;
        private System.Windows.Forms.TextBox txtQtd2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView GrdOrdemProducao;
        private System.Windows.Forms.Button btnImprimirOP;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSalvarOP;
        private System.Windows.Forms.RichTextBox txtObservacao;
        private System.Windows.Forms.Label label15;
    }
}