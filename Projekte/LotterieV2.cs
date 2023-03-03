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
            
            const int gewinn_0 = 3;
            const int gewinn1 = 2;
            const int gewinn2 = 1;
            const int gewinn5 = 1;
            const int gewinn8 = 2;
            const int gewinn10 = 3;
            int wert_zufallszahl;
            int Gewinn = 0;
            int Guthaben = 15000;


        A:
            int Einsatz = 0;

            //Hintergrund und Farbe ändern
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //Kopf des Glückrads
            Console.WriteLine("========================================");
            Console.WriteLine("           G L Ü C K S R A D");
            Console.WriteLine("========================================\n");
            Console.WriteLine("GEWINNSUMMEN\n");
            Console.WriteLine("   -3000€         -700€           1500€");
            Console.WriteLine("   -1000€          700€           2000€\n");
            Console.WriteLine("========================================\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Guthaben {Guthaben}€\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Ihr Einsatz 0-10000€: \n\n");
            int.TryParse(Console.ReadLine(), out Einsatz);
            if (Einsatz < 500 || Einsatz > 10000 || Guthaben <= 0 || Einsatz > Guthaben)

            {
                Console.WriteLine("Bitte richtigen Einsatz eingeben\b\n ");
                Console.ReadLine();

                goto A;
            }
            // erstellen einer ZUfallszahl
            Random zufahlszahl = new Random();
            //Zufallszahl von 0 bis 51
            wert_zufallszahl = zufahlszahl.Next(1, 51);

            //switch start
            switch (wert_zufallszahl)
            {
                case 3:
                case 9:
                case 11:
                case 20:
                case 23:
                case 10:
                case 25:
                case 26:
                case 32:
                case 33:
                case 36:
                case 40:
                case 44:
                case 45:
                case 50:
                    Gewinn = Einsatz/gewinn_0;
                    break;
                case 5:
                case 7:
                case 15:
                case 16:
                case 21:
                case 27:
                case 34:
                case 37:
                case 39:
                case 42:
                case 46:
                case 49:
                    Gewinn = Einsatz/ gewinn1;
                    break;
                case 2:
                case 6:
                case 12:
                case 19:
                case 22:
                case 28:
                case 35:
                case 38:
                case 43:
                case 47:
                case 48:
                    Gewinn = Einsatz/gewinn2;
                    break;
                case 1:
                case 4:
                case 8:
                case 13:
                case 29:
                case 41:
                    Gewinn = Einsatz*gewinn5;
                    break;
                case 14:
                case 18:
                case 24:
                case 30:
                    Gewinn = Einsatz *  gewinn8;
                    break;
                case 17:
                case 31:
                    Gewinn = Einsatz *  gewinn10;
                    break;
                default:
                    break;
            }
            // ende Case anweisung


            if (Gewinn >= 0)
            {
                Guthaben = Guthaben + Gewinn;
                Console.Write("\a");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Guthaben = (Guthaben + Gewinn) - Einsatz;
            }
            Console.WriteLine("========================================\n");
            Console.WriteLine($"Ihre Glückszahl {wert_zufallszahl}\n");
            Console.WriteLine("========================================\n");
            Console.WriteLine($"Ihre Gewinnsumme {Gewinn} €\n");
            Console.WriteLine($"Ihre Guthaben {Guthaben} €\n");
            Console.WriteLine("========================================\n");
            if (Guthaben >= 0)
            {
                Console.WriteLine("Beenden mit Q");
                ConsoleKeyInfo name = Console.ReadKey();
                
                if (name.KeyChar != 113)
                {
                    goto A;
                }

            }

            else if (Guthaben <= 0)
             
            // Pleite
            Console.WriteLine("DU BIST PLEITE!!!!!\a\a\a\a\a\a\a\a\a\a");
            DateTime dtStart = DateTime.Now;
            while (1 == 1)
            {
                    TimeSpan dtDiff = DateTime.Now - dtStart;
                    if (dtDiff.Seconds > 5) break;
                    Task.Delay(1); //does not work 
            }
            



        }
    }
}
