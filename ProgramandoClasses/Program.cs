using System;

namespace ProgramandoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public Carro(int potencia, int velocidade,string marca,string modelo,int ano)
        {
            this.potencia = potencia;
            this.velocidade = velocidade;
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

          public void acelerar()
        {
            velocidade +=10;
        }

         private void parar()
        {
            velocidade = 0;
        }

         public void frear()
        {
            reduzir();
            parar();
        }
    }
}
