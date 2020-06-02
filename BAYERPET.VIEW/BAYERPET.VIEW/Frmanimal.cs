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
    public partial class Frmanimal : Form
    {
         CadAnimal _Control;
        
        private bool Incluir = true;
        private bool Alterar = true;
        public Frmanimal()
        {
            InitializeComponent();
            _Control = new CadAnimal();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbldonoanimal_Click(object sender, EventArgs e)
        {

        }
      

        private void Frmanimal_Load(object sender, EventArgs e)
        {
            CboCliente.ValueMember = "Clicodigo";
            CboCliente.DisplayMember = "Clinome";
            CboCliente.DataSource = _Control.TodosClientes();
            CboCliente.Focus();
            CboCliente.SelectedIndex = -1;
           
            TxtDataEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TxtHoraEntrada.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void LimpaControles()
        {
            TxtNomeAnimal.Text = "";
            TxtEspecie.Text = "";     
            TxtCor.Text = "";
            TxtInformaçao.Text = "";

        }
        private void TxtCodCliente_Leave(object sender, EventArgs e)
        {
            //.................................................................................
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

            //.......................................................................................
            if (TxtCodCliente.Text.Trim() != "")
            {
                int Codigo;
                if (int.TryParse(TxtCodCliente.Text, out Codigo))
                {
                    Pet oPet = _Control.SelecionarPet(Codigo);
                    if (oPet != null)
                    {

                        TxtNomeAnimal.Text = oPet.Pnome;
                        TxtEspecie.Text = oPet.Pespecie;
                        TxtCor.Text = oPet.Pcor;
                        TxtCodCliente.Text = oPet.Pcodigo.ToString();
                        TxtInformaçao.Text = oPet.Pinfo;
                        BtnIncluir.Enabled = true;
                        BtnAlterar.Enabled = true;
                        BtnExcluir.Enabled = true;
                        Incluir = true;

                    }
                    else
                    {
                        // permite a inclusao
                        LimpaControles();
                        BtnIncluir.Enabled = true;
                        BtnAlterar.Enabled = true;
                        BtnExcluir.Enabled = false;
                        Incluir = true;

                    }
                }
                else
                {
                    LimpaControles();
                    BtnIncluir.Enabled = false;
                    BtnAlterar.Enabled = false;
                    BtnExcluir.Enabled = false;
                }
            }
        }
        private bool ValidaControles()
        {
            return true; 
        }
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
                {
                Pet oPet = new Pet();
                oPet.Pnome = TxtNomeAnimal.Text;
                oPet.Pespecie = TxtEspecie.Text;
                oPet.Psexo = CheckM.Text;
                oPet.Psexo = CheckF.Text;
                oPet.Pcor = TxtCor.Text;
                oPet.Pcodigo = TxtCodCliente.TextLength;
                oPet.Pinfo = TxtInformaçao.Text;
                if (Incluir)
                {
                    _Control.IncluirPet(oPet);
                    Incluir = false;
                    MessageBox.Show("Pet incluído com sucesso");
                }
                else
                  {

                  }
                }
        }
        private void Frmanimal_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Frmprincipal)this.MdiParent).MnuCadAnimal.Enabled = true;
        }
        //.........................................................................
        private void CarregaCliente(Cliente oCliente)
        {

            TxtCodCliente.Text = oCliente.ClienteDoBayer.Clicodigo.ToString();
            CboCliente.SelectedValue = oCliente.ClienteDoBayer.Clicodigo;

        }
        //...............................................................................


      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtCodCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (Alterar)
            {
                try
                {
                    Pet oPet = new Pet();
                    oPet.Pnome = TxtNomeAnimal.Text;
                    oPet.Pespecie = TxtEspecie.Text;
                    oPet.Psexo = CheckM.Text;
                    oPet.Psexo = CheckF.Text;
                    oPet.Pcor = TxtCor.Text;
                    oPet.Pcodigo = TxtCodCliente.TextLength;
                    oPet.Pinfo = TxtInformaçao.Text;

                    _Control.AlterarPet(oPet);
                    MessageBox.Show("Pet alterado com sucesso");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se confirmar será impossível recuperar o pet. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Pet oPet = new Pet();
                oPet.Pcodigo = TxtCodCliente.TextLength;
                try
                {
                    _Control.ExcluirPet(oPet);
                    LimpaControles();
                    TxtCodCliente.Text = "";
                    TxtCodCliente.Focus();
                    Incluir = true;
                    MessageBox.Show("Pet excluído com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Control.Serializar(Application.StartupPath + "//");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _Control.Serializar(Application.StartupPath + "//");
        }
    }
}
