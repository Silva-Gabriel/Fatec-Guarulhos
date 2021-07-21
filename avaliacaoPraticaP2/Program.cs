using System;
using System.Collections.Generic;

namespace avaliacaoPraticaP2
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<string> ingredientes = new List<string>(){"Pão com gergilim","Alface americana","Tomate","Queijo cheddar","Hamburguer","Nuggets"};   
            float[,] valores = new float[6,3];
                for(int i = 0; i < 6;i++)
                {
                    if(i == 0)
                    {
                        Console.Write($"Por favor insira a quantidade em estoque do ingrediente informado:\n {ingredientes[0]}: ");
                        valores[0,0] = float.Parse(Console.ReadLine());

                        Console.Write($"Por favor insira a quantidade mínima do ingrediente informado:\n {ingredientes[0]}: ");
                        valores[0,1] = float.Parse(Console.ReadLine());
                        // A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.
                        while(Convert.ToInt32(valores[0,1]) < Convert.ToInt32(valores[0,2]))
                        {
                            Console.WriteLine("A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.");
                            Console.Write($"Por favor insira novamente a quantidade mínima do ingrediente informado:\n {ingredientes[0]}: ");
                            valores[0,1] = float.Parse(Console.ReadLine());
                        }

                        Console.Write($"Por favor insira a valor unitário do ingrediente informado:\n {ingredientes[0]}: ");
                        valores[0,2] = float.Parse(Console.ReadLine());
                    }
                    else if(i == 1)
                    {
                        Console.Write($"Por favor insira a quantidade em estoque do ingrediente informado:\n {ingredientes[1]}: ");
                        valores[1,0] = float.Parse(Console.ReadLine());

                        Console.Write($"Por favor insira a quantidade mínima do ingrediente informado:\n {ingredientes[1]}: ");
                        valores[1,1] = float.Parse(Console.ReadLine());
                        // A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.
                        while(Convert.ToInt32(valores[1,1]) < Convert.ToInt32(valores[1,2]))
                        {
                            Console.WriteLine("A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.");
                            Console.Write($"Por favor insira novamente a quantidade mínima do ingrediente informado:\n {ingredientes[1]}: ");
                            valores[1,1] = float.Parse(Console.ReadLine());
                        }

                        Console.Write($"Por favor insira a valor unitário do ingrediente informado:\n {ingredientes[1]}: ");
                        valores[1,2] = float.Parse(Console.ReadLine());
                    }
                    else if(i == 2)
                    {
                        Console.Write($"Por favor insira a quantidade em estoque do ingrediente informado:\n {ingredientes[2]}: ");
                        valores[2,0] = float.Parse(Console.ReadLine());

                        Console.Write($"Por favor insira a quantidade mínima do ingrediente informado:\n {ingredientes[2]}: ");
                        valores[2,1] = float.Parse(Console.ReadLine());
                        // A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.
                        while(Convert.ToInt32(valores[2,1]) < Convert.ToInt32(valores[2,2]))
                        {
                            Console.WriteLine("A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.");
                            Console.Write($"Por favor insira novamente a quantidade mínima do ingrediente informado:\n {ingredientes[2]}: ");
                            valores[2,1] = float.Parse(Console.ReadLine());
                        }

                        Console.Write($"Por favor insira a valor unitário do ingrediente informado:\n {ingredientes[2]}: ");
                        valores[2,2] = float.Parse(Console.ReadLine());
                    }
                    else if(i == 3)
                    {
                        Console.Write($"Por favor insira a quantidade em estoque do ingrediente informado:\n {ingredientes[3]}: ");
                        valores[3,0] = float.Parse(Console.ReadLine());

                        Console.Write($"Por favor insira a quantidade mínima do ingrediente informado:\n {ingredientes[3]}: ");
                        valores[3,1] = float.Parse(Console.ReadLine());
                        // A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.
                        while(Convert.ToInt32(valores[3,1]) < Convert.ToInt32(valores[3,2]))
                        {
                            Console.WriteLine("A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.");
                            Console.Write($"Por favor insira novamente a quantidade mínima do ingrediente informado:\n {ingredientes[3]}: ");
                            valores[3,1] = float.Parse(Console.ReadLine());
                        }

                        Console.Write($"Por favor insira a valor unitário do ingrediente informado:\n {ingredientes[3]}: ");
                        valores[3,2] = float.Parse(Console.ReadLine());
                    }
                    else if(i == 4)
                    {
                        Console.Write($"Por favor insira a quantidade em estoque do ingrediente informado:\n {ingredientes[4]}: ");
                        valores[4,0] = float.Parse(Console.ReadLine());

                        Console.Write($"Por favor insira a quantidade mínima do ingrediente informado:\n {ingredientes[4]}: ");
                        valores[4,1] = float.Parse(Console.ReadLine());
                        // A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.
                        while(Convert.ToInt32(valores[4,1]) < Convert.ToInt32(valores[4,2]))
                        {
                            Console.WriteLine("A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.");
                            Console.Write($"Por favor insira novamente a quantidade mínima do ingrediente informado:\n {ingredientes[4]}: ");
                            valores[4,1] = float.Parse(Console.ReadLine());
                        }

                        Console.Write($"Por favor insira a valor unitário do ingrediente informado:\n {ingredientes[4]}: ");
                        valores[4,2] = float.Parse(Console.ReadLine());
                    }
                    else if(i == 5)
                    {
                        Console.Write($"Por favor insira a quantidade em estoque do ingrediente informado:\n {ingredientes[5]}: ");
                        valores[5,0] = float.Parse(Console.ReadLine());

                        Console.Write($"Por favor insira a quantidade mínima do ingrediente informado:\n {ingredientes[5]}: ");
                        valores[5,1] = float.Parse(Console.ReadLine());
                        // A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.
                        while(Convert.ToInt32(valores[5,1]) < Convert.ToInt32(valores[5,2]))
                        {
                            Console.WriteLine("A quantidade em estoque não poderá ser inferior a quantidade mínima exigida.");
                            Console.Write($"Por favor insira novamente a quantidade mínima do ingrediente informado:\n {ingredientes[5]}: ");
                            valores[5,1] = float.Parse(Console.ReadLine());
                        }

                        Console.Write($"Por favor insira a valor unitário do ingrediente informado:\n {ingredientes[5]}: ");
                        valores[5,2] = float.Parse(Console.ReadLine());

                    }   
                }   

                //"Pão com gergilim","Alface americana","Tomate","Queijo cheddar","Hamburguer","Nuggets"
                for(int k = 0; k < 6;k++)
                    for(int l = 0;l < 3;l++)
                    {
                        if(k == 0)
                        {
                            if(l == 0)
                            {
                                Console.WriteLine("\n\nPão com Gergilim");
                                Console.Write("Quantidade em estoque: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 1)
                            {
                                Console.Write("Quantidade mínima: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 2)
                            {
                                Console.Write("Valor unitário: ");
                                Console.WriteLine($"R${valores[k,l]} ");
                            }
                    
                        }
                        else if(k == 1)
                        {
                            if(l == 0)
                            {
                                Console.WriteLine("\n\nAlface americana");
                                Console.Write("Quantidade em estoque: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 1)
                            {
                                Console.Write("Quantidade mínima: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 2)
                            {
                                Console.Write("Valor unitário: ");
                                Console.WriteLine($"R${valores[k,l]} ");
                            }
                        }
                        else if(k == 2)
                        {
                           if(l == 0)
                            {
                                Console.WriteLine("\n\nTomate");
                                Console.Write("Quantidade em estoque: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 1)
                            {
                                Console.Write("Quantidade mínima: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 2)
                            {
                                Console.Write("Valor unitário: ");
                                Console.WriteLine($"R${valores[k,l]} ");
                            }
                        }
                        else if(k == 3)
                        {
                            if(l == 0)
                            {
                                Console.WriteLine("\n\nQueijo cheddar");
                                Console.Write("Quantidade em estoque: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 1)
                            {
                                Console.Write("Quantidade mínima: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 2)
                            {
                                Console.Write("Valor unitário: ");
                                Console.WriteLine($"R${valores[k,l]} ");
                            }
                        }
                        else if(k == 4)
                        {
                            if(l == 0)
                            {
                                Console.WriteLine("\n\nHamburguer");
                                Console.Write("Quantidade em estoque: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 1)
                            {
                                Console.Write("Quantidade mínima: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 2)
                            {
                                Console.Write("Valor unitário: ");
                                Console.WriteLine($"R${valores[k,l]} ");
                            }
                        }
                        else if(k == 5)
                        {
                            if(l == 0)
                            {
                                Console.WriteLine("\n\nNuggets");
                                Console.Write("Quantidade em estoque: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 1)
                            {
                                Console.Write("Quantidade mínima: ");
                                Console.WriteLine($"{valores[k,l]} ");
                            }
                            else if(l == 2)
                            {
                                Console.Write("Valor unitário: ");
                                Console.WriteLine($"R${valores[k,l]} ");
                            }
                        }
                    } 
                    Console.WriteLine("Pressione qualquer tecla para sair:");
                    string sair = Console.ReadLine();
        }
    }
}
