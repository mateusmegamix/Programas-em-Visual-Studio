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
    public partial class CRControleReator : Form
    {
        public Principal MdiContainer { get; internal set; }
        public CRControleReator()
        {
            InitializeComponent();
            CrystalControleReator1.SetDatabaseLogon("megamix", "coltii123.", "megamix.database.windows.net", "Quiminvest");
            CrystalControleReator1.Refresh();
        }

        private void CRControleReator_Load(object sender, EventArgs e)
        {
            CrystalControleReator1.SetDatabaseLogon("megamix", "coltii123.", "megamix.database.windows.net", "Quiminvest");
            CrystalControleReator1.Refresh();
        }

        private void CRControleReator_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((Principal)this.MdiContainer).MnuCrystalDescricao.Enabled = true;
        }
    }
}
