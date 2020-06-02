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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if ((TxtAdmin.Text == "admin") && (TxtSenha.Text == "admin"))
            {
                Principal frm = new Principal();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Login e senha não correspodem! :(", "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
