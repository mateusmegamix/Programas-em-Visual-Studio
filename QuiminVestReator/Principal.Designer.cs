namespace QuiminVestReator
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLab = new System.Windows.Forms.ToolStripMenuItem();
            this.portariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEntradaESaidaDeCarros = new System.Windows.Forms.ToolStripMenuItem();
            this.reatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuControle = new System.Windows.Forms.ToolStripMenuItem();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.reatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFuncionario});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.CadastroToolStripMenuItem_Click);
            // 
            // MnuFuncionario
            // 
            this.MnuFuncionario.Name = "MnuFuncionario";
            this.MnuFuncionario.Size = new System.Drawing.Size(137, 22);
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
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.AjudaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "&Consulta";
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
            this.MnuEntradaESaidaDeCarros});
            this.portariaToolStripMenuItem.Name = "portariaToolStripMenuItem";
            this.portariaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.portariaToolStripMenuItem.Text = "&Portaria";
            // 
            // MnuEntradaESaidaDeCarros
            // 
            this.MnuEntradaESaidaDeCarros.Name = "MnuEntradaESaidaDeCarros";
            this.MnuEntradaESaidaDeCarros.Size = new System.Drawing.Size(213, 22);
            this.MnuEntradaESaidaDeCarros.Text = "Entrada /Saida de Veiculos";
            this.MnuEntradaESaidaDeCarros.Click += new System.EventHandler(this.EntradaESaídaDeCarrosToolStripMenuItem_Click);
            // 
            // reatorToolStripMenuItem
            // 
            this.reatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuControle});
            this.reatorToolStripMenuItem.Name = "reatorToolStripMenuItem";
            this.reatorToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.reatorToolStripMenuItem.Text = "&Reator";
            // 
            // MnuControle
            // 
            this.MnuControle.Name = "MnuControle";
            this.MnuControle.Size = new System.Drawing.Size(120, 22);
            this.MnuControle.Text = "Controle";
            this.MnuControle.Click += new System.EventHandler(this.MnuControle_Click);
            // 
            // Data
            // 
            this.Data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Data.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.Data.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(468, 27);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(264, 22);
            this.Data.TabIndex = 2;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 482);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal - Reator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ControleDados_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuLab;
        private System.Windows.Forms.ToolStripMenuItem portariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuEntradaESaidaDeCarros;
        private System.Windows.Forms.ToolStripMenuItem reatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuControle;
        private System.Windows.Forms.ToolStripMenuItem MnuFuncionario;
    }
}