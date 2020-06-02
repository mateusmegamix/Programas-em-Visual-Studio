namespace ManutencaoQuiminvest.View
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuCadPro = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEnt = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSai = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRltPro = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRltEnt = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRltSai = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCadPro,
            this.MnuEnt,
            this.MnuSai,
            this.sairToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.MnuRelatorio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuCadPro
            // 
            this.MnuCadPro.Image = ((System.Drawing.Image)(resources.GetObject("MnuCadPro.Image")));
            this.MnuCadPro.Name = "MnuCadPro";
            this.MnuCadPro.Size = new System.Drawing.Size(144, 20);
            this.MnuCadPro.Text = "&Cadastro de Produto";
            this.MnuCadPro.Click += new System.EventHandler(this.cadastroDeProdutoToolStripMenuItem_Click);
            // 
            // MnuEnt
            // 
            this.MnuEnt.Image = ((System.Drawing.Image)(resources.GetObject("MnuEnt.Image")));
            this.MnuEnt.Name = "MnuEnt";
            this.MnuEnt.Size = new System.Drawing.Size(75, 20);
            this.MnuEnt.Text = "&Entrada";
            this.MnuEnt.Click += new System.EventHandler(this.MnuEnt_Click);
            // 
            // MnuSai
            // 
            this.MnuSai.Image = ((System.Drawing.Image)(resources.GetObject("MnuSai.Image")));
            this.MnuSai.Name = "MnuSai";
            this.MnuSai.Size = new System.Drawing.Size(63, 20);
            this.MnuSai.Text = "&Saída";
            this.MnuSai.Click += new System.EventHandler(this.MnuSai_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ajudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripMenuItem.Image")));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // MnuRelatorio
            // 
            this.MnuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRltPro,
            this.MnuRltEnt,
            this.MnuRltSai});
            this.MnuRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("MnuRelatorio.Image")));
            this.MnuRelatorio.Name = "MnuRelatorio";
            this.MnuRelatorio.Size = new System.Drawing.Size(87, 20);
            this.MnuRelatorio.Text = "Relatórios";
            // 
            // MnuRltPro
            // 
            this.MnuRltPro.Image = ((System.Drawing.Image)(resources.GetObject("MnuRltPro.Image")));
            this.MnuRltPro.Name = "MnuRltPro";
            this.MnuRltPro.Size = new System.Drawing.Size(122, 22);
            this.MnuRltPro.Text = "Produtos";
            this.MnuRltPro.Click += new System.EventHandler(this.MnuRltPro_Click);
            // 
            // MnuRltEnt
            // 
            this.MnuRltEnt.Image = ((System.Drawing.Image)(resources.GetObject("MnuRltEnt.Image")));
            this.MnuRltEnt.Name = "MnuRltEnt";
            this.MnuRltEnt.Size = new System.Drawing.Size(122, 22);
            this.MnuRltEnt.Text = "Entrada";
            this.MnuRltEnt.Click += new System.EventHandler(this.MnuRltEnt_Click);
            // 
            // MnuRltSai
            // 
            this.MnuRltSai.Image = ((System.Drawing.Image)(resources.GetObject("MnuRltSai.Image")));
            this.MnuRltSai.Name = "MnuRltSai";
            this.MnuRltSai.Size = new System.Drawing.Size(122, 22);
            this.MnuRltSai.Text = "Saída";
            this.MnuRltSai.Click += new System.EventHandler(this.MnuRltSai_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(580, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Quiminvest - Manutenção";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ToolStripMenuItem MnuCadPro;
        public System.Windows.Forms.ToolStripMenuItem MnuEnt;
        public System.Windows.Forms.ToolStripMenuItem MnuSai;
        public System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MnuRelatorio;
        public System.Windows.Forms.ToolStripMenuItem MnuRltPro;
        public System.Windows.Forms.ToolStripMenuItem MnuRltEnt;
        public System.Windows.Forms.ToolStripMenuItem MnuRltSai;
    }
}