
using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace prj_menü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Menü");
                Console.WriteLine("Fakultät  (1)");
                Console.WriteLine("Menüpunkt 02  (2)");
                Console.WriteLine("Lottozahlen  (3)");
                Console.WriteLine("Fakultät  (4)");
                Console.WriteLine("Böse 7  (5)");
                Console.WriteLine("ENDE         (e)");
                Console.Write("Eingabe:");
                eingabe = Console.ReadLine();
                switch (eingabe)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Fakultät 01 gewählt!\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        int iZahl;
                        Int64 ifak = 1;
                        Console.WriteLine("Zahl eingeben größer 0");
                        int.TryParse(Console.ReadLine(), out iZahl);
                        Console.WriteLine("Ihre Zahlen Wahl " + iZahl);
                        if (iZahl >= 0)
                        {
                            iZahl = ++iZahl;
                            for (int i = 1; i < iZahl; i++)
                            {
                                ifak = ifak * i;
                            }
                            Console.WriteLine("Die Fakultät von N ist : " + ifak);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Fehlerfahte eingabe");
                            Console.ReadLine();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n Menüpunkt   02                 gewählt\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        int zeile = 1;
                        int spalte = 1;
                        while (zeile < 10)
                        {
                            while (spalte < 10)
                            {
                                Console.Write("  X  ");
                                spalte = spalte + 1;
                            }
                            Console.WriteLine("\n");
                            spalte = 1;
                            zeile++;
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("\nLottozahlen  03");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        int[] numbers = new int[6];
                        Random random = new Random();
                        int newNumber;
                        Console.WriteLine("Lottozahlen:");

                        for (int i = 0; i < 6; i++)
                        {
                            
                            do
                            {
                                newNumber = random.Next(1, 50);
                            }
                            while (newNumber != newNumber);
                            
                            Console.Write(newNumber + " ");
                        }
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.Clear();
                        int num;
                        long factorial = 1;

                        Console.Write(mJn_e5�^}����������ll�@��G�"�J��S,����f\rr\j                                                                                                    ���d  vh��y{␉;i�'��U����I��}�QXX���WR%�ˊA�@���(5�t=�3l�%0"s461�`�ƚȿ͝���I�3���F4TRch������I��@�p(���Z��ZY{DkN#ҫ�K�J��))��9�X;��1��s?B��b2h�L�V�DC������^)X��|\�'����b�"ɢ�)�u���.�������r�i����`PAĴ�Bb$�Ɖ9�rz����-\��G�lQə��vOph��C��-Da�J�B�sk�h�E�)�B�DlG��6��Wqg���w��ʖ�31T��@|E�&A1'��҂� ( IDQ�ӽ��"(QaX�/�Q��a���l��DC�&���Y�Rx�q�d@zƠ{�0�!ӯ�;[�/�lw��TD`Ep���U����ޮ6�u��X���$���k�R% Ԏ�	%@c���6%����y�:Le��$��\�T,t���e�IP�#�j
��̉r@#����vP�be�$���w"��m��a��Qy;]-Q-53�1��@Df#k���X�;WP(Q�H������z�41Kv��G dחF�l(*`�wQ@��Ƞ����rZ��^��{�B��@Dź�V,D�b�/H�+��~6���Y�"b�r��i���ɉ�@�@L������}���I;D�U;S���9�1,!����
�H�ziڒ�X��p���h[C�<C�CЃ�Yn4��\B�ۦ�Y2���>����G���ZE\r��,�% ň�Q�rj\�,(S�I7��$�j]rû�o���c����p_������i1�kv8򽳐���;Z��~d��^�_�#d)v�Z�����#;�,��������R2)��U�-�q15̸���                                                                                                                        ���d  iW�Y{r��[e'�$��Y���
{�뽔��Hh��dYJE	N� 6��t�A1�,��be�ٌA�M0a�y3
hCc�����B*�8�F�� (+S9�� ��V�.c�)}*'��"���1G6M<݊�5桔�5���@g�ӓ�c)QLo��Τ����:�V��G�nU�K�	��/A�s�/Ε�=:(���d}�e�h��Y!U�<����[�	s8��� r��� $%[�e�7MB�X$f�+:�㮪�M���z�>N+��b_��R�D%v1R�'%�%����|J��JX���pȾv��1(��A"y�W!�~�(F�B��7����Nܶm�,�䶤ء���ȜFR$���#\(�2T��m�'��0�>cz��-��乎x�lT>ά<��ӳ*z����0��ɤ� ���Q�_��q�&�衘)&1����'�����),m�p:L�K�#-ю� �Z�Cv�x�1@����d�"c��@���n ��H![\����E|�$�48� X�ց�q�F�A�&�(������f�e�O`�(��KvQ�I#��E`�i��������J�oL�\�L�%�䴖ZWwb.D1,���;�s	DN�(�#rL.����$�`��Vp�)V7�1�%72�����m`f��ݺ�����j1�b%!�S	w�+Z��U�Ɔt2%at�oS�%�d)i�;��b�#�:3/}�@������@-^�F�����"@��o�p!�����'S`U%6��y%��2�Y��\���NC!BĤK��auun�%[��Nc�WG�f0k��nU⓳$Gf�� �z����x�]u��7��U���1��K����B,�!@`�a8Ûj�pLAME3.99.5                                                                                                                                                        ���d  hW�X|��ij�i��#ɣY��������7z��VK[j	O�D$ݣvn��>�نm$��z)Pq+@
�F$"АęKW�Ʊ	��Ō?�잂[-��i_�-h��[p�~u�Q#\�(n�n�N&�#}�Xm0�4��x�8�eZ��8a��3Pp��g�m�"��a(OE�/���o����?Ө�j��CkS�E�����*�@�(i��F�R�Q�`#��S�at~(N?A��~�e/'"�q7�X���##ҽZ�C�k���z1��/w���1%goq�c�բ�c"�~�u���.鹴h��qiy֘'�AA��	ADUap�A5�a��rcG�w�i~��W�f�p�b�������(�[>0D/*
�P� �Zk�Ӵ�%ԙY�o��̹p��_*x�ufԡ��w�̩r[�Ag ���9�!R �ץ����Myʧ�B���:ra���!3Pe�� (�1XB�g����c�g�^wz8�"���Z��鸉Yѹ)ce,���	jh���B�v�T!�mPfT��6D��̈́��:`�*Cy�)�$���}���4�JG�Ѷ�cR�����V~�rY�%��mC]�H��
�n7kM�j1I,��{IL�<l-�ʱ�E%��W�9{<��v��e��ʠ�4X6���U����(�T��&PwX�Lh�3�ӅY�eU��i���gE���ҩ�̰@W���rW�����K���o����<$)Q�U9Z���M0����
nFR�d�BF\Ta�f(�g3&�RqĠ d�*���p