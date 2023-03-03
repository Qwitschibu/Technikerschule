using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._12._2022_Lotterie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            

            //Variablen
            const int gewinn_0 = 0;
            const int gewinn1 = 1000;
            const int gewinn2 = 2000;
            const int gewinn5 = 5000;
            const int gewinn8 = 8000;
            const int gewinn10 = 10000;
            int wert_zufallszahl;
            int Gewinn = 0;
            //Hintergrund und Farbe ändern
            

        A:
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.Clear();
            //Kopf des Glückrads
            Console.WriteLine("========================================");
            Console.WriteLine("           G L Ü C K S R A D");
            Console.WriteLine("========================================\n" );
            Console.WriteLine("GEWINNSUMMEN\n");
            Console.WriteLine("      0€          1000€           2000€");
            Console.WriteLine("   5000€          8000€          10000€\n");
            Console.WriteLine("========================================\n");
            Console.WriteLine("STARTEN MIT ENTER");
            Console.ReadLine();

            // erstellen einer ZUfallszahl
            Random zufahlszahl = new Random();
            //Zufallszahl von 0 bis 24
            wert_zufallszahl = zufahlszahl.Next(1,25);

            //switch start
            switch (wert_zufallszahl)
            {
                case 3:
                case 9:
                case 11:
                case 20:
                case 23:
                case 10:
                    Gewinn=gewinn_0;
                    break;
                case 5:
                case 7:
                case 15:
                case 16:
                case 21:
                    Gewinn=gewinn1;
                    break;
                case 2:
                case 6:
                case 12:
                case 19:
                case 22:
                    Gewinn=gewinn2;
                    break;
                case 1:
                case 4:
                case 8:
                case 13:
                    Gewinn=gewinn5;
                    break;
                case 14:
                case 18:
                case 24:
                    Gewinn=gewinn8;
                    break;
                case 17:
                    Gewinn=gewinn10;
                    break;
                default:
                    break;
            }
            // ende Case anweisung

            Console.WriteLine("========================================\n");
            Console.WriteLine($"Ihre Glückszahl {wert_zufallszahl}\n");
            Console.WriteLine("========================================\n");
            Console.WriteLine($"Ihre Gewinnsumme {Gewinn}\n");
            Console.WriteLine("========================================\n");
            Console.WriteLine("Nochmal Spielen mit Y");
            ConsoleKeyInfo name = Console.ReadKey();
            
            if (name.KeyChar == 121) 
            {
                goto A;
            }
            
           
            
            
        }
    }
}
