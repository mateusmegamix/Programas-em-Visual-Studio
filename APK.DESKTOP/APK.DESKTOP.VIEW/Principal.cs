using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APK.DESKTOP.MODEL;
using System.IO;
using System.Drawing.Imaging;


namespace APK.DESKTOP.VIEW
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void MnuCliente_Click(object sender, EventArgs e)
        {
            FrmCliente oFrm = new FrmCliente();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuCliente.Enabled = true;
        }

        private void MnuFesta_Click(object sender, EventArgs e)
        {
            FrmFesta oFrm = new FrmFesta();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuFesta.Enabled = true;
        }

        private void MnuHotel_Click(object sender, EventArgs e)
        {
            FrmHotel oFrm = new FrmHotel();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuHotel.Enabled = true;
        }

        private void MnuJogo_Click(object sender, EventArgs e)
        {
            FrmJogo oFrm = new FrmJogo();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuJogo.Enabled = true;
        }

        private void MnuUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrm = new FrmUsuario();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuUsuario.Enabled = true;
        }

        private void mapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaps oFrm = new FrmMaps();
            oFrm.MdiContainer = this;
            oFrm.Show();
            MnuMapa.Enabled = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    
}
