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
    public partial class CRProduto : Form
    {
        public Principal MdiContainer { get; internal set; }
        public CRProduto()
        {
            InitializeComponent();
            CrystalProduto1.Refresh();
        }

        private void CRProduto_Load(object sender, EventArgs e)
        {
            CrystalProduto1.Refresh();
        }

        private void CRProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((Principal)this.MdiContainer).MnuRltPro.Enabled = true;
        }
    }
}
