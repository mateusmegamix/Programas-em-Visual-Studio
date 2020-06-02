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
    public partial class CROrdem : Form
    {
        public Principal MdiContainer { get; internal set; }
        public CROrdem()
        {
            InitializeComponent();
            //CrystalOrdem1.SetDatabaseLogon("megamix", "coltii123.", "megamix.database.windows.net", "Quiminvest");
            //CrystalOrdem1.Refresh();
        }

        private void CROrdem_Load(object sender, EventArgs e)
        {
            //CrystalOrdem1.SetDatabaseLogon("megamix", "coltii123.", "megamix.database.windows.net", "Quiminvest");
            //CrystalOrdem1.Refresh();
        }
    }
}
