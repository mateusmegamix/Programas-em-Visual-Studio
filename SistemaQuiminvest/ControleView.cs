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

namespace SistemaQuiminvest
{
    public partial class ControleView : Form
    {
        private bool Incluir = true;
        private Control.oControle _Control = new Control.oControle();
        int id = 0;
        public Principal MdiContainer { get; internal set; }
        public ControleView()
        {
            InitializeComponent();
            cbAmostra.Enabled = false;
            txtQtdFormol.Enabled = false;
        }

        private void Controle_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'quiminvestDataSetControle.controle'. Você pode movê-la ou removê-la conforme necessário.
            this.controleTableAdapter.Fill(this.quiminvestDataSetControle.controle);
            txtHora.Text = DateTime.Now.ToString("HH:mm");
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            // TODO: esta linha de código carrega dados na tabela 'reatorDataSetControle.controle'. Você pode movê-la ou removê-la conforme necessário.
            CarregaGrid();

            cbEtapa.SelectedIndex = -1;

        }

        private void CarregaGrid()
        {
            GrdControle.AutoGenerateColumns = false;
            GrdControle.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }



        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            ((Principal)this.MdiContainer).MnuControle.Enabled = true;
        }

        private void BtnSalvarControle_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                controle oControle = new controle();
                oControle.Etapa = cbEtapa.Text;
                oControle.AgitacaoRpm = txtAgitacao.Text;
                oControle.AmperagemA = txtAmperagem.Text;
                oControle.Caldeira = txtCaldeira.Text;
                oControle.Data = txtData.Text;
                oControle.Fluido = txtFluido.Text;
                oControle.Hora = txtHora.Text;
                oControle.PressaoMmHg = txtPressao.Text;
                oControle.Reator = txtReator.Text;
                oControle.VolDestilado = txtVolDestilado.Text;
                //if ((TxtSenhaControle == TxtConfirmarSenhaControle) && (TxtSenhaControle != null))

                if (Incluir)
                {
                    _Control.Incluir(oControle);
                    Incluir = true;
                    MessageBox.Show("Cadastro de Processo de Descrição foi realizada com sucesso!");
                }
                else
                {
                    oControle.Id = id;
                    _Control.Alterar(oControle);
                    Incluir = true;
                    LimpaCampos();
                    MessageBox.Show("Os dados foram alterados com sucessso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


            cbEtapa.Text = "";
            txtAgitacao.Text = "";
            txtAmperagem.Text = "";
            txtCaldeira.Text = "";
            txtData.Text = "";
            txtFluido.Text = "";
            txtHora.Text = "";
            txtPressao.Text = "";
            txtReator.Text = "";
            txtVolDestilado.Text = "";
            cbAmostra.Text = "";
            txtQtdFormol.Text = "";


            CarregaGrid();
        }
        private void LimpaCampos()
        {
            cbEtapa.Text = "";
            txtAgitacao.Text = "";
            txtAmperagem.Text = "";
            txtCaldeira.Text = "";
            txtData.Text = "";
            txtFluido.Text = "";
            txtHora.Text = "";
            txtPressao.Text = "";
            txtReator.Text = "";
            txtVolDestilado.Text = "";
            cbAmostra.Text = "";
            txtQtdFormol.Text = "";

            Incluir = true;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void GrdControle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdControle.Rows[e.RowIndex].DataBoundItem != null)
            {
                controle oControle = ((controle)GrdControle.Rows[e.RowIndex].DataBoundItem);
                if (GrdControle.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    cbEtapa.Text = oControle.Etapa;
                    txtAgitacao.Text = oControle.AgitacaoRpm;
                    txtAmperagem.Text = oControle.AmperagemA;
                    txtCaldeira.Text = oControle.Caldeira;
                    txtData.Text = oControle.Data;
                    txtFluido.Text = oControle.Fluido;
                    txtHora.Text = oControle.Hora;
                    txtPressao.Text = oControle.PressaoMmHg;
                    txtReator.Text = oControle.Reator;
                    txtVolDestilado.Text = oControle.VolDestilado;
                    id = oControle.Id;

                }
                else if (GrdControle.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Se confirmar será impossível recuperar os dados. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        _Control.Excluir(oControle);
                        cbEtapa.Text = "";
                        txtAgitacao.Text = "";
                        txtAmperagem.Text = "";
                        txtCaldeira.Text = "";
                        txtData.Text = "";
                        txtFluido.Text = "";
                        txtHora.Text = "";
                        txtPressao.Text = "";
                        txtReator.Text = "";
                        txtVolDestilado.Text = "";
                        cbAmostra.Text = "";
                        txtQtdFormol.Text = "";

                        CarregaGrid();
                    }
                }
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            CRControleReator oreator = new CRControleReator();
            oreator.ShowDialog();
        }

        private void ControleView_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)this.MdiContainer).MnuControle.Enabled = true;
        }

        private void txtQtdFormol_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void cbEtapa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbEtapa.SelectedIndex == 3) || (cbEtapa.SelectedIndex == 4))
            {
                // Aqui pode ser Visible (caso o campo esteja oculto) ou Enabled (caso só esteja desabilitado).
                cbAmostra.Enabled = true;
                txtQtdFormol.Enabled = true;
            }
            else
            {
                // Aqui pode ser Visible (caso o campo esteja oculto) ou Enabled (caso só esteja desabilitado).
                cbAmostra.Enabled = false;
                txtQtdFormol.Enabled = false;
            }
        }
    }
}
