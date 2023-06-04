using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Übungen_schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1
            for (int i = 1; i < 11; i++)
            {
                


                if (i > 9)
                {
                    Console.WriteLine(i + "");

                }
                else
                {
                    Console.Write(i + ",");
                }
            }

            //Aufagbe2
            int zaehler;
            int wert = 0;
            for (int i = 1; i < 11;i= wert )
            {

                if (i < 10)
                {
                    Console.Write(i + ",");
                    wert = wert + 1;
                }
                else
                {
                    Console.WriteLine(i + "");
                    if (wert >= 0) { 
                    wert = -1;
                }
                }


            }

            Console.ReadLine();

            
        }
    }
}
