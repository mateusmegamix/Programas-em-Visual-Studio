using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICOP.MODEL;
using SICOP.CONTROLLER;
using System.IO;

namespace SICOP.VIEW
{
    public partial class frmConsultarPessoa : Form
    {
        public frmConsultarPessoa()
        {
            InitializeComponent();
        }

        private void frmConsultarPessoa_Load(object sender, EventArgs e)
        {
            dtgPessoa.AutoGenerateColumns = false;
            dtgPessoa.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            dtgPessoa.DefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            dtgPessoa.DataSource = CPessoa.CarregarPessoa();

            cbxFiltro.SelectedIndex = 0;
        }

        Image temp = null;
        private void CarregaFoto()
        {
            if (dtgPessoa.RowCount > 0)
            {
                String nomefoto = dtgPessoa.CurrentRow.Cells[0].Value.ToString();

                if (System.IO.Directory.Exists(@".\Captured Images\"))
                {
                    try
                    {
                        string path = @".\Captured Images\" + nomefoto + ".jpg";
                        using (Stream stream = File.OpenRead(path))
                        {
                            temp = System.Drawing.Image.FromStream(stream);
                        }
                        imgCamera.BackgroundImage = temp;
                    }
                    catch (Exception ex)
                    {
                        imgCamera.BackgroundImage = Properties.Resources.img_default;
                    }
                }
            }
            else
            {
                imgCamera.BackgroundImage = null;
            }
        }

        private void CarregaInfo()
        {
            try
            {
                int id = Convert.ToInt32(dtgPessoa.CurrentRow.Cells[0].Value);
                Pessoa oPessoa = CPessoa.CarregarPK(id);
                CNH oCNH = CCNH.CarregarPK(id);
                Veiculo oVeiculo = CVeiculo.CarregarPK(id);

                //Insere informações da tabale IDENTIFICACAO

                //Adiciona os nodes caso estes não existam
                if (trvPessoa.Nodes.Count == 0)
                {
                    trvPessoa.Nodes.Add("Identificacao").Name = "Identificacao";
                    trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("Identificacao")].Text = "Identificação";
                    trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("Identificacao")].NodeFont = new Font("Segoe UI", 10, FontStyle.Bold);
                    TreeNode ident = trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("Identificacao")];
                    ident.Nodes.Add("Nome").Name = "Nome";
                    ident.Nodes.Add("Documento").Name = "Documento";
                    ident.Nodes.Add("Telefone").Name = "Telefone";
                    ident.Nodes.Add("Vinculo").Name = "Vinculo";
                    ident.Nodes.Add("Empresa").Name = "Empresa";
                }

                TreeNode tn = trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("Identificacao")];
                tn.Nodes[tn.Nodes.IndexOfKey("Nome")].Text = "Nome: " + oPessoa.PesNome;
                tn.Nodes[tn.Nodes.IndexOfKey("Documento")].Text = "Documento: " + oPessoa.PesDocumento;
                tn.Nodes[tn.Nodes.IndexOfKey("Telefone")].Text = "Telefone: " + oPessoa.PesTelefone;
                tn.Nodes[tn.Nodes.IndexOfKey("Vinculo")].Text = "Vínculo: " + oPessoa.PesVinculo;
                tn.Nodes[tn.Nodes.IndexOfKey("Empresa")].Text = "Empresa: " + oPessoa.PesEmpresa;

                //Verifica se é um motorista
                if (oCNH != null && oVeiculo != null)
                {
                    //Adiciona os nodes caso estes não existam
                    if (trvPessoa.Nodes.Count == 1)
                    {
                        trvPessoa.Nodes.Add("CNH").Name = "CNH";
                        TreeNode cnh = trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("CNH")];
                        trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("CNH")].NodeFont = new Font("Segoe UI", 10, FontStyle.Bold);
                        cnh.Nodes.Add("Numero").Name = "Numero";
                        cnh.Nodes.Add("Categoria").Name = "Categoria";
                        cnh.Nodes.Add("Validade").Name = "Validade";
                        cnh.Nodes.Add("Mopp").Name = "Mopp";

