namespace ManutencaoQuiminvest.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.TxtSenhaLogin = new System.Windows.Forms.TextBox();
            this.TxtNomeLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnLogar
            // 
            this.BtnLogar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogar.Image")));
            this.BtnLogar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogar.Location = new System.Drawing.Point(77, 285);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLogar.Size = new System.Drawing.Size(78, 31);
            this.BtnLogar.TabIndex = 14;
            this.BtnLogar.Text = "Acessar";
            this.BtnLogar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogar.UseVisualStyleBackColor = true;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(168, 285);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(77, 31);
            this.BtnSair.TabIndex = 15;
            this.BtnSair.Text = "Cancelar";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tela de Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Informe nome e senha para acessar o sistema!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Password:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(42, 177);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(50, 16);
            this.Label.TabIndex = 10;
            this.Label.Text = "Login:";
            // 
            // TxtSenhaLogin
            // 
            this.TxtSenhaLogin.Location = new System.Drawing.Point(98, 211);
            this.TxtSenhaLogin.Name = "TxtSenhaLogin";
            this.TxtSenhaLogin.Size = new System.Drawing.Size(147, 20);
            this.TxtSenhaLogin.TabIndex = 13;
            // 
            // TxtNomeLogin
            // 
            this.TxtNomeLogin.Location = new System.Drawing.Point(98, 176);
            this.TxtNomeLogin.Name = "TxtNomeLogin";
            this.TxtNomeLogin.Size = new System.Drawing.Size(148, 20);
            this.TxtNomeLogin.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(259, 330);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TxtSenhaLogin);
            this.Controls.Add(this.TxtNomeLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLogar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox TxtSenhaLogin;
        private System.Windows.Forms.TextBox TxtNomeLogin;
    }
}