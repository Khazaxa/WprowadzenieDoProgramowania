using System;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj wymiary planszy
            string[] dimensions = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]);
            int columns = int.Parse(dimensions[1]);

            // Wczytaj planszę
            char[][] board = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                board[i] = Console.ReadLine().ToCharArray();
            }

            // Dla każdej komórki planszy sprawdź, ile min przylega do niej
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Jeśli komórka zawiera minę, to nie robimy nic
                    if (board[i][j] == '*')
                    {
                        continue;
                    }

                    // Sprawdź, ile min znajduje się w komórkach sąsiadujących z komórką (w poziomie, pionie i na ukos)
                    int mines = 0;
                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            if (k >= 0 && k < rows && l >= 0 && l < columns && board[k][l] == '*')
                            {
                                mines++;
                            }
                        }
                    }

                    // Wpisz liczbę min do komórki
                    if (mines > 0)
                    {
                        board[i][j] = (char)('0' + mines);
                    }
                    else
                    {
                        board[i][j] = '.';
                    }
                }
            }

            // Wypisz planszę
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(board[i]);
            }
        }

    }
}