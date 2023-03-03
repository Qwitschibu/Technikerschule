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

                        break;
                    case "ende":
                        break;
                    default:
                        Console.WriteLine("andere Auswahl");Console.ReadLine();
                        break;
                }

            } while (eingabe != "ende");


        }
        static void add()
        static void mul()
        static void div()
        static void sub()
    }
}
