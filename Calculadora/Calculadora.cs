using System;

namespace TestCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os números a serem calculados:");
            Console.Write("Digite o primeiro número: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = Int32.Parse(Console.ReadLine());
            int soma = a+b;
            int divisao = a/b;
            int subtracao = a-b;
            int modulo = a%b;
            Console.WriteLine("Digite:\n[1]Soma\n[2]Subtração\n[3]Divisão\n[4]Modulazização");
            Console.Write("Sua escolha: ");
            int escolha = Int32.Parse(Console.ReadLine());
            switch(escolha)
            {
                case 1:
                    Console.WriteLine($"{a}+{b} = {soma}");
                    break;
                case 2:
                    Console.WriteLine($"{a}-{b} = {subtracao}");
                    break;
                case 3:
                    Console.WriteLine($"{a}/{b} = {divisao}");
                    break;
                case 4:
                    Console.WriteLine($"{a}%{b} = {modulo}");
                    break;   
            }
            Console.ReadLine();

        }
    }
}
