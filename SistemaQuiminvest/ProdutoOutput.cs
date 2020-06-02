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
    public partial class ProdutoOutput : Form
    {
        public Principal MdiContainer { get; internal set; }
        public ProdutoOutput()
        {
            InitializeComponent();
        }

        private void ProdutoOutput_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProdutoOutput_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)this.MdiContainer).MnuSaida.Enabled = true;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            ((Principal)this.MdiContainer).MnuSaida.Enabled = true;
            this.Close();
        }
    }
}
