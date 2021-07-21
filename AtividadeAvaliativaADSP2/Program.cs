using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativaADSP2
{
    static class Program
    {
        static void Main(string[] args)
        {
            double salario,totalReajuste = 0.00;

            Console.Write("Digite o seu salario: ");
            salario = double.Parse(Console.ReadLine());
            while(salario < 1100.00)
            {
                MessageBox.Show("Salario inferior a R$1100,00 não permitido","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Console.Write("Digite o seu salario novamente: ");
                salario = double.Parse(Console.ReadLine()); 
            }
            if(salario >= 1100.00)
            {
                if(salario <= 1999.99)
                {
                    totalReajuste = salario+(salario*0.10);
                }
                else if(salario <= 2999.99)
                {
                    totalReajuste = salario+(salario*0.12);
                }
                    
                else if(salario <= 3999.99)
                {
                    totalReajuste = salario+(salario*0.14);
                }
                    
                else
                {
                    totalReajuste = salario+(salario*0.16);
                }
               MessageBox.Show($"seu novo salário é R${totalReajuste}","Parabéns!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }  
        }
    }
}
