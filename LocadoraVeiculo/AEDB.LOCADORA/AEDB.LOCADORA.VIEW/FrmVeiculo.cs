using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AEDB.LOCADORA.MODEL;

namespace AEDB.LOCADORA.VIEW
{
    public partial class FrmVeiculo : Form
    {
        private bool Incluir = true;

        private Control.CVeiculo _Control = new Control.CVeiculo();
        public FrmVeiculo()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            GrdVeiculo.AutoGenerateColumns = false;
            GrdVeiculo.DataSource = _Control.SelecionarTodos();
        }
        private void FrmVeiculo_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuVeiculo.Enabled = true;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVeiculo_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private bool ValidaControles()
        {
            return true;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                Veiculo oVeiculo = new Veiculo();
                oVeiculo.CodVeiculo = Convert.ToInt32(TxtCodVeiculo.Text);
                oVeiculo.Modelo = TxtModelo.Text;
                oVeiculo.Placa = TxtPlaca.Text;
                oVeiculo.Valor = Convert.ToDouble(TxtValor.Text);
                oVeiculo.Cor = TxtCor.Text;
                oVeiculo.Ano = Convert.ToDateTime(TxtAno.Text);
                if (Incluir)
                {
                    _Control.Incluir(oVeiculo);
                }
                else
                {
                    _Control.Alterar(oVeiculo);
                }
                CarregaGrid();
            }
        }
    }
}
