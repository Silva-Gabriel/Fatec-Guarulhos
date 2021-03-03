using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contas = new string[4]{"12345678910","448787646452",
            "59274521721","268729521"};

            Random numeroAleatorio = new Random();
            int numeroDaConta = numeroAleatorio.Next(contas.Length);
            string index = contas[numeroDaConta];
            Console.WriteLine(numeroDaConta);
            Console.Write(index);
        }
    }
}
