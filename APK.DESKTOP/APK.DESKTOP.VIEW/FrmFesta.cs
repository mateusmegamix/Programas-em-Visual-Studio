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
    public partial class FrmFesta : Form
    {
        public FrmFesta()
        {
            InitializeComponent();
        }

        public Principal MdiContainer { get; internal set; }
        private bool Incluir = true;
        private Control.Cfesta _Control = new Control.Cfesta();
  
        private void FrmFesta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tccDataSetFest.CadastroFesta'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroFestaTableAdapter.Fill(this.tccDataSetFest.CadastroFesta);
            // TODO: esta linha de código carrega dados na tabela 'tccDataSetFesta.CadastroFesta'. Você pode movê-la ou removê-la conforme necessário.

            CarregaGrid();
            
        }

        private void CarregaGrid()
        {
            GridFesta.AutoGenerateColumns = false;
            GridFesta.DataSource = _Control.SelecionarTodos();
        }

        private bool ValidaControles()
        {
            return true;
        }

        private void BtnLocalizacao_Click(object sender, EventArgs e)
        {
           Principal oFrm = (Principal)this.MdiParent;
           FrmMaps oFrm1 = new FrmMaps();
           oFrm1.MdiParent = oFrm;
           oFrm1.Show();
        }

        private void BtnSalvarF_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (Incluir)
                {
                    CadastroFesta oFestas = new CadastroFesta();
                    oFestas.Bairrof = TxtBairroF.Text;
                    oFestas.Cepf = TxtCepF.Text;
                    oFestas.Cidadef = TxtCidadeF.Text;
                    oFestas.Dataf = TxtDateF.Text;
                    oFestas.DescricaoEvento = TxtDescricaoF.Text;
                    oFestas.NomeCliente = TxtClienteF.Text;
                    oFestas.Ruaf = TxtRuaF.Text;
                    oFestas.TipoF = TxtTipoFesta.Text;
                    oFestas.Uff = TxtUfF.Text;
                    oFestas.Valorf = ValorF.Text;
                    oFestas.ReferenciaF = TxtReferenciaF.Text;
                    oFestas.Lotef = CbLoteF.Text;
                    oFestas.Telefone = TxtTelefoneF.Text;

                    Bitmap bmp = new Bitmap(PbImagem.Image);

                    MemoryStream memory = new MemoryStream();
                    bmp.Save(memory, ImageFormat.Bmp);

                    byte[] Imagem = memory.ToArray();

                    oFestas.Fotof = Imagem;


                    _Control.Incluir(oFestas);
                }

                TxtBairroF.Text = "";
                TxtCepF.Text = "";
                TxtCidadeF.Text = "";
                TxtDateF.Text = "";
                TxtDescricaoF.Text = "";
                TxtClienteF.Text = "";
                TxtRuaF.Text = "";
                TxtTipoFesta.Text = "";
                TxtUfF.Text = "";
                ValorF.Text = "";
                CbLoteF.Text = "";
                TxtReferenciaF.Text = "";
                TxtTelefoneF.Text = "";

                PbImagem.Image = null;
                TxtAbrir.Text = String.Empty;

                CarregaGrid();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridFesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GridFesta.Rows[e.RowIndex].DataBoundItem != null)
            {
                CadastroFesta oFestas = ((CadastroFesta)GridFesta.Rows[e.RowIndex].DataBoundItem);
                if (GridFesta.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    Incluir = false;
                    TxtBairroF.Text = oFestas.Bairrof;
                    TxtCepF.Text = oFestas.Cepf;
                    TxtCidadeF.Text = oFestas.Cidadef;
                    TxtDateF.Text = oFestas.Dataf;
                    TxtDescricaoF.Text = oFestas.DescricaoEvento;
                    TxtClienteF.Text = oFestas.NomeCliente;
                    TxtRuaF.Text = oFestas.Ruaf;
                    TxtTipoFesta.Text = oFestas.TipoF;
                    TxtUfF.Text = oFestas.Uff;
                    ValorF.Text = oFestas.Valorf;
                    TxtReferenciaF.Text = oFestas.ReferenciaF;
                    CbLoteF.Text = oFestas.Lotef;
                    TxtTelefoneF.Text = oFestas.Telefone;

                    PbImagem.Image = null;
                    TxtAbrir.Text = String.Empty;
                }
                else if (GridFesta.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    _Control.Excluir(oFestas);
                    TxtBairroF.Text = "";
                    TxtCepF.Text = "";
                    TxtCidadeF.Text = "";
                    TxtDateF.Text = "";
                    TxtDescricaoF.Text = "";
                    TxtClienteF.Text = "";
                    TxtRuaF.Text = "";
                    TxtTipoFesta.Text = "";
                    TxtUfF.Text = "";
                    ValorF.Text = "";
                    CbLoteF.Text = "";
                    TxtReferenciaF.Text = "";
                    TxtTelefoneF.Text = "";

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

        private void BtnCancelarF_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            TxtBairroF.Text = "";
            TxtCepF.Text = "";
            TxtCidadeF.Text = "";
            TxtDateF.Text = "";
            TxtDescricaoF.Text = "";
            TxtClienteF.Text = "";
            TxtRuaF.Text = "";
            TxtTipoFesta.Text = "";
            TxtUfF.Text = "";
            ValorF.Text = "";
            CbLoteF.Text = "";
            TxtReferenciaF.Text = "";
            TxtTelefoneF.Text = "";
        }
    }
}
