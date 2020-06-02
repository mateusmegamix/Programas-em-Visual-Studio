namespace SICOP.VIEW
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
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
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
            this.menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(532, 31);
            this.menu.TabIndex = 1;
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
            this.menuCadastrar.Size = new System.Drawing.Size(233, 26);
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
            this.menuConsultar.Size = new System.Drawing.Size(299, 26);
            this.menuConsultar.Text = "Consultar Pessoas";
            this.menuConsultar.Click += new System.EventHandler(this.menuConsultar_Click);
            // 
            // menuConsultarES
            // 
            this.menuConsultarES.Name = "menuConsultarES";
            this.menuConsultarES.ShortcutKeyDisplayString = "";
            this.menuConsultarES.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuConsultarES.Size = new System.Drawing.Size(299, 26);
            this.menuConsultarES.Text = "Consultar Entradas e Saídas";
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
            this.menuExcel.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuExcel.Size = new System.Drawing.Size(284, 26);
            this.menuExcel.Text = "Exportar dados para Excel";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 342);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICOP | QUIMINVEST - INDÚSTRIA E COMÉRCIO LTDA.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
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
    }
}