namespace APK.DESKTOP.VIEW
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
            this.MnuEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFesta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuJogo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.festasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotéisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.festasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hotéisToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMapa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Data.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.Data.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(416, 27);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(264, 22);
            this.Data.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEventos,
            this.MnuCadastro,
            this.MnuConsulta,
            this.sairToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.MnuMapa});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuEventos
            // 
            this.MnuEventos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFesta,
            this.MnuHotel,
            this.MnuJogo});
            this.MnuEventos.Name = "MnuEventos";
            this.MnuEventos.Size = new System.Drawing.Size(60, 20);
            this.MnuEventos.Text = "&Eventos";
            // 
            // MnuFesta
            // 
            this.MnuFesta.Name = "MnuFesta";
            this.MnuFesta.Size = new System.Drawing.Size(108, 22);
            this.MnuFesta.Text = "Festas";
            this.MnuFesta.Click += new System.EventHandler(this.MnuFesta_Click);
            // 
            // MnuHotel
            // 
            this.MnuHotel.Name = "MnuHotel";
            this.MnuHotel.Size = new System.Drawing.Size(108, 22);
            this.MnuHotel.Text = "Hotéis";
            this.MnuHotel.Click += new System.EventHandler(this.MnuHotel_Click);
            // 
            // MnuJogo
            // 
            this.MnuJogo.Name = "MnuJogo";
            this.MnuJogo.Size = new System.Drawing.Size(108, 22);
            this.MnuJogo.Text = "Jogos";
            this.MnuJogo.Click += new System.EventHandler(this.MnuJogo_Click);
            // 
            // MnuCadastro
            // 
            this.MnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCliente,
            this.MnuUsuario});
            this.MnuCadastro.Name = "MnuCadastro";
            this.MnuCadastro.Size = new System.Drawing.Size(66, 20);
            this.MnuCadastro.Text = "&Cadastro";
            // 
            // MnuCliente
            // 
            this.MnuCliente.Name = "MnuCliente";
            this.MnuCliente.Size = new System.Drawing.Size(139, 22);
            this.MnuCliente.Text = "Cliente Gold";
            this.MnuCliente.Click += new System.EventHandler(this.MnuCliente_Click);
            // 
            // MnuUsuario
            // 
            this.MnuUsuario.Name = "MnuUsuario";
            this.MnuUsuario.Size = new System.Drawing.Size(139, 22);
            this.MnuUsuario.Text = "Usuario";
            this.MnuUsuario.Click += new System.EventHandler(this.MnuUsuario_Click);
            // 
            // MnuConsulta
            // 
            this.MnuConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.festasToolStripMenuItem1,
            this.hotéisToolStripMenuItem1});
            this.MnuConsulta.Name = "MnuConsulta";
            this.MnuConsulta.Size = new System.Drawing.Size(66, 20);
            this.MnuConsulta.Text = "&Consulta";
            // 
            // festasToolStripMenuItem1
            // 
            this.festasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.festasToolStripMenuItem1.Name = "festasToolStripMenuItem1";
            this.festasToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.festasToolStripMenuItem1.Text = "Usuario";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // hotéisToolStripMenuItem1
            // 
            this.hotéisToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.festasToolStripMenuItem2,
            this.hotéisToolStripMenuItem2,
            this.jogosToolStripMenuItem2});
            this.hotéisToolStripMenuItem1.Name = "hotéisToolStripMenuItem1";
            this.hotéisToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.hotéisToolStripMenuItem1.Text = "Eventos";
            // 
            // festasToolStripMenuItem2
            // 
            this.festasToolStripMenuItem2.Name = "festasToolStripMenuItem2";
            this.festasToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.festasToolStripMenuItem2.Text = "Festas";
            // 
            // hotéisToolStripMenuItem2
            // 
            this.hotéisToolStripMenuItem2.Name = "hotéisToolStripMenuItem2";
            this.hotéisToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.hotéisToolStripMenuItem2.Text = "Hotéis";
            // 
            // jogosToolStripMenuItem2
            // 
            this.jogosToolStripMenuItem2.Name = "jogosToolStripMenuItem2";
            this.jogosToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.jogosToolStripMenuItem2.Text = "Jogos";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
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
            // MnuMapa
            // 
            this.MnuMapa.Name = "MnuMapa";
            this.MnuMapa.Size = new System.Drawing.Size(49, 20);
            this.MnuMapa.Text = "&Mapa";
            this.MnuMapa.Click += new System.EventHandler(this.mapaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 457);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entre Laços - Home";
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
        private System.Windows.Forms.ToolStripMenuItem MnuEventos;
        private System.Windows.Forms.ToolStripMenuItem MnuFesta;
        private System.Windows.Forms.ToolStripMenuItem MnuHotel;
        private System.Windows.Forms.ToolStripMenuItem MnuJogo;
        private System.Windows.Forms.ToolStripMenuItem MnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MnuCliente;
        private System.Windows.Forms.ToolStripMenuItem MnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem MnuConsulta;
        private System.Windows.Forms.ToolStripMenuItem festasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotéisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem festasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hotéisToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuMapa;
    }
}

