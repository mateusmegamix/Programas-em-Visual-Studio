namespace QuiminVestReator
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
            this.TxtNomeLogin = new System.Windows.Forms.TextBox();
            this.TxtSenhaLogin = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNomeLogin
            // 
            this.TxtNomeLogin.Location = new System.Drawing.Point(98, 173);
            this.TxtNomeLogin.Name = "TxtNomeLogin";
            this.TxtNomeLogin.Size = new System.Drawing.Size(148, 20);
            this.TxtNomeLogin.TabIndex = 0;
            // 
            // TxtSenhaLogin
            // 
            this.TxtSenhaLogin.Location = new System.Drawing.Point(98, 208);
            this.TxtSenhaLogin.Name = "TxtSenhaLogin";
            this.TxtSenhaLogin.Size = new System.Drawing.Size(147, 20);
            this.TxtSenhaLogin.TabIndex = 1;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(42, 174);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(50, 16);
            this.Label.TabIndex = 2;
            this.Label.Text = "Login:";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informe nome e senha para acessar o sistema!";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnSair
            // 
            this.BtnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSair.Location = new System.Drawing.Point(168, 282);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(77, 31);
            this.BtnSair.TabIndex = 24;
            this.BtnSair.Text = "Cancelar";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLogar
            // 
            this.BtnLogar.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogar.Image")));
            this.BtnLogar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLogar.Location = new System.Drawing.Point(77, 282);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLogar.Size = new System.Drawing.Size(78, 31);
            this.BtnLogar.TabIndex = 25;
            this.BtnLogar.Text = "Acessar";
            this.BtnLogar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::QuiminVestReator.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(258, 340);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TxtSenhaLogin);
            this.Controls.Add(this.TxtNomeLogin);
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login - QuiminVest";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNomeLogin;
        private System.Windows.Forms.TextBox TxtSenhaLogin;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLogar;
    }
}