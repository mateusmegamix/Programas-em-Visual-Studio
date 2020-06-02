namespace SistemaQuiminvest
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNf = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCrystalDescricao = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCrystalVeiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCrystalFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOrdem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLab = new System.Windows.Forms.ToolStripMenuItem();
            this.portariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuControleNotasFiscais = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEntradaESaidaDeCarros = new System.Windows.Forms.ToolStripMenuItem();
            this.reatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuControle = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOProd = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEntrada = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.LblClock = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Data.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.Data.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(536, 27);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(264, 22);
            this.Data.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.MnuLab,
            this.portariaToolStripMenuItem,
            this.reatorToolStripMenuItem,
            this.manutençãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFuncionario});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // MnuFuncionario
            // 
            this.MnuFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("MnuFuncionario.Image")));
            this.MnuFuncionario.Name = "MnuFuncionario";
            this.MnuFuncionario.Size = new System.Drawing.Size(180, 22);
            this.MnuFuncionario.Text = "Funcionario";
            this.MnuFuncionario.Click += new System.EventHandler(this.MnuFuncionario_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuNf,
            this.MnuCrystalDescricao,
            this.MnuCrystalVeiculos,
            this.MnuCrystalFuncionarios,
            this.manutençãoToolStripMenuItem1,
            this.MnuOrdem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "&Consulta";
            // 
            // MnuNf
            // 
            this.MnuNf.Image = ((System.Drawing.Image)(resources.GetObject("MnuNf.Image")));
            this.MnuNf.Name = "MnuNf";
            this.MnuNf.Size = new System.Drawing.Size(213, 22);
            this.MnuNf.Text = "Controle de Notas";
            this.MnuNf.Click += new System.EventHandler(this.MnuNf_Click);
            // 
            // MnuCrystalDescricao
            // 
            this.MnuCrystalDescricao.Image = ((System.Drawing.Image)(resources.GetObject("MnuCrystalDescricao.Image")));
            this.MnuCrystalDescricao.Name = "MnuCrystalDescricao";
            this.MnuCrystalDescricao.Size = new System.Drawing.Size(213, 22);
            this.MnuCrystalDescricao.Text = "Descrição de Processo";
            this.MnuCrystalDescricao.Click += new System.EventHandler(this.MnuCrystalDescricao_Click);
            // 
            // MnuCrystalVeiculos
            // 
            this.MnuCrystalVeiculos.Image = ((System.Drawing.Image)(resources.GetObject("MnuCrystalVeiculos.Image")));
            this.MnuCrystalVeiculos.Name = "MnuCrystalVeiculos";
            this.MnuCrystalVeiculos.Size = new System.Drawing.Size(213, 22);
            this.MnuCrystalVeiculos.Text = "Entrada/Saida de Veiculos ";
            this.MnuCrystalVeiculos.Click += new System.EventHandler(this.MnuCrystalVeiculos_Click);
            // 
            // MnuCrystalFuncionarios
            // 
            this.MnuCrystalFuncionarios.Enabled = false;
            this.MnuCrystalFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("MnuCrystalFuncionarios.Image")));
            this.MnuCrystalFuncionarios.Name = "MnuCrystalFuncionarios";
            this.MnuCrystalFuncionarios.Size = new System.Drawing.Size(213, 22);
            this.MnuCrystalFuncionarios.Text = "Funcionarios";
            this.MnuCrystalFuncionarios.Click += new System.EventHandler(this.MnuCrystalFuncionarios_Click);
            // 
            // manutençãoToolStripMenuItem1
            // 
            this.manutençãoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem1,
            this.saidaToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.manutençãoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("manutençãoToolStripMenuItem1.Image")));
            this.manutençãoToolStripMenuItem1.Name = "manutençãoToolStripMenuItem1";
            this.manutençãoToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.manutençãoToolStripMenuItem1.Text = "Manutenção";
            this.manutençãoToolStripMenuItem1.Click += new System.EventHandler(this.manutençãoToolStripMenuItem1_Click);
            // 
            // entradaToolStripMenuItem1
            // 
            this.entradaToolStripMenuItem1.Enabled = false;
            this.entradaToolStripMenuItem1.Name = "entradaToolStripMenuItem1";
            this.entradaToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.entradaToolStripMenuItem1.Text = "Produtos";
            // 
            // saidaToolStripMenuItem
            // 
            this.saidaToolStripMenuItem.Enabled = false;
            this.saidaToolStripMenuItem.Name = "saidaToolStripMenuItem";
            this.saidaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saidaToolStripMenuItem.Text = "Entrada";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Enabled = false;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "Saída";
            // 
            // MnuOrdem
            // 
            this.MnuOrdem.Image = ((System.Drawing.Image)(resources.GetObject("MnuOrdem.Image")));
            this.MnuOrdem.Name = "MnuOrdem";
            this.MnuOrdem.Size = new System.Drawing.Size(213, 22);
            this.MnuOrdem.Text = "Ordem de Produção";
            this.MnuOrdem.Click += new System.EventHandler(this.ordemDeProduçãoToolStripMenuItem_Click);
            // 
            // MnuLab
            // 
            this.MnuLab.Name = "MnuLab";
            this.MnuLab.Size = new System.Drawing.Size(80, 20);
            this.MnuLab.Text = "&Laboratorio";
            // 
            // portariaToolStripMenuItem
            // 
            this.portariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuControleNotasFiscais,
            this.MnuEntradaESaidaDeCarros});
            this.portariaToolStripMenuItem.Name = "portariaToolStripMenuItem";
            this.portariaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.portariaToolStripMenuItem.Text = "&Portaria";
            // 
            // MnuControleNotasFiscais
            // 
            this.MnuControleNotasFiscais.Image = ((System.Drawing.Image)(resources.GetObject("MnuControleNotasFiscais.Image")));
            this.MnuControleNotasFiscais.Name = "MnuControleNotasFiscais";
            this.MnuControleNotasFiscais.Size = new System.Drawing.Size(271, 22);
            this.MnuControleNotasFiscais.Text = "Controle de Entradas de Notas Fiscais";
            this.MnuControleNotasFiscais.Click += new System.EventHandler(this.MnuControleNotasFiscais_Click);
            // 
            // MnuEntradaESaidaDeCarros
            // 
            this.MnuEntradaESaidaDeCarros.Image = ((System.Drawing.Image)(resources.GetObject("MnuEntradaESaidaDeCarros.Image")));
            this.MnuEntradaESaidaDeCarros.Name = "MnuEntradaESaidaDeCarros";
            this.MnuEntradaESaidaDeCarros.Size = new System.Drawing.Size(271, 22);
            this.MnuEntradaESaidaDeCarros.Text = "Entrada/Saida de Veiculos";
            this.MnuEntradaESaidaDeCarros.Click += new System.EventHandler(this.MnuEntradaESaidaDeCarros_Click);
            // 
            // reatorToolStripMenuItem
            // 
            this.reatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuControle,
            this.MnuOProd});
            this.reatorToolStripMenuItem.Name = "reatorToolStripMenuItem";
            this.reatorToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.reatorToolStripMenuItem.Text = "&Reator";
            // 
            // MnuControle
            // 
            this.MnuControle.Image = ((System.Drawing.Image)(resources.GetObject("MnuControle.Image")));
            this.MnuControle.Name = "MnuControle";
            this.MnuControle.Size = new System.Drawing.Size(192, 22);
            this.MnuControle.Text = "Descrição do Processo";
            this.MnuControle.Click += new System.EventHandler(this.MnuControle_Click);
            // 
            // MnuOProd
            // 
            this.MnuOProd.Image = ((System.Drawing.Image)(resources.GetObject("MnuOProd.Image")));
            this.MnuOProd.Name = "MnuOProd";
            this.MnuOProd.Size = new System.Drawing.Size(192, 22);
            this.MnuOProd.Text = "Ordem  de Produção";
            this.MnuOProd.Click += new System.EventHandler(this.MnuOProd_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuProduto,
            this.MnuEntrada,
            this.MnuSaida});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "&Manutenção";
            // 
            // MnuProduto
            // 
            this.MnuProduto.Image = ((System.Drawing.Image)(resources.GetObject("MnuProduto.Image")));
            this.MnuProduto.Name = "MnuProduto";
            this.MnuProduto.Size = new System.Drawing.Size(183, 22);
            this.MnuProduto.Text = "Cadastro de Produto";
            this.MnuProduto.Click += new System.EventHandler(this.CadastroDeProdutoToolStripMenuItem_Click);
            // 
            // MnuEntrada
            // 
            this.MnuEntrada.Image = ((System.Drawing.Image)(resources.GetObject("MnuEntrada.Image")));
            this.MnuEntrada.Name = "MnuEntrada";
            this.MnuEntrada.Size = new System.Drawing.Size(183, 22);
            this.MnuEntrada.Text = "Entrada";
            this.MnuEntrada.Click += new System.EventHandler(this.EntradaToolStripMenuItem_Click);
            // 
            // MnuSaida
            // 
            this.MnuSaida.Image = ((System.Drawing.Image)(resources.GetObject("MnuSaida.Image")));
            this.MnuSaida.Name = "MnuSaida";
            this.MnuSaida.Size = new System.Drawing.Size(183, 22);
            this.MnuSaida.Text = "Saída";
            this.MnuSaida.Click += new System.EventHandler(this.SaídaToolStripMenuItem_Click);
            // 
            // LblClock
            // 
            this.LblClock.AutoSize = true;
            this.LblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClock.ForeColor = System.Drawing.Color.Black;
            this.LblClock.Location = new System.Drawing.Point(629, 9);
            this.LblClock.Name = "LblClock";
            this.LblClock.Size = new System.Drawing.Size(39, 13);
            this.LblClock.TabIndex = 5;
            this.LblClock.Text = "Clock";
            this.LblClock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblClock.Click += new System.EventHandler(this.LblClock_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblClock);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUIMINVEST";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuLab;
        private System.Windows.Forms.ToolStripMenuItem portariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reatorToolStripMenuItem;
        private System.Windows.Forms.Label LblClock;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MnuProduto;
        public System.Windows.Forms.ToolStripMenuItem MnuEntrada;
        public System.Windows.Forms.ToolStripMenuItem MnuSaida;
        public System.Windows.Forms.ToolStripMenuItem MnuControle;
        public System.Windows.Forms.ToolStripMenuItem MnuControleNotasFiscais;
        public System.Windows.Forms.ToolStripMenuItem MnuEntradaESaidaDeCarros;
        public System.Windows.Forms.ToolStripMenuItem MnuFuncionario;
        public System.Windows.Forms.ToolStripMenuItem MnuCrystalDescricao;
        public System.Windows.Forms.ToolStripMenuItem MnuCrystalVeiculos;
        public System.Windows.Forms.ToolStripMenuItem MnuCrystalFuncionarios;
        public System.Windows.Forms.ToolStripMenuItem MnuNf;
        public System.Windows.Forms.ToolStripMenuItem MnuOProd;
        private System.Windows.Forms.ToolStripMenuItem MnuOrdem;
    }
}

