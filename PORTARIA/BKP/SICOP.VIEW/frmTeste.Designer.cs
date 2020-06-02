namespace SICOP.VIEW
{
    partial class frmTeste
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtgPessoas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SICOP.VIEW.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 231);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(681, 274);
            this.reportViewer1.TabIndex = 1;
            // 
            // dtgPessoas
            // 
            this.dtgPessoas.AllowUserToAddRows = false;
            this.dtgPessoas.AllowUserToDeleteRows = false;
            this.dtgPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgPessoas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPessoas.Location = new System.Drawing.Point(13, 67);
            this.dtgPessoas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgPessoas.MultiSelect = false;
            this.dtgPessoas.Name = "dtgPessoas";
            this.dtgPessoas.ReadOnly = true;
            this.dtgPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPessoas.Size = new System.Drawing.Size(681, 154);
            this.dtgPessoas.TabIndex = 0;
            this.dtgPessoas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPessoas_CellClick);
            this.dtgPessoas.SelectionChanged += new System.EventHandler(this.dtgPessoas_SelectionChanged);
            // 
            // frmConsultarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 519);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtgPessoas);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultarPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarPessoa";
            this.Load += new System.EventHandler(this.frmConsultarPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPessoas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridView dtgPessoas;
    }
}