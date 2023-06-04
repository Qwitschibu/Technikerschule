using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grund_2D_array__26._05._2023_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 D array
            int[,] iArray = new int[5, 3];

            //Zugriff über Zeilen und Spaltennummern
            //z.b. 
            iArray[0, 2] = 5;
            //Übung 
            int zahl = 1;
            
            for (int i = 0; i < iArray.GetLength(0); i++)
            {

                for (int i1 = 0; i1 < iArray.GetLength(1); i1++)
                {
                    iArray[i, i1] = i*3+i1+1;
                    
                }
                
             }

            for (int i2 = 0; i2 < iArray.GetLength(0); i2++)
            {
                for (int i3 = 0; i3 < iArray.GetLength(1); i3++)
                {
                    Console.Write($"{ iArray[i2, i3],3}" );
                
                }
                Console.WriteLine("\n");
            }


            Console.ReadLine();



        }
    }
}
