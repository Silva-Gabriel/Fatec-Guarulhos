using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraInterativa
{
    class Fatoracao
    {
        public int Fatorando(int n) 
        {
            int fator = 1;
            for (int i = n; i > 1 ; i--) 
            {
                fator *= i;
            }
            n = fator;
            return n;
        }
    }
}
