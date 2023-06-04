using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionsbausteine3
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {//Menü
            string eingabe;
            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("Taschenrechner    (A)");
                Console.WriteLine("Menüpunkt 2       (B)");
                Console.WriteLine("Menüpunkt 3       (C)");
                Console.WriteLine("Menüpunkt 4       (D)");
                Console.WriteLine("Ende           (ENDE)");
                Console.Write("Eingabe:  ");
                eingabe = Console.ReadLine();
                eingabe = eingabe.ToLower();
                switch (eingabe)
                {
                    case "a":
                        Console.WriteLine("Taschenrechner gewählt");
                        taschenrechner();
                        break;
                    case "ende":
                        break;
                    default:
                        Console.WriteLine("andere Auswahl"); Console.ReadLine();
                        break;
                }

            } while (eingabe != "ende");


        }

        static void taschenrechner()
        {
            int iZ1, iZ2;
            double Ergebnis;
            string eingabe;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Taschenrechner gewählt");
                Console.WriteLine("addieren           (A)");
                Console.WriteLine("subtrahieren       (B)");
                Console.WriteLine("dividieren         (C)");
                Console.WriteLine("multipliezieren    (D)");
                Console.WriteLine("Ende            (ENDE)");
                Console.Write("Eingabe:  ");
                eingabe = Console.ReadLine();
                eingabe = eingabe.ToLower();
                switch (eingabe)
                {
                    case "a":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\naddieren gewählt");
                        Zein(out iZ1, out iZ2);
                        Ergebnis = add(iZ1, iZ2);
                        Console.WriteLine("{0}+{1}Ergebnis {2}",iZ1,iZ2,Ergebnis);
                        Console.ReadLine();
                        break;
                    case "b":
                        Console.WriteLine("subtrahieren gewählt");
                        break;
                    case "c":
                        Console.WriteLine("dividieren gewählt");
                        break;
                    case "d":
                        Console.WriteLine("multipliezieren gewählt");
                        break;
                    case "ende":
                        break;
                    default:
                        Console.WriteLine("andere Auswahl"); Console.ReadLine();
                        break;
                }
            } while (eingabe != "ende");
        }
        static int Zein(out int Zahl1, out  int Zahl2)
        {
            
            Console.WriteLine("erste Zahl eingeben");
            int.TryParse(Console.ReadLine(), out Zahl1);
            Console.WriteLine("zweite Zahl eingeben");
            int.TryParse(Console.ReadLine(), out Zahl2);
            return 1;
        }
        static double add(double zahl1,double Zahl2)
        {
            if (zahl1 < 0) 
            {
                Console.WriteLine("Falsche Zahlen");
                return 0;
            }
            return zahl1 + Zahl2;
        }
        static void mul()
        { }

        static void div()
        { }
        static void sub()
        { }


    }


}
           

          

       
