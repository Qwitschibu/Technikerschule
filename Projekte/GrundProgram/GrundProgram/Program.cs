using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor= ConsoleColor.Yellow;    
                Console.Clear();
                Console.WriteLine("    Menü");
                Console.WriteLine("Menüpunkt 01  (1)");
                Console.WriteLine("Beispiel 6  (2)");
                Console.WriteLine("AUfgabe 3  (3)");
                Console.WriteLine("ENDE         (e)");
                Console.Write("Eingabe:");
                eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "1":
                        Console.WriteLine("Menüpunkt 01 gewählt");
                        

                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Beispiel 6  gewählt");
                        int von = 20;
                        int bis = 1;
                        int schrittweise = -2;
                        int laeufer = 20;
                        while (laeufer>=bis)
                        {
                            Console.WriteLine("{0}",laeufer);
                            laeufer = laeufer + schrittweise;
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Aufgabe 3 gewählt");
                        // VAriablen
                        int zahlen;
                        int Ausgabe;
                        int startmal ;
                        int endmal = 10;
                        Console.Write("Zahl eingeben größer 0:");
                        Int32.TryParse(Console.ReadLine(),out zahlen );
                        startmal = zahlen;

                        while (startmal == 0)
                        {
                            Ausgabe = zahlen * startmal;
                            Console.WriteLine($"{0}+{1}", Ausgabe,startmal);
                        }

                        
                        Console.ReadLine() ;    


                            
                              
                        
                        
                            
                        break;











                    case "e":
                    case "E":
                        Console.ForegroundColor = ConsoleColor.Red;
                        
                        Console.WriteLine("Ende gewählt Beendet sich in 5 Sekunden\n");
                        DateTime dtStart = DateTime.Now;
                        int Sekunden_zähler = 5;
                        while (1 == 1)
                        {
                            TimeSpan dtDiff = DateTime.Now - dtStart;
                            if (dtDiff.Seconds == Sekunden_zähler)
                                Console.WriteLine($"Ende gewählt Beendet sich in {Sekunden_zähler} Sekunden");
                                Sekunden_zähler = Sekunden_zähler - 1;
                            if (dtDiff.Seconds > 5)
                               
                            break;//does not work 
                        }
                        break;
                }
            } while (eingabe != "e" && eingabe != "E");

        }
    }
}

