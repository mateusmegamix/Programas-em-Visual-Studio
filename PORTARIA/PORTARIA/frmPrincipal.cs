using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PORTARIA
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Database db = new Database();
            db.CriarBanco();
        }

        private void menuCadastrar_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.Count == 1)
            {
                frmCadastrarPessoa frm = new frmCadastrarPessoa();
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void menuConsultar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                frmConsultarPessoa frm = new frmConsultarPessoa();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menuRegistrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                frmRegistrarES frm = new frmRegistrarES();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menuConsultarES_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                frmConsultarHESP frm = new frmConsultarHESP();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menuHESP_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                frmConsultarHESP frm = new frmConsultarHESP();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menuHESD_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                frmConsultarHESD frm = new frmConsultarHESD();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tsbRegistrarES_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                frmRegistrarES frm = new frmRegistrarES();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tsbCadastrarPessoas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                frmCadastrarPessoa frm = new frmCadastrarPessoa();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tsbConsultarPessoas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                frmConsultarPessoa frm = new frmConsultarPessoa();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void menuExcel_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                frmExportarExcel frm = new frmExportarExcel();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tbsConsultarHESP_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                frmConsultarHESP frm = new frmConsultarHESP();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void tbsConsultarHESD_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                frmConsultarHESD frm = new frmConsultarHESD();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
