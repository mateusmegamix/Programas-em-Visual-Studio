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
    public partial class frmRegistrarES : Form
    {
        public frmRegistrarES()
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

        private bool VerificarRegistro()
        {
            return Registro.CarregarEntradas((int)dtgPessoa.CurrentRow.Cells[0].Value);
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

            btnSaida.Enabled = VerificarRegistro();
            btnEntrada.Enabled = !btnSaida.Enabled;
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ComportamentoCampos.LetrasMaiusculas(txtBuscar, e);
        }

        private void btnEntrada_EnabledChanged(object sender, EventArgs e)
        {
            if (btnEntrada.Enabled == true)
            {
                btnEntrada.BackColor = Color.Green;
                btnEntrada.ForeColor = Color.White;
                btnEntrada.Text = "ENTRADA";
            }
            else
            {
                btnEntrada.BackColor = Color.Gainsboro;
                btnEntrada.ForeColor = Color.Black;
                btnEntrada.Text = "ENTROU";
            }
        }

        private void btnSaida_EnabledChanged(object sender, EventArgs e)
        {
            if (btnSaida.Enabled == true)
            {
                btnSaida.BackColor = Color.Maroon;
                btnSaida.ForeColor = Color.White;
                btnSaida.Text = "SAÍDA";
            }
            else
            {
                btnSaida.BackColor = Color.Gainsboro;
                btnSaida.ForeColor = Color.Black;
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (dtgPessoa.RowCount > 0)
            {
                try
                {
                    Registro registro = new Registro();
                    registro.CodPessoa = (int)dtgPessoa.CurrentRow.Cells[0].Value;
                    registro.HoraEntrada = DateTime.Now.ToShortTimeString();
                    registro.HoraSaida = "--";
                    registro.Datae = DateTime.Now.ToShortDateString();

                    Registro.Incluir(registro);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar registro! Tente novamente.");
                }
            }

            btnSaida.Enabled = VerificarRegistro();
            btnEntrada.Enabled = !btnSaida.Enabled;
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            if (dtgPessoa.RowCount > 0)
            {
                try
                {
                    Registro registro = new Registro();
                    registro.CodPessoa = (int)dtgPessoa.CurrentRow.Cells[0].Value;
                    registro.HoraSaida = DateTime.Now.ToShortTimeString();

                    Registro.Alterar(registro);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar registro! Tente novamente.");
                }
            }

            btnSaida.Enabled = VerificarRegistro();
            btnEntrada.Enabled = !btnSaida.Enabled;
        }
    }
}
