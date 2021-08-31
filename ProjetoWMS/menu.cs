using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace FAWS_WMS
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login frm = new login();
            this.Close();
            frm.Show();
        }
        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para informações e suporte do sistema, entre em contato através de um dos e-mails abaixo:\n\n" +
                "Cássia Yaisa e Lucas Bezerra - Responsáveis pelo módulo de Produtos.\n(cassia.souza2@fatec.sp.gov.br)\n(lucas.silva776@fatec.sp.gov.br)\n\n" +
                "Danielle de Oliveira - Responsável pelo módulo de Expedição.\n(danielle.cabral@fatec.sp.gov.br)\n\n" +
                "Gabriel Soares - Responsável pelo módulo de Armazém.\n(gabriel.gomes13@fatec.sp.gov.br)\n\n" +
                "Lucas Aparecido - Responsável pelo módulo de Recebimento.\n(lucas.marcuzo@fatec.sp.gov.br)\n\n" +
                "Netivan Florentino - Responsável pelo módulo de Clientes e Fornecedores.\n(netivan.rocha@fatec.sp.gov.br)", "FAWS WMS - Suporte");
        }
        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resposta = MessageBox.Show("Tem certeza que deseja sair?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == resposta)
            {
                e.Cancel = true;
                return;
            }
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            string cf = Application.StartupPath + @"\baseCF.exe";
            Process.Start(cf);
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            string pdt = Application.StartupPath + @"\interface-wms-prod.exe";
            Process.Start(pdt);
        }
        private void btnRecebimento_Click(object sender, EventArgs e)
        {
            string rcb = Application.StartupPath + @"\interface-wms";
            Process.Start(rcb);
        }

        private void btnArmazem_Click(object sender, EventArgs e)
        {
            string amz = Application.StartupPath + @"\interfaceWMS_Armazem.exe";
            Process.Start(amz);
        }
        private void btnExpedicao_Click(object sender, EventArgs e)
        {
            string expd = Application.StartupPath + @"\interface-wms-exped.exe";
            Process.Start(expd);
        }
    }
}
