using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste2
{
    static class Program
    {
        static void Main()
        {
            DialogResult resultado = MessageBox.Show("Confirmação","Deseja sair do programa?",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.Yes)
            {
                Console.WriteLine("QUERO SAIR");
                throw new ArgumentOutOfRangeException();
            }
            else if(resultado == DialogResult.No)
                Console.WriteLine("NÃO QUERO SAIR");
            else
                Console.WriteLine("CANCELA");
            Console.ReadLine();

        }
    }
}
