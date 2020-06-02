using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManutencaoQuiminvest.View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoView oFrm = new ProdutoView();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuCadPro.Enabled =  false;
        }

        private void MnuEnt_Click(object sender, EventArgs e)
        {
            EntradaView oFrm = new EntradaView();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuEnt.Enabled = false;
        }

        private void MnuSai_Click(object sender, EventArgs e)
        {
            SaidaView oFrm = new SaidaView();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuSai.Enabled = false;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void MnuRltPro_Click(object sender, EventArgs e)
        {
            CRProduto oFrm = new CRProduto();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuRltPro.Enabled = true;
        }

        private void MnuRltEnt_Click(object sender, EventArgs e)
        {
            CREntrada oFrm = new CREntrada();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuRltEnt.Enabled = true;
        }

        private void MnuRltSai_Click(object sender, EventArgs e)
        {
            CRSaida oFrm = new CRSaida();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuRltSai.Enabled = true;
        }
    }
}
