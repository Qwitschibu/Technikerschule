using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionsbausteine1
{
    internal class Program
    {
        static void grunMenue(out int programm)
        {
            Console.Clear();
            Console.WriteLine("Programm 1  ");
            Console.WriteLine("Programm 2  ");
            Console.Write("Programm auswählen : ");
            int.TryParse(Console.ReadLine(), out programm);
            return;
        }

        static void Main(string[] args)
        {
            //Menü aufbau
            int auswahl;
            
            grunMenue(out auswahl);
            
           

        }
         public void programmstart1()
        {
            Console.WriteLine( "Hallo");
            Console.ReadLine();
            return;
        }
        static void programmstart2()
        {
            Console.WriteLine("test");
            return;
        }
    }
}
