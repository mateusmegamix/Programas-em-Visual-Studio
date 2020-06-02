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
    public partial class CRFuncionario : Form
    {
        public CRFuncionario()
        {
            InitializeComponent();
            CrystalFuncionario1.SetDatabaseLogon("megamix", "coltii123.", "megamix.database.windows.net", "Quiminvest");
            CrystalFuncionario1.Refresh();
        }
        public Principal MdiContainer { get; internal set; }

        private void CRFuncionario_Load(object sender, EventArgs e)
        {
            CrystalFuncionario1.SetDatabaseLogon("megamix", "coltii123.", "megamix.database.windows.net", "Quiminvest");
            CrystalFuncionario1.Refresh();
        }

        private void CRFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((Principal)this.MdiContainer).MnuCrystalFuncionarios.Enabled = true;
        }
    }
}
