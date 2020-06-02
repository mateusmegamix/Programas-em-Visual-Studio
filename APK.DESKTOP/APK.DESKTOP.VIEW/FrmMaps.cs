using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APK.DESKTOP.VIEW
{
    public partial class FrmMaps : Form
    {
        public Principal MdiContainer { get; internal set; }

        public FrmMaps()
        {
            InitializeComponent();
        }

        private void FrmMaps_Load(object sender, EventArgs e)
        {

        }
       

        private void BtnPesquisar_Click_1(object sender, EventArgs e)
        {
            {
                string Rua = TxtRua.Text;
                string Cidade = TxtCidade.Text;
                string Estado = TxtEstado.Text;
                String Cep = TxtCep.Text;

                try
                {
                    StringBuilder queryaddress = new StringBuilder();
                    queryaddress.Append(" http://maps.google.com/maps?q=");

                    if (Rua != string.Empty)
                    {
                        queryaddress.Append(Rua + "," + "+");
                    }

                    if (Cidade != string.Empty)
                    {
                        queryaddress.Append(Cidade + "," + "+");
                    }

                    if (Estado != string.Empty)
                    {
                        queryaddress.Append(Estado + "," + "+");
                    }

                    if (Cep != string.Empty)
                    {
                        queryaddress.Append(Cep + "," + "+");
                    }

                    webBrowser1.Navigate(queryaddress.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                }
            }

        }
    }
}