                        trvPessoa.Nodes.Add("Veiculo").Name = "Veiculo";
                        trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("Veiculo")].Text = "Veículo";
                        trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("Veiculo")].NodeFont = new Font("Segoe UI", 10, FontStyle.Bold);
                        TreeNode vei = trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("Veiculo")];
                        vei.Nodes.Add("Tipo").Name = "Tipo";
                        vei.Nodes.Add("Placa").Name = "Placa";
                        vei.Nodes.Add("Cidade").Name = "Cidade";
                    }

                    tn = trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("CNH")];
                    tn.Nodes[tn.Nodes.IndexOfKey("Numero")].Text = "Número: " + oCNH.CNHNumero;
                    tn.Nodes[tn.Nodes.IndexOfKey("Categoria")].Text = "Categoria: " + oCNH.CNHCategoria;
                    tn.Nodes[tn.Nodes.IndexOfKey("Validade")].Text = "Validade: " + oCNH.CNHValidade;
                    tn.Nodes[tn.Nodes.IndexOfKey("Mopp")].Text = "MOPP: " + oCNH.CNHMopp;

                    tn = trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("Veiculo")];
                    tn.Nodes[tn.Nodes.IndexOfKey("Tipo")].Text = "Tipo: " + oVeiculo.VeiTipo;
                    tn.Nodes[tn.Nodes.IndexOfKey("Placa")].Text = "Placa: " + oVeiculo.VeiPlaca;
                    tn.Nodes[tn.Nodes.IndexOfKey("Cidade")].Text = "Cidade: " + oVeiculo.VeiCidadePlaca;
                }
                else if (trvPessoa.Nodes.Count > 1)
                {
                    trvPessoa.Nodes.Remove(trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("CNH")]);
                    trvPessoa.Nodes.Remove(trvPessoa.Nodes[trvPessoa.Nodes.IndexOfKey("Veiculo")]);
                }

                trvPessoa.ExpandAll();
                trvPessoa.Nodes[0].EnsureVisible();

            }
            catch(Exception e)
            {
                trvPessoa.Nodes.Clear();
            }

        }

        private void Filtrar()
        {
            List<Pessoa> lista = Pessoa.CarregarPessoa();
            List<Pessoa> listaFiltrada = new List<Pessoa>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (cbxFiltro.Text == "NOME")
                {
                    if (lista[i].PesNome.Contains(txtBuscar.Text))
                    {
                        listaFiltrada.Add(lista[i]);
                    }
                }
                if (cbxFiltro.Text == "CPF" || cbxFiltro.Text == "RG")
                {
                    if (lista[i].PesDocumento.Contains(txtBuscar.Text))
                    {
                        listaFiltrada.Add(lista[i]);
                    }
                }
                if (cbxFiltro.Text == "EMPRESA")
                {
                    if (lista[i].PesEmpresa.Contains(txtBuscar.Text))
                    {
                        listaFiltrada.Add(lista[i]);
                    }
                }
            }

            dtgPessoa.DataSource = listaFiltrada;
        }

        private void dtgPessoas_SelectionChanged(object sender, EventArgs e)
        {
            CarregaFoto();
            CarregaInfo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFiltro.Text == "CPF")
            {
                txtBuscar.MaxLength = 14;
                ComportamentoCampos.NumeroCPF(txtBuscar, e);
            }
            else if (cbxFiltro.Text == "RG")
            {
                txtBuscar.MaxLength = 12;
                ComportamentoCampos.NumeroRG(txtBuscar, e);
            }
            else
            {
                txtBuscar.MaxLength = 100;
            }

            if (e.KeyChar == (char)13) //Enter
            {
                Filtrar();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            cbxFiltro.Text = "NOME";
            dtgPessoa.DataSource = CPessoa.CarregarPessoa();
            txtBuscar.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPessoa.RowCount > 0)
            {
                if (e.ColumnIndex == 6)
                {
                    Pessoa pessoa = CPessoa.CarregarPK((int)dtgPessoa.CurrentRow.Cells[0].Value);
                    CNH cnh = CCNH.CarregarPK(pessoa.PesCodigo);
                    Veiculo vei = CVeiculo.CarregarPK(pessoa.PesCodigo);

                    frmCadastrarPessoa frm = new frmCadastrarPessoa(pessoa, cnh, vei, true);
                    frm.MdiParent = this.MdiParent;
                    this.Close();
                    frm.Show();
                }
                if (e.ColumnIndex == 7)
                {
                    DialogResult dialogResult = MessageBox.Show("Essa ação é irreversível. Deseja mesmo excluir?", "Atenção!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            Pessoa pessoa = CPessoa.CarregarPK((int)dtgPessoa.CurrentRow.Cells[0].Value);
                            CNH cnh = CCNH.CarregarPK(pessoa.PesCodigo);
                            Veiculo vei = CVeiculo.CarregarPK(pessoa.PesCodigo);

                            if (cnh != null && vei != null)
                            {
                                CPessoa.ExcluirCompleto(pessoa, cnh, vei);
                            }
                            else
                            {
                                CPessoa.Excluir(pessoa);
                            }

                            string path = @".\Captured Images\" + pessoa.PesCodigo.ToString() + ".jpg";
                            if (System.IO.File.Exists(path))
                            {
                                System.IO.File.Delete(path);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao excluir registro! Tente novamente.");
                        }
                        
                        dtgPessoa.DataSource = CPessoa.CarregarPessoa();
                    }                    
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                int id = (int)dtgPessoa.CurrentRow.Cells[0].Value;
                frmRelatorio frm = new frmRelatorio(CPessoa.CarregarPK(id), CCNH.CarregarPK(id), CVeiculo.CarregarPK(id));
                frm.MdiParent = this.MdiParent;
                this.Close();
                frm.Show();
            }
        }
    }
}
