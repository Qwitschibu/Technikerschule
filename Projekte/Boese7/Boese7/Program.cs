using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boese7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i= 1;
            int iZaehlweite;
            Console.WriteLine("Startwert eingeben:");
            int.TryParse(Console.ReadLine(), out i);
            iZaehlweite = i + 100;
            for (; i <= iZaehlweite; i++)
                {
                    bool shouldSkip = false;
                    int num = i;
                    while (num > 0)
                    {
                        int digit = num % 10;
                        if (digit == 7 || i % 7 == 0)
                        {
                            shouldSkip = true;
                        iZaehlweite++;
                            break;
                        }
                        num /= 10;
                    }
                    if (!shouldSkip)
                    {
                        Console.Write(i+", ");
                    }
                

                }
            Console.ReadLine();
        }
        }

    }
