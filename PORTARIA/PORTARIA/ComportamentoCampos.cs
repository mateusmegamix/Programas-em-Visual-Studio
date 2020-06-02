using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PORTARIA
{
    public class ComportamentoCampos
    {
        public static void ApenasNumerosInteiros(KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Função auxiliar para formatar numeros decimais que verifica se já existe um ponto
        private static bool jaExiste(string _text, ref char KeyChar)
        {
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        public static void ApenasNumerosDecimais(TextBox pTexto, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            //verifica se ',' foi pressionada
            char sepratorChar = 's';
            if (e.KeyChar == ',')
            {
                // verifica se está no começo do texto
                if (pTexto.SelectionStart == 0) e.Handled = true;
                // verifica se ja existem algum caracter do tipo ','
                if (jaExiste(pTexto.Text, ref sepratorChar)) e.Handled = true;
                //verifica se ',' é o meio de um número e depois não é um número superior a 99
                if (pTexto.SelectionStart != pTexto.Text.Length && e.Handled == false)
                {
                    // ',' é o meio
                    string AfterDotString = pTexto.Text.Substring(pTexto.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //verifica se um número foi pressionado
            if (Char.IsDigit(e.KeyChar))
            {
                //verifica se um ponto existe
                if (jaExiste(pTexto.Text, ref sepratorChar))
                {
                    int sepratorPosition = pTexto.Text.IndexOf(sepratorChar);
                    string afterSepratorString = pTexto.Text.Substring(sepratorPosition + 1);
                    if (pTexto.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
            if (pTexto.TextLength == 5 && pTexto.Text.Contains(',') == false && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += ',';
                pTexto.SelectionStart = pTexto.TextLength;
            }

        }

        public static void PlacaVeiculo(TextBox pTexto, KeyPressEventArgs e)
        {
            if (pTexto.TextLength < 3)
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (pTexto.TextLength == 3 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += "-";
            }
            if (pTexto.TextLength >= 4)
            {
                if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            pTexto.Text = pTexto.Text.ToUpper();
            pTexto.SelectionStart = pTexto.TextLength;
        }

        public static void NumeroCNH(TextBox pTexto, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (pTexto.TextLength == 6 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += "-";
            }
            pTexto.SelectionStart = pTexto.TextLength;
        }

        public static void NumeroTelefone(TextBox pTexto, KeyPressEventArgs e)
        {
            ApenasNumerosInteiros(e);
            if (pTexto.TextLength == 0 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += "(";
            }
            if (pTexto.TextLength == 3 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += ") ";
            }
            if (pTexto.TextLength == 10 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += "-";
            }
            pTexto.SelectionStart = pTexto.TextLength;
        }

        public static void Data(TextBox pTexto, KeyPressEventArgs e)
        {
            ApenasNumerosInteiros(e);
            if (pTexto.TextLength == 2 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += "/";
            }
            if (pTexto.TextLength == 5 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += "/";
            }
            pTexto.SelectionStart = pTexto.TextLength;
        }

        public static void NumeroRG(TextBox pTexto, KeyPressEventArgs e)
        {
            ApenasNumerosInteiros(e);
            if (pTexto.TextLength == 2 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += ".";
            }
            if (pTexto.TextLength == 6 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += ".";
            }
            if (pTexto.TextLength == 10 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += "-";
            }
            pTexto.SelectionStart = pTexto.TextLength;
        }

        public static void NumeroCPF(TextBox pTexto, KeyPressEventArgs e)
        {
            ApenasNumerosInteiros(e);
            if (pTexto.TextLength == 3 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += ".";
            }
            if (pTexto.TextLength == 7 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += ".";
            }
            if (pTexto.TextLength == 11 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += "-";
            }
            pTexto.SelectionStart = pTexto.TextLength;
        }

        public static void NumeroCNPJ(TextBox pTexto, KeyPressEventArgs e)
        {
            ApenasNumerosInteiros(e);
            if (pTexto.TextLength == 2 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += ".";
            }
            if (pTexto.TextLength == 6 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += ".";
            }
            if (pTexto.TextLength == 10 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += "/";
            }
            if (pTexto.TextLength == 15 && !Char.IsControl(e.KeyChar))
            {
                pTexto.Text += "-";
            }
            pTexto.SelectionStart = pTexto.TextLength;
        }

        public static void LetrasMaiusculas(TextBox pTexto, EventArgs e)
        {
            pTexto.Text = pTexto.Text.ToUpper();
            pTexto.SelectionStart = pTexto.TextLength;
        }

        public static void LimpaCampos(Form pThis)
        {
            foreach (Control c in pThis.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }

                if (c is GroupBox)
                {
                    foreach(Control cc in c.Controls)
                    {
                        if (cc is TextBox)
                        {
                            cc.Text = string.Empty;
                        }
                    }
                }
            }
            foreach (Control c in pThis.Controls)
            {
                if (c.TabIndex == 3 && c.Enabled == true)
                {
                    c.Focus();
                }
            }
        }

        public static bool VerificaCampos(Form pThis)
        {
            bool retorno = false;
            foreach (Control c in pThis.Controls)
            {
                if (c is TextBox && c.Enabled == true)
                {
                    if(c.Text == string.Empty && c.Name != "txtCodigo")
                    {
                        //MessageBox.Show("Preencha todos os campos corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        retorno = false;
                    }
                    else
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
    }
}
