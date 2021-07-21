using System;
namespace teste
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;

        public void mensagem(string nome,string sobrenome,int idade)
        {
            Console.WriteLine($"Olá {nome} {sobrenome},você tem {idade} anos,correto?");
        }

        public void Pessoas()
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Gabriel";
            pessoa1.sobrenome = "Santana";
            pessoa1.idade = 20;
            pessoa1.mensagem(pessoa1.nome,pessoa1.sobrenome,pessoa1.idade);
        }
    }
}