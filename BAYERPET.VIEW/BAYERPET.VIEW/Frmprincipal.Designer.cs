namespace BAYERPET.VIEW
{
    partial class Frmprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmprincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBayerPet = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCadCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCadAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCadFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Relogio = new System.Windows.Forms.Timer(this.components);
            this.LblClock = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentaçõesToolStripMenuItem,
            this.StripMenu,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuBayerPet});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            this.movimentaçõesToolStripMenuItem.Click += new System.EventHandler(this.movimentaçõesToolStripMenuItem_Click);
            // 
            // MnuBayerPet
            // 
            this.MnuBayerPet.Name = "MnuBayerPet";
            this.MnuBayerPet.Size = new System.Drawing.Size(123, 22);
            this.MnuBayerPet.Text = "Bayer Pet";
            this.MnuBayerPet.Click += new System.EventHandler(this.bayerPetToolStripMenuItem_Click);
            // 
            // StripMenu
            // 
            this.StripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCadCliente,
            this.MnuCadAnimal,
            this.MnuCadFuncionario});
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(71, 20);
            this.StripMenu.Text = "Cadastros";
            // 
            // MnuCadCliente
            // 
            this.MnuCadCliente.Name = "MnuCadCliente";
            this.MnuCadCliente.Size = new System.Drawing.Size(190, 22);
            this.MnuCadCliente.Text = "Cadastrar Cliente";
            this.MnuCadCliente.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem1_Click);
            // 
            // MnuCadAnimal
            // 
            this.MnuCadAnimal.Name = "MnuCadAnimal";
            this.MnuCadAnimal.Size = new System.Drawing.Size(190, 22);
            this.MnuCadAnimal.Text = "Cadastrar Animal";
            this.MnuCadAnimal.Click += new System.EventHandler(this.cadastrarAnimalToolStripMenuItem1_Click);
            // 
            // MnuCadFuncionario
            // 
            this.MnuCadFuncionario.Name = "MnuCadFuncionario";
            this.MnuCadFuncionario.Size = new System.Drawing.Size(190, 22);
            this.MnuCadFuncionario.Text = "Cadastrar Funcionario";
            this.MnuCadFuncionario.Click += new System.EventHandler(this.cadastrarFuncionarioToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Relogio
            // 
            this.Relogio.Enabled = true;
            this.Relogio.Interval = 1000;
            this.Relogio.Tick += new System.EventHandler(this.Relogio_Tick);
            // 
            // LblClock
            // 
            this.LblClock.AutoSize = true;
            this.LblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClock.ForeColor = System.Drawing.Color.Black;
            this.LblClock.Location = new System.Drawing.Point(671, 9);
            this.LblClock.Name = "LblClock";
            this.LblClock.Size = new System.Drawing.Size(39, 13);
            this.LblClock.TabIndex = 2;
            this.LblClock.Text = "Clock";
            this.LblClock.Click += new System.EventHandler(this.LblClock_Click);
            // 
            // Frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 368);
            this.Controls.Add(this.LblClock);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmprincipal";
            this.Text = "Bayer Pet";
            this.Load += new System.EventHandler(this.Frmprincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenu;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MnuBayerPet;
        public System.Windows.Forms.ToolStripMenuItem MnuCadCliente;
        public System.Windows.Forms.ToolStripMenuItem MnuCadAnimal;
        public System.Windows.Forms.ToolStripMenuItem MnuCadFuncionario;
        public System.Windows.Forms.Timer Relogio;
        private System.Windows.Forms.Label LblClock;
    }
}

