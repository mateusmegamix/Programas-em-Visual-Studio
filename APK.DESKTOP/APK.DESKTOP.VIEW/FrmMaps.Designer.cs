namespace APK.DESKTOP.VIEW
{
    partial class FrmMaps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaps));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCep = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtRua = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitContainer1.Panel1.Controls.Add(this.BtnSalvar);
            this.splitContainer1.Panel1.Controls.Add(this.BtnPesquisar);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.TxtCep);
            this.splitContainer1.Panel1.Controls.Add(this.TxtEstado);
            this.splitContainer1.Panel1.Controls.Add(this.TxtCidade);
            this.splitContainer1.Panel1.Controls.Add(this.TxtRua);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(635, 450);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(80, 211);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(69, 23);
            this.BtnSalvar.TabIndex = 19;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(10, 211);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(64, 23);
            this.BtnPesquisar.TabIndex = 18;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(14, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cep :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cidade :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rua :";
            // 
            // TxtCep
            // 
            this.TxtCep.Location = new System.Drawing.Point(57, 170);
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(100, 20);
            this.TxtCep.TabIndex = 13;
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(57, 125);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(100, 20);
            this.TxtEstado.TabIndex = 12;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(57, 82);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(100, 20);
            this.TxtCidade.TabIndex = 11;
            // 
            // TxtRua
            // 
            this.TxtRua.Location = new System.Drawing.Point(57, 45);
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(100, 20);
            this.TxtRua.TabIndex = 10;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(420, 450);
            this.webBrowser1.TabIndex = 0;
            // 
            // FrmMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmMaps";
            this.Text = "FrmMaps";
            this.Load += new System.EventHandler(this.FrmMaps_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCep;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtRua;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}