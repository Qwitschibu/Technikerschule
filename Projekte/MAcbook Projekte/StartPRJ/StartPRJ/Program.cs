using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_menü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("    Menü");
                Console.WriteLine("Menüpunkt 01  (1)");
                Console.WriteLine("Menüpunkt 02  (2)");
                Console.WriteLine("Menüpunkt 03  (3)");
                Console.WriteLine("ENDE         (e)");
                Console.Write("Eingabe:");
                eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "1":
                        Console.WriteLine("Menüpunkt            01       gewählt");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Menüpunkt   02                 gewählt");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Menüpunkt  03");
                        Console.ReadLine();
                        break;
                    case "e":
                    case "E":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ende gewählt Beendet sich in 5 Sekunden\n");
                        DateTime dtStart = DateTime.Now;
                        int Sekunden_zähler = 5;
                        while (1 == 1)
                        {
                            TimeSpan dtDiff = DateTime.Now - dtStart;
                            if (dtDiff.Seconds < Sekunden_zähler)
                                Console.WriteLine($"Ende gewählt Beendet sich in {Sekunden_zähler} Sekunden");
                            Sekunden_zähler = Sekunden_zähler - 1;
                            if (dtDiff.Seconds > 5)
                                Task.Delay(5);
                            //does not work 
                        }
                        break;
                }
            } while (eingabe != "e" && eingabe != "E");

        }
    }
}
