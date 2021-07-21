using System;

namespace ListaDeSeries
{
    class ListandoSeries
    {
        static void Main(string[] args)
        {
        string[] Series = new string[8]
        {"FRIENDS","The Flash","Supergirl","Ginny and Georgia",
        "WandaVision","Punho de Ferro","Luke Cage","The Boys"
        };
        for(int i = 0;i < 8;i++)
        {
            Console.WriteLine($"Índice:{i}-{Series[i]}");
        }

        }
    }
}
