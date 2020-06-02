using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICOP.MODEL;
using SICOP.CONTROLLER;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace SICOP.VIEW
{
    public partial class frmRelatorio : Form
    {
        Pessoa _pPessoa;
        CNH _pCNH;
        Veiculo _pVeiculo;

        public frmRelatorio(Pessoa pPessoa = null, CNH pCNH = null, Veiculo pVeiculo = null)
        {
            InitializeComponent();

            _pPessoa = pPessoa;
            _pCNH = pCNH;
            _pVeiculo = pVeiculo;
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            rpvPrincipal.LocalReport.EnableExternalImages = true;
            CarregarFicha();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rpvPrincipal.PrintDialog();
        }

        private void CarregarFicha()
        {
            rpvPrincipal.LocalReport.ReportEmbeddedResource = "SICOP.VIEW.rptIdentificao1.rdlc";

            string imgPath;

            string testePath = @".\Captured Images\" + _pPessoa.PesCodigo.ToString() + ".jpg";
            if (System.IO.File.Exists(testePath))
            {
                imgPath = "file:///" + Application.StartupPath + "\\Captured Images\\" + _pPessoa.PesCodigo + ".jpg";
            }
            else
            {
                imgPath = "file:///" + Application.StartupPath + "\\Resources\\default.jpg";
            }

            List<ReportParameter> lista = new List<ReportParameter>();
            lista.Add(new ReportParameter("imgPath", imgPath));
            lista.Add(new ReportParameter("PesNome", _pPessoa.PesNome));
            lista.Add(new ReportParameter("PesDocumento", _pPessoa.PesDocumento));
            lista.Add(new ReportParameter("PesTelefone", _pPessoa.PesTelefone));
            lista.Add(new ReportParameter("PesVinculo", _pPessoa.PesVinculo));
            lista.Add(new ReportParameter("PesEmpresa", _pPessoa.PesEmpresa));
            if (_pCNH != null && _pVeiculo != null)
            {
                lista.Add(new ReportParameter("CNHNumero", _pCNH.CNHNumero));
                lista.Add(new ReportParameter("CNHCategoria", _pCNH.CNHCategoria));
                lista.Add(new ReportParameter("CNHValidade", _pCNH.CNHValidade));
                lista.Add(new ReportParameter("CNHMopp", _pCNH.CNHMopp));
                lista.Add(new ReportParameter("VeiTipo", _pVeiculo.VeiTipo));
                lista.Add(new ReportParameter("VeiPlaca", _pVeiculo.VeiPlaca));
                lista.Add(new ReportParameter("VeiCidadePlaca", _pVeiculo.VeiCidadePlaca));
            }
            else
            {
                rpvPrincipal.LocalReport.ReportEmbeddedResource = "SICOP.VIEW.rptIdentificao2.rdlc";
            }

            for (int i = 0; lista.Count > i; i++)
            {
                rpvPrincipal.LocalReport.SetParameters(lista[i]);
            }

            rpvPrincipal.LocalReport.DisplayName = "Ficha de Identificação";
            rpvPrincipal.RefreshReport();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmConsultarPessoa frm = new frmConsultarPessoa();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }
    }
}
