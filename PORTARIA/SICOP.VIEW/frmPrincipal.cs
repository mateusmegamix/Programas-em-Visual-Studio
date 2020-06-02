using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICOP.CONTROLLER;

namespace SICOP.VIEW
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CDatabase.CriarBanco();
        }

        private void menuCadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
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
    }
}
