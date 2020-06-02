using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APK.DESKTOP.MODEL;
using System.IO;
using System.Drawing.Imaging;

namespace APK.DESKTOP.VIEW
{
    public partial class FrmCliente : Form
    {
        private bool Incluir = true;
        private Control.oCliente _Control = new Control.oCliente();
        internal Principal MdiContainer;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSetClient.CadastroCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroClienteTableAdapter.Fill(this.tccDataSetClient.CadastroCliente);
            CarregaGrid();

        }

        private void CarregaGrid()
        {
            GridCliente.AutoGenerateColumns = false;
            GridCliente.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void BtnSalvarCliente_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                //if ((TxtSenhaCliente == TxtConfirmarSenhaCliente) && (TxtSenhaCliente != null))

                if (Incluir)
                {
                    CadastroCliente oCliente = new CadastroCliente();
                    oCliente.Bairro = TxtBairroCliente.Text;
                    oCliente.Cidade = TxtCidadeCliente.Text;
                    oCliente.Cnpj = TxtCnpj.Text;
                    oCliente.SenhaCliente = TxtSenhaCliente.Text;
                    oCliente.ConfCliente = TxtConfirmarSenhaCliente.Text;
                    oCliente.Cpf = TxtCPF.Text;
                    oCliente.DataNasc = TxtDateCliente.Text;
                    oCliente.Descricao = TxtDescricaoCliente.Text;
                    oCliente.EmailCliente = TxtEmailCliente.Text;
                    oCliente.Idade = TxtIdadeCliente.Text;
                    oCliente.Nome = TxtNomeCliente.Text;
                    oCliente.Rua = TxtRuaCliente.Text;
                    oCliente.Telefone = TxtTelefoneCliente.Text;

                    oCliente.Sexo = CbSexoCliente.Text;

                    Bitmap bmp = new Bitmap(PbImagem.Image);

                    MemoryStream memory = new MemoryStream();
                    bmp.Save(memory, ImageFormat.Bmp);

                    byte[] Imagem = memory.ToArray();

                    oCliente.Foto = Imagem;

                    _Control.Incluir(oCliente);
                }
            }


            TxtBairroCliente.Text = "";
            TxtCidadeCliente.Text = "";
            TxtCnpj.Text = "";
            TxtSenhaCliente.Text = "";
            TxtConfirmarSenhaCliente.Text = "";
            TxtCPF.Text = "";
            TxtDateCliente.Text = "";
            TxtDescricaoCliente.Text = "";
            TxtEmailCliente.Text = "";
            TxtIdadeCliente.Text = "";
            TxtNomeCliente.Text = "";
            TxtRuaCliente.Text = "";
            CbSexoCliente.Text = "";
            TxtTelefoneCliente.Text = "";
            PbImagem.Image = null;
            TxtAbrir.Text = String.Empty;

            CarregaGrid();
        }
   


        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridCliente.Rows[e.RowIndex].DataBoundItem != null)
            {
                CadastroCliente oCliente = ((CadastroCliente)GridCliente.Rows[e.RowIndex].DataBoundItem);
                if (GridCliente.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    TxtBairroCliente.Text = oCliente.Bairro;
                    TxtCidadeCliente.Text = oCliente.Cidade;
                    TxtCnpj.Text = oCliente.Cnpj;
                    TxtSenhaCliente.Text = oCliente.SenhaCliente;
                    TxtConfirmarSenhaCliente.Text = oCliente.ConfCliente;
                    TxtCPF.Text = oCliente.Cpf;
                    TxtDateCliente.Text = oCliente.DataNasc;
                    TxtDescricaoCliente.Text = oCliente.Descricao;
                    TxtEmailCliente.Text = oCliente.EmailCliente;
                    TxtIdadeCliente.Text = oCliente.Idade;
                    TxtNomeCliente.Text = oCliente.Nome;
                    TxtRuaCliente.Text = oCliente.Rua;
                    CbSexoCliente.Text = oCliente.Sexo;
                    TxtTelefoneCliente.Text = oCliente.Telefone;
                    PbImagem.Image = null;
                    TxtAbrir.Text = String.Empty;

                }
                else if (GridCliente.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Deseja realmente excluir?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _Control.Excluir(oCliente);
                        TxtBairroCliente.Text = "";
                        TxtCidadeCliente.Text = "";
                        TxtCnpj.Text = "";
                        TxtSenhaCliente.Text = "";
                        TxtConfirmarSenhaCliente.Text = "";
                        TxtCPF.Text = "";
                        TxtDateCliente.Text = "";
                        TxtDescricaoCliente.Text = "";
                        TxtEmailCliente.Text = "";
                        TxtIdadeCliente.Text = "";
                        TxtNomeCliente.Text = "";
                        TxtRuaCliente.Text = "";
                        CbSexoCliente.Text = "";
                        TxtTelefoneCliente.Text = "";

                        PbImagem.Image = null;
                        TxtAbrir.Text = String.Empty;

                        CarregaGrid();
                    }
                }
            }
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtAbrir.Text = openFileDialog1.FileName;
                PbImagem.ImageLocation = openFileDialog1.FileName;

            }

        }

        private void BtnCancelarCliente_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            TxtBairroCliente.Text = "";
            TxtCidadeCliente.Text = "";
            TxtCnpj.Text = "";
            TxtSenhaCliente.Text = "";
            TxtConfirmarSenhaCliente.Text = "";
            TxtCPF.Text = "";
            TxtDateCliente.Text = "";
            TxtDescricaoCliente.Text = "";
            TxtEmailCliente.Text = "";
            TxtIdadeCliente.Text = "";
            TxtNomeCliente.Text = "";
            TxtRuaCliente.Text = "";
            CbSexoCliente.Text = "";
            TxtTelefoneCliente.Text = "";
        }
    }
}

