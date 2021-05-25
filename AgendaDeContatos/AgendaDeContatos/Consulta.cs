using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AgendaDeContatos
{
    public partial class Consulta : Form
    {
        public Consulta(string nome,string sobrenome,string celular,string telefone,string endereco,string sigla)
        {
            InitializeComponent();

            resultNome.Text = nome;
            resultSobrenome.Text = sobrenome;
            resultCelular.Text = celular;
            resultTelefone.Text = telefone;
            resultEndereco.Text = endereco;
            resultEstado.Text = sigla;

        }

        private void Consulta_Paint(object sender, PaintEventArgs e)
        {
            principal classePrincipal = new principal();
            classePrincipal.changeBackgroundColor(sender, e);
        }

        private void Consulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal formPrincipal = new principal();
            formPrincipal.Visible = true;
        }
    }
}
