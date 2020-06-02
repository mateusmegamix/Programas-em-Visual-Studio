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
    public partial class FrmFuncionario : Form
    {
        private bool Incluir = true;

        private Control.CFuncionario _Control = new Control.CFuncionario();
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            GrdFuncionario.AutoGenerateColumns = false;
            GrdFuncionario.DataSource = _Control.SelecionarTodos();
        }

        private void FrmFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuFuncionario.Enabled = true;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidaControles())
            {
                Funcionario oFuncionario = new Funcionario();
                oFuncionario.CodFunc = Convert.ToInt32(TxtCodFunc.Text);
                oFuncionario.NomeFunc = TxtNomeFunc.Text;
                oFuncionario.CpfFunc = TxtCpfFunc.Text;
                oFuncionario.TelFunc = TxtTelFunc.Text;
                oFuncionario.NascFunc = Convert.ToDateTime(TxtNascFunc.Text);
                
                if(Incluir)
                {
                    _Control.Incluir(oFuncionario);
                }
                else
                {
                    _Control.Alterar(oFuncionario);
                }
                CarregaGrid();
            }
        }
    }
}
