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
    public partial class SaidaView : Form
    {
        private bool Incluir = true;
        private Control.oSaida _Control = new Control.oSaida();
        int id = 0;
        public Principal MdiContainer { get; internal set; }
        public SaidaView()
        {
            InitializeComponent();
        }

        private void SaidaView_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'saidaDataSet.Saida'. Você pode movê-la ou removê-la conforme necessário.
            this.saidaTableAdapter.Fill(this.saidaDataSet.Saida);
            // TODO: esta linha de código carrega dados na tabela 'saidaDataSet.Saida'. Você pode movê-la ou removê-la conforme necessário.
            this.saidaTableAdapter.Fill(this.saidaDataSet.Saida);
            TxtHoraSaida.Text = DateTime.Now.ToString("HH:mm");
            TxtDataSaida.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //===========================================================

            cbProduto.SelectedIndex = -1;
            cbProduto.Focus();

            List<Entrada> Produtos = _Control.SelecionarTodosProdutos();


            foreach (var x in Produtos)
            {
                cbProduto.Items.Add(x.Produto);
            }

            // TODO: esta linha de código carrega dados na tabela 'saidaDataSet.Saida'. Você pode movê-la ou removê-la conforme necessário.
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            GrdSaida.AutoGenerateColumns = false;
            GrdSaida.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void BtnSalvarControle_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (cbProduto.Text != "" &&
                TxtDataSaida.Text != "" &&
                txtDescricao.Text != "" &&
                TxtHoraSaida.Text != "" &&
                txtMotivoSaida.Text != "" &&
                txtQtdEstoque.Text != "" &&
                txtQtdSaida.Text != "" &&
                txtRespEntrada.Text != "" &&
                txtRespSaida.Text != "" &&
                txtTipo.Text != "")
                
                {
                    Saida oProduto = new Saida();
                    oProduto.Data = TxtDataSaida.Text;
                    oProduto.Descricao = txtDescricao.Text;
                    oProduto.Hora = TxtHoraSaida.Text;
                    oProduto.Motivo = txtMotivoSaida.Text;
                    oProduto.Produto = cbProduto.Text;
                    oProduto.QtdSaida = Convert.ToInt32(txtQtdSaida.Text);
                    oProduto.QtdEstoque = Convert.ToInt32(txtQtdEstoque.Text);
                    oProduto.ResponsavelEntrada = txtRespEntrada.Text;
                    oProduto.Responsavel = txtRespSaida.Text;
                    oProduto.Tipo = txtTipo.Text;
                    oProduto.Id = id;

                    if (Incluir)
                    {
                        Entrada op = new Entrada();
                        op.QtdEstoque = op.QtdEstoque - Convert.ToInt32(txtQtdSaida.Text);
                       
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
                    txtMotivoSaida.Text = "";
                    txtQtdEstoque.Text = "";
                    txtQtdSaida.Text = "";
                    txtRespEntrada.Text = "";
                    txtRespSaida.Text = "";
                    txtTipo.Text = "";

                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show("Preencha os campos!");
                }
            }
        }

        private void LimpaCampos()
        {
            cbProduto.Text = "";
            txtDescricao.Text = "";
            txtMotivoSaida.Text = "";
            txtQtdEstoque.Text = "";
            txtQtdSaida.Text = "";
            txtRespEntrada.Text = "";
            txtRespSaida.Text = "";
            txtTipo.Text = "";

            Incluir = true;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            ((Principal)this.MdiContainer).MnuSai.Enabled = true;
        }

        private void GrdSaida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdSaida.Rows[e.RowIndex].DataBoundItem != null)
            {
                Saida oProduto = ((Saida)GrdSaida.Rows[e.RowIndex].DataBoundItem);
                if (GrdSaida.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    cbProduto.Text = oProduto.Produto;
                    TxtDataSaida.Text = oProduto.Data;
                    txtDescricao.Text = oProduto.Descricao;
                    TxtHoraSaida.Text = oProduto.Hora;
                    txtMotivoSaida.Text = oProduto.Motivo;
                    txtQtdEstoque.Text = oProduto.QtdEstoque.ToString();
                    txtQtdSaida.Text = oProduto.QtdSaida.ToString();
                    txtRespEntrada.Text = oProduto.ResponsavelEntrada;
                    txtRespSaida.Text = oProduto.Responsavel;
                    txtTipo.Text = oProduto.Tipo;
                    id = oProduto.Id;
                    //Alterar = true;
                    //MessageBox.Show("Cliente alterado com sucesso!");

                }
                else if (GrdSaida.Columns[e.ColumnIndex].Name == "BtnExcluir")
                    if (MessageBox.Show("Se confirmar será impossível recuperar os dados. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        _Control.Excluir(oProduto);

                        cbProduto.Text = "";
                        txtDescricao.Text = "";
                        txtMotivoSaida.Text = "";
                        txtQtdEstoque.Text = "";
                        txtQtdSaida.Text = "";
                        txtRespEntrada.Text = "";
                        txtRespSaida.Text = "";
                        txtTipo.Text = "";

                        CarregaGrid();
                    }
            }
        }

        private void SaidaView_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)this.MdiContainer).MnuSai.Enabled = true;
        }

        //====================================================
        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entrada oProduto = _Control.SelecionarProdutoNome(cbProduto.Text);
            txtTipo.Text = oProduto.Tipo;
            txtDescricao.Text = oProduto.Descricao;
            txtRespEntrada.Text = oProduto.Responsavel;
            txtQtdEstoque.Text = oProduto.QtdEstoque.ToString();
        }
        //====================================================

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CRSaida oes = new CRSaida();
            oes.ShowDialog();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {

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
            if (cbProduto.Text == "Selecione")
            {
                cbProduto.Text = "";
                cbProduto.ForeColor = Color.Black;
            }
        }
    }
}
