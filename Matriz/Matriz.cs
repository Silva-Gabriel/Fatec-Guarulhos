using System;

namespace teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0,j = 0;

            int[,] matriz = new int[3,3];

            for(i = 0;i < 3;i++)
            for(j = 0; j < 3;j++)
            {
                Console.Write($"Linha {i+1} Coluna {j}: ");
                matriz[i,j] = Convert.ToInt32(Console.ReadLine());
            }
          for(i = 0;i < 3;i++)
            for(j = 0; j < 3;j++)
            {
                if(i == 0)
                {
                    Console.Write($"{matriz[i,j]}\t");
                    if(j == 2)
                        Console.WriteLine("");
                }
                if(i == 1)
                {
                    Console.Write($"{matriz[i,j]}\t");
                    if(j == 2)
                        Console.WriteLine("");
                }
                if(i == 2)
                {
                    Console.Write($"{matriz[i,j]}\t");
                    if(j == 2)
                        Console.WriteLine("");
                }
            }

        }
    }
}
