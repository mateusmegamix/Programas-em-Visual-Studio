using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManutencaoQuiminvest.View
{
    public partial class EntradaView : Form
    {
        private bool Incluir = true;
        private Control.oEntrada _Control = new Control.oEntrada();
        int id = 0;
        public Principal MdiContainer { get; internal set; }
        public EntradaView()
        {
            InitializeComponent();
        }

        private void EntradaView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'manutencaoDataSet.Entrada'. Você pode movê-la ou removê-la conforme necessário.
            this.entradaTableAdapter.Fill(this.manutencaoDataSet.Entrada);
            // TODO: esta linha de código carrega dados na tabela 'entradaDataSet.Entrada'. Você pode movê-la ou removê-la conforme necessário.
            //this.entradaTableAdapter.Fill(this.entradaDataSet.Entrada);
            TxtHoraEntrada.Text = DateTime.Now.ToString("HH:mm");
            TxtDataEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //===========================================================
          
            cbProduto.SelectedIndex = -1;
            cbProduto.Focus();

            List<Produto> Produtos = _Control.SelecionarTodosProdutos();


            foreach (var x in Produtos)
            {
                cbProduto.Items.Add(x.Produtos);
            }

            // TODO: esta linha de código carrega dados na tabela 'entradaDataSet.Entrada'. Você pode movê-la ou removê-la conforme necessário.
            //this.entradaTableAdapter.Fill(this.entradaDataSet.Entrada);
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            GrdEntrada.AutoGenerateColumns = false;
            GrdEntrada.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void LimpaCampos()
        {
            cbProduto.Text = "";
            txtDescricao.Text = "";
            txtQtdEntrada.Text = "";
            txtResponsavelEntrada.Text = "";
            txtTipo.Text = "";
            txtModelo.Text = "";

            Incluir = true;
        }

        private void BtnSalvarControle_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (cbProduto.Text != "" &&
                TxtHoraEntrada.Text != "" &&
                TxtDataEntrada.Text != "" &&
                txtQtdEntrada.Text != "" &&
                txtResponsavelEntrada.Text != "" &&
                txtTipo.Text != "" &&
                txtDescricao.Text != "")
                {                     
                    Entrada oProduto = new Entrada();
                    oProduto.Descricao = txtDescricao.Text;
                    oProduto.Data = TxtDataEntrada.Text;
                    oProduto.Hora = TxtHoraEntrada.Text;
                    oProduto.Produto = cbProduto.Text;
                    oProduto.QtdEstoque = Convert.ToInt32(txtQtdEntrada.Text);
                    oProduto.Responsavel = txtResponsavelEntrada.Text;
                    oProduto.Tipo = txtTipo.Text;
                    oProduto.Modelo = txtDescricao.Text;
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

                    cbProduto.Text = "";
                    txtDescricao.Text = "";
                    txtQtdEntrada.Text = "";
                    txtResponsavelEntrada.Text = "";
                    txtTipo.Text = "";
                    txtModelo.Text = "";

                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show("Preencha os campos!");
                }
            }
            
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            ((Principal)this.MdiContainer).MnuEnt.Enabled = true;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void EntradaView_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)this.MdiContainer).MnuEnt.Enabled = true;
        }

        private void GrdEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdEntrada.Rows[e.RowIndex].DataBoundItem != null)
            {
                Entrada oProduto = ((Entrada)GrdEntrada.Rows[e.RowIndex].DataBoundItem);
                if (GrdEntrada.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    TxtDataEntrada.Text = oProduto.Data;
                    txtDescricao.Text = oProduto.Descricao;
                    TxtHoraEntrada.Text = oProduto.Hora;
                    txtQtdEntrada.Text = oProduto.QtdEstoque.ToString();
                    txtResponsavelEntrada.Text = oProduto.Responsavel;
                    txtTipo.Text = oProduto.Tipo;
                    cbProduto.Text = oProduto.Produto;
                    txtModelo.Text = oProduto.Modelo;
                    id = oProduto.Id;
                    //Alterar = true;
                    //MessageBox.Show("Cliente alterado com sucesso!");

                }
                else if (GrdEntrada.Columns[e.ColumnIndex].Name == "BtnExcluir")
                    if (MessageBox.Show("Se confirmar será impossível recuperar os dados. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        _Control.Excluir(oProduto);

                        cbProduto.Text = "";
                        txtDescricao.Text = "";
                        txtQtdEntrada.Text = "";
                        txtResponsavelEntrada.Text = "";
                        txtTipo.Text = "";
                        txtModelo.Text = "";

                        CarregaGrid();
                    }
            }
        }

        private void cbProduto_TextChanged(object sender, EventArgs e)
        {
            
        }
        //====================================================
        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto oProduto = _Control.SelecionarProdutoNome(cbProduto.Text);
            txtTipo.Text = oProduto.Tipo;
            txtDescricao.Text = oProduto.Descricao;
            txtModelo.Text = oProduto.Modelo;
        }
        //====================================================

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CREntrada oes = new CREntrada();
            oes.ShowDialog();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "PESQUISE UM PRODUTO")
            {
                txtBuscar.Text = "";

                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void cbProduto_Enter(object sender, EventArgs e)
        {
            if(cbProduto.Text == "Selecione")
            {
                cbProduto.Text = "";
                cbProduto.ForeColor = Color.Black;
            }
        }
    }
}
