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
    public partial class Produto : Form
    {
        public Principal MdiContainer { get; internal set; }
        public Produto()
        {
            InitializeComponent();
        }

        private void Produto_Load(object sender, EventArgs e)
        {

        }


        public void BtnSair_Click(object sender, EventArgs e)
        {
            ((Principal)this.MdiContainer).MnuProduto.Enabled = true;
            this.Close();
        }

        private void Produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)this.MdiContainer).MnuProduto.Enabled = true;
        }
    }
}
