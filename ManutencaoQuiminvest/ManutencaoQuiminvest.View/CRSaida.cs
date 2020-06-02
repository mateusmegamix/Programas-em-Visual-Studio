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
    public partial class CRSaida : Form
    {
        public Principal MdiContainer { get; internal set; }
        public CRSaida()
        {
            InitializeComponent();
            CRSaida1.Refresh();
        }

        private void CRSaida_Load(object sender, EventArgs e)
        {
            CRSaida1.Refresh();
        }

        private void CRSaida_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((Principal)this.MdiContainer).MnuRltSai.Enabled = true;
        }
    }
}
