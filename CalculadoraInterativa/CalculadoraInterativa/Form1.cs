using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalculadoraInterativa
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            R.Clear();
        }
        Somatoria sm_obj = new Somatoria();
        Subtracao st_obj = new Subtracao();
        Dividindo dv_obj = new Dividindo();
        Multiplicando mt_obj = new Multiplicando();
        Modularizacao md_obj = new Modularizacao();
        Potenciacao pc_obj = new Potenciacao();

        double SegundoNumero = 0;
        double PrimeiroNumero = 0;
        string Operador = "";

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Somar_Click(object sender, EventArgs e)
        {
            if (R.Text != "") 
            {
                Operador = "+";
                PrimeiroNumero = double.Parse(R.Text,CultureInfo.InvariantCulture);
                R.Clear();
            }
        }
        private void Um_Click(object sender, EventArgs e)
        {
                R.Text += Um.Text ;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (R.Text != "0,0" && R.Text != "")
            {
                R.Text += Zero.Text;
            }
        }

        private void Dois_Click(object sender, EventArgs e)
        {
                R.Text = R.Text + Dois.Text;
        }

        private void Tres_Click(object sender, EventArgs e)
        {
                R.Text = R.Text + Tres.Text;
        }

        private void Quatro_Click(object sender, EventArgs e)
        { 
                R.Text = R.Text + Quatro.Text;
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
                R.Text = R.Text + Cinco.Text;
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            R.Text = R.Text + Seis.Text;
        }

        private void Sete_Click(object sender, EventArgs e)
        {
                R.Text = R.Text + Sete.Text;
        }

        private void Oito_Click(object sender, EventArgs e)
        {
                R.Text = R.Text + Oito.Text;
        }

        private void Nove_Click(object sender, EventArgs e)
        {
               R.Text = R.Text + Nove.Text;
        }
        int contador = 0;
        private void Separador_Click(object sender, EventArgs e)
        {
            if (R.Text != "")
            {
                contador += 1;
                if (contador == 1)
                {
                    R.Text = R.Text + Separador.Text;
                }
                contador = 0;
            }
        }

        private void Subtrair_Click(object sender, EventArgs e)
        {
            if (R.Text != "") 
            {
                Operador = "-";
                PrimeiroNumero = double.Parse(R.Text,CultureInfo.InvariantCulture);
                R.Clear();
            }
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            if (R.Text != "")
            {
                Operador = "x";
                PrimeiroNumero = double.Parse(R.Text, CultureInfo.InvariantCulture);
                R.Clear();
            }
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            if (R.Text != "") 
            {
                Operador = "÷";
                PrimeiroNumero = double.Parse(R.Text, CultureInfo.InvariantCulture);
                R.Clear();
            }
        }

        private void ElevarAoQuadrado_Click(object sender, EventArgs e)
        {
            if (R.Text != "") 
            {
                Operador = "x²";
                PrimeiroNumero = double.Parse(R.Text, CultureInfo.InvariantCulture);
                R.Clear();
            }
        }

        private void VerificaResultado_Click(object sender, EventArgs e)
        {
            if (R.Text != "") 
            {
                SegundoNumero = double.Parse(R.Text, CultureInfo.InvariantCulture);
                //soma e subtração
                double sm;
                double st;
                double dv;
                double mt;
                double md;
                double pc;

                switch (Operador)
                {
                    case "+":
                        sm = sm_obj.Somando(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = sm.ToString();
                        break;

                    case "-":
                        st = st_obj.Sutraindo(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = st.ToString();
                        break;

                    case "÷":
                        dv = dv_obj.Dividir(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = dv.ToString();
                        break;
                    case "x":
                        mt = mt_obj.Multiplicar(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = mt.ToString();
                        break;
                    case "%":
                        md = md_obj.Modulo(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = md.ToString();
                        break;
                    case "x²":
                        pc = pc_obj.Potencia(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = pc.ToString();
                        break;
                }
            }
        }

        private void Modulo_Click(object sender, EventArgs e)
        {
            if(R.Text != "")
            {
                Operador = "%";
                PrimeiroNumero = double.Parse(R.Text, CultureInfo.InvariantCulture);
                R.Clear();
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            R.Clear();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
