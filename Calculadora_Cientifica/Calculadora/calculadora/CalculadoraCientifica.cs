using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string no1,constfun;
        public bool inputstatus;
        
        public Form1()
        {
            InitializeComponent();
            no1 = "";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            radioButton1.Checked = true;
       }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button1.Text;
            }
            else
            {
                textBox1.Text = button1.Text;
                inputstatus = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button6.Text;

            }
            else
            {
                textBox1.Text = button6.Text;
                inputstatus = true;
            } 
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button7.Text;

            }
            else
            {
                textBox1.Text = button7.Text;
                inputstatus = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button8.Text;
            }
            else
            {
                textBox1.Text = button8.Text;
                inputstatus = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button11.Text;
            }
            else
            {
                textBox1.Text = button11.Text;
                inputstatus = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button12.Text;
            }
            else
            {
                textBox1.Text = button12.Text;
                inputstatus = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button13.Text;

            }
            else
            {
                textBox1.Text = button13.Text;
                inputstatus = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button16.Text;
            }
            else
            {
                textBox1.Text = button16.Text;
                inputstatus = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button17.Text;
            }
            else
            {
                textBox1.Text = button17.Text;
                inputstatus = true;
            }
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button18.Text;
            }
            else
            {
                textBox1.Text = button18.Text;
                inputstatus = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputstatus == true)
            {
                textBox1.Text += button2.Text;
            }
            else
            {
                textBox1.Text = button2.Text;
                inputstatus = true;
            }
        }

        //Operador SOmar
        private void button3_Click(object sender, EventArgs e)
        {
              no1 = textBox1.Text;
              textBox1.Text = "";
              constfun = "+";
        }

        //subtrair
        private void button9_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "-";
        }

        //multiplicar
        private void button10_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "*";
        }

        //dividir
        private void button15_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "/";
        }

        //função definida pelo usuário
        private void funcal()
        {
            switch (constfun)
            {
                case "+":
                    textBox1.Text=Convert.ToString( Convert.ToDouble(no1) + Convert.ToDouble(textBox1.Text));
                    
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(no1) - Convert.ToDouble(textBox1.Text));
                   
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(no1) * Convert.ToDouble(textBox1.Text));
                    break;
                case "/":
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "infinito";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(Convert.ToDouble(no1) / Convert.ToDouble(textBox1.Text));
                    }
                 break;
                case "x^y":
                    textBox1.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(no1), Convert.ToDouble(textBox1.Text)));
                    break;
                case "mod": textBox1.Text = Convert.ToString(Convert.ToDouble(no1) % Convert.ToDouble(textBox1.Text));
                    break;
                case "nPr": 
                    Double varn, var2,var3;                      //declara variaveis
                    varn = factorial(Convert.ToSingle(no1));    //chama funcão factorial
                    var2=  factorial(Convert.ToSingle(no1)-Convert.ToSingle(textBox1.Text));
                    textBox1.Text=Convert.ToString(varn/var2);
                    break;
                case "nCr":
                    varn = factorial(Convert.ToSingle(no1));
                    var2 = factorial(Convert.ToSingle(no1)-Convert.ToSingle(textBox1.Text));
                    var3 = factorial(Convert.ToSingle(textBox1.Text));
                    textBox1.Text = Convert.ToString(varn/(var3*var2));
                    break;
            }
        }

        //funcao para calcular o factorial
        private Single  factorial(Single x)
        {
            Single i = 1;
            for (Single s = 1; s <= x; s++)
            {
                i = i * s;
            }
            return i;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            funcal();
           inputstatus = false;
        }
       
        //when AC is pressed to power on
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Text = "0";
        }

        //calculando x evelvado a 2
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
            inputstatus = false;
        }

        //calculando x elevado a 3
        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text));
            inputstatus = false;
        }

        //calculando raiz quadrada
        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            inputstatus = false;
        }


        //x elevedo a y
        private void button22_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "x^y";
        }

        //botão CE pressionado
        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            inputstatus = true;
        }

        //setar valor de PI
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592654";
        }

        //seno
        private void button24_Click(object sender, EventArgs e)
        {
        //se selecionou radianos
            if (radioButton3.Checked==true)
            {
                textBox1.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
                //se selecionou graus
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        //cosseno
        private void button25_Click(object sender, EventArgs e)
        {
            //radianos
           if (radioButton3.Checked==true)
            {
                textBox1.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }

               //graus
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }


        //tangente
        private void button26_Click(object sender, EventArgs e)
        {
            //radianos
               if (radioButton3.Checked==true)
            {

                textBox1.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
           //graus
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        //calculando 1/x
        private void button27_Click(object sender, EventArgs e)
        {
               textBox1.Text = Convert.ToString(Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text)));
               inputstatus = false;
        }

        //calculando x! 
        private void button28_Click(object sender, EventArgs e)
        {
            Single var1=1;
            Single valor = Convert.ToSingle(textBox1.Text);
            for (int i = 1; i <= valor; i++)
            {
                var1 = var1 * i;
            }
            textBox1.Text = Convert.ToString(var1);
            inputstatus = false;

        }

        //calculanado log10
        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text=Convert.ToString(System.Math.Log10(Convert.ToDouble(textBox1.Text)));
            inputstatus=false;
        }

        //calculando log natural
        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text=Convert.ToString(System.Math.Log(Convert.ToDouble(textBox1.Text)));
            inputstatus=false;
        }
     
        //pressionou backspace
        private void button31_Click(object sender, EventArgs e)
        {
            no1= textBox1.Text;
            int n=no1.Length;
            textBox1.Text=(no1.Substring(0,n-1));
        }

        //operator(%) mod
        private void button32_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "mod";
        }

        //codigo para chave +/- 
        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(-Convert.ToInt32(textBox1.Text));
            inputstatus = false;
        }


        //inverso de Seno
        private void button35_Click(object sender, EventArgs e)
        {
           if (radioButton3.Checked==true)
            {
                textBox1.Text = Convert.ToString(System.Math.Asin(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Asin((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        //Inversa do cosseno
        private void button34_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked==true)
            {
                textBox1.Text = Convert.ToString(System.Math.Acos(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Acos((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }

        //Inversa da tangente
        private void button36_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Atan(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Atan((Convert.ToDouble(System.Math.PI)/180) * (Convert.ToDouble(textBox1.Text))));
                inputstatus = false;
            }
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        //permutação
        private void button37_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "nPr";
        }

        //combinação
        private void button38_Click(object sender, EventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            constfun = "nCr";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }
      
        //codigo para botão off 
        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = "";
            inputstatus = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_2(object sender, EventArgs e)
        {
        }
    }
} 