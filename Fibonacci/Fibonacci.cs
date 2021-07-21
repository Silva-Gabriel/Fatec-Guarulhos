using System;
namespace FIBONACCI
{
    class FIBONACCI
    {
        static void Main(string[] args)
        {
            int contador,num_atual,num_prox,num_ant,quantidade;
            
            num_atual = 1;
            num_ant = 0;
            num_prox = 0;

            Console.Write("Digite a quantidade de termos da sequência: ");
            quantidade = Int32.Parse(Console.ReadLine());
            
            for(contador = 1;contador <= quantidade;contador++)
            {
                num_ant = num_prox;        //O número anterior passa a ser o próximo número,No caso quando for reiniciar o looping isso fará mais sentido
                num_prox = num_ant+num_atual;   //A soma dos dois anteriores é o resultado do próximo número
                num_atual = num_ant;        //O número atual passa a ser o número anterior
                Console.Write($" {num_atual}");
            }

        }
    }
}