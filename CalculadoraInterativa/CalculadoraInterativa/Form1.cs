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
            expressao.Text = "";
        }
        Somatoria sm_obj = new Somatoria();
        Subtracao st_obj = new Subtracao();
        Dividindo dv_obj = new Dividindo();
        Multiplicando mt_obj = new Multiplicando();
        Modularizacao md_obj = new Modularizacao();
        Potenciacao pc_obj = new Potenciacao();
        Fatoracao fc_obj = new Fatoracao();

        int NumeroFatorial = 0;
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
                expressao.Text = "";
                Operador = "+";
                expressao.Text += R.Text + "+";
                PrimeiroNumero = double.Parse(R.Text, CultureInfo.InvariantCulture);
                R.Clear();
            }
        }
        private void Um_Click(object sender, EventArgs e)
        {
            R.Text += Um.Text;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (R.Text != "0" && R.Text != "")
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
                expressao.Text = "";
                Operador = "-";
                expressao.Text += R.Text + "-";
                PrimeiroNumero = double.Parse(R.Text, CultureInfo.InvariantCulture);
                R.Clear();
            }
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            if (R.Text != "")
            {
                expressao.Text = "";
                Operador = "x";
                expressao.Text += R.Text + "x";
                PrimeiroNumero = double.Parse(R.Text, CultureInfo.InvariantCulture);
                R.Clear();
            }
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            if (R.Text != "")
            {
                expressao.Text = "";
                Operador = "÷";
                expressao.Text += R.Text + "÷";
                PrimeiroNumero = double.Parse(R.Text, CultureInfo.InvariantCulture);
                R.Clear();
            }
        }

        private void ElevarAoQuadrado_Click(object sender, EventArgs e)
        {
            if (R.Text != "")
            {
                expressao.Text = "";
                Operador = "x²";
                expressao.Text += R.Text + "^";
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
                        expressao.Text += R.Text + "=";
                        sm = sm_obj.Somando(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = sm.ToString();
                        expressao.Text += R.Text;
                        break;

                    case "-":
                        expressao.Text += R.Text + "=";
                        st = st_obj.Sutraindo(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = st.ToString();
                        expressao.Text += R.Text;
                        break;

                    case "÷":
                        expressao.Text += R.Text + "=";
                        dv = dv_obj.Dividir(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = dv.ToString();
                        expressao.Text += R.Text;
                        break;
                    case "x":
                        expressao.Text += R.Text + "=";
                        mt = mt_obj.Multiplicar(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = mt.ToString();
                        expressao.Text += R.Text;
                        break;
                    case "%":
                        expressao.Text += R.Text + "=";
                        md = md_obj.Modulo(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = md.ToString();
                        expressao.Text += R.Text;
                        break;
                    case "x²":
                        expressao.Text += R.Text + "=";
                        pc = pc_obj.Potencia(PrimeiroNumero, SegundoNumero);
                        R.Clear();
                        R.Text = pc.ToString();
                        expressao.Text += R.Text;
                        break;
                }
            }
        }

        private void Modulo_Click(object sender, EventArgs e)
        {
            if (R.Text != "")
            {
                expressao.Text = "";
                Operador = "%";
                expressao.Text = "";
                expressao.Text += R.Text + "%";
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
        private void Fatorial_Click(object sender, EventArgs e)
        {
            expressao.Text = "";
            Operador = "n!";
            expressao.Text = R.Text + "!" + " =";
            NumeroFatorial = int.Parse(R.Text);
            if (NumeroFatorial >= 1)
            {
                int fc;
                fc = fc_obj.Fatorando(NumeroFatorial);
                R.Clear();
                R.Text = fc.ToString();
                expressao.Text += R.Text;
            }

        }
        int min = 1, max = 50, IAnum = 0;
        public void ArmazenarNumeroIA()
        {
            Random NumeroPensado = new Random();
            int IAnum = NumeroPensado.Next(min, max);
        }
        public void jogo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estou Pesando em um número,tente adivinhar qual é...","IA diz:",MessageBoxButtons.OK,MessageBoxIcon.Question);
            //MessageBox.Show("Dificuldade:Médio", "Nível do game");
            Random NumeroPensado = new Random();
            IAnum = NumeroPensado.Next(min, max);
            MessageBox.Show($"Estou Pesando em um número entre {min} e {max}\ntente adivinhar qual é...", "IA diz:");
            R.Clear();
            jogo.Enabled = false;
        }
        private void jogo_KeyDown(object sender, KeyEventArgs e)
        {
        }
        int tentativas = 1;

        private void SeparadorVirgula_Click(object sender, EventArgs e)
        {
            if (R.Text != "")
            {
                contador += 1;
                if (contador == 1)
                {
                    R.Text = R.Text + SeparadorVirgula.Text;
                }
                contador = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (R.Text != "")
            {
                int Jogadornum = int.Parse(R.Text);
                if (Jogadornum > max || Jogadornum < min)
                {
                    R.Clear();
                    MessageBox.Show($"Por favor,digite um número entre {min} e {max}");
                }
                else
                {
                    if (Jogadornum < IAnum)
                    {
                        MessageBox.Show("- Mais...", "IA DIZ");
                        R.Clear();
                        tentativas++;
                    }
                    else if (Jogadornum > IAnum)
                    {
                        MessageBox.Show("- Menos...", "IA DIZ");
                        R.Clear();
                        tentativas++;
                    }
                    else
                    {
                        MessageBox.Show("- Acertou!!!", "IA DIZ");
                        MessageBox.Show($"Tentativas: {tentativas}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        R.Clear();
                        tentativas = 1;
                        jogo.Enabled = true;
                    }
                }
            }
        }

        private void Conversor_Click(object sender, EventArgs e)
        {
            if (R.Text != "")
            {
                double ValorReal = 0.00, ValorDolar = 5.76, ValorTotal = 0.00;
                ValorReal = double.Parse(R.Text);
                ValorTotal = ValorReal * ValorDolar;
                R.Text = ValorTotal.ToString("c");
            }
        }
    }
}