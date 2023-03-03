using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _prjMAtheratespiel
{
    internal class Program
    {
        //Variablen global
        static double Zahl1;
            static double Zahl2;
            static double ergebnis;
        static void Main(string[] args)
        {
            double eingabe;

            Console.WriteLine("Rechenaufgabe");
            berechnen();
            Console.Write($"Berechen {Zahl1} + {Zahl2} = ");
            double.TryParse(Console.ReadLine(), out eingabe);
            if (eingabe == ergebnis)
            {ausgabetoll();
            }
            else
            { ausgabeschlecht();
            }
            Console.ReadLine();
        }//End Main
        static void berechnen ()
        {
            
            Random zz = new Random();
            Zahl1= zz.Next(100);//Zufallszahl von bis 0...9
            Zahl2= zz.Next(100);
            ergebnis = Zahl2 + Zahl1;
        }// ende berechnen
        static void minusrechnen ()
        {

        }
        static void ausgabetoll ()
        {
            Console.WriteLine("Das hast du gut gemacht");
        }
        static void ausgabeschlecht()
        {
            Console.WriteLine("Das hast du nicht so gut gemacht");
        }
        
    }
}
