using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaQuiminvest.Model;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using SistemaQuiminvest.RELATORIOS;

namespace SistemaQuiminvest
{

    
    public partial class CREntradaSaida : Form
    {
        public CREntradaSaida()
        {
            InitializeComponent();
            CrystalEntradaSaida1.SetDatabaseLogon("megamix", "coltii123.", "megamix.database.windows.net", "Quiminvest");
            CrystalEntradaSaida1.Refresh();
        }
        public Principal MdiContainer { get; internal set; }
        private void CRNota_Load(object sender, EventArgs e)
        {
            CrystalEntradaSaida1.SetDatabaseLogon("megamix", "coltii123.", "megamix.database.windows.net", "Quiminvest");
            CrystalEntradaSaida1.Refresh();
        }

        private void CrystalReportViewer2_Load(object sender, EventArgs e)
        {
            CrystalEntradaSaida1.SetDatabaseLogon("megamix", "coltii123.", "megamix.database.windows.net", "Quiminvest");
        }

        private void CREntradaSaida_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((Principal)this.MdiContainer).MnuCrystalVeiculos.Enabled = true;
        }
    }
}
