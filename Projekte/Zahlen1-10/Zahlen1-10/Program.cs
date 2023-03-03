using System;

namespace Zahlen1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i < 11; i++)
            {



                if (i > 9)
                {
                    Console.WriteLine(i + "");

                }
                else
                {
                    Console.Write(i + ",");
                }
            }
            */
           
            //Aufgabe 2 neu
            for (int i = 1; i < 20; i++)
            {
                if (i >= 10)
                {
                    Console.Write((20 - i) + ",");

                }
                else
                    Console.Write(i + ",");
            }


            // Aufgabe 3

            // Start Schleife 
            string eingabe; 
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("Menüüunkt 01 (1)");
                Console.WriteLine("Menüpunkt 02 (2)");
                Console.WriteLine("Menüpunkt 03 (3)");
                Console.WriteLine("Ende (e) ");
                Console.Write("Eingabe: ");
                eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "1":
                        Console.WriteLine("Menüpunkt 01 gewählt");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Menüpunkt 02 gewählt");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Menüpunkt 03 gewählt");
                        Console.ReadLine();
                        break;
                    case "e":
                    case "E":
                        break;
                    default:
                        Console.WriteLine("andere Auswahl");
                        Console.ReadLine();
                        break;
                }//end switch

            } while (eingabe  != "e" && eingabe != "E");





        }
    }
}
