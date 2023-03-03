
using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading;
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
                Console.WriteLine("Menü");
                Console.WriteLine("Fakultät  (1)");
                Console.WriteLine("Menüpunkt 02  (2)");
                Console.WriteLine("Lottozahlen  (3)");
                Console.WriteLine("Fakultät  (4)");
                Console.WriteLine("Böse 7  (5)");
                Console.WriteLine("ENDE         (e)");
                Console.Write("Eingabe:");
                eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Fakultät 01 gewählt!\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        int iZahl;
                        Int64 ifak = 1;
                        Console.WriteLine("Zahl eingeben größer 0");
                        int.TryParse(Console.ReadLine(), out iZahl);
                        Console.WriteLine("Ihre Zahlen Wahl " + iZahl);
                        if (iZahl >= 0)
                        {
                            iZahl = ++iZahl;
                            for (int i = 1; i < iZahl; i++)
                            {
                                ifak = ifak * i;
                            }
                            Console.WriteLine("Die Fakultät von N ist : " + ifak);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Fehlerfahte eingabe");
                            Console.ReadLine();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n Menüpunkt   02                 gewählt\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        int zeile = 1;
                        int spalte = 1;
                        while (zeile < 10)
                        {
                            while (spalte < 10)
                            {
                                Console.Write("  X  ");
                                spalte = spalte + 1;
                            }
                            Console.WriteLine("\n");
                            spalte = 1;
                            zeile++;
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("\nLottozahlen  03");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        int[] numbers = new int[6];
                        Random random = new Random();
                        int newNumber;
                        Console.WriteLine("Lottozahlen:");

                        for (int i = 0; i < 6; i++)
                        {
                            
                            do
                            {
                                newNumber = random.Next(1, 50);
                            }
                            while (newNumber != newNumber);
                            
                            Console.Write(newNumber + " ");
                        }
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.Clear();
                        int num;
                        long factorial = 1;

                        Console.Write("Enter a number: ");
                        num = int.Parse(Console.ReadLine());
                        if (num < 0)
                            Console.WriteLine("Invalid input. Number should be greater than or equal to 0.");
                        else
                        {
                            for (int i = 1; i <= num; i++)
                            {
                                factorial *= i;
                            }
                            Console.WriteLine("The factorial of " + num + " is " + factorial); ;
                            Console.ReadLine();
                        }
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("BOESE 7 gewählt ");
                        Console.Write("Startzahl eingeben ");
                        int ieingabe, iReichweite, i7prüf, igeprüf, i70geteilt= 5,zähler ;
                        double dblgeteilt, dbl70geteilt;
                        int.TryParse(Console.ReadLine(), out ieingabe);
                        iReichweite = ieingabe + 100;
                        do
                        {
                            i7prüf = ieingabe % 7;
                            igeprüf = ieingabe / 10;
                            i70geteilt = igeprüf % 7;
                            if (i7prüf != 0 || i70geteilt != 0 )
                            {
                                Console.Write(ieingabe+"  ");
                                
                                ieingabe++;
                            }
                            
                            iReichweite++;
                            
                        } while (iReichweite>ieingabe);

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
                            break;//does not work 
                        }
                        break;
                        

                }
            } while (eingabe != "e" && eingabe != "E");

        }
    }
}

