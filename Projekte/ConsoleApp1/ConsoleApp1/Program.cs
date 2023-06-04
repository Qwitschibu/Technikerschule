using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    class Program
    {
        static string CaesarEncrypt(string plaintext, int key)
        {
            string ciphertext = "";
            foreach (char c in plaintext)
            {
                if (Char.IsLetter(c))
                {
                    char shiftedChar = (char)(((c + key) - 'A') % 26 + 'A');
                    ciphertext += shiftedChar;
                }
                else
                {
                    ciphertext += c;
                }
            }
            return ciphertext;
        }

        static string CaesarDecrypt(string ciphertext, int key)
        {
            string plaintext = "";
            foreach (char c in ciphertext)
            {
                if (Char.IsLetter(c))
                {
                    char shiftedChar = (char)(((c - key + 26) - 'A') % 26 + 'A');
                    plaintext += shiftedChar;
                }
                else
                {
                    plaintext += c;
                }
            }
            return plaintext;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. Encrypt text");
            Console.WriteLine("2. Decrypt text");

            Console.Write("Enter your choice (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter the text to be encrypted: ");
                string plaintext = Console.ReadLine();

                Console.Write("Enter the encryption key: ");
                int key = Convert.ToInt32(Console.ReadLine());

                string ciphertext = CaesarEncrypt(plaintext, key);
                Console.WriteLine("Encrypted text: " + ciphertext);
            }
            else if (choice == 2)
            {
                Console.Write("Enter the text to be decrypted: ");
                string ciphertext = Console.ReadLine();

                Console.Write("Enter the decryption key: ");
                int key = Convert.ToInt32(Console.ReadLine());

                string plaintext = CaesarEncrypt(ciphertext, -key);
                Console.WriteLine("Decrypted text: " + plaintext);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.ReadLine();
        }
    }
}
    
