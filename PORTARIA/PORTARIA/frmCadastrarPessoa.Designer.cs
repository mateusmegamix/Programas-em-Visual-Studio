namespace PORTARIA
{
    partial class frmCadastrarPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarPessoa));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtTerceiro = new System.Windows.Forms.RadioButton();
            this.rbtVisitante = new System.Windows.Forms.RadioButton();
            this.rbtColaborador = new System.Windows.Forms.RadioButton();
            this.gbxPessoal = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValidadeCNH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxMOPP = new System.Windows.Forms.CheckBox();
            this.txtCNH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxNAOSEAPLICA = new System.Windows.Forms.CheckBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.imgCamera = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxDispositivo = new System.Windows.Forms.ComboBox();
            this.gbxPessoal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 55);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(411, 26);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(92, 91);
            this.txtCPF.MaxLength = 14;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(160, 26);
            this.txtCPF.TabIndex = 6;
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Enter);
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(343, 125);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(160, 26);
            this.txtEmpresa.TabIndex = 12;
            this.txtEmpresa.TextChanged += new System.EventHandler(this.txtEmpresa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Empresa:";
            // 
            // rbtTerceiro
            // 
            this.rbtTerceiro.AutoSize = true;
            this.rbtTerceiro.Checked = true;
            this.rbtTerceiro.Location = new System.Drawing.Point(38, 28);
            this.rbtTerceiro.Name = "rbtTerceiro";
            this.rbtTerceiro.Size = new System.Drawing.Size(84, 24);
            this.rbtTerceiro.TabIndex = 0;
            this.rbtTerceiro.TabStop = true;
            this.rbtTerceiro.Text = "Terceiro";
            this.rbtTerceiro.UseVisualStyleBackColor = true;
            // 
            // rbtVisitante
            // 
            this.rbtVisitante.AutoSize = true;
            this.rbtVisitante.Location = new System.Drawing.Point(128, 28);
            this.rbtVisitante.Name = "rbtVisitante";
            this.rbtVisitante.Size = new System.Drawing.Size(89, 24);
            this.rbtVisitante.TabIndex = 1;
            this.rbtVisitante.Text = "Visitante";
            this.rbtVisitante.UseVisualStyleBackColor = true;
            // 
            // rbtColaborador
            // 
            this.rbtColaborador.AutoSize = true;
            this.rbtColaborador.Location = new System.Drawing.Point(223, 28);
            this.rbtColaborador.Name = "rbtColaborador";
            this.rbtColaborador.Size = new System.Drawing.Size(114, 24);
            this.rbtColaborador.TabIndex = 2;
            this.rbtColaborador.Text = "Colaborador";
            this.rbtColaborador.UseVisualStyleBackColor = true;
            this.rbtColaborador.CheckedChanged += new System.EventHandler(this.rbtColaborador_CheckedChanged);
            // 
            // gbxPessoal
            // 
            this.gbxPessoal.Controls.Add(this.txtTelefone);
            this.gbxPessoal.Controls.Add(this.label8);
            this.gbxPessoal.Controls.Add(this.label9);
            this.gbxPessoal.Controls.Add(this.txtRG);
            this.gbxPessoal.Controls.Add(this.rbtTerceiro);
            this.gbxPessoal.Controls.Add(this.rbtColaborador);
            this.gbxPessoal.Controls.Add(this.txtNome);
            this.gbxPessoal.Controls.Add(this.rbtVisitante);
            this.gbxPessoal.Controls.Add(this.label1);
            this.gbxPessoal.Controls.Add(this.label2);
            this.gbxPessoal.Controls.Add(this.txtCPF);
            this.gbxPessoal.Controls.Add(this.txtEmpresa);
            this.gbxPessoal.Controls.Add(this.label3);
            this.gbxPessoal.Location = new System.Drawing.Point(12, 12);
            this.gbxPessoal.Name = "gbxPessoal";
            this.gbxPessoal.Size = new System.Drawing.Size(520, 170);
            this.gbxPessoal.TabIndex = 0;
            this.gbxPessoal.TabStop = false;
            this.gbxPessoal.Text = "Pessoal";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(92, 125);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(160, 26);
            this.txtTelefone.TabIndex = 10;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(343, 91);
            this.txtRG.MaxLength = 12;
            this.txtRG.Name = "txtRG";
            this.txtRG.ReadOnly = true;
            this.txtRG.Size = new System.Drawing.Size(160, 26);
            this.txtRG.TabIndex = 8;
            this.txtRG.TabStop = false;
            this.txtRG.Enter += new System.EventHandler(this.txtRG_Enter);
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtValidadeCNH);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbxMOPP);
            this.groupBox2.Controls.Add(this.txtCNH);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxNAOSEAPLICA);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.txtPlaca);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veículo e Motorista";
            // 
            // txtValidadeCNH
            // 
            this.txtValidadeCNH.Location = new System.Drawing.Point(343, 86);
            this.txtValidadeCNH.MaxLength = 10;
            this.txtValidadeCNH.Name = "txtValidadeCNH";
            this.txtValidadeCNH.Size = new System.Drawing.Size(160, 26);
            this.txtValidadeCNH.TabIndex = 8;
            this.txtValidadeCNH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidadeCNH_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Validade:";
            // 
            // cbxMOPP
            // 
            this.cbxMOPP.AutoSize = true;
            this.cbxMOPP.Location = new System.Drawing.Point(343, 120);
            this.cbxMOPP.Name = "cbxMOPP";
            this.cbxMOPP.Size = new System.Drawing.Size(73, 24);
            this.cbxMOPP.TabIndex = 11;
            this.cbxMOPP.Text = "MOPP";
            this.cbxMOPP.UseVisualStyleBackColor = true;
            // 
            // txtCNH
            // 
            this.txtCNH.Location = new System.Drawing.Point(343, 53);
            this.txtCNH.MaxLength = 12;
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Size = new System.Drawing.Size(160, 26);
            this.txtCNH.TabIndex = 4;
            this.txtCNH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNH_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "CNH:";
            // 
            // cbxNAOSEAPLICA
            // 
            this.cbxNAOSEAPLICA.AutoSize = true;
            this.cbxNAOSEAPLICA.Location = new System.Drawing.Point(28, 23);
            this.cbxNAOSEAPLICA.Name = "cbxNAOSEAPLICA";
            this.cbxNAOSEAPLICA.Size = new System.Drawing.Size(149, 24);
            this.cbxNAOSEAPLICA.TabIndex = 0;
            this.cbxNAOSEAPLICA.Text = "NÃO SE APLICA";
            this.cbxNAOSEAPLICA.UseVisualStyleBackColor = true;
            this.cbxNAOSEAPLICA.CheckedChanged += new System.EventHandler(this.cbxNAOSEAPLICA_CheckedChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(92, 53);
            this.txtModelo.MaxLength = 15;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(160, 26);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(92, 86);
            this.txtMarca.MaxLength = 15;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(160, 26);
            this.txtMarca.TabIndex = 6;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(92, 118);
            this.txtPlaca.MaxLength = 8;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(160, 26);
            this.txtPlaca.TabIndex = 10;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Placa:";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(752, 378);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 50);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Image = global::PORTARIA.Properties.Resources.ic_novo;
            this.btnNovo.Location = new System.Drawing.Point(306, 378);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 50);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Image = global::PORTARIA.Properties.Resources.ic_salvar;
            this.btnSalvar.Location = new System.Drawing.Point(422, 378);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 50);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Enabled = false;
            this.btnCapturar.Image = global::PORTARIA.Properties.Resources.ic_camera;
            this.btnCapturar.Location = new System.Drawing.Point(652, 299);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(210, 30);
            this.btnCapturar.TabIndex = 5;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Image = global::PORTARIA.Properties.Resources.ic_on_off;
            this.btnOnOff.Location = new System.Drawing.Point(542, 299);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(100, 30);
            this.btnOnOff.TabIndex = 4;
            this.btnOnOff.Text = "ON/OFF";
            this.btnOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // imgCamera
            // 
            this.imgCamera.BackColor = System.Drawing.Color.Black;
            this.imgCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCamera.Location = new System.Drawing.Point(542, 20);
            this.imgCamera.Name = "imgCamera";
            this.imgCamera.Size = new System.Drawing.Size(320, 240);
            this.imgCamera.TabIndex = 0;
            this.imgCamera.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Image = global::PORTARIA.Properties.Resources.ic_configs;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(541, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "    Dispositivo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbxDispositivo
            // 
            this.cbxDispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDispositivo.FormattingEnabled = true;
            this.cbxDispositivo.Location = new System.Drawing.Point(652, 266);
            this.cbxDispositivo.Name = "cbxDispositivo";
            this.cbxDispositivo.Size = new System.Drawing.Size(210, 28);
            this.cbxDispositivo.TabIndex = 3;
            // 
            // frmCadastrarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 440);
            this.Controls.Add(this.cbxDispositivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxPessoal);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.imgCamera);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCadastrarPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastrarPessoa_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastrarPessoa_Load);
            this.gbxPessoal.ResumeLayout(false);
            this.gbxPessoal.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCamera;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.RadioButton rbtTerceiro;
        private System.Windows.Forms.RadioButton rbtVisitante;
        private System.Windows.Forms.RadioButton rbtColaborador;
        private System.Windows.Forms.GroupBox gbxPessoal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxNAOSEAPLICA;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtCNH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.CheckBox cbxMOPP;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxDispositivo;
        private System.Windows.Forms.TextBox txtValidadeCNH;
        private System.Windows.Forms.Label label11;
    }
}

