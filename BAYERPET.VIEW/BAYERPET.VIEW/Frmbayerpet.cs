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
    public partial class Frmbayerpet : Form
    {
        private CBayer _Control;
        public Frmbayerpet()
        {
            InitializeComponent();
            _Control = new CBayer();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frmbayerpet_Load(object sender, EventArgs e)
        {

            CboCliente.ValueMember = "Clicodigo";
            CboCliente.DisplayMember = "Clinome";
            CboPet.DisplayMember = "Pnome";
            dataentrada.Text = DateTime.Now.ToString("dd/MM/yyyy"); //teste
            horaentrada.Text = DateTime.Now.ToString("HH:mm:ss"); //teste

            CboCliente.DataSource = _Control.SelecionarCliente();
            CboPet.DataSource = _Control.SelecionarPet();


            CboCliente.SelectedIndex = -1;
            CboPet.SelectedIndex = -1;

            datasaida.Text = DateTime.Now.ToString("dd/MM/yyyy");
            horasaida.Text = DateTime.Now.ToString("HH:mm:ss");
            CboCliente.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmbayerpet_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Frmprincipal)this.MdiParent).MnuBayerPet.Enabled = true;
        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //.............................................................................
        private void CarregaPet(Pet oPet)
        {
            CboPet.SelectedValue = oPet.PetDoBayer.Pnome;
            dataentrada.Text = oPet.PetDoBayer.Pdataentrada.ToString(); // teste
            horaentrada.Text = oPet.PetDoBayer.Phorasaida.ToString(); // teste
            

        }
        private void CarregaCliente(Cliente oCliente)
        {

            TxtCodCliente.Text = oCliente.ClienteDoBayer.Clicodigo.ToString();
            CboCliente.SelectedValue = oCliente.ClienteDoBayer.Clicodigo;

        }

        //...............................................................................
        private void TxtCodCliente_Leave(object sender, EventArgs e)

        {

            if (TxtCodCliente.Text.Trim() != "")
            {
                int ClienteDoBayer;
                if (int.TryParse(TxtCodCliente.Text, out ClienteDoBayer))
                {
                    Cliente oCliente = _Control.SelecionarCliente(ClienteDoBayer);
                    if (oCliente != null)
                    {
                        CarregaCliente(oCliente);
                    }
                    else
                    {
                        MessageBox.Show("O codigo do cliente nao é valido");
                        TxtCodCliente.Focus();
                    }
                }
            }
        }

        //private void Grid(Cliente oCliente)
        //{

        //    TxtCodCliente.Text = oCliente.ClienteDoBayer.Clicodigo.ToString();
        //    CboCliente.SelectedValue = oCliente.ClienteDoBayer.Clicodigo;
        //    CarregaGrid.AutoGenerateColumns = true;
        //    CarregaGrid.DataSource = oCliente.Clicodigo;

        //    for (int i = 0; i < CarregaGrid.Rows.Count; i++)
        //    {
        //        Cliente oClientes = (Cliente)CarregaGrid.Rows[i].DataBoundItem;
        //        CarregaGrid.Rows[i].Cells[i].Value = oCliente.ClienteDoBayer.Clicodigo;
        //    }
        //}




        private void CarregaGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtValorTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }


 
           
    }
    
    
    
        
  

    

