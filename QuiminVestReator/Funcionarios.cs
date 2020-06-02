using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using ReatorModel;

namespace QuiminVestReator
{
    public partial class Funcionarios : Form
    {
        private bool Incluir = true;
        private Control.oFuncionario _Control = new Control.oFuncionario();
        internal TelaPrincipal MdiContainer;
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'reatorDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.reatorDataSet.funcionario);
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            GrdFuncionario.AutoGenerateColumns = false;
            GrdFuncionario.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void GrdFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdFuncionario.Rows[e.RowIndex].DataBoundItem != null)
            {
                funcionario oFuncionario = ((funcionario)GrdFuncionario.Rows[e.RowIndex].DataBoundItem);
                if (GrdFuncionario.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    txtBairro.Text = oFuncionario.Bairro;
                    txtCargo.Text = oFuncionario.Cargo;
                    txtCidade.Text = oFuncionario.Cidade;
                    TxtCPF.Text = oFuncionario.Cpf;
                    TxtDate.Text = oFuncionario.DataNasc;
                    TxtDescricaoCliente.Text = oFuncionario.Descricao;
                    txtEmail.Text = oFuncionario.Email;
                    TxtIdadeFuncionario.Text = oFuncionario.Idade;
                    TxtLogin.Text = oFuncionario.Login;
                    TxtNomeFuncionario.Text = oFuncionario.Nome;
                    txtRua.Text = oFuncionario.Rua;
                    TxtSenha.Text = oFuncionario.Senha;
                    CbSexo.Text = oFuncionario.Sexo;
                    PbImagem.Image = null;
                    TxtAbrir.Text = String.Empty;

                }
                else if (GrdFuncionario.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Deseja realmente excluir?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _Control.Excluir(oFuncionario);
                        txtBairro.Text = "";
                        txtCargo.Text = "";
                        txtCidade.Text = "";
                        TxtCPF.Text = "";
                        TxtDate.Text = "";
                        TxtDescricaoCliente.Text = "";
                        txtEmail.Text = "";
                        TxtIdadeFuncionario.Text = "";
                        TxtLogin.Text = "";
                        TxtNomeFuncionario.Text = "";
                        txtRua.Text = "";
                        TxtSenha.Text = "";
                        CbSexo.Text = "";

                        PbImagem.Image = null;
                        TxtAbrir.Text = String.Empty;

                        CarregaGrid();
                    }
                }
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (Incluir)
                {
                    funcionario oFuncionario = new funcionario();
                    oFuncionario.Bairro = txtBairro.Text;
                    oFuncionario.Cargo = txtCargo.Text;
                    oFuncionario.Cidade = txtCidade.Text;
                    oFuncionario.Cpf = TxtCPF.Text;
                    oFuncionario.DataNasc = TxtDate.Text;
                    oFuncionario.Descricao = TxtDescricaoCliente.Text;
                    oFuncionario.Email = txtEmail.Text;
                    oFuncionario.Idade = TxtIdadeFuncionario.Text;
                    oFuncionario.Login = TxtLogin.Text;
                    oFuncionario.Nome = TxtNomeFuncionario.Text;
                    oFuncionario.Rua = txtRua.Text;
                    oFuncionario.Senha = TxtSenha.Text;
                    oFuncionario.Sexo = CbSexo.Text;

                    Bitmap bmp = new Bitmap(PbImagem.Image);

                    MemoryStream memory = new MemoryStream();
                    bmp.Save(memory, ImageFormat.Bmp);

                    byte[] Imagem = memory.ToArray();

                    oFuncionario.Image = Imagem;

                    _Control.Incluir(oFuncionario);

                }
            }

            txtBairro.Text = "";
            txtCargo.Text = "";
            txtCidade.Text = "";
            TxtCPF.Text = "";
            TxtDate.Text = "";
            TxtDescricaoCliente.Text = "";
            txtEmail.Text = "";
            TxtIdadeFuncionario.Text = "";
            TxtLogin.Text = "";
            TxtNomeFuncionario.Text = "";
            txtRua.Text = "";
            TxtSenha.Text = "";
            CbSexo.Text = "";
            TxtTelefone.Text = "";
            PbImagem.Image = null;
            TxtAbrir.Text = String.Empty;

            CarregaGrid();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            txtBairro.Text = "";
            txtCargo.Text = "";
            txtCidade.Text = "";
            TxtCPF.Text = "";
            TxtDate.Text = "";
            TxtDescricaoCliente.Text = "";
            txtEmail.Text = "";
            TxtIdadeFuncionario.Text = "";
            TxtLogin.Text = "";
            TxtNomeFuncionario.Text = "";
            txtRua.Text = "";
            TxtSenha.Text = "";
            CbSexo.Text = "";
            TxtTelefone.Text = "";
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtAbrir.Text = openFileDialog1.FileName;
                PbImagem.ImageLocation = openFileDialog1.FileName;

            }
        }
    }
}
