using System;

namespace Equação_Grau_2
{
    class EquacaoGrau2
    {
        static void Main(string[] args)
        {
            double a,b,c,delta,x1,x2;

            Console.Write("Digite o coeficiente A: ");
            a = Int32.Parse(Console.ReadLine());
            while(a == 0)
            {
                Console.Write("Coeficiente A não pode ser igual a 0 insira outro valor: ");
                a = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nDigite o coeficiente B: ");
            b = Int32.Parse(Console.ReadLine());

            Console.Write("\nDigite o coeficiente C: ");
            c = Int32.Parse(Console.ReadLine());

            delta = Math.Sqrt(Math.Pow(b,2)-4*a*c);
            x1 = (-(b)+delta)/2*a;
            x2 = (-(b)-delta)/2*a;
            
            Console.WriteLine($"As raízes da equação são x1 = {x1} e x2 = {x2}");
        }
    }
}
