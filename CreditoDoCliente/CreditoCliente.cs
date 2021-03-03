using System;

namespace CreditoDoCliente
{
    class CreditoCliente
    {
        static void Main(string[] args)
        {
            int codigo,i;
            string senhaPassada = "",senha,numeroDaConta = "";
            double saldo = 0,TotalDeCreditos = 0,TotalDeItensCobrados = 0,LimitePermitido = 0;
            string[] contas = new string[4]{"12345678910","48787646452",
            "59274521721","268729521"};

            Console.Write("Digite o código da sua conta: ");
            codigo = Int32.Parse(Console.ReadLine());
            if(codigo == 0)
            {
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();
                senhaPassada = senha;
                if(senhaPassada != "123456")
                {
                    for(i = 0;senhaPassada != "123456";i++)
                    {
                        Console.Write("Senha incorreta\nInforme a senha novamente: ");
                        senhaPassada = Console.ReadLine();
                        if(i > 2)
                            Environment.Exit(0);
                    }
                }
            }
            if(codigo == 1)
            {
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();
                senhaPassada = senha;
                if(senha != "987654")
                {
                    for(i = 0 ;senhaPassada != "987654";i++)
                    {
                        Console.Write("Senha incorreta\nInforme a senha novamente: ");
                        senhaPassada = Console.ReadLine();
                            if(i > 2)
                                Environment.Exit(0);
                    }
                }
            }
            if(codigo == 2)
            {
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();
                if(senha != "0147852")
                {
                    for(i = 0;senhaPassada != "0147852";i++)
                    {
                        Console.Write("Senha incorreta\nInforme a senha novamente: ");
                        senhaPassada = Console.ReadLine();
                        if(i > 2)
                            Environment.Exit(0);
                    }
                }
            }
            if(codigo == 3)
            {
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();
                if(senha != "111222")
                {
                    for(i = 0;senhaPassada != "111222";i++)
                    {
                        Console.Write("Senha incorreta\nInforme a senha novamente: ");
                        senhaPassada = Console.ReadLine();
                        if(i > 2)
                            Environment.Exit(0);
                    }
                }
            }
            if(codigo == 0)
                numeroDaConta = "0";
            else if(codigo == 1)
                numeroDaConta = "1";
            else if(codigo == 2)
                numeroDaConta = "2";
            else if(codigo == 3)
                numeroDaConta = "3";
            else{
                Environment.Exit(0);
            }

            //Início
            if(numeroDaConta == "0")
            {
                saldo = 1000.00;
                TotalDeItensCobrados = 1230.90;
                TotalDeCreditos = saldo-TotalDeItensCobrados;
                
            }
            else if(numeroDaConta == "1")
            {
                saldo = 1400.00;
                TotalDeItensCobrados = 1547.60;
                TotalDeCreditos = saldo-TotalDeItensCobrados;
                
            }
            else if(numeroDaConta == "2")
            {
                saldo = 2150.00;
                TotalDeItensCobrados = 2200.00;
                TotalDeCreditos = saldo-TotalDeItensCobrados;
                
            }
            else if(numeroDaConta == "3")
            {
                saldo = 6420.00;
                TotalDeItensCobrados = 4900.70;
                TotalDeCreditos = saldo-TotalDeItensCobrados;
            }
            //Fim

            //Início
            if(saldo < 1000.00)
            {
                LimitePermitido = 200.00; 
            }
            else if(saldo >=1000.00 && saldo < 1500.00)
            {
                LimitePermitido = 300.00;
            }
            else if(saldo >= 1500.00 && saldo < 2000.00)
            {
                LimitePermitido = 500.00;
            }
            else{
                LimitePermitido = 800.00;
            }
            //Fim

            Console.WriteLine("[1]Ver o número da conta\n[2]VerSaldo do início do mês\n[3]Ver Total de itens cobrados no mês\n[4]Ver o total de créditos aplicados na conta no mês\n[5]Ver limite de crédito permitido\n[6]Sair do programa\n");

            Console.Write("Digite sua escolha: ");
            int escolha = Int32.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine($"\nNúmero da conta: {contas[codigo]}");
                    break;
                case 2:
                    Console.WriteLine($"\nSaldo no mês: R${saldo:N}");
                    break;
                case 3:
                    Console.WriteLine($"\nTotal de itens cobrados: R${TotalDeItensCobrados:N}");
                    break;
                case 4:
                    Console.WriteLine($"\nCréditos utilizados: R${TotalDeCreditos:N}");
                    break;
                case 5:
                    Console.WriteLine($"\nLimite de crédito permitido: R${LimitePermitido:N}");
                    break;
                case 6:
                    break;
                default:
                    break;
            }
            double Credito = (saldo+LimitePermitido)-TotalDeItensCobrados;
            if(Credito < 0)
            {
                Console.WriteLine($"\nVocê excedeu seu limite de crédito!\nCrédito total: R${Credito:N}");
            }
            else if(Credito >= 0)
            {
                Console.WriteLine($"\nCrédito total: R${Credito:N}\n");
            }
            Console.ReadKey();
        }  
    }
}
