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
    public partial class FrmClientee : Form
    {
        private bool Incluir = true;

        private Control.CClientee _Control = new Control.CClientee();
        public FrmClientee()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            GrdClientee.AutoGenerateColumns = false;
            GrdClientee.DataSource = _Control.SelecionarTodos();
        }
        private void FrmClientee_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmClientee_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuClientee.Enabled = true;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private bool ValidaControles()
        {
            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                Clientee oClientee = new Clientee();
                oClientee.CodCli = Convert.ToInt32(TxtCodCli.Text);
                oClientee.Nome = TxtNome.Text;
                oClientee.Cpf = TxtCpf.Text;
                oClientee.Endereco = TxtEndereco.Text;
                oClientee.Tel = TxtTel.Text;
                oClientee.DataNasc = Convert.ToDateTime(TxtDataNasc.Text);
                if(Incluir)
                {
                    _Control.Incluir(oClientee);
                }
                else
                {
                    _Control.Alterar(oClientee);
                }
                CarregaGrid();
            }
        }

        
    }
}
