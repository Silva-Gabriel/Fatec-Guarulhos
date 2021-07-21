using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoWMS
{
    public partial class InterfacePrincipal : Form
    {
        public InterfacePrincipal()
        {
            InitializeComponent();
            List<TextBox> txtList = new List<TextBox>() { txtAltura, txtArea, txtCodBarras, txtCodProd, txtComprimento, txtCorredor, txtIDfornecedor, txtIDlocal, txtLargura, txtLote, txtModulo, txtnivel, txtPesoBruto, txtQuantidade, txtStatusProd, txtVao, txtVolumeProd, txtNomeProd, localizarCodigo, localizarFornecedor, localizarNome  };
            List<string> descList = new List<string>() { "Altura do produto", "Área", "Código de barras","Código","Comprimento","Corredor", "ID fornecedor","ID Endereço", "Largura", "Lote", "Módulo", "Nível", "Peso bruto", "Quantidade", "Status(Ativo/Inativo)", "Vão", "Volume", "Nome", "Código", "Fornecedor","Nome" };
            SetCueBanner(ref txtList, descList);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr i, string str);

        void SetCueBanner(ref List<TextBox> txts, List<string> description)
        {
            for (int i = 0; i < txts.Count; i++)
            {
                SendMessage(txts[i].Handle, 0x1501, (IntPtr)1, description[i]);
            }
        }

        private void pag1_Click(object sender, EventArgs e)
        {

        }

        private void pag2_Click(object sender, EventArgs e)
        {

        }

        private void InterfacePrincipal_Load(object sender, EventArgs e)
        {

        }

        private void botaoConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
