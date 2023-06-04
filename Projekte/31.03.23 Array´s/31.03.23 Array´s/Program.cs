using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _31._03._23_Array_s
{
    internal class Program
    {
        static string Ausgabe;
        static double[] temperaturWoche3 = { 0, 5, 4, 23, 6,7,4 };
        static double[] temperaturWoche4 = new double[7] { 0, 0, 0, 0, 0, 0, 0 };
        static void Main(string[] args)
        {
            //Arrays
            //Array aus double - Arrayname
            double[] temperaturWoche1;
            //Speicherplatz für das Array anlegen
            //Arrayname = new Datentyp des Arrays - [X] x anzahl der Elemente
            temperaturWoche1 = new double[7]; // Indiezies von 0 bis 6
            //// üblicherweise wird ein Arra in EINER Zeile angelegt
            double[] temperaturWoche2 = new double[7];
            //Array kann beim anlegen initialiesiert werden
            //hier Array der Größe 5  wird mit den entscprechenden Werten initialiersiert


            //Zugriff auf ein Array schreibend
            //ArrayName [Index] = Wert
            temperaturWoche1[5] = 20.3; //an das 6 Element wird mit 20.3 beschrieben

            //lesender Zugriff
            Console.WriteLine("Temperatur am Samstag {0} Grad", temperaturWoche1[5]);

            temperaturWoche3[0] = 12;
            Console.WriteLine("Temperatur am Tag  ist die temperatur {0} ", temperaturWoche3[4]);

            //auslesen aller Temperaturen aus Woche 4
            //Iterieren über ein Array ist möglich ; der Index kan neine Varaible sein
            for (int index = 0; index < 7; index++)
            {
                Console.WriteLine("Die Temperaturen am Tag " + (index + 1).ToString() + " " + temperaturWoche4[index]);
            }
            Console.ReadLine();
            //besser: Länge des Arrays mit Arrayname.Length ermitteln
            for (int index = 0; index < temperaturWoche4.Length; index++)
            {
                Console.WriteLine("Die Temperaturen am Tag " + (index + 1).ToString() + "\n " + temperaturWoche4[index]);
            }
            //andere Möglichkeit ALLE Elemente eines Arrays zu durchlaufen
            foreach (double temperatur in temperaturWoche3)
            {
                Console.Write(temperatur + " Woche 3  ");
            }
            foreach (double temperatur in temperaturWoche4)
            {
                Console.WriteLine(temperatur + "  Woche 4  ");
            }
           
            for (int index = 0; index < 7; index++)
            {
                verschieben(index);
            }
            foreach (double temperatur in temperaturWoche4)
            {
                Console.WriteLine(temperatur  + " Woche 4  ");
            }

            Console.ReadLine();
        }
        //Erstellen Sie eine Funktion, in welcher Sie alle Tmperaturen eines übergebenen Temperaturarrays eingeben können
        //Arrays werden immer call-by-reference übergeben
        //                    Datentyp[]Name(beliebig)
        static void tempEingabe(double[] tempArray)
        {
            double dblHilf = 0;
            for (int index = 0; index < tempArray.Length; index++)
            {
                Console.WriteLine("Temperatur eingeben: ");
                dblHilf = Convert.ToDouble(Console.ReadLine());
                tempArray[index] = dblHilf;
                Console.WriteLine();
            }
        }


        // Ausgabe eines Array´s im FB als string

        // Funktion wo ein Arry die Daten in ein zweites einegegeben werden

        //Variablen
        /*
        static void Ausgaben(double[] tempArray)
        {
            double dblHilf = 0;
            for (int index = 0; index < tempArray.Length; index++)
            {
                
                dblHilf = Convert.ToDouble(Console.ReadLine());
                tempArray[index] = dblHilf;
                Console.WriteLine("");
            }
         }
        */
        static void verschieben(int index)
        {

            temperaturWoche4[index] = temperaturWoche3[index];
        }
    }
}
