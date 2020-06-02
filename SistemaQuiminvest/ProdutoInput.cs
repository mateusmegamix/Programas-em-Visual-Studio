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
    public partial class ProdutoInput : Form
    {
        public Principal MdiContainer { get; internal set; }
        public ProdutoInput()
        {
            InitializeComponent();
        }

        private void ProdutoInput_Load(object sender, EventArgs e)
        {

        }

        private void ProdutoInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)this.MdiContainer).MnuEntrada.Enabled = true;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            ((Principal)this.MdiContainer).MnuEntrada.Enabled = true;
        }
    }
}
