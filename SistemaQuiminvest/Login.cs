using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaQuiminvest.Model;

namespace SistemaQuiminvest
{
    public partial class Login : Form
    {
        public Principal MdiContainer { get; private set; }

        public Login()
        {
            InitializeComponent();
            TxtSenhaLogin.PasswordChar = '*';
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            if ((TxtNomeLogin.Text == "quiminvest") && (TxtSenhaLogin.Text == "qvst1983"))
            {
                Principal frm = new Principal();
                frm.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Login e senha não correspodem!", "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSenhaLogin_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
