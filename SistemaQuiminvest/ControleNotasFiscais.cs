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
    public partial class ControleNotasFiscais : Form
    {

       // private bool Alterar = true;
        public Principal MdiContainer { get; internal set; }
        private bool Incluir = true;
        int id=0;
        private Control.oCtrlNotas _Control = new Control.oCtrlNotas();
        public ControleNotasFiscais()
        {
            InitializeComponent();
            
        }

        private void ControleNotasFiscais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'quiminvestDataSet.CtrlNotasFiscais'. Você pode movê-la ou removê-la conforme necessário.
            this.ctrlNotasFiscaisTableAdapter.Fill(this.quiminvestDataSet.CtrlNotasFiscais);
            // TODO: esta linha de código carrega dados na tabela 'reatorDataSetControleNotas.CtrlNotasFiscais'. Você pode movê-la ou removê-la conforme necessário.
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            GrdNotas.AutoGenerateColumns = false;
            GrdNotas.DataSource = _Control.SelecionarTodos();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            ((Principal)this.MdiContainer).MnuControleNotasFiscais.Enabled = true;
            this.Close();
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void GrdNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdNotas.Rows[e.RowIndex].DataBoundItem != null)
            {
                CtrlNotasFiscais oNF = ((CtrlNotasFiscais)GrdNotas.Rows[e.RowIndex].DataBoundItem);
                if (GrdNotas.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    TxtDataNF.Text = oNF.Data;
                    txtEntrega.Text = oNF.Entrega;
                    txtFornecedor.Text = oNF.Fornecedor;
                    txtHoraNF.Text = oNF.Hora;
                    txtNF.Text = oNF.NumeroNF;
                    txtProduto.Text = oNF.Produto;
                    txtRecebimento.Text = oNF.Recebido;
                    id = oNF.Id;
                    //Alterar = true;
                    //MessageBox.Show("Cliente alterado com sucesso!");

                }
                else if (GrdNotas.Columns[e.ColumnIndex].Name == "BtnExcluir")
                if (MessageBox.Show("Se confirmar será impossível recuperar os dados. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    _Control.Excluir(oNF);

                    TxtDataNF.Text = "";
                    txtEntrega.Text = "";
                    txtFornecedor.Text = "";
                    txtHoraNF.Text = "";
                    txtNF.Text = "";
                    txtProduto.Text = "";
                    txtRecebimento.Text = "";

                    CarregaGrid();
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            TxtDataNF.Text = "";
            txtEntrega.Text = "";
            txtFornecedor.Text = "";
            txtHoraNF.Text = "";
            txtNF.Text = "";
            txtProduto.Text = "";
            txtRecebimento.Text = "";

            Incluir = true;

        }

        private void BtnSalvarControleNF_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                CtrlNotasFiscais oNotasFiscais = new CtrlNotasFiscais();
                oNotasFiscais.Fornecedor = txtFornecedor.Text;
                oNotasFiscais.NumeroNF = txtNF.Text;
                oNotasFiscais.Data = TxtDataNF.Text;
                oNotasFiscais.Entrega = txtEntrega.Text;
                oNotasFiscais.Hora = txtHoraNF.Text;
                oNotasFiscais.Produto = txtProduto.Text;
                oNotasFiscais.Recebido = txtRecebimento.Text;

                if (Incluir)
                {
                    _Control.Incluir(oNotasFiscais);
                    Incluir = true;
                    MessageBox.Show("Cadastro de nota fiscal foi realizada com sucesso!");
                }else
                {
                    oNotasFiscais.Id = id;
                    _Control.Alterar(oNotasFiscais);
                    Incluir = true;
                    LimpaCampos();
                    MessageBox.Show("Os dados foram alterados com sucessso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                TxtDataNF.Text = "";
                txtEntrega.Text = "";
                txtFornecedor.Text = "";
                txtHoraNF.Text = "";
                txtNF.Text = "";
                txtProduto.Text = "";
                txtRecebimento.Text = "";

                CarregaGrid();
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            CRNf onotas = new CRNf();
            onotas.ShowDialog();
        }

        private void ControleNotasFiscais_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)this.MdiContainer).MnuControleNotasFiscais.Enabled = true;
        }
    }
}
