using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAYERPET.CONTROL;
using BAYERPET.MODEL;

namespace BAYERPET.VIEW
{
    public partial class Frmcliente : Form
    {
        CadCliente _Control = new CadCliente();
        private bool Incluir = true;
        private bool Alterar = true;
        public Frmcliente()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmcliente_Load(object sender, EventArgs e)
        {

            TxtDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private bool ValidaControles()
        {
            return true;
        }
        private void  BtnIncluir_Click(object sender, EventArgs e)
        {

            if(ValidaControles())
            {
                Cliente oCliente = new Cliente();
                oCliente.Clicodigo =  int.Parse(TxtCodCliente.Text);
                oCliente.Clinome = TxtNomeCliente.Text;
                oCliente.CliCPF = TxtCPF.Text;
                oCliente.CliRG = TxtRG.Text;
                oCliente.Cliidade = TxtIdade.Text;
                oCliente.Clitelefone = TxtTelefone.Text;
                oCliente.Cliendereço = TxtEndereço.Text;
                oCliente.Clicidade = TxtCidade.Text;
                oCliente.Clibairro = TxtBairro.Text;
                oCliente.Clisexo = CheckF.Text;
                oCliente.Clisexo = CheckM.Text;
                if (Incluir)
                {
                    _Control.IncluirCliente(oCliente);
                    Incluir = true;
                    MessageBox.Show("Cliente incluído com sucesso");
                }
                else
                {

                }
            }
        }
        private void LimpaControles()
        {
     
            TxtNomeCliente.Text = "";
            TxtCPF.Text = "";
            TxtRG.Text = "";
            TxtIdade.Text = "";
            TxtTelefone.Text = "";
            TxtEndereço.Text = "";
            TxtCidade.Text = "";
            TxtBairro.Text = "";
            



        }
        private void TxtCodCliente_Leave(object sender, EventArgs e)
        {
            if (TxtCodCliente.Text.Trim() != "")
            {
                int Codigo;
                if (int.TryParse(TxtCodCliente.Text, out Codigo))
                {
                    Cliente oCliente = _Control.SelecionarCliente(Codigo);
                    if (oCliente != null)
                    {
                        TxtCodCliente.Text = oCliente.Clicodigo.ToString();
                        TxtNomeCliente.Text = oCliente.Clinome.ToString();
                        TxtCPF.Text = oCliente.CliCPF;
                        TxtRG.Text = oCliente.CliRG;
                        TxtIdade.Text = oCliente.Cliidade;
                        TxtTelefone.Text = oCliente.Clitelefone.ToString();
                        TxtEndereço.Text = oCliente.Cliendereço;
                        TxtCidade.Text = oCliente.Clicidade;
                        TxtBairro.Text = oCliente.Clibairro;
                      

                        BtnIncluir.Enabled = true;
                        BtnAlterar.Enabled = true;
                        BtnExcluir.Enabled = true;
                        Incluir = true;
                       

                    }
                    else
                    {
                        //permite a inclusão
                        LimpaControles();
                        BtnIncluir.Enabled = true;
                        BtnAlterar.Enabled = true;
                        BtnExcluir.Enabled = false;
                        Incluir = true;

                    }
                }
                else
                {

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

        private void Frmcliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Frmprincipal)this.MdiParent).MnuCadCliente.Enabled = true;
        }

        private void TxtCodCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se confirmar será impossível recuperar o cliente. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.Yes)
            {

                Cliente oCliente = new Cliente();
                oCliente.Clicodigo = int.Parse(TxtCodCliente.Text);
                try
                {
                    _Control.ExcluirCliente(oCliente);
                    LimpaControles();
                    TxtCodCliente.Text = "";
                    TxtCodCliente.Focus();
                    Incluir = true;
                    MessageBox.Show("Cliente excluído com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (Alterar)
            {
                try
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Clicodigo = int.Parse(TxtCodCliente.Text);
                    oCliente.Clinome = TxtNomeCliente.Text;
                    oCliente.CliCPF = TxtCPF.Text;
                    oCliente.CliRG = TxtRG.Text;
                    oCliente.Cliidade = TxtIdade.Text;
                    oCliente.Clitelefone = TxtTelefone.Text;
                    oCliente.Cliendereço = TxtEndereço.Text;
                    oCliente.Clicidade = TxtCidade.Text;
                    oCliente.Clibairro = TxtBairro.Text;
                    oCliente.Clisexo = CheckF.Text;
                    oCliente.Clisexo = CheckM.Text;

                    _Control.AlterarCliente(oCliente);
                    Alterar = true;
                    MessageBox.Show("Cliente alterado com sucesso");
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
