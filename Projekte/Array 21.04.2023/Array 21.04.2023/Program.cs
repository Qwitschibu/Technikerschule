using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Array_21._04._2023
{
    internal class Program
    {
        static char[] ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        static char[] caesarkey2 = "RUGVFAMPBICWTDXZYSEJKLQONH".ToCharArray();
        static string message;
        static int[] code = new int[message.Length];
        static char[] ausgabe = new char[message.Length];
        static void Main(string[] args)
        {  //Variablen
            int Summe, irot;
            string Eingabe, srot, Vereingabe;

            double Durchschnitt;

            do
            {
                Console.Clear();
                Console.WriteLine("Auswahl der Aufgaben");
                Console.WriteLine("Aufgabe 1 (Array aufgabe)                    1");
                Console.WriteLine("Aufgabe 2 (Zahlen tauschen )                 2");
                Console.WriteLine("Aufgabe 3 (Cäsar verschlüsselung)            3");
                Console.WriteLine("Beenden              e");
                Eingabe = Console.ReadLine();
                switch (Eingabe)
                {
                    case "1":
                        //Array mit unterschiedlischer größe anlegen
                        int[] Datenbank1 = new int[Datenbankerzeugen()];
                        //Zufallszahlen erzeugen
                        Zufallszahl(Datenbank1);
                        // Summe Ausgeben 
                        Summe = Summerechnung(Datenbank1);
                        Console.WriteLine("Summe Aller Werte " + Summe);
                        Durchschnitt = Durschnittswert(Datenbank1);
                        Console.WriteLine("Der Duschschnittswert von " + Datenbank1.Length + " Datenbanken Inhalt ist  " + Durchschnitt);
                        Ausgabe(Datenbank1);
                        Minimum(Datenbank1);
                        Ausgabe(Datenbank1);
                        Console.ReadLine();
                        break;
                    case "2":
                        int[] Datenbank2 = new int[Datenbankerzeugen()];
                        Zufallszahl(Datenbank2);
                        Ausgabe(Datenbank2);
                        Console.Write("Angabe der Rotationen: ");
                        int.TryParse(Console.ReadLine(), out irot);
                        Console.Write("Rotatiosnsrichtugn wählen links oder rechts: ");
                        srot = Console.ReadLine();
                        for (int i = 0; i < irot; i++)
                        {
                            if (srot == "links")
                            {
                                rotieren(Datenbank2);
                            }
                            else if (srot == "rechts")
                            {
                                rotieren2(Datenbank2);
                            }
                        }
                        Ausgabe(Datenbank2);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("zu verschlüsselnden Text eingeben :");
                        eingabenach();
                        verschlüsselung();


                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            } while (Eingabe != "e" && Eingabe != "E");

        }
        static int Datenbankerzeugen()
        {
            int Anzahl;
            Console.Write("geben sie die größe des Arrays an : ");
            int.TryParse(Console.ReadLine(), out Anzahl);
            return Anzahl;
        }
        static void Zufallszahl(int[] Datenbank1)
        {
            Random rnd = new Random();

            for (int j = 0; j < Datenbank1.Length; j++)
            {
                Datenbank1[j] = rnd.Next(100);
            }
        }
        static int Summerechnung(int[] Datenbank1)
        {
            int rechnung = 0;
            for (int i = 0; i < Datenbank1.Length; i++)
            {
                rechnung = Datenbank1[i] + rechnung;
            }
            return rechnung;
        }
        static double Durschnittswert(int[] Datenbank1)
        {
            double Summe = 0;
            for (int i = 0; i < Datenbank1.Length; i++)
            {
                Summe = Summe + Datenbank1[i];
            }

            return Summe / Datenbank1.Length;
        }
        static void Ausgabe(int[] Datenbank1)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < Datenbank1.Length; i++)
            {
                Console.WriteLine("Zeile " + i + " mit dem Inhalt " + Datenbank1[i]);
            }
            Console.WriteLine("\n");
        }
        static void Minimum(int[] datenbank1)
        {
            System.Array.Sort(datenbank1);
            int min = datenbank1.GetLowerBound(0);
            int max = datenbank1.GetUpperBound(0);
            Console.WriteLine("max (größter Wert) " + datenbank1[max]);
            Console.WriteLine("min (kleinster Wert) " + datenbank1[min]);
        }
        static void rotieren(int[] datenbank1)
        {
            int Arrayg = datenbank1.GetLowerBound(0);
            int hilf = datenbank1[Arrayg];
            for (int i = 0; i < datenbank1.Length; i++)
            {
                if (i < datenbank1.Length - 1)
                {
                    datenbank1[i] = datenbank1[i + 1];
                }
                else if (i == datenbank1.Length - 1)
                {
                    datenbank1[i] = hilf;
                }
            }
        }
        static void rotieren2(int[] datenbank1)
        {
            int Arrayg = datenbank1.GetUpperBound(0);
            int hilf = datenbank1[Arrayg];
            for (int i = datenbank1.GetUpperBound(0); i >= 0; i--)
            {
                if (i > 0)
                {
                    datenbank1[i] = datenbank1[i - 1];

                }
                else if (i == 0)
                {
                    datenbank1[0] = hilf;
                }
            }

        }
        static void eingabenach()
        {
            string nachtichtein;
            nachtichtein = Console.ReadLine();
            string message = nachtichtein.ToUpper();

        }
        static void verschlüsselung()
        {
            char[] verschl = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                verschl[i] = message[i];
            }
            for (int i = 0; i < verschl.Length; i++)
            {
                for (int j = 0; j < (ABC.Length - 1); j++)
                {
                    if (ABC[j] == verschl[i])
                    {
                        ausgabe[i] = caesarkey2[j];
                        code[i] = j;
                        j = ABC.Length;
                    }
                }
            }
        }
        static void ausgaben()
        {
        
        Console.Write(ausgabe[i]);
        }
        


        }


    }

