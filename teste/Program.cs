using System;

namespace teste{
    class Program{
        static void Main(string[] args)
        {
            //Neste espaço chamo os métodos criados
            Console.WriteLine("[1]Calculo do fatorial\n[2]Calculo da constante de fatorial\n[3]Exercício de vetor Uri Judge\n[4]Sair");
            Console.Write("Sua Opção: ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    fatorial();
                    break;
                case 2:
                    constanteFatorialn();
                    break;
                case 3:
                    UriVetor1();
                    break;
                default:
                    Console.WriteLine("Saindo...");
                    break;
            }
        }
        static void UriVetor1()
        {
            int I,J,cont;

            for(J = 7,cont = 1,I = 1;cont <= 12;cont++)
            {
                if(cont <= 3)
                {
                    Console.WriteLine($"I={I} J={J}");
                    J--;
                }
                else if(cont > 3 && cont <= 6)
                {
                    if(cont == 4)
                        J += 3;
                    I = 3;
                    Console.WriteLine($"I={I} J={J}");
                    J--;
                }
                else if(cont > 6 && cont <= 9)
                {
                    if(cont == 7)
                        J += 3;
                    I = 6;
                    Console.WriteLine($"I={I} J={J}");
                    J--;
                }                
                else if(cont > 9 && cont <= 12)
                {
                    if(cont == 10)
                        J += 3;
                    I = 9;
                    Console.WriteLine($"I={I} J={J}");
                    J--;
                }
                
            }
        }

        static void fatorial()
        {
            int numero,numero_fatorial,i;
            Console.Write("Digite um número para calcular seu fatorial: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if(numero < 0)
            {
                Console.WriteLine("O número não pode ser negativo!\nDigite novamente: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            i = numero;
            numero_fatorial = numero;
            Console.Write($"O fatorial de {numero} é >> ");
            while(i != 1)
            {
                numero_fatorial = numero_fatorial*(i-1);
                if(i == numero)
                    Console.Write($"{i}");
                i--;
                Console.Write($"x{i}");
            }
            Console.Write($" = {numero_fatorial}");
        }

        static void constanteFatorialn()
        {
            int N,I;
            double E = 1.0 ,fatorialn = 1.0;

            E = Convert.ToDouble(E);
            fatorialn = Convert.ToDouble(fatorialn);

            Console.Write("Digite um número: ");
            N = Convert.ToInt32(Console.ReadLine());

            for(I =1; I <= N ; I++)
            {
                fatorialn *= I;
                E = E + (1.0/ fatorialn);
            }
                Console.WriteLine($"Segue abaixo o valor aproximado de E: ");
                Console.WriteLine($"E ~= {E:f3}");
        }
    }
}