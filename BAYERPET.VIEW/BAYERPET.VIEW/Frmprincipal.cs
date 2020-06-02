using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAYERPET.MODEL;
using BAYERPET.CONTROL;

namespace BAYERPET.VIEW
{
    public partial class Frmprincipal : Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
          
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void movimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cadastrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)

        {
            Frmcliente oFrm = new VIEW.Frmcliente();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuCadCliente.Enabled = false;
            movimentaçõesToolStripMenuItem.Enabled = true;
        }

        private void Frmprincipal_Load(object sender, EventArgs e) 
        {
            for (int i = 1; i < 100; i++)
            {
                Cliente oCliente = new Cliente();
                oCliente.Clicodigo = i;
                oCliente.Clinome = "" + i.ToString();
               

                Pet oPet = new Pet();
                oPet.Pcodigo = i;
                oPet.Pnome = "" + i.ToString();
      


                Funcionario oFuncionario = new Funcionario();
                oFuncionario.Fcodigo = i;
                oFuncionario.Fnome = "" + i.ToString();
  
            }
        }

        private void bayerPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmbayerpet oFrm = new VIEW.Frmbayerpet();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuBayerPet.Enabled = false;
            movimentaçõesToolStripMenuItem.Enabled = true;
        }

        private void cadastrarAnimalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmanimal oFrm = new VIEW.Frmanimal();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuCadAnimal.Enabled = false;
            movimentaçõesToolStripMenuItem.Enabled = true;
        }

        private void cadastrarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmfuncionario oFrm = new VIEW.Frmfuncionario();
            oFrm.MdiParent = this;
            oFrm.Show();
            MnuCadFuncionario.Enabled = false;
            movimentaçõesToolStripMenuItem.Enabled = true;
        }

        private void Relogio_Tick(object sender, EventArgs e)
        {
            LblClock.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LblClock_Click(object sender, EventArgs e)
        {

        }
    }
}
