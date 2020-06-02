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
    public partial class CRNf : Form
    {
        public Principal MdiContainer { get; internal set; }
        public CRNf()
        {
            InitializeComponent();
            CrystalControleNF1.SetDatabaseLogon("megamix", "coltii123.", "megamix.database.windows.net", "Quiminvest");
            CrystalControleNF1.Refresh();
        }

        private void CRNf_Load(object sender, EventArgs e)
        {
            CrystalControleNF1.SetDatabaseLogon("megamix", "coltii123.", "megamix.database.windows.net", "Quiminvest");
            CrystalControleNF1.Refresh();
        }

        private void CRNf_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((Principal)this.MdiContainer).MnuNf.Enabled = true;
        }
    }
}
