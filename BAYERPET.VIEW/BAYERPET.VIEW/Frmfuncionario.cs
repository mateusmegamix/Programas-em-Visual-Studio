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
    public partial class Frmfuncionario : Form

    {
        CadFuncionario _Control = new CadFuncionario();
        private bool Incluir = true;
        private bool Alterar = true;
        public Frmfuncionario()
        {
            InitializeComponent();
        }

        private void Lblnome_Click(object sender, EventArgs e)
        {

        }

        private void Lblcodigo_Click(object sender, EventArgs e)
        {

        }

        private void Frmfuncionario_Load(object sender, EventArgs e)
        {

        }
        private void LimpaControles()
        {

            TxtNomeFuncionario.Text = "";
            TxtCPF.Text = "";
            TxtRG.Text = "";
            TxtIdade.Text = "";
            TxtTelefone.Text = "";
            TxtEndereço.Text = "";
            TxtCidade.Text = "";
            TxtBairro.Text = "";

        }
        private void TxtCodFuncionario_Leave(object sender, EventArgs e)
        {
            if (TxtCodFuncionario.Text.Trim() != "")
            {
                int Codigo;
                if (int.TryParse(TxtCodFuncionario.Text, out Codigo))
                {
                    Funcionario oFuncionario = _Control.SelecionarFuncionario(Codigo);
                    if (oFuncionario != null)
                    {
                        TxtCodFuncionario.Text = oFuncionario.Fcodigo.ToString();
                        TxtNomeFuncionario.Text = oFuncionario.Fnome;
                        TxtCPF.Text = oFuncionario.FCPF;
                        TxtRG.Text = oFuncionario.FRG;
                        TxtIdade.Text = oFuncionario.Fidade;
                        TxtTelefone.Text = oFuncionario.Ftelefone;
                        TxtEndereço.Text = oFuncionario.Fendereço;
                        TxtCidade.Text = oFuncionario.Fcidade;
                        TxtBairro.Text = oFuncionario.Fbairro;

                        BtnIncluir.Enabled = true;
                        BtnAlterar.Enabled = true;
                        BtnExcluir.Enabled = true;
                        Incluir = true;

                    }
                    else
                    {
                        //permite a inclusao
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
                Funcionario oFuncionario = new Funcionario();
                oFuncionario.Fcodigo = int.Parse(TxtCodFuncionario.Text);
                oFuncionario.Fnome = TxtNomeFuncionario.Text;
                oFuncionario.FCPF = TxtCPF.Text;
                oFuncionario.FRG = TxtRG.Text;
                oFuncionario.Fidade = TxtIdade.Text;
                oFuncionario.Ftelefone = TxtTelefone.Text;
                oFuncionario.Fendereço = TxtEndereço.Text;
                oFuncionario.Fcidade = TxtCidade.Text;
                oFuncionario.Fbairro = TxtBairro.Text;
                oFuncionario.Fsexo = CheckF.Text;
                oFuncionario.Fsexo = CheckM.Text;
                if (Incluir)
                {
                    _Control.IncluirFuncionario(oFuncionario);
                    Incluir = false;
                    MessageBox.Show("Funcionario incluído com sucesso");
                }
                else
                {

                }
            }
        }

        private void Frmfuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Frmprincipal)this.MdiParent).MnuCadFuncionario.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se confirmar será impossível recuperar o funcionario. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Funcionario oFuncionario = new Funcionario();
                oFuncionario.Fcodigo = int.Parse(TxtCodFuncionario.Text);
                try
                {
                    _Control.ExcluirFuncionario(oFuncionario);
                    LimpaControles();
                    TxtCodFuncionario.Text = "";
                    TxtCodFuncionario.Focus();
                    Incluir = true;
                    MessageBox.Show("Funcionario excluído com sucesso.");
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

                    Funcionario oFuncionario = new Funcionario();
                    oFuncionario.Fcodigo = int.Parse(TxtCodFuncionario.Text);
                    oFuncionario.Fnome = TxtNomeFuncionario.Text;
                    oFuncionario.FCPF = TxtCPF.Text;
                    oFuncionario.FRG = TxtRG.Text;
                    oFuncionario.Fidade = TxtIdade.Text;
                    oFuncionario.Ftelefone = TxtTelefone.Text;
                    oFuncionario.Fendereço = TxtEndereço.Text;
                    oFuncionario.Fcidade = TxtCidade.Text;
                    oFuncionario.Fbairro = TxtBairro.Text;
                    oFuncionario.Fsexo = CheckF.Text;
                    oFuncionario.Fsexo = CheckM.Text;

                    _Control.AlterarFuncionario(oFuncionario);
                    Alterar = true;
                    MessageBox.Show("Funcionario alterado com sucesso");
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