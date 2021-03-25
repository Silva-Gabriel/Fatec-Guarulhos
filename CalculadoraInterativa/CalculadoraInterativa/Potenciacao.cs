using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraInterativa
{
    class Potenciacao
    {
        public double Potencia(double a, double b) 
        {
            double elevado;
            elevado = Math.Pow(a, b);
            return elevado;
        }
    }
}
