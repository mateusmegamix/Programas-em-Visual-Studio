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
using SistemaQuiminvest.Model;

namespace SistemaQuiminvest
{
    public partial class Funcionarios : Form
    {
        private bool Incluir = true;
        private Control.oFuncionario _Control = new Control.oFuncionario();
        int id = 0;
        public Principal MdiContainer { get; internal set; }
        public Funcionarios()
        {
            InitializeComponent();
            TxtSenha.PasswordChar = '*';
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'quiminvestDataSetFuncionario.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.quiminvestDataSetFuncionario.funcionario);
            CarregaGrid();
            // TODO: esta linha de código carrega dados na tabela 'reatorDataSetFuncionario.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            
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

        private void BtnSair_Click(object sender, EventArgs e)
        {
            ((Principal)this.MdiContainer).MnuFuncionario.Enabled = true;
            this.Close();
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
                    TxtLogin.Text = oFuncionario.Login;
                    TxtNomeFuncionario.Text = oFuncionario.Nome;
                    txtRua.Text = oFuncionario.Rua;
                    TxtSenha.Text = oFuncionario.Senha;
                    CbSexo.Text = oFuncionario.Sexo;
                    TxtUfCliente.Text = oFuncionario.Uf;
                    TxtTelefone.Text = oFuncionario.Telefone;

                    id = oFuncionario.Id;

                    //PbImagem.Image = null;
                    //TxtAbrir.Text = String.Empty;

                }
                else if (GrdFuncionario.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Se confirmar será impossível recuperar os dados. Deseja continuar?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        _Control.Excluir(oFuncionario);
                        txtBairro.Text = "";
                        txtCargo.Text = "";
                        txtCidade.Text = "";
                        TxtCPF.Text = "";
                        TxtDate.Text = "";
                        TxtDescricaoCliente.Text = "";
                        txtEmail.Text = "";
                        TxtLogin.Text = "";
                        TxtNomeFuncionario.Text = "";
                        txtRua.Text = "";
                        TxtSenha.Text = "";
                        CbSexo.Text = "";
                        TxtUfCliente.Text = "";
                        TxtTelefone.Text = "";

                        //PbImagem.Image = null;
                        //TxtAbrir.Text = String.Empty;

                        CarregaGrid();
                    }
                }
            }
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
            TxtLogin.Text = "";
            TxtNomeFuncionario.Text = "";
            txtRua.Text = "";
            TxtSenha.Text = "";
            CbSexo.Text = "";
            TxtTelefone.Text = "";
            TxtUfCliente.Text = "";

            Incluir = true;
        }

        private void BtnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                funcionario oFuncionario = new funcionario();
                oFuncionario.Bairro = txtBairro.Text;
                oFuncionario.Cargo = txtCargo.Text;
                oFuncionario.Cidade = txtCidade.Text;
                oFuncionario.Telefone = TxtTelefone.Text;
                oFuncionario.Cpf = TxtCPF.Text;
                oFuncionario.DataNasc = TxtDate.Text;
                oFuncionario.Descricao = TxtDescricaoCliente.Text;
                oFuncionario.Email = txtEmail.Text;
                oFuncionario.Login = TxtLogin.Text;
                oFuncionario.Nome = TxtNomeFuncionario.Text;
                oFuncionario.Rua = txtRua.Text;
                oFuncionario.Senha = TxtSenha.Text;
                oFuncionario.Sexo = CbSexo.Text;
                oFuncionario.Uf = TxtUfCliente.Text;

                Bitmap bmp = new Bitmap(PbImagem.Image);

                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Bmp);

                byte[] Imagem = memory.ToArray();

                oFuncionario.Image = Imagem;
            
                if (Incluir)
                {
                    _Control.Incluir(oFuncionario);
                    Incluir = true;
                    MessageBox.Show("Cadastro de Funcionario foi realizada com sucesso!");
                }
                else
                {
                    oFuncionario.Id = id;
                    _Control.Alterar(oFuncionario);
                    Incluir = true;
                    LimpaCampos();
                    MessageBox.Show("Os dados foram alterados com sucessso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            txtBairro.Text = "";
            txtCargo.Text = "";
            txtCidade.Text = "";
            TxtCPF.Text = "";
            TxtDate.Text = "";
            TxtDescricaoCliente.Text = "";
            txtEmail.Text = "";
            TxtLogin.Text = "";
            TxtNomeFuncionario.Text = "";
            txtRua.Text = "";
            TxtSenha.Text = "";
            CbSexo.Text = "";
            TxtTelefone.Text = "";
            TxtUfCliente.Text = "";

            CarregaGrid();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void BtnAbrir_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtAbrir.Text = openFileDialog1.FileName;
                PbImagem.ImageLocation = openFileDialog1.FileName;

            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            CRFuncionario ofuncionario = new CRFuncionario();
            ofuncionario.ShowDialog();
        }

        private void Funcionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Principal)this.MdiContainer).MnuFuncionario.Enabled = true;
        }
    }
}
