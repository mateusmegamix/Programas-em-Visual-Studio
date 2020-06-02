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
    public partial class OrdemProducao : Form
    {
        private bool Incluir = true;
        private Control.oCordem _Control = new Control.oCordem();
        int id = 0;
        public Principal MdiContainer { get; internal set; }
        public OrdemProducao()
        {
            InitializeComponent();
        }

        private void OrdemProducao_Load(object sender, EventArgs e)
        {
            
            txtHoraOP.Text = DateTime.Now.ToString("HH:mm");
            txtDataOP.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            GrdOrdemProducao.AutoGenerateColumns = false;
            GrdOrdemProducao.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void OrdemProducao_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)this.MdiContainer).MnuOProd.Enabled = true;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            ((Principal)this.MdiContainer).MnuOProd.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CROrdem oOrdemP = new CROrdem();
            oOrdemP.ShowDialog();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();

        }

        private void cbProducao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProducao.SelectedIndex == 0)
            {
                // Aqui pode ser Visible (caso o campo esteja oculto) ou Enabled (caso só esteja desabilitado).
                cbM1.Text = "Fenol";
                cbM2.Text = "Paraformol";
                cbM3.Text = "Acido Oxálico";
            }
            
        }

        private void BtnSalvarOP_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                OrdemP oOrdemP = new OrdemP();
                oOrdemP.ProdutoOP = cbProducao.Text;
                oOrdemP.LoteOP = txtLoteProducao.Text;
                oOrdemP.DataOP = txtDataOP.Text;
                oOrdemP.HoraOP = txtHoraOP.Text;
                oOrdemP.Nome1 = cbO1.Text;
                oOrdemP.Nome2 = cbO2.Text;
                oOrdemP.Nome3 = cbO3.Text;
                oOrdemP.HO1 = ho1.Text;
                oOrdemP.HO2 = ho2.Text;
                oOrdemP.HO3 = ho3.Text;
                oOrdemP.NomeA1 = cbA1.Text;
                oOrdemP.NomeA2 = cbA2.Text;
                oOrdemP.NomeA3 = cbA3.Text;
                oOrdemP.HA1 = ha1.Text;
                oOrdemP.HA2 = ha2.Text;
                oOrdemP.HA3 = ha3.Text;
                oOrdemP.Materia1 = cbM1.Text;
                oOrdemP.Materia2 = cbM2.Text;
                oOrdemP.Materia3 = cbM3.Text;
                oOrdemP.LM1 = txtLoteM1.Text;
                oOrdemP.LM2 = txtLoteM2.Text;
                oOrdemP.LM3 = txtLoteM3.Text;
                oOrdemP.Qtd1 = txtQtd1.Text;
                oOrdemP.Qtd2 = txtQtd2.Text;
                oOrdemP.Qtd3 = txtQtd3.Text;
                oOrdemP.Observacao = txtObservacao.Text;
                //if ((TxtSenhaControle == TxtConfirmarSenhaControle) && (TxtSenhaControle != null))

                if (Incluir)
                {
                    _Control.Incluir(oOrdemP);
                    Incluir = true;
                    MessageBox.Show("Cadastro de Processo de Descrição foi realizada com sucesso!");
                }
                else
                {
                    oOrdemP.Id = id;
                    _Control.Alterar(oOrdemP);
                    Incluir = true;
                    LimpaCampos();
                    MessageBox.Show("Os dados foram alterados com sucessso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


            cbProducao.Text = "";
            txtLoteProducao.Text = "";
            cbO1.Text = "";
            cbO2.Text = "";
            cbO3.Text = "";
            ho1.Text = "";
            ho2.Text = "";
            ho3.Text = "";
            cbA1.Text = "";
            cbA2.Text = "";
            cbA3.Text = "";
            ha1.Text = "";
            ha2.Text = "";
            ha3.Text = "";
            cbM1.Text = "";
            cbM2.Text = "";
            cbM3.Text = "";
            txtLoteM1.Text = "";
            txtLoteM2.Text = "";
            txtLoteM3.Text = "";
            txtQtd1.Text = "";
            txtQtd2.Text = "";
            txtQtd3.Text = "";
            txtObservacao.Text = "";


            CarregaGrid();
        }
        private void LimpaCampos()
        {
            cbProducao.Text = "";
            txtLoteProducao.Text = "";
            cbO1.Text = "";
            cbO2.Text = "";
            cbO3.Text = "";
            ho1.Text = "";
            ho2.Text = "";
            ho3.Text = "";
            cbA1.Text = "";
            cbA2.Text = "";
            cbA3.Text = "";
            ha1.Text = "";
            ha2.Text = "";
            ha3.Text = "";
            cbM1.Text = "";
            cbM2.Text = "";
            cbM3.Text = "";
            txtLoteM1.Text = "";
            txtLoteM2.Text = "";
            txtLoteM3.Text = "";
            txtQtd1.Text = "";
            txtQtd2.Text = "";
            txtQtd3.Text = "";
            txtObservacao.Text = "";

            Incluir = true;
        }

        private void GrdOrdemProducao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdOrdemProducao.Rows[e.RowIndex].DataBoundItem != null)
            {
                OrdemP oOrdemP = ((OrdemP)GrdOrdemProducao.Rows[e.RowIndex].DataBoundItem);
                if (GrdOrdemProducao.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    cbProducao.Text = oOrdemP.ProdutoOP;
                    txtLoteProducao.Text = oOrdemP.LoteOP;
                    txtDataOP.Text = oOrdemP.DataOP;
                    txtHoraOP.Text = oOrdemP.HoraOP;
                    cbO1.Text = oOrdemP.Nome1;
                    cbO2.Text = oOrdemP.Nome2;
                    cbO3.Text = oOrdemP.Nome3;
                    ho1.Text = oOrdemP.HO1;
                    ho2.Text = oOrdemP.HO2;
                    ho3.Text = oOrdemP.HO3;
                    cbA1.Text = oOrdemP.NomeA1;
                    cbA2.Text = oOrdemP.NomeA2;
                    cbA3.Text = oOrdemP.NomeA3;
                    ha1.Text = oOrdemP.HA1;
                    ha2.Text = oOrdemP.HA2;
                    ha3.Text= oOrdemP.HA3;
                    cbM1.Text = oOrdemP.Materia1;
                    cbM2.Text = oOrdemP.Materia2;
                    cbM3.Text = oOrdemP.Materia3;
                    txtLoteM1.Text = oOrdemP.LM1;
                    txtLoteM2.Text = oOrdemP.LM2;
                    txtLoteM3.Text  = oOrdemP.LM3;
                    txtQtd1.Text = oOrdemP.Qtd1;
                    txtQtd2.Text = oOrdemP.Qtd2;
                    txtQtd3.Text = oOrdemP.Qtd3;
                    txtObservacao.Text = oOrdemP.Observacao;
                    id = oOrdemP.Id;

                }
                else if (GrdOrdemProducao.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Se confirmar será impossível recuperar os dados. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        _Control.Excluir(oOrdemP);
                        cbProducao.Text = "";
                        txtLoteProducao.Text = "";
                        txtDataOP.Text = "";
                        txtHoraOP.Text = "";
                        cbO1.Text = "";
                        cbO2.Text = "";
                        cbO3.Text = "";
                        ho1.Text = "";
                        ho2.Text = "";
                        ho3.Text = "";
                        cbA1.Text = "";
                        cbA2.Text = "";
                        cbA3.Text = "";
                        ha1.Text = "";
                        ha2.Text = "";
                        ha3.Text = "";
                        cbM1.Text = "";
                        cbM2.Text = "";
                        cbM3.Text = "";
                        txtLoteM1.Text = "";
                        txtLoteM2.Text = "";
                        txtLoteM3.Text = "";
                        txtQtd1.Text = "";
                        txtQtd2.Text = "";
                        txtQtd3.Text = "";
                        txtObservacao.Text = "";

                        CarregaGrid();
                    }
                }
            }
        }
    }
    
}
