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
    public partial class frmConsultarHESD : Form
    {
        public frmConsultarHESD()
        {
            InitializeComponent();
        }

        Image temp = null;
        private void CarregaFoto()
        {
            if (dtgES.RowCount > 0)
            {
                String nomefoto = dtgES.CurrentRow.Cells[1].Value.ToString();

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
            if (dtgES.RowCount > 0)
            {
                List<VeiculoEMotorista> lista = VeiculoEMotorista.CarregarPK((int)dtgES.CurrentRow.Cells[1].Value);
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

                List<Pessoa> lista2 = Pessoa.CarregarPK((int)dtgES.CurrentRow.Cells[1].Value);

                if(lista2.Count > 0)
                {
                    txtPessoa.Text = string.Empty;
                    string status = string.Empty;
                    for(int i = 0; i < lista2.Count; i++)
                    {
                        txtPessoa.Text += "CÓDIGO: " + lista2[i].Codigo.ToString() + "\n";
                        txtPessoa.Text += "CATEGORIA: " + lista2[i].Categoria + "\n";
                        txtPessoa.Text += "NOME: " + lista2[i].Nome + "\n";
                        txtPessoa.Text += "DOCUMENTO: " + lista2[i].Documento + "\n";
                        txtPessoa.Text += "TELEFONE: " + lista2[i].Tel + "\n";
                        txtPessoa.Text += "EMPRESA: " + lista2[i].Empresa;
                        txtPessoa.Text += "\n- - - - - - - - - - - - - - - - - - - - - - - - - \n";                     
                    }
                }
                else
                {
                    txtPessoa.Text = "NENHUM REGISTRO DE ENTRADA E SAÍDA.";
                }

            }
            else
            {
                txtInfo.Text = string.Empty;
                txtPessoa.Text = string.Empty;
            }
        }


        private void Filtrar()
        {
            List<Registro> lista = Registro.CarregarData(dtpBuscar.Value.ToShortDateString());

            dtgES.DataSource = lista;
            CarregaInfo();
            CarregaFoto();
        }

        private void frmConsultarPessoa_Load(object sender, EventArgs e)
        {
            dtgES.AutoGenerateColumns = false;
            dtgES.DataSource = Registro.CarregarData(DateTime.Now.ToShortDateString());

            CarregaFoto();
            CarregaInfo();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtgES.DataSource = Registro.CarregarData(DateTime.Now.ToShortDateString());
            CarregaFoto();
            CarregaInfo();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //Enter
            {
                Filtrar();
            }
        }
    }
}
