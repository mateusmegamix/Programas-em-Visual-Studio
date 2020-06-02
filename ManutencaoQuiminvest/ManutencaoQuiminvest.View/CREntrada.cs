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
    public partial class CREntrada : Form
    {
        public Principal MdiContainer { get; internal set; }
        public CREntrada()
        {
            InitializeComponent();
            CrystalEntrada1.Refresh();
        }

        private void CREntrada_Load(object sender, EventArgs e)
        {
            CrystalEntrada1.Refresh();
        }

        private void CREntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((Principal)this.MdiContainer).MnuRltEnt.Enabled = true;
        }
    }
}
