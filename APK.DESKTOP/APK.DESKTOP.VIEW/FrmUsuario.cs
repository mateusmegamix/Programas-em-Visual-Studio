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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private bool Incluir = true;
        private Control.Cusuario _Control = new Control.Cusuario();
        internal Principal MdiContainer;

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSetUsuario.CadastroUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroUsuarioTableAdapter.Fill(this.tccDataSetUsuario.CadastroUsuario);
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            GridUsuario.AutoGenerateColumns = false;
            GridUsuario.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }



        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtAbrir.Text = openFileDialog1.FileName;
                PbImagem.ImageLocation = openFileDialog1.FileName;

            }
        }

        private void GridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridUsuario.Rows[e.RowIndex].DataBoundItem != null)
            {
                CadastroUsuario oUsuario = ((CadastroUsuario)GridUsuario.Rows[e.RowIndex].DataBoundItem);
                if (GridUsuario.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    TxtConfirmarSenhaUsuario.Text = oUsuario.ConfSenha;
                    TxtDateUsuario.Text = oUsuario.DataNascUsua;
                    TxtEmailUsuario.Text = oUsuario.Email;
                    TxtNomeUsuario.Text = oUsuario.NomeUsuario;
                    TxtSenhaUsuario.Text = oUsuario.SenhaUsuario;
                    CbSexoUsuario.Text = oUsuario.Sexo;

                    PbImagem.Image = null;
                    TxtAbrir.Text = String.Empty;

                }
                else if (GridUsuario.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Deseja realmente excluir?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _Control.Excluir(oUsuario);
                        TxtConfirmarSenhaUsuario.Text = "";
                        TxtDateUsuario.Text = "";
                        TxtEmailUsuario.Text = "";
                        TxtNomeUsuario.Text = "";
                        TxtSenhaUsuario.Text = "";
                        CbSexoUsuario.Text = "";

                        PbImagem.Image = null;
                        TxtAbrir.Text = String.Empty;

                        CarregaGrid();
                    }
                }
            }
        }

        private void BtnSalvarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (Incluir)
                {
                    CadastroUsuario oUsuario = new CadastroUsuario();
                    oUsuario.ConfSenha = TxtConfirmarSenhaUsuario.Text;
                    oUsuario.DataNascUsua = TxtDateUsuario.Text;
                    oUsuario.Email = TxtEmailUsuario.Text;
                    oUsuario.NomeUsuario = TxtNomeUsuario.Text;
                    oUsuario.SenhaUsuario = TxtSenhaUsuario.Text;
                    oUsuario.Sexo = CbSexoUsuario.Text;

                    Bitmap bmp = new Bitmap(PbImagem.Image);

                    MemoryStream memory = new MemoryStream();
                    bmp.Save(memory, ImageFormat.Bmp);

                    byte[] Imagem = memory.ToArray();

                    oUsuario.FotoUsuario = Imagem;


                    _Control.Incluir(oUsuario);
                }
                TxtConfirmarSenhaUsuario.Text = "";
                TxtDateUsuario.Text = "";
                TxtEmailUsuario.Text = "";
                TxtNomeUsuario.Text = "";
                TxtSenhaUsuario.Text = "";
                CbSexoUsuario.Text = "";

                PbImagem.Image = null;
                TxtAbrir.Text = String.Empty;

                CarregaGrid();
            }this.Close();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelarUsuario_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            TxtConfirmarSenhaUsuario.Text = "";
            TxtDateUsuario.Text = "";
            TxtEmailUsuario.Text = "";
            TxtNomeUsuario.Text = "";
            TxtSenhaUsuario.Text = "";
            CbSexoUsuario.Text = "";
        }
    }
}
