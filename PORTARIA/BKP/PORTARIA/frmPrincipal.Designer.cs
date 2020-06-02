namespace PORTARIA
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarES = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHESP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHESD = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbRegistrarES = new System.Windows.Forms.ToolStripButton();
            this.tsbCadastrarPessoas = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultarPessoas = new System.Windows.Forms.ToolStripButton();
            this.tbsConsultarHESP = new System.Windows.Forms.ToolStripButton();
            this.tbsConsultarHESD = new System.Windows.Forms.ToolStripButton();
            this.menu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 29);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRegistrar});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // menuRegistrar
            // 
            this.menuRegistrar.BackColor = System.Drawing.SystemColors.Control;
            this.menuRegistrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuRegistrar.Name = "menuRegistrar";
            this.menuRegistrar.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuRegistrar.Size = new System.Drawing.Size(271, 26);
            this.menuRegistrar.Text = "Registrar Entrada/Saída";
            this.menuRegistrar.Click += new System.EventHandler(this.menuRegistrar_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrar});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // menuCadastrar
            // 
            this.menuCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuCadastrar.Name = "menuCadastrar";
            this.menuCadastrar.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuCadastrar.Size = new System.Drawing.Size(232, 26);
            this.menuCadastrar.Text = "Cadastrar Pessoas";
            this.menuCadastrar.Click += new System.EventHandler(this.menuCadastrar_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConsultar,
            this.menuConsultarES});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // menuConsultar
            // 
            this.menuConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuConsultar.Name = "menuConsultar";
            this.menuConsultar.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuConsultar.Size = new System.Drawing.Size(272, 26);
            this.menuConsultar.Text = "Consultar Pessoas";
            this.menuConsultar.Click += new System.EventHandler(this.menuConsultar_Click);
            // 
            // menuConsultarES
            // 
            this.menuConsultarES.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHESP,
            this.menuHESD});
            this.menuConsultarES.Name = "menuConsultarES";
            this.menuConsultarES.Size = new System.Drawing.Size(272, 26);
            this.menuConsultarES.Text = "Consultar Entradas e Saídas";
            this.menuConsultarES.Click += new System.EventHandler(this.menuConsultarES_Click);
            // 
            // menuHESP
            // 
            this.menuHESP.Name = "menuHESP";
            this.menuHESP.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuHESP.Size = new System.Drawing.Size(182, 26);
            this.menuHESP.Text = "Por pessoa";
            this.menuHESP.Click += new System.EventHandler(this.menuHESP_Click);
            // 
            // menuHESD
            // 
            this.menuHESD.Name = "menuHESD";
            this.menuHESD.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuHESD.Size = new System.Drawing.Size(182, 26);
            this.menuHESD.Text = "Por data";
            this.menuHESD.Click += new System.EventHandler(this.menuHESD_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExcel});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(109, 25);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // menuExcel
            // 
            this.menuExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuExcel.Name = "menuExcel";
            this.menuExcel.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.menuExcel.Size = new System.Drawing.Size(284, 26);
            this.menuExcel.Text = "Exportar dados para Excel";
            this.menuExcel.Click += new System.EventHandler(this.menuExcel_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRegistrarES,
            this.tsbCadastrarPessoas,
            this.tsbConsultarPessoas,
            this.tbsConsultarHESP,
            this.tbsConsultarHESD});
            this.toolStrip.Location = new System.Drawing.Point(0, 29);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 70);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbRegistrarES
            // 
            this.tsbRegistrarES.AutoSize = false;
            this.tsbRegistrarES.BackColor = System.Drawing.Color.Transparent;
            this.tsbRegistrarES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbRegistrarES.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRegistrarES.Image = global::PORTARIA.Properties.Resources.ic_registrar_es;
            this.tsbRegistrarES.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegistrarES.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.tsbRegistrarES.Name = "tsbRegistrarES";
            this.tsbRegistrarES.Size = new System.Drawing.Size(60, 60);
            this.tsbRegistrarES.ToolTipText = "Registrar Entrada/Saída     F1";
            this.tsbRegistrarES.Click += new System.EventHandler(this.tsbRegistrarES_Click);
            // 
            // tsbCadastrarPessoas
            // 
            this.tsbCadastrarPessoas.AutoSize = false;
            this.tsbCadastrarPessoas.BackColor = System.Drawing.Color.Transparent;
            this.tsbCadastrarPessoas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbCadastrarPessoas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadastrarPessoas.Image = global::PORTARIA.Properties.Resources.ic_cadastras_pessoas;
            this.tsbCadastrarPessoas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadastrarPessoas.Margin = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.tsbCadastrarPessoas.Name = "tsbCadastrarPessoas";
            this.tsbCadastrarPessoas.Size = new System.Drawing.Size(60, 60);
            this.tsbCadastrarPessoas.ToolTipText = "Cadastrar Pessoas     F2";
            this.tsbCadastrarPessoas.Click += new System.EventHandler(this.tsbCadastrarPessoas_Click);
            // 
            // tsbConsultarPessoas
            // 
            this.tsbConsultarPessoas.AutoSize = false;
            this.tsbConsultarPessoas.BackColor = System.Drawing.Color.Transparent;
            this.tsbConsultarPessoas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbConsultarPessoas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConsultarPessoas.Image = global::PORTARIA.Properties.Resources.ic_consultar_pessas;
            this.tsbConsultarPessoas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultarPessoas.Margin = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.tsbConsultarPessoas.Name = "tsbConsultarPessoas";
            this.tsbConsultarPessoas.Size = new System.Drawing.Size(60, 60);
            this.tsbConsultarPessoas.ToolTipText = "Consultar Pessoas     F3";
            this.tsbConsultarPessoas.Click += new System.EventHandler(this.tsbConsultarPessoas_Click);
            // 
            // tbsConsultarHESP
            // 
            this.tbsConsultarHESP.AutoSize = false;
            this.tbsConsultarHESP.BackColor = System.Drawing.Color.Transparent;
            this.tbsConsultarHESP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbsConsultarHESP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsConsultarHESP.Image = global::PORTARIA.Properties.Resources.ic_consultar_es;
            this.tbsConsultarHESP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsConsultarHESP.Margin = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.tbsConsultarHESP.Name = "tbsConsultarHESP";
            this.tbsConsultarHESP.Size = new System.Drawing.Size(60, 60);
            this.tbsConsultarHESP.ToolTipText = "Histórico de Entradas e Saídas por Pessoa     F4";
            this.tbsConsultarHESP.Click += new System.EventHandler(this.tbsConsultarHESP_Click);
            // 
            // tbsConsultarHESD
            // 
            this.tbsConsultarHESD.AutoSize = false;
            this.tbsConsultarHESD.BackColor = System.Drawing.Color.Transparent;
            this.tbsConsultarHESD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbsConsultarHESD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsConsultarHESD.Image = global::PORTARIA.Properties.Resources.ic_consultar_es2;
            this.tbsConsultarHESD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsConsultarHESD.Margin = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.tbsConsultarHESD.Name = "tbsConsultarHESD";
            this.tbsConsultarHESD.Size = new System.Drawing.Size(60, 60);
            this.tbsConsultarHESD.ToolTipText = "Histórico de Entradas e Saídas por Data     F5";
            this.tbsConsultarHESD.Click += new System.EventHandler(this.tbsConsultarHESD_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 641);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PORTARIA | QUIMINVEST - INDÚSTRIA E COMÉRCIO LTDA.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRegistrar;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarES;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExcel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbRegistrarES;
        private System.Windows.Forms.ToolStripButton tsbCadastrarPessoas;
        private System.Windows.Forms.ToolStripButton tsbConsultarPessoas;
        private System.Windows.Forms.ToolStripButton tbsConsultarHESD;
        private System.Windows.Forms.ToolStripMenuItem menuHESP;
        private System.Windows.Forms.ToolStripMenuItem menuHESD;
        private System.Windows.Forms.ToolStripButton tbsConsultarHESP;
    }
}