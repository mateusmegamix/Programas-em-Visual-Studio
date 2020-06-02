using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaQuiminvest
{
    public partial class Principal : Form
    {
        public object TxtSenhaLogin { get; private set; }
        public object TxtNomeLogin { get; private set; }

        public Principal()
        {
            InitializeComponent();
        }

        private void MnuFuncionario_Click(object sender, EventArgs e)
        {
                Funcionarios oFrm = new Funcionarios();
                oFrm.MdiContainer = this;
                oFrm.Show();
                MnuFuncionario.Enabled = false;
            
        }

        private void LblClock_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            LblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void MnuEntradaESaidaDeCarros_Click(object sender, EventArgs e)
        {
            EntradaSaidaView oFrm = new EntradaSaidaView();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuEntradaESaidaDeCarros.Enabled = false;
        }

        private void MnuControle_Click(object sender, EventArgs e)
        {
            ControleView oFrm = new ControleView();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuControle.Enabled = false;
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuControleNotasFiscais_Click(object sender, EventArgs e)
        {
            ControleNotasFiscais oFrm = new ControleNotasFiscais();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuControleNotasFiscais.Enabled = false;
        }

        

        private void MnuCrystalDescricao_Click(object sender, EventArgs e)
        {
            CRControleReator oFrm = new CRControleReator();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuCrystalDescricao.Enabled = true;
        }

        private void MnuCrystalVeiculos_Click(object sender, EventArgs e)
        {
            CREntradaSaida oFrm = new CREntradaSaida();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuCrystalVeiculos.Enabled = true;
        }

        private void MnuCrystalFuncionarios_Click(object sender, EventArgs e)
        {
            CRFuncionario oFrm = new CRFuncionario();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuCrystalFuncionarios.Enabled = true;
        }

        public void CadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Produto oFrm = new Produto();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuProduto.Enabled = false;

        }

        private void EntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoInput oFrm = new ProdutoInput();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuEntrada.Enabled = false;
        }

        private void SaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoOutput oFrm = new ProdutoOutput();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuSaida.Enabled = false;
        }

        private void MnuNf_Click(object sender, EventArgs e)
        {
            CRNf oFrm = new CRNf();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuNf.Enabled = true;
        }

        private void manutençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MnuOProd_Click(object sender, EventArgs e)
        {
            OrdemProducao oFrm = new OrdemProducao();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuOProd.Enabled = false;
        }

        private void ordemDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CROrdem oFrm = new CROrdem();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuOrdem.Enabled = true;
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
