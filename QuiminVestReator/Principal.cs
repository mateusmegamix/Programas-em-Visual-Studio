using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuiminVestReator
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void ControleDados_Load(object sender, EventArgs e)
        {

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MnuFuncionario_Click(object sender, EventArgs e)
        {
            Funcionarios oFrm = new Funcionarios();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuFuncionario.Enabled = true;
        }

        private void MnuControle_Click(object sender, EventArgs e)
        {
            Controle oFrm = new Controle();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuControle.Enabled = true;
        }

        private void EntradaESaídaDeCarrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntradaSaidaView oFrm = new EntradaSaidaView();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuEntradaESaidaDeCarros.Enabled = true;
        }
    }
}
