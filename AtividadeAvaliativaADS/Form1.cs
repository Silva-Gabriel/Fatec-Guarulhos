using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaADS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> Vezes = new List<double>();
            List<double> ValorUnitario = new List<double>() { 0.5,0.75, 40, 3, 0.05, 1, 0.02 };
            List<double> QuantidadeUtilizada = new List<double>() { 135000, 10000, 75, 500, 20000, 450, 18000 };
            double[] vezes = new double[7];

            double acumulador = 0.00, giroEstoque = 0.00, Cobertura = 0.0;

            int retornaVezes = 7;

            for(int i = 0; i < retornaVezes;i++) 
            {
                vezes[i] = ValorUnitario[i] * QuantidadeUtilizada[i];
                Vezes.Add(vezes[i]);
            }
            acumulador = Vezes.Sum();
            giroEstoque = acumulador / 3900;
            Cobertura = 365 / giroEstoque;

            txtCobertura.Text = Cobertura.ToString("C");
            txtGiroEstoque.Text = giroEstoque.ToString("C");


            /*for (int i = 0; i < 7; i++)
            {

                vezes[i] = valorU[i] * qtd[i];
                acumulador += vezes[i];
            }
            giroEstoque = acumulador / 3900;
            Cobertura = 365 / giroEstoque;

            txtCobertura.Text = Cobertura.ToString("C");
            txtGiroEstoque.Text = giroEstoque.ToString("C");*/
        }

        private void Clear_Click(object sender, EventArgs e)
        {
        }
    }
}
