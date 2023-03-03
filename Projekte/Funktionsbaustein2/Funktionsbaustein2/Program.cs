using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionsbaustein2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



        }
        // Funktionen mit Übergabeparameter
        // Rückgabetyp hier int 
        // Übergabeparameter hier int,int
        // die Übergabeparameter gelten NUR innerhalb der Funktion (lokale Variablen)
        static int addiereGanzezahlen (int Zahl1,int Zahl2)
        {
            int Zahl3;
            Zahl3= Zahl1+ Zahl2;
            return Zahl3;

        }// end addiereGanzezahlen
    }
}
