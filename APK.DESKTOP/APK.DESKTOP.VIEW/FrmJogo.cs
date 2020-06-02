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
    public partial class FrmJogo : Form
    {
        public FrmJogo()
        {
            InitializeComponent();
        }

        public Principal MdiContainer { get; internal set; }
        private bool Incluir = true;
        private Control.CJogo _Control = new Control.CJogo();

        private void BtnLocalizacao_Click(object sender, EventArgs e)
        {
            Principal oFrm = (Principal)this.MdiParent;
            FrmMaps oFrm1 = new FrmMaps();
            oFrm1.MdiParent = oFrm;
            oFrm1.Show();
        }

        private void FrmJogo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSetJogos.CadastroJogo'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroJogoTableAdapter.Fill(this.tccDataSetJogos.CadastroJogo);
            CarregaGrid();

        }

        private void CarregaGrid()
        {
            GridJogo.AutoGenerateColumns = false;
            GridJogo.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }



        private void GridJogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridJogo.Rows[e.RowIndex].DataBoundItem != null)
            {
                CadastroJogo oJogo = ((CadastroJogo)GridJogo.Rows[e.RowIndex].DataBoundItem);
                if (GridJogo.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    TxtMembros.Text = oJogo.AddMembrosj;
                    TxtObjetos.Text = oJogo.AddObjeto;
                    TxtBairroJ.Text = oJogo.Bairroj;
                    TxtCidadeJ.Text = oJogo.Cidadej;
                    TxtDateJ.Text = oJogo.Dataj;
                    TxtDescricaoJ.Text = oJogo.DescricaoJ;
                    TxtPessoas.Text = oJogo.QtdPessoas;
                    TxtRuaJ.Text = oJogo.RuaJ;
                    TxtTipoJogo.Text = oJogo.TipoJ;
                    TxtUfJ.Text = oJogo.Ufj;
                    TxtUfJ.Text = oJogo.Valorj;
                    TxtTelefoneJ.Text = oJogo.Telefone;

                    PbImagem.Image = null;
                    TxtAbrir.Text = String.Empty;
                }
                else if (GridJogo.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    _Control.Excluir(oJogo);
                    TxtMembros.Text = "";
                    TxtObjetos.Text = "";
                    TxtBairroJ.Text = "";
                    TxtCidadeJ.Text = "";
                    TxtDateJ.Text = "";
                    TxtDescricaoJ.Text = "";
                    TxtPessoas.Text = "";
                    TxtRuaJ.Text = "";
                    TxtTipoJogo.Text = "";
                    TxtUfJ.Text = "";
                    TxtUfJ.Text = "";
                    TxtTelefoneJ.Text = "";

                    PbImagem.Image = null;
                    TxtAbrir.Text = String.Empty;

                    CarregaGrid();
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

        private void BtnSalvarJ_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (Incluir)
                {
                    CadastroJogo oJogo = new CadastroJogo();
                    oJogo.AddMembrosj = TxtMembros.Text;
                    oJogo.AddObjeto = TxtObjetos.Text;
                    oJogo.Bairroj = TxtBairroJ.Text;
                    oJogo.Cidadej = TxtCidadeJ.Text;
                    oJogo.Dataj = TxtDateJ.Text;
                    oJogo.DescricaoJ = TxtDescricaoJ.Text;
                    oJogo.QtdPessoas = TxtPessoas.Text;
                    oJogo.RuaJ = TxtRuaJ.Text;
                    oJogo.TipoJ = TxtTipoJogo.Text;
                    oJogo.Ufj = TxtUfJ.Text;
                    oJogo.Valorj = TxtUfJ.Text;
                    oJogo.Telefone = TxtTelefoneJ.Text;

                    Bitmap bmp = new Bitmap(PbImagem.Image);

                    MemoryStream memory = new MemoryStream();
                    bmp.Save(memory, ImageFormat.Bmp);

                    byte[] Imagem = memory.ToArray();

                    oJogo.FotoJ = Imagem;


                    _Control.Incluir(oJogo);
                }

                TxtMembros.Text = "";
                TxtObjetos.Text = "";
                TxtBairroJ.Text = "";
                TxtCidadeJ.Text = "";
                TxtDateJ.Text = "";
                TxtDescricaoJ.Text = "";
                TxtPessoas.Text = "";
                TxtRuaJ.Text = "";
                TxtTipoJogo.Text = "";
                TxtUfJ.Text = "";
                TxtUfJ.Text = "";
                TxtTelefoneJ.Text = "";

                PbImagem.Image = null;
                TxtAbrir.Text = String.Empty;

                CarregaGrid();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelarJ_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            TxtMembros.Text = "";
            TxtObjetos.Text = "";
            TxtBairroJ.Text = "";
            TxtCidadeJ.Text = "";
            TxtDateJ.Text = "";
            TxtDescricaoJ.Text = "";
            TxtPessoas.Text = "";
            TxtRuaJ.Text = "";
            TxtTipoJogo.Text = "";
            TxtUfJ.Text = "";
            TxtUfJ.Text = "";
            TxtTelefoneJ.Text = "";
        }
    }
}
