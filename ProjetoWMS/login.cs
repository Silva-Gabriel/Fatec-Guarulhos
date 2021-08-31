using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAWS_WMS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            lblSystemName.Parent = picBK;
            lblSystemName.BackColor = Color.Transparent;
            lblUser.Parent = picBK;
            lblUser.BackColor = Color.Transparent;
            lblPass.Parent = picBK;
            lblPass.BackColor = Color.Transparent;
            lnkData.Parent = picBK;
            lnkData.BackColor = Color.Transparent;
        }

        private void lblForget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void lnkData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não consegue acessar? Entre em contato com o RH através do e-mail abaixo:\n\n(rh@companyname.com.br)\n\n-- Apagar ---------\n\nUsuário:\nfatec\n\nSenha:\n123\n----------------------", "FAWS WMS");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string user = "fatec";
            string pass = "123";

            if (txtUser.Text == user && txtPass.Text == pass)
            {
                menu frm = new menu();
                Hide();
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.","FAWS WMS");
            }
        }
        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resposta = MessageBox.Show("Tem certeza que deseja sair?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.No == resposta)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
