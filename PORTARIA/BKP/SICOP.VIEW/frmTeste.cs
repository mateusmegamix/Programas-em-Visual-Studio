using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICOP.CONTROLLER;
using SICOP.MODEL;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace SICOP.VIEW
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void frmConsultarPessoa_Load(object sender, EventArgs e)
        {
            dtgPessoas.DataSource = CPessoa.CarregarPessoa();
            reportViewer1.LocalReport.EnableExternalImages = true;

            CarregarFicha();

        }

        private void CarregarFicha()
        {
            if (dtgPessoas.RowCount > 0)
            {

                int id = Convert.ToInt32(dtgPessoas.CurrentRow.Cells[0].Value);
                String nomefoto = id.ToString();
                Pessoa oPessoa = CPessoa.CarregarPK(id);
                CNH oCNH = CCNH.CarregarPK(id);
                Veiculo oVeiculo = CVeiculo.CarregarPK(id);

                string imgPath = "file:///" + Application.StartupPath + "\\Captured Images\\" + nomefoto + ".jpg";

                List<ReportParameter> lista = new List<ReportParameter>();
                lista.Add(new ReportParameter("imgPath", imgPath));
                lista.Add(new ReportParameter("PesNome", oPessoa.PesNome));
                lista.Add(new ReportParameter("PesDocumento", oPessoa.PesDocumento));
                lista.Add(new ReportParameter("PesTelefone", oPessoa.PesTelefone));
                lista.Add(new ReportParameter("PesVinculo", oPessoa.PesVinculo));
                lista.Add(new ReportParameter("PesEmpresa", oPessoa.PesEmpresa));
                if(oCNH != null && oVeiculo != null)
                {
                    lista.Add(new ReportParameter("CNHNumero", oCNH.CNHNumero));
                    lista.Add(new ReportParameter("CNHCategoria", oCNH.CNHCategoria));
                    lista.Add(new ReportParameter("CNHValidade", oCNH.CNHValidade));
                    lista.Add(new ReportParameter("CNHMopp", oCNH.CNHMopp));
                    lista.Add(new ReportParameter("VeiTipo", oVeiculo.VeiTipo));
                    lista.Add(new ReportParameter("VeiPlaca", oVeiculo.VeiPlaca));
                    lista.Add(new ReportParameter("VeiCidadePlaca", oVeiculo.VeiCidadePlaca));
                }
                else
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SICOP.VIEW.Report2.rdlc";
                }

                for (int i = 0; lista.Count > i; i++)
                {
                    reportViewer1.LocalReport.SetParameters(lista[i]);
                }

                reportViewer1.RefreshReport();
            }
        }

        private void dtgPessoas_SelectionChanged(object sender, EventArgs e)
        {
            //CarregarFicha();
        }

        private void dtgPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarFicha();
        }
    }
}
