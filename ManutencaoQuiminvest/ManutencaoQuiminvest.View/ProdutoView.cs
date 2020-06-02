using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManutencaoQuiminvest.Model;
using ManutencaoQuiminvest.Model.Repositories;

namespace ManutencaoQuiminvest.View
{
    public partial class ProdutoView : Form
    {
        private bool Incluir = true;
        private Control.oProduto _Control = new Control.oProduto();
        int id = 0;
        public Principal MdiContainer { get; internal set; }
        public ProdutoView()
        {
            InitializeComponent();
        }

        private void ProdutoView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'producaoDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.producaoDataSet.Produto);
            // TODO: esta linha de código carrega dados na tabela 'producaoDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtoTableAdapter1.Fill(this.producaoDataSet.Produto);
            TxtHoraEntrada.Text = DateTime.Now.ToString("HH:mm");
            TxtDataEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
            // TODO: esta linha de código carrega dados na tabela 'grdCadastroProdutoDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'produtoDataSet.Produto'. Você pode movê-la ou removê-la coProdutoorme necessário.
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            GrdProduto.AutoGenerateColumns = false;
            GrdProduto.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }


        private void LimpaCampos()
        {
            txtProduto.Text = "";
            txtDescricao.Text = "";
            txtFabricante.Text = "";
            txtFornecedor.Text = "";
            txtModelo.Text = "";
            TxtTelefone.Text = "";
            txtTipo.Text = "";

            Incluir = true;

        }

        private void GrdProduto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdProduto.Rows[e.RowIndex].DataBoundItem != null)
            {
                Produto oProduto = ((Produto)GrdProduto.Rows[e.RowIndex].DataBoundItem);
                if (GrdProduto.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    txtProduto.Text = oProduto.Produtos;
                    txtDescricao.Text = oProduto.Descricao;
                    txtFabricante.Text = oProduto.Fabricante;
                    txtFornecedor.Text = oProduto.Forcenecedor;
                    txtModelo.Text = oProduto.Modelo;
                    TxtTelefone.Text = oProduto.Telefone;
                    txtTipo.Text = oProduto.Tipo;
                    TxtHoraEntrada.Text = oProduto.Hora;
                    TxtDataEntrada.Text = oProduto.Data;
                    id = oProduto.Id;
                    //Alterar = true;
                    //MessageBox.Show("Cliente alterado com sucesso!");

                }
                else if (GrdProduto.Columns[e.ColumnIndex].Name == "BtnExcluir")
                    if (MessageBox.Show("Se confirmar será impossível recuperar os dados. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        _Control.Excluir(oProduto);

                        txtProduto.Text = "";
                        txtDescricao.Text = "";
                        txtFabricante.Text = "";
                        txtFornecedor.Text = "";
                        txtModelo.Text = "";
                        TxtTelefone.Text = "";
                        txtTipo.Text = "";

                        CarregaGrid();
                    }
            }
        }

        private void BtnSalvarProduto_Click_1(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (txtProduto.Text != "" &&
                txtDescricao.Text != "" &&
                txtTipo.Text != "" &&
                TxtHoraEntrada.Text != "" &&
                TxtDataEntrada.Text != "")
                {
                   
                    Produto oProduto = new Produto();
                    oProduto.Produtos = txtProduto.Text;
                    oProduto.Descricao = txtDescricao.Text;
                    oProduto.Fabricante = txtFabricante.Text;
                    oProduto.Forcenecedor = txtFornecedor.Text;
                    oProduto.Modelo = txtModelo.Text;
                    oProduto.Telefone = TxtTelefone.Text;
                    oProduto.Tipo = txtTipo.Text;
                    oProduto.Hora = TxtHoraEntrada.Text;
                    oProduto.Data = TxtDataEntrada.Text;
                    oProduto.Id = id;

                    if (Incluir)
                    {
                        _Control.Incluir(oProduto);
                        Incluir = true;
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    }

                    else
                    {
                        oProduto.Id = id;
                        _Control.Alterar(oProduto);
                        Incluir = true;
                        LimpaCampos();
                        MessageBox.Show("Os dados foram alterados com sucessso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    txtProduto.Text = "";
                    txtDescricao.Text = "";
                    txtFabricante.Text = "";
                    txtFornecedor.Text = "";
                    txtModelo.Text = "";
                    TxtTelefone.Text = "";
                    txtTipo.Text = "";

                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show("Preencha os campos!");
                }
            }
        }

        private void BtnLimpar_Click_1(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ((Principal)this.MdiContainer).MnuCadPro.Enabled = true;
        }

        private void ProdutoView_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)this.MdiContainer).MnuCadPro.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CRProduto oes = new CRProduto();
            oes.ShowDialog();
        }
    }
}
