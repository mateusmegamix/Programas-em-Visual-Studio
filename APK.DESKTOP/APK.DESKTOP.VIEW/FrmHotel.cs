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
    public partial class FrmHotel : Form
    {
        public FrmHotel()
        {
            InitializeComponent();
        }

        public Principal MdiContainer { get; internal set; }
        private bool Incluir = true;
        private Control.Chotel _Control = new Control.Chotel();

        private void BtnLocalizacao_Click(object sender, EventArgs e)
        {
            Principal oFrm = (Principal)this.MdiParent;
            FrmMaps oFrm1 = new FrmMaps();
            oFrm1.MdiParent = oFrm;
            oFrm1.Show();
        }

        private void FrmHotel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSetHotell.CadastroHotel'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroHotelTableAdapter.Fill(this.tccDataSetHotell.CadastroHotel);
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            GridHotel.AutoGenerateColumns = false;
            GridHotel.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void BtnSalvarH_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (Incluir)
                {
                    CadastroHotel oHotel = new CadastroHotel();
                    oHotel.Bairroh = TxtBairroH.Text;
                    oHotel.Categoria = CbCategoriaH.Text;
                    oHotel.Cidadeh = TxtCidadeH.Text;
                    oHotel.DescricaoHotel = TxtDescricaoH.Text;
                    oHotel.NomeCliente = TxtClienteH.Text;
                    oHotel.ReferenciaH = TxtReferenciaH.Text;
                    oHotel.Ruah = TxtRuaH.Text;
                    oHotel.Ufh = TxtUfH.Text;
                    oHotel.Valorh = ValorH.Text;
                    oHotel.Telefone = TxtTelefoneH.Text;

                    Bitmap bmp = new Bitmap(PbImagem.Image);

                    MemoryStream memory = new MemoryStream();
                    bmp.Save(memory, ImageFormat.Bmp);

                    byte[] Imagem = memory.ToArray();

                    oHotel.FotoHotel = Imagem;


                    _Control.Incluir(oHotel);
                }

                TxtBairroH.Text = "";
                CbCategoriaH.Text = "";
                TxtCidadeH.Text = "";
                TxtDescricaoH.Text = "";
                TxtClienteH.Text = "";
                TxtReferenciaH.Text = "";
                TxtRuaH.Text = "";
                TxtUfH.Text = "";
                ValorH.Text = "";
                TxtTelefoneH.Text = "";

                PbImagem.Image = null;
                TxtAbrir.Text = String.Empty;

                CarregaGrid();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridHotel.Rows[e.RowIndex].DataBoundItem != null)
            {
                CadastroHotel oHotel = ((CadastroHotel)GridHotel.Rows[e.RowIndex].DataBoundItem);
                if (GridHotel.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    TxtBairroH.Text = oHotel.Bairroh;
                    CbCategoriaH.Text = oHotel.Categoria;
                    TxtCidadeH.Text = oHotel.Cidadeh;
                    TxtDescricaoH.Text = oHotel.DescricaoHotel;
                    TxtClienteH.Text = oHotel.NomeCliente;
                    TxtReferenciaH.Text = oHotel.ReferenciaH;
                    TxtRuaH.Text = oHotel.Ruah;
                    TxtUfH.Text = oHotel.Ufh;
                    ValorH.Text = oHotel.Valorh;
                    TxtTelefoneH.Text = oHotel.Telefone;

                    PbImagem.Image = null;
                    TxtAbrir.Text = String.Empty;
                }
                else if (GridHotel.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    _Control.Excluir(oHotel);
                    TxtBairroH.Text = "";
                    CbCategoriaH.Text = "";
                    TxtCidadeH.Text = "";
                    TxtDescricaoH.Text = "";
                    TxtClienteH.Text = "";
                    TxtReferenciaH.Text = "";
                    TxtRuaH.Text = "";
                    TxtUfH.Text = "";
                    ValorH.Text = "";
                    TxtTelefoneH.Text = "";

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

        private void BtnCancelarH_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            TxtBairroH.Text = "";
            CbCategoriaH.Text = "";
            TxtCidadeH.Text = "";
            TxtDescricaoH.Text = "";
            TxtClienteH.Text = "";
            TxtReferenciaH.Text = "";
            TxtRuaH.Text = "";
            TxtUfH.Text = "";
            ValorH.Text = "";
            TxtTelefoneH.Text = "";
        }


    }
}
