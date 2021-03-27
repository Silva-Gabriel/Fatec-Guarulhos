using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraInterativa
{
    class JogoAdivinha
    {
        public int NumeroIA(int[] a) 
        {
            Random NumeroPensado = new Random();
            a = new int[8];
            for (int i = 0; i < 8; i++)
            {
                a[i] = NumeroPensado.Next(1, 25);
            }
            return a[0];
        }
    }
}
