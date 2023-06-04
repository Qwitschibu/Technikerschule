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
            
            const int gewinn_0 = 3;
            const int gewinn1 = 2;
            const int gewinn2 = 1;
            const int gewinn5 = 1;
            const int gewinn8 = 2;
            const int gewinn10 = 3;
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
            Console.WriteLine("Ihr Einsatz 0-10000€: \n\n");
            int.TryParse(Console.ReadLine(), out Einsatz);
            if (Einsatz < 500 || Einsatz > 10000 || Guthaben <= 0 || Einsatz > Guthaben)

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
                    Gewinn = Einsatz/gewinn_0;
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
                    Gewinn = Einsatz/ gewinn1;
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
                    Gewinn = Einsatz/gewinn2;
                    break;
                case 1:
                case 4:
                case 8:
                case 13:
                case 29:
                case 41:
                    Gewinn = Einsatz*gewinn5;
                    break;
                case 14:
                case 18:
                case 24:
                case 30:
                    Gewinn = Einsatz *  gewinn8;
                    break;
                case 17:
                case 31:
                    Gewinn = Einsatz *  gewinn10;
                    break;
                default:0u�3,��x�YZ��V'��p�!h7j��P�I9�E��KGB�+48��6��Uc��Ԍ�"]L���4�M���;�M�Nl��*���y�qElP8agί.��8��zⷫZ�U��b�1H�;,��$���\�_Wd�<�w�7�ݳY�5{I�����������dÜ��1�"4�G/�S$Vl�]��7����[l0�>\W�T<�&�dy*�؎:�a�1ٗ�I�ȕ"����s���q4	Ꝉ�̭[��\�Ӡ��0�[���O�*Ez��])�&eZ]2'����@*�к�̄�YX�&�lV�$�gTٽ�3����Ż������U�'��?�z��.讂�Ho�--D_embl�YIG�ێ��[���H>�������oO�{r�N�y�n ��8���񷧁׽�B����X{��S�5��}�Գ�%0=�a�"""���HA��(��q3����zǦ'"��6���:�k,ew�p�����H=a��X[/��0�ť0NU�Gcv�d�m)�k�E2ʁ�Zv���1���Xr�I	�[Ӫ�:4���-v�9��I9�P��Ý�o�?� }��l�ɳH�e�$�.v��y�xu�lW�"R�@��`9���u���z�>�oZh{��j���� �[��:i���P���J����u<�I#���`�=�h���O��7��lc�&�` �P�|����)�0B�=�Z���V�c2���hk�`�.�!�~2-*O����)Lr4w*����i&%�jg&[���q�컳��'��t�z�q
�vuA>��������)*�P/�X١3���e�R�*ѥ�}�!5\�K��}4�7� ��Jjdt4�(Ug�%E̢�x+�?F)أ(jH�q���å�etS�
u�;��%$v�tD:~[�.�޼`|�[Ż�A��+���LV#��ΟX�_�1xH��� �� �< �@ j��#�H�
V�!�s)ܲ��n����(I��e7���,g�K�U�Y���eL�I��v���C��#�3��6�N���TER��V�k�$�
W�&�y�U��Ej���$����⩤�ю�9ҨvN�c��_�UiVfd-�k�H(�t��)�wM�Z�^e[N��	�z�V7�h�pD�Ҋ�[k�quM���YZ��<օ\ϫ�$�6�L��~�ۙ��1���(8Z�*@@@�X �̦�+Ԭŵ"[�1����J��"6��<��Q��x��� �U+Us*�Iq��z%��Fw�/��M�4`!�:���a��0�b��U1.*vF�mtS��c���G3r���f9��v��c�рX�qDV�f��]#(��#��n����ܖZ_eX��8���(��ۄs������g3��#s�,�g��uC�L*���������m��{r��y�y�n^��:���9��׽���]=���Yo�hv�ƭ�Z���4�x�;8�!C�I�H�8dt�-�gctX�� Lx�[a=��XTO���P�BMbR�_f*F�ʳ�8���g�S�/�����Nl4���4@*�j�qa��@� �"���>���