using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaDeContatos
{
    class limpeza
    {
        public void limparCampos()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtEmail.Clear();
            txtCelular.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            siglas.Text = "";
        }
    }
}
