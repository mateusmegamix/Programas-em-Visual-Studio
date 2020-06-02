using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GuessTheWord
{
    public delegate void CheckLetter(string letter);
    
    public partial class Forca : Form
    {
        const int  NUMERO_MAXIMO_CHANCES = 5;
        //Um evento que é invocado a cada vez quando um tecla (letra) é pressionada
        event CheckLetter ChkLtr;

        string input;
        string letras_Informadas = "";
        
        //procura uma palavra
        string palavraAEcontrar= "";
        
        //estado atual das letras encontradas na palavra
        string palavraAExibir = "";
        
        //array de caracteres da palavra
        char[] arrayPalavraAEncontrar;
        int[] palavraAEncontrarPosicaoLetras;
        bool isLetraEncontrada = false;

        //gerador randomico numerico para pegar a palavra randomica da lista
        Random rndm = new Random(0);
        
        //Collection de palavras
        List<string> listaPalavras = new List<string>();
        
        List<int> palavrasIndiceJaUsada = new List<int>();

        int contadorLetraUsada = 0;

        public Forca()
        {
            InitializeComponent();

            //Subscribe the event
            this.ChkLtr += new CheckLetter(Form1_ChkLtr);
            
            //Cria lista de palavra
            CriaListaPalavras();

            //Inicia um novo jogo
            IniciarJogo();
        }

        private void CriaListaPalavras()
        {
            // lista de 15 palavras
            listaPalavras.Add("Localizacao");
            listaPalavras.Add("Amadora");
            listaPalavras.Add("Educando");
            listaPalavras.Add("Veterano");
            listaPalavras.Add("Nacional");
            listaPalavras.Add("Computador");
            listaPalavras.Add("Calculadora");
            listaPalavras.Add("Transmissão");
            listaPalavras.Add("Continental");
            listaPalavras.Add("Razoavel");
            listaPalavras.Add("Operacao");
            listaPalavras.Add("Suspeito");
            listaPalavras.Add("Amanha");
            listaPalavras.Add("Ontem");
            listaPalavras.Add("Perfume");
        }

        private string GetNovaPalavraDoPool()
        {
            bool IsNovaPalavra = false;
            //Default word
            string temp = "HANGMAN";
            
            try
            {
                while (IsNovaPalavra == false)
                {
                    //-------------pega a palavra randomica da lista de palavras
                    int index = rndm.Next();

                    index = index % listaPalavras.Count;

                    if (!palavrasIndiceJaUsada.Exists(e => e == index))
                    {
                        temp = listaPalavras[index];
                        palavrasIndiceJaUsada.Add(index);
                        IsNovaPalavra = true;
                        break;
                    }
                    else
                    {
                        IsNovaPalavra = false;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            return temp.ToUpper();
        }

        private void IniciarJogo()
        {
            try
            {
                palavraAEcontrar = GetNovaPalavraDoPool();
                palavraAEcontrar = palavraAEcontrar.ToUpper();
                arrayPalavraAEncontrar = palavraAEcontrar.ToCharArray();

                palavraAEncontrarPosicaoLetras = new int[palavraAEcontrar.Length];

                input = "";
                palavraAExibir = "";
                for (int i = 0; i < palavraAEcontrar.Length; i++)
                {
                    palavraAExibir += "-";
                }

                letras_Informadas = "";
                contadorLetraUsada = 0;

                label_Word.Text = palavraAExibir.ToUpper();
                label_MissedLetters.Text = letras_Informadas;
                label_MissedLtrCnt.Text = NUMERO_MAXIMO_CHANCES.ToString();
                Application.DoEvents();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //Event handler
        private void Form1_ChkLtr(string currentInputletter)
        {
            try
            {
                if (contadorLetraUsada < NUMERO_MAXIMO_CHANCES)
                {

                    isLetraEncontrada = false;
                    for (int i = 0; i < arrayPalavraAEncontrar.Length; i++)
                    {
                        if (currentInputletter[0] == arrayPalavraAEncontrar[i])
                        {
                            palavraAEncontrarPosicaoLetras[i] = 1;
                            isLetraEncontrada = true;
                        }
                    }

                    if (isLetraEncontrada == false)
                    {
                        letras_Informadas += currentInputletter + ", ";
                        contadorLetraUsada++;
                        label_MissedLtrCnt.Text = (NUMERO_MAXIMO_CHANCES - contadorLetraUsada).ToString();
                    }

                    palavraAExibir = "";
                    for (int i = 0; i < arrayPalavraAEncontrar.Length; i++)
                    {
                        if (palavraAEncontrarPosicaoLetras[i] == 1)
                        {
                            palavraAExibir += arrayPalavraAEncontrar[i].ToString();
                        }
                        else
                        {
                            palavraAExibir += "-";
                        }
                    }

                    label_Word.Text = palavraAExibir.ToUpper();
                    label_MissedLetters.Text = letras_Informadas;

                    if (palavraAEncontrarPosicaoLetras.All(e => e == 1))
                    {
                        MessageBox.Show("PARABÉNS ! VOCÊ ACERTOU A PALAVRA.", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IniciarJogo();
                    }
                }
                else
                {
                    MessageBox.Show("Infelizmente, você não acertou a palavra" + "\nA palavra correta é: " + palavraAEcontrar, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IniciarJogo();
                }
                Application.DoEvents();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        #region Getting Alphabets
        
        private void button_A_Click(object sender, EventArgs e)
        {
            input = "A"; 
            
            ChkLtr(input);
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            input = "B";
            
            ChkLtr(input);
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            input = "C";
            
            ChkLtr(input);
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            input = "D";
            
            ChkLtr(input);
        }

        private void button_E_Click(object sender, EventArgs e)
        {
            input = "E";
            
            ChkLtr(input);
        }

        private void button_F_Click(object sender, EventArgs e)
        {
            input = "F";
            
            ChkLtr(input);
        }

        private void button_G_Click(object sender, EventArgs e)
        {
            input = "G";
            
            ChkLtr(input);
        }

        private void button_H_Click(object sender, EventArgs e)
        {
            input = "H";
            
            ChkLtr(input);
        }

        private void button_I_Click(object sender, EventArgs e)
        {
            input = "I";
            
            ChkLtr(input);
        }

        private void button_J_Click(object sender, EventArgs e)
        {
            input = "J";
            
            ChkLtr(input);
        }

        private void button_K_Click(object sender, EventArgs e)
        {
            input = "K";
            
            ChkLtr(input);
        }

        private void button_L_Click(object sender, EventArgs e)
        {
            input = "L";
            
            ChkLtr(input);
        }

        private void button_M_Click(object sender, EventArgs e)
        {
            input = "M";
            
            ChkLtr(input);
        }

        private void button_N_Click(object sender, EventArgs e)
        {
            input = "N";
            
            ChkLtr(input);
        }

        private void button_O_Click(object sender, EventArgs e)
        {
            input = "O";
            
            ChkLtr(input);
        }

        private void button_P_Click(object sender, EventArgs e)
        {
            input = "P";
            
            ChkLtr(input);
        }

        private void button_Q_Click(object sender, EventArgs e)
        {
            input = "Q";
            
            ChkLtr(input);
        }

        private void button_R_Click(object sender, EventArgs e)
        {
            input = "R";
            
            ChkLtr(input);
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            input = "S";
            
            ChkLtr(input);
        }

        private void button_T_Click(object sender, EventArgs e)
        {
            input = "T";
            
            ChkLtr(input);
        }

        private void button_U_Click(object sender, EventArgs e)
        {
            input = "U";
            
            ChkLtr(input);
        }

        private void button_V_Click(object sender, EventArgs e)
        {
            input = "V";
            
            ChkLtr(input);
        }

        private void button_W_Click(object sender, EventArgs e)
        {
            input = "W";
            
            ChkLtr(input);
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            input = "X";
            
            ChkLtr(input);
        }

        private void button_Y_Click(object sender, EventArgs e)
        {
            input = "Y";
            
            ChkLtr(input);
        }

        private void button_Z_Click(object sender, EventArgs e)
        {
            input = "Z";
            
            ChkLtr(input);
        }
#endregion

        private void button_LoadNewWord_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                e.Link.LinkData = "http://www.macoratti.net/";
                System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
