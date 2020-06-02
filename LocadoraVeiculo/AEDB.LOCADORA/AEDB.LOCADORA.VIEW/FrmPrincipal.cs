using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEDB.LOCADORA.VIEW
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void MnuCliente_Click(object sender, EventArgs e)
        {
            FrmClientee oFrm = new FrmClientee();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuClientee.Enabled = false;
        }

        private void MnuFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionario oFrm = new FrmFuncionario();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuFuncionario.Enabled = false;
        }

        private void MnuVeiculo_Click(object sender, EventArgs e)
        {
            FrmVeiculo oFrm = new FrmVeiculo();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuVeiculo.Enabled = false;
        }

        private void MnuLocacao_Click(object sender, EventArgs e)
        {
            FrmLocacao oFrm = new FrmLocacao();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuLocacao.Enabled = false;
        }
    }
}
