using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjetoWMS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            ColorDialog cores = new ColorDialog();

            List<TextBox> txtList = new List<TextBox>() { txtCredencial, txtSenha };
            List<string> descList = new List<string>() { "Credencial", "Senha" };
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

        private void aoClicar(object sender, EventArgs e)
        {
            InterfacePrincipal abrirInterfacePrincipal = new InterfacePrincipal();
            abrirInterfacePrincipal.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }
        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);

            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(0, 255, 0, 0), Color.FromArgb(255, 0, 0, 0), 90F);

            graphics.FillRectangle(br,gradient_rect);
        }

        private void FormLogin_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
