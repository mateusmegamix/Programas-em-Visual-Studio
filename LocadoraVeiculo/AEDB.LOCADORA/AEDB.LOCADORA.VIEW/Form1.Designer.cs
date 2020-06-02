namespace AEDB.LOCADORA.VIEW
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuClientee = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVeiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLocacao = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCadastros});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // MnuCadastros
            // 
            resources.ApplyResources(this.MnuCadastros, "MnuCadastros");
            this.MnuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuClientee,
            this.MnuVeiculo,
            this.MnuFuncionario,
            this.MnuLocacao,
            this.MnuSair});
            this.MnuCadastros.Name = "MnuCadastros";
            // 
            // MnuClientee
            // 
            resources.ApplyResources(this.MnuClientee, "MnuClientee");
            this.MnuClientee.Name = "MnuClientee";
            this.MnuClientee.Click += new System.EventHandler(this.MnuCliente_Click);
            // 
            // MnuVeiculo
            // 
            resources.ApplyResources(this.MnuVeiculo, "MnuVeiculo");
            this.MnuVeiculo.Name = "MnuVeiculo";
            this.MnuVeiculo.Click += new System.EventHandler(this.MnuVeiculo_Click);
            // 
            // MnuFuncionario
            // 
            resources.ApplyResources(this.MnuFuncionario, "MnuFuncionario");
            this.MnuFuncionario.Name = "MnuFuncionario";
            this.MnuFuncionario.Click += new System.EventHandler(this.MnuFuncionario_Click);
            // 
            // MnuLocacao
            // 
            resources.ApplyResources(this.MnuLocacao, "MnuLocacao");
            this.MnuLocacao.Name = "MnuLocacao";
            this.MnuLocacao.Click += new System.EventHandler(this.MnuLocacao_Click);
            // 
            // MnuSair
            // 
            resources.ApplyResources(this.MnuSair, "MnuSair");
            this.MnuSair.Name = "MnuSair";
            this.MnuSair.Click += new System.EventHandler(this.MnuSair_Click);
            // 
            // FrmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MnuSair;
        public System.Windows.Forms.ToolStripMenuItem MnuClientee;
        public System.Windows.Forms.ToolStripMenuItem MnuVeiculo;
        public System.Windows.Forms.ToolStripMenuItem MnuFuncionario;
        public System.Windows.Forms.ToolStripMenuItem MnuLocacao;
    }
}

