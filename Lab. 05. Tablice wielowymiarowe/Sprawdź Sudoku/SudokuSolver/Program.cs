using System;

namespace SudokuSolver
{
    class Program
    {
        static bool IsSudokuSolution(int[][] board)
        {
            // Sprawdź, czy w każdym wierszu znajdują się wszystkie cyfry od 1 do 9
            for (int i = 0; i < 9; i++)
            {
                bool[] found = new bool[9];
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] < 1 || board[i][j] > 9)
                    {
                        return false;
                    }
                    found[board[i][j] - 1] = true;
                }
                for (int j = 0; j < 9; j++)
                {
                    if (!found[j])
                    {
                        return false;
                    }
                }
            }

            // Sprawdź, czy w każdej kolumnie znajdują się wszystkie cyfry od 1 do 9
            for (int i = 0; i < 9; i++)
            {
                bool[] found = new
                bool[9];
                for (int j = 0; j < 9; j++)
                {
                    if (board[j][i] < 1 || board[j][i] > 9)
                    {
                        return false;
                    }
                    found[board[j][i] - 1] = true;
                }
                for (int j = 0; j < 9; j++)
                {
                    if (!found[j])
                    {
                        return false;
                    }
                }
            }
            // Sprawdź, czy w każdym z dziewięciu małych kwadratów 3x3 znajdują się wszystkie cyfry od 1 do 9
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    bool[] found = new bool[9];
                    for (int k = i; k < i + 3; k++)
                    {
                        for (int l = j; l < j + 3; l++)
                        {
                            if (board[k][l] < 1 || board[k][l] > 9)
                            {
                                return false;
                            }
                            found[board[k][l] - 1] = true;
                        }
                    }
                    for (int k = 0; k < 9; k++)
                    {
                        if (!found[k])
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            // Wczytaj planszę Sudoku
            int[][] board = new int[9][];
            for (int i = 0; i < 9; i++)
            {
                string[] parts = Console.ReadLine().Split(' ');
                board[i] = new int[9];
                for (int j = 0; j < 9; j++)
                {
                    board[i][j] = int.Parse(parts[j]);
                }
            }
            // Sprawdź, czy plansza jest rozwiązaniem Sudoku
            bool isSolution = IsSudokuSolution(board);

            // Wypisz wynik
            Console.WriteLine(isSolution ? "yes" : "no");
        }
    }
}




