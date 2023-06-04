using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Zählergesteuerte Schleife
            for (int i = 0; i < 10; i++)
            {
                // Schleifenkörper wird ausgeführt so lange Bedingung erfüllt ist

                Console.Write("*\n");
                //for (int j = 0; j < 20; j=j+2)
               // {
                //    Console.WriteLine($"{j}");

                //}
            }

            // schleiferückwärts
            for (int i = 10; i > 0; i--)
            {
                Console.Write(i+ "\n");
            }
            /*
            // variabler Endwert
            int endwert;
            int startwert;
            Console.WriteLine("endwert eingeben");
            endwert = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("startwert eingeben");
            startwert = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = startwert; i < endwert; i++)
            {
                Console.WriteLine(i + "");

            }
            */

            for (int i = 1; i < 11; i++)
            {
                
                if (i > 9)
                {
                    Console.WriteLine(i + "");
                }
                else
                {
                    Console.Write(i +",");
                }

                
            }
            /*
            //while schleifen
            //läuft dauerhaft
            int zaehler = 0;
            char eingabe = 'a';
            while (zaehler <= 0 && eingabe != 'e')
            {
                Console.WriteLine("test");
            }
            */


            //whileschleifen
            Console.WriteLine("whileschleife\n");
            int zaehler = 0;
            
            while (zaehler <= 10 )
            {
                Console.Write(zaehler+" test ");
                zaehler++;  
            }
            //whileschleife beenden 
            /*

            char eingabe = ' ';
            
            while (eingabe != 'e')
            {
                
                Console.WriteLine( "*");
                eingabe = Convert.ToChar(Console.ReadLine());
            }


            */
            //fussgesteuerte schleife 

            do
            {

            } while (true);


            Console.ReadLine();
        }
    }
}
