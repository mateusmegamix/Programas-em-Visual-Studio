namespace SICOP.VIEW
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
            this.cbxDispositivo = new System.Windows.Forms.ComboBox();
            this.gbxID = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.rbtTerceiro = new System.Windows.Forms.RadioButton();
            this.rbtColaborador = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbtVisitante = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxCNH = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxMOPP = new System.Windows.Forms.CheckBox();
            this.txtValidadeCNH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroCNH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxVeiculo = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.imgCamera = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxMotorista = new System.Windows.Forms.ComboBox();
            this.gbxID.SuspendLayout();
            this.gbxCNH.SuspendLayout();
            this.gbxVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDispositivo
            // 
            this.cbxDispositivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDispositivo.FormattingEnabled = true;
            this.cbxDispositivo.Location = new System.Drawing.Point(662, 271);
            this.cbxDispositivo.Name = "cbxDispositivo";
            this.cbxDispositivo.Size = new System.Drawing.Size(210, 29);
            this.cbxDispositivo.TabIndex = 6;
            // 
            // gbxID
            // 
            this.gbxID.Controls.Add(this.txtTelefone);
            this.gbxID.Controls.Add(this.label8);
            this.gbxID.Controls.Add(this.label9);
            this.gbxID.Controls.Add(this.txtRG);
            this.gbxID.Controls.Add(this.rbtTerceiro);
            this.gbxID.Controls.Add(this.rbtColaborador);
            this.gbxID.Controls.Add(this.txtNome);
            this.gbxID.Controls.Add(this.rbtVisitante);
            this.gbxID.Controls.Add(this.label1);
            this.gbxID.Controls.Add(this.label2);
            this.gbxID.Controls.Add(this.txtCPF);
            this.gbxID.Controls.Add(this.txtEmpresa);
            this.gbxID.Controls.Add(this.label3);
            this.gbxID.Location = new System.Drawing.Point(12, 12);
            this.gbxID.Name = "gbxID";
            this.gbxID.Size = new System.Drawing.Size(513, 166);
            this.gbxID.TabIndex = 0;
            this.gbxID.TabStop = false;
            this.gbxID.Text = "Identificação";
            // 
            // txtTelefone
            // 
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.Location = new System.Drawing.Point(89, 125);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(160, 29);
            this.txtTelefone.TabIndex = 10;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRG.Location = new System.Drawing.Point(340, 91);
            this.txtRG.MaxLength = 12;
            this.txtRG.Name = "txtRG";
            this.txtRG.ReadOnly = true;
            this.txtRG.Size = new System.Drawing.Size(160, 29);
            this.txtRG.TabIndex = 8;
            this.txtRG.TabStop = false;
            this.txtRG.Enter += new System.EventHandler(this.txtRG_Enter);
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // rbtTerceiro
            // 
            this.rbtTerceiro.AutoSize = true;
            this.rbtTerceiro.Checked = true;
            this.rbtTerceiro.Location = new System.Drawing.Point(35, 28);
            this.rbtTerceiro.Name = "rbtTerceiro";
            this.rbtTerceiro.Size = new System.Drawing.Size(84, 25);
            this.rbtTerceiro.TabIndex = 0;
            this.rbtTerceiro.TabStop = true;
            this.rbtTerceiro.Text = "Terceiro";
            this.rbtTerceiro.UseVisualStyleBackColor = true;
            // 
            // rbtColaborador
            // 
            this.rbtColaborador.AutoSize = true;
            this.rbtColaborador.Location = new System.Drawing.Point(220, 28);
            this.rbtColaborador.Name = "rbtColaborador";
            this.rbtColaborador.Size = new System.Drawing.Size(115, 25);
            this.rbtColaborador.TabIndex = 2;
            this.rbtColaborador.Text = "Colaborador";
            this.rbtColaborador.UseVisualStyleBackColor = true;
            this.rbtColaborador.CheckedChanged += new System.EventHandler(this.rbtColaborador_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(89, 55);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(411, 29);
            this.txtNome.TabIndex = 4;
            // 
            // rbtVisitante
            // 
            this.rbtVisitante.AutoSize = true;
            this.rbtVisitante.Location = new System.Drawing.Point(125, 28);
            this.rbtVisitante.Name = "rbtVisitante";
            this.rbtVisitante.Size = new System.Drawing.Size(88, 25);
            this.rbtVisitante.TabIndex = 1;
            this.rbtVisitante.Text = "Visitante";
            this.rbtVisitante.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPF.Location = new System.Drawing.Point(89, 91);
            this.txtCPF.MaxLength = 14;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(160, 29);
            this.txtCPF.TabIndex = 6;
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Enter);
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpresa.Location = new System.Drawing.Point(340, 125);
            this.txtEmpresa.MaxLength = 15;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(160, 29);
            this.txtEmpresa.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Empresa:";
            // 
            // gbxCNH
            // 
            this.gbxCNH.Controls.Add(this.txtCategoria);
            this.gbxCNH.Controls.Add(this.label4);
            this.gbxCNH.Controls.Add(this.cbxMOPP);
            this.gbxCNH.Controls.Add(this.txtValidadeCNH);
            this.gbxCNH.Controls.Add(this.label11);
            this.gbxCNH.Controls.Add(this.txtNumeroCNH);
            this.gbxCNH.Controls.Add(this.label7);
            this.gbxCNH.Location = new System.Drawing.Point(12, 223);
            this.gbxCNH.Name = "gbxCNH";
            this.gbxCNH.Size = new System.Drawing.Size(513, 111);
            this.gbxCNH.TabIndex = 3;
            this.gbxCNH.TabStop = false;
            this.gbxCNH.Text = "CNH";
            // 
            // txtCategoria
            // 
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Location = new System.Drawing.Point(340, 28);
            this.txtCategoria.MaxLength = 5;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(160, 29);
            this.txtCategoria.TabIndex = 3;
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Categoria:";
            // 
            // cbxMOPP
            // 
            this.cbxMOPP.AutoSize = true;
            this.cbxMOPP.Checked = true;
            this.cbxMOPP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMOPP.Location = new System.Drawing.Point(340, 64);
            this.cbxMOPP.Name = "cbxMOPP";
            this.cbxMOPP.Size = new System.Drawing.Size(73, 25);
            this.cbxMOPP.TabIndex = 6;
            this.cbxMOPP.Text = "MOPP";
            this.cbxMOPP.UseVisualStyleBackColor = true;
            // 
            // txtValidadeCNH
            // 
            this.txtValidadeCNH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValidadeCNH.Location = new System.Drawing.Point(89, 63);
            this.txtValidadeCNH.MaxLength = 10;
            this.txtValidadeCNH.Name = "txtValidadeCNH";
            this.txtValidadeCNH.Size = new System.Drawing.Size(160, 29);
            this.txtValidadeCNH.TabIndex = 5;
            this.txtValidadeCNH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidadeCNH_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "Validade:";
            // 
            // txtNumeroCNH
            // 
            this.txtNumeroCNH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroCNH.Location = new System.Drawing.Point(89, 28);
            this.txtNumeroCNH.MaxLength = 12;
            this.txtNumeroCNH.Name = "txtNumeroCNH";
            this.txtNumeroCNH.Size = new System.Drawing.Size(160, 29);
            this.txtNumeroCNH.TabIndex = 1;
            this.txtNumeroCNH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNH_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Número:";
            // 
            // gbxVeiculo
            // 
            this.gbxVeiculo.Controls.Add(this.label13);
            this.gbxVeiculo.Controls.Add(this.txtCidade);
            this.gbxVeiculo.Controls.Add(this.txtTipo);
            this.gbxVeiculo.Controls.Add(this.label5);
            this.gbxVeiculo.Controls.Add(this.label12);
            this.gbxVeiculo.Controls.Add(this.txtPlaca);
            this.gbxVeiculo.Location = new System.Drawing.Point(12, 340);
            this.gbxVeiculo.Name = "gbxVeiculo";
            this.gbxVeiculo.Size = new System.Drawing.Size(513, 104);
            this.gbxVeiculo.TabIndex = 4;
            this.gbxVeiculo.TabStop = false;
            this.gbxVeiculo.Text = "Veículo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 21);
            this.label13.TabIndex = 6;
            this.label13.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(89, 62);
            this.txtCidade.MaxLength = 15;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(160, 29);
            this.txtCidade.TabIndex = 7;
            // 
            // txtTipo
            // 
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.Location = new System.Drawing.Point(89, 27);
            this.txtTipo.MaxLength = 15;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(160, 29);
            this.txtTipo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaca.Location = new System.Drawing.Point(340, 27);
            this.txtPlaca.MaxLength = 8;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(160, 29);
            this.txtPlaca.TabIndex = 5;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaca_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFechar.Image = global::SICOP.VIEW.Properties.Resources.ic_fechar;
            this.btnFechar.Location = new System.Drawing.Point(762, 450);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 50);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Image = global::SICOP.VIEW.Properties.Resources.ic_novo;
            this.btnNovo.Location = new System.Drawing.Point(299, 450);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 50);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Image = global::SICOP.VIEW.Properties.Resources.ic_salvar;
            this.btnSalvar.Location = new System.Drawing.Point(415, 450);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 50);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Image = global::SICOP.VIEW.Properties.Resources.ic_configs;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(551, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "    Dispositivo:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapturar.Enabled = false;
            this.btnCapturar.Image = global::SICOP.VIEW.Properties.Resources.ic_camera;
            this.btnCapturar.Location = new System.Drawing.Point(662, 304);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(210, 30);
            this.btnCapturar.TabIndex = 8;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOnOff.Image")));
            this.btnOnOff.Location = new System.Drawing.Point(552, 304);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(105, 30);
            this.btnOnOff.TabIndex = 7;
            this.btnOnOff.Text = "ON/OFF";
            this.btnOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // imgCamera
            // 
            this.imgCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgCamera.BackColor = System.Drawing.Color.Black;
            this.imgCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCamera.Location = new System.Drawing.Point(552, 25);
            this.imgCamera.Name = "imgCamera";
            this.imgCamera.Size = new System.Drawing.Size(320, 240);
            this.imgCamera.TabIndex = 6;
            this.imgCamera.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "Motorista?";
            // 
            // cbxMotorista
            // 
            this.cbxMotorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMotorista.FormattingEnabled = true;
            this.cbxMotorista.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cbxMotorista.Location = new System.Drawing.Point(101, 188);
            this.cbxMotorista.Name = "cbxMotorista";
            this.cbxMotorista.Size = new System.Drawing.Size(121, 29);
            this.cbxMotorista.TabIndex = 2;
            this.cbxMotorista.SelectedIndexChanged += new System.EventHandler(this.cbxMotorista_SelectedIndexChanged);
            // 
            // frmCadastrarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.cbxMotorista);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbxVeiculo);
            this.Controls.Add(this.gbxCNH);
            this.Controls.Add(this.gbxID);
            this.Controls.Add(this.cbxDispositivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.imgCamera);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Pessoas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastrarPessoa_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastrarPessoa_Load);
            this.gbxID.ResumeLayout(false);
            this.gbxID.PerformLayout();
            this.gbxCNH.ResumeLayout(false);
            this.gbxCNH.PerformLayout();
            this.gbxVeiculo.ResumeLayout(false);
            this.gbxVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDispositivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.PictureBox imgCamera;
        private System.Windows.Forms.GroupBox gbxID;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.RadioButton rbtTerceiro;
        private System.Windows.Forms.RadioButton rbtColaborador;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbtVisitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxCNH;
        private System.Windows.Forms.TextBox txtNumeroCNH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValidadeCNH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbxMOPP;
        private System.Windows.Forms.GroupBox gbxVeiculo;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxMotorista;
    }
}