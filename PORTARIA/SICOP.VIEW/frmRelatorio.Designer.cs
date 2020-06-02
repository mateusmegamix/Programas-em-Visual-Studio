namespace SICOP.VIEW
{
    partial class frmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.rpvPrincipal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(546, 500);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrint.Size = new System.Drawing.Size(110, 50);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "IMPRIMIR";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFechar.Image = global::SICOP.VIEW.Properties.Resources.ic_fechar;
            this.btnFechar.Location = new System.Drawing.Point(662, 500);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 50);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // rpvPrincipal
            // 
            this.rpvPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rpvPrincipal.LocalReport.ReportEmbeddedResource = "SICOP.VIEW.rptIdentificao1.rdlc";
            this.rpvPrincipal.Location = new System.Drawing.Point(13, 14);
            this.rpvPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rpvPrincipal.Name = "rpvPrincipal";
            this.rpvPrincipal.ServerReport.BearerToken = null;
            this.rpvPrincipal.Size = new System.Drawing.Size(758, 478);
            this.rpvPrincipal.TabIndex = 18;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.rpvPrincipal);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnFechar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnPrint;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPrincipal;
    }
}