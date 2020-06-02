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
    public partial class FrmLocacao : Form
    {
        public FrmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmPrincipal)this.MdiParent).MnuLocacao.Enabled = true;
        }
    }
}
