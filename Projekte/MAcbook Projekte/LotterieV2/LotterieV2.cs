using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._12._2022_Lotterie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;


            //Variablen
            
            const int gewinn_0 = -3000;
            const int gewinn1 = -1000;
            const int gewinn2 = -700;
            const int gewinn5 = 700;
            const int gewinn8 = 1500;
            const int gewinn10 = 2000;
            int wert_zufallszahl;
            int Gewinn = 0;
            int Guthaben = 15000;


        A:
            int Einsatz = 0;

            //Hintergrund und Farbe ändern
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //Kopf des Glückrads
            Console.WriteLine("========================================");
            Console.WriteLine("           G L Ü C K S R A D");
            Console.WriteLine("========================================\n");
            Console.WriteLine("GEWINNSUMMEN\n");
            Console.WriteLine("   -3000€         -700€           1500€");
            Console.WriteLine("   -1000€          700€           2000€\n");
            Console.WriteLine("========================================\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Guthaben {Guthaben}€\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Ihr Einsatz 30-10000€: \n\n");
            int.TryParse(Console.ReadLine(), out Einsatz);
            if (Einsatz < 30 || Einsatz > 10000 || Guthaben <= 0 || Einsatz > Guthaben)

            {
                Console.WriteLine("Bitte richtigen Einsatz eingeben\b\n ");
                Console.ReadLine();

                goto A;
            }
            // erstellen einer ZUfallszahl
            Random zufahlszahl = new Random();
            //Zufallszahl von 0 bis 51
            wert_zufallszahl = zufahlszahl.Next(1, 51);

            //switch start
            switch (wert_zufallszahl)
            {
                case 3:
                case 9:
                case 11:
                case 20:
                case 23:
                case 10:
                case 25:
                case 26:
                case 32:
                case 33:
                case 36:
                case 40:
                case 44:
                case 45:
                case 50:
                    Gewinn = gewinn_0;
                    break;
                case 5:
                case 7:
                case 15:
                case 16:
                case 21:
                case 27:
                case 34:
                case 37:
                case 39:
                case 42:
                case 46:
                case 49:
                    Gewinn = gewinn1;
                    break;
                case 2:
                case 6:
                case 12:
                case 19:
                case 22:
                case 28:
                case 35:
                case 38:
                case 43:
                case 47:
                case 48:
                    Gewinn = gewinn2;
                    break;
                case 1:
                case 4:
                case 8:
                case 13:
                case 29:
                case 41:
                    Gewinn = gewinn5;
                    break;
                case 14:
                case 18:
                case 24:
                case 30:
                    Gewinn = gewinn8;
                    break;
                case 17:
                case 31:
                    Gewinn = gewinn10;
                    break;
                default:
                    break;
      ;%�*)���WF9�E2�i ��+�5��-"�6F��	ŕ84m2�,QԂJ�p@�[�˙Q�֓�(�����1hRez��)�f���͆�MF-Ҩ�m�u���>zfv��1z���C��_���+)�	����<�`� 8"=4q�"2�03Q����8	���J�zLd4,:���:a����`%+Z��n������;&��L��љKh�vbjR�9�zV�/S@w�Y߁�i ���$�2|����lZ[5.���Bd�"̖0z���b�8��:�\<9���uL��$��Z"����Ce"x� ���5���ϋ���	�^�I���I�a5-y�Ю>ID�N�Lj��6�R����VB�g��I��]1ș��jL/���֕s@��%�eM�1�%��#6�� %P,�P�|ù�TA�j�L)t�U�C?լ�jlÖA��1i��,cq	�}T-K�DB�v����~`�Sw���q�}���ה�J�2y�ӑ,�m��c�	au!�����ʪ�$h�F���.VSC=C�V�A�Y��M����zr~Q6���q�j�.�;0�(Φ��`�N2B(��ӄ(Q��qH��0h�b��e��O<k=y��2����&�����S2㓒�P                                                                  ���D  Wh�s/K��m+e��!�U�<��=�����8uee.�k5n^��+���Q�1��P�p�Đ� ��a4����<6S�A�/���J�b����3
t��t���~�T�Lh���\sJ�֑«�	��/��D���a���<^F�-��+^f���A���Ut*���a�fj���}�K
�����	ä�����IQtv��gv�I4�TJ���jw=��k��#O��sg�lҎ�d��m�3F��g@�n�T���ڀ�%5L���j���ΰ��ԧ����F����KZC/��C�(�7�`k��I��.)9F�L;0p�dv��E�	�X��v��8��uI׿szQu�LwX�F2TS�U��L�~Sw�q�4�F�����H��Q�H��-l��n�\M�D�9�Jt�$e�zgY0����3��E$q�m�`�,�5�%  ���:Qd'��E@v�,�)i�)|n��Y� *^�Ev�{\��*���VҭB�{.B�c�YK��ƫR�~.���B��ϻGWQ��H�ua+��)d�yhz�F&3�"=5��Z'7�Rjv��9&&�R��c��H�iڟV �b�ѕ�+,�U�X/vU�{R2=I{�(��L�ʐ!4Ќ��H2�)�$**�ɰP�Fʴ0��L�B�&RGi���3Q��M8�h%�U�ed��zȘA�)�mGbi|0��b�>zRm�d-F��4�3DtJ�e��� \^�29*��)X@�h2�%d3n���DaަBu`z�x�B�{0�>�E�L>�/�7�6�|�V�#ion]e����̍2�2P�.�v�$��tX���V�~(V�*���;�۔����t.Ұ���n4�*�
��b�"4��ĳ:s�E���M