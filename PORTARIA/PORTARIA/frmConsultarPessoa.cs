using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PORTARIA
{
    public partial class frmConsultarPessoa : Form
    {
        public frmConsultarPessoa()
        {
            InitializeComponent();
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
            if (dtgPessoa.RowCount > 0)
            {
                List<VeiculoEMotorista> lista = VeiculoEMotorista.CarregarPK((int)dtgPessoa.CurrentRow.Cells[0].Value);
                if (lista.Count > 0)
                {
                    txtInfo.Text = "MOTORISTA:";
                    txtInfo.Text += "\nCNH: " + lista[0].CNH.ToString();
                    txtInfo.Text += "\nVALIDADE: " + lista[0].Validade.ToString();
                    txtInfo.Text += "\nMOPP: " + lista[0].MOPP;
                    txtInfo.Text += "\n\nVEÍCULO:";
                    txtInfo.Text += "\nPLACA: " + lista[0].Placa;
                    txtInfo.Text += "\nMODELO: " + lista[0].Modelo;
                    txtInfo.Text += "\nMARCA: " + lista[0].Marca;
                }
                else
                {
                    txtInfo.Text = "NÃO SE APLICA";
                }
            }
            else
            {
                txtInfo.Text = string.Empty;
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
                    if (lista[i].Nome.Contains(txtBuscar.Text))
                    {
                        listaFiltrada.Add(lista[i]);
                    }
                }
                if (cbxFiltro.Text == "CPF" || cbxFiltro.Text == "RG")
                {
                    if (lista[i].Documento.Contains(txtBuscar.Text))
                    {
                        listaFiltrada.Add(lista[i]);
                    }
                }
                if (cbxFiltro.Text == "EMPRESA")
                {
                    if (lista[i].Empresa.Contains(txtBuscar.Text))
                    {
                        listaFiltrada.Add(lista[i]);
                    }
                }
            }

            dtgPessoa.DataSource = listaFiltrada;
            CarregaInfo();
            CarregaFoto();
        }

        private void frmConsultarPessoa_Load(object sender, EventArgs e)
        {
            dtgPessoa.AutoGenerateColumns = false;
            dtgPessoa.DataSource = Pessoa.CarregarPessoa();
            CarregaFoto();
            CarregaInfo();
            cbxFiltro.Text = "NOME";

        }

        private void dtgPessoa_SelectionChanged(object sender, EventArgs e)
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
            dtgPessoa.DataSource = Pessoa.CarregarPessoa();
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
                    Pessoa pessoa = new Pessoa();
                    VeiculoEMotorista vem = null;

                    pessoa.Codigo = (int)dtgPessoa.CurrentRow.Cells[0].Value;
                    pessoa.Categoria = dtgPessoa.CurrentRow.Cells[1].Value.ToString();
                    pessoa.Nome = dtgPessoa.CurrentRow.Cells[2].Value.ToString();
                    pessoa.Documento = dtgPessoa.CurrentRow.Cells[3].Value.ToString();
                    pessoa.Tel = dtgPessoa.CurrentRow.Cells[4].Value.ToString();
                    pessoa.Empresa = dtgPessoa.CurrentRow.Cells[5].Value.ToString();

                    List<VeiculoEMotorista> lista = VeiculoEMotorista.CarregarPK(pessoa.Codigo);
                    if (lista.Count > 0)
                    {
                        vem = lista[0];
                    }

                    this.WindowState = FormWindowState.Normal;
                    frmCadastrarPessoa frm = new frmCadastrarPessoa(pessoa, vem, true);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    this.Close();

                }
                if (e.ColumnIndex == 7)
                {
                    DialogResult dialogResult = MessageBox.Show("Essa ação é irreversível. Deseja mesmo excluir?", "Atenção!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //try
                        //{
                            Pessoa pessoa = new Pessoa();

                            pessoa.Codigo = (int)dtgPessoa.CurrentRow.Cells[0].Value;
                            pessoa.Categoria = dtgPessoa.CurrentRow.Cells[1].Value.ToString();
                            pessoa.Nome = dtgPessoa.CurrentRow.Cells[2].Value.ToString();
                            pessoa.Documento = dtgPessoa.CurrentRow.Cells[3].Value.ToString();
                            pessoa.Tel = dtgPessoa.CurrentRow.Cells[4].Value.ToString();
                            pessoa.Empresa = dtgPessoa.CurrentRow.Cells[5].Value.ToString();

                            Pessoa.Excluir(pessoa);
                            List<VeiculoEMotorista> lista = VeiculoEMotorista.CarregarPK(pessoa.Codigo);
                            if (lista.Count > 0)
                            {
                                VeiculoEMotorista.Excluir(lista[0]);
                            }
                            string path = @".\Captured Images\" + pessoa.Codigo.ToString() + ".jpg";
                            if (System.IO.File.Exists(path))
                            {
                                System.IO.File.Delete(path);
                            }
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show("Erro ao excluir registro! Tente novamente.");
                        //}

                        dtgPessoa.DataSource = Pessoa.CarregarPessoa();
                        CarregaFoto();
                        CarregaInfo();
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ComportamentoCampos.LetrasMaiusculas(txtBuscar, e);
        }
    }
}
