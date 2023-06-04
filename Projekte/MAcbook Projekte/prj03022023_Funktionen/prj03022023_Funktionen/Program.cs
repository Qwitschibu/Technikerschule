using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prj03022023_Funktionen
{
    internal class Program
    {
         static void Main(string[] args)
        {
            
            double ergbnis,Zahl1=0.0,Zahl2 =0.0;
            
            Console.WriteLine("zahl 1 eingeben:");
            double.TryParse(Console.ReadLine(), out Zahl1);
            Console.WriteLine("zahl 2 eingeben:");
            double.TryParse(Console.ReadLine(), out Zahl2);
            ergbnis = addierendoubezahl(Zahl1, Zahl2);
            Console.WriteLine("Ergebnis : " + ergbnis);
          
            Console.ReadLine();
        }
        static double addierendoubezahl(double x, double y)
        {
            double zahl = x + y;
            return zahl;
        }
    }
}
