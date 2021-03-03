using System;

namespace Equação_Grau_2
{
    class EquacaoGrau2
    {
        static void Main(string[] args)
        {
            double a,b,c,delta,x1,x2,controladora,verticeX,verticeY;

            for(controladora = 0;controladora < 8;controladora++)
            {
                Console.Write($"{controladora}º: Digite o coeficiente A: ");
                a = Double.Parse(Console.ReadLine());
                while(a == 0)
                {
                    Console.Write("Coeficiente A não pode ser igual a 0 insira outro valor: ");
                    a = Double.Parse(Console.ReadLine());
                }

                Console.Write($"\n {controladora}º: Digite o coeficiente B: ");
                b = Double.Parse(Console.ReadLine());

                Console.Write($"\n {controladora}º: Digite o coeficiente C: ");
                c = Double.Parse(Console.ReadLine());

                delta = Math.Sqrt(Math.Pow(b,2)-4*a*c);
                x1 = (-(b)+delta)/2.0*a;
                x2 = (-(b)-delta)/2.0*a;
            
                Console.WriteLine($"{controladora}: As raízes da equação são x1 = {x1} e x2 = {x2}");
                verticeX = -(b/2.0*a);
                verticeY = -(delta/4.0*a);
                Console.WriteLine($"{controladora}º: Vértice de X = {verticeX}\nVértice de Y = {verticeY}");
                Console.ReadLine();
            }

        }
    }
}
