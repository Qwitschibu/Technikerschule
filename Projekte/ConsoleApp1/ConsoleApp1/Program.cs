using System;
using System.Linq;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1;
    static Random random = new Random();

    static void Main()
    {
        while (true)
        {
            ZeichneBrett();
            if (player == 1)
            {
                HoleSpielerEingabe();
            }
            else
            {
                HoleComputerEingabe();
            }
            if (ÜberprüfeAufSieg())
            {
                if (player == 1)
                {
                    Console.WriteLine("Spieler hat gewonnen!");
                }
                else
                {
                    Console.WriteLine("Computer hat gewonnen!");
                }
                break;
            }
            if (ÜberprüfeAufUnentschieden())
            {
                Console.WriteLine("Es ist unentschieden!");
                break;
            }
            WechsleSpieler();
        }
        Console.WriteLine("Drücken Sie eine beliebige Taste um das Programm zu beenden...");
        Console.ReadKey();
    }
    static void ZeichneBrett()
    {
        Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
    }

    static void HoleSpielerEingabe()
    {
        Console.WriteLine("Spieler, wähle eine Zahl:");
        int eingabe = int.Parse(Console.ReadLine());
        if (eingabe < 1 || eingabe > 9)
        {
            Console.WriteLine("Ungültige Eingabe, versuche es erneut.");
            HoleSpielerEingabe();
        }
        else if (board[eingabe - 1] == 'X' || board[eingabe - 1] == 'O')
        {
            Console.WriteLine("Dieser Platz ist bereits besetzt, versuche es erneut.");
            HoleSpielerEingabe();
        }
        else
        {
            board[eingabe - 1] = 'X';
        }
    }

    static void HoleComputerEingabe()
    {
        int eingabe = random.Next(1, 10);
        while (board[eingabe - 1] == 'X' || board[eingabe - 1] == 'O')
        {
            eingabe = random.Next(1, 10);
        }
        board[eingabe - 1] = 'O';
        Console.WriteLine("Der Computer hat {0} gewählt.", eingabe);
    }
    static bool ÜberprüfeAufSieg()
    {
        if (board[0] == board[1] && board[1] == board[2]) return true;
        if (board[3] == board[4] && board[4] == board[5]) return true;
        if (board[6] == board[7] && board[7] == board[8]) return true;
        if (board[0] == board[3] && board[3] == board[6]) return true;
        if (board[1] == board[4] && board[4] == board[7]) return true;
        if (board[2] == board[5] && board[5] == board[8]) return true;
        if (board[0] == board[4] && board[4] == board[8]) return true;
        if (board[2] == board[4] && board[4] == board[6]) return true;
        return false;
    }

    static bool ÜberprüfeAufUnentschieden()
    {
        for (int i = 0; i < 9; i++)
        {
            if (board[i] != 'X' && board[i] != 'O')
            {
                return false;
            }
        }
        return true;
    }
    static void WechsleSpieler()
    {
        player = player == 1 ? 2 : 1;
    }
}
