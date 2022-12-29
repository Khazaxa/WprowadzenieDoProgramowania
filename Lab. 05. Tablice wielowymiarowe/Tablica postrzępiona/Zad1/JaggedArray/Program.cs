using System;

namespace JaggedArray
{
    class Program
    {
        static char[][] ReadJaggedArrayFromStdInput()
        {
            // Wczytaj liczbę wierszy
            int rows = int.Parse(Console.ReadLine());

            // Wczytaj wiersze
            char[][] jagged = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                string[] parts = Console.ReadLine().Split(' ');
                jagged[i] = new char[parts.Length];
                for (int j = 0; j < parts.Length; j++)
                {
                    jagged[i][j] = char.Parse(parts[j]);
                }
            }

            return jagged;
        }

        static char[][] TransposeJaggedArray(char[][] tab)
        {
            // Oblicz liczbę kolumn
            int columns = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                columns = Math.Max(columns, tab[i].Length);
            }

            // Stwórz tablicę postrzępioną o odpowiedniej wielkości
            char[][] transposed = new char[columns][];
            for (int i = 0; i < columns; i++)
            {
                transposed[i] = new char[tab.Length];
            }

            // Przepisz elementy tablicy
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    transposed[j][i] = tab[i][j];
                }
            }

            return transposed;
        }

        static void PrintJaggedArrayToStdOutput(char[][] tab)
        {
            // Wypisz wiersze tablicy
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    // Jeśli element jest równy \x00, wypisz spację
                    Console.Write(tab[i][j] == '\x00' ? ' ' : tab[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {
            char[][] jagged = ReadJaggedArrayFromStdInput();
            PrintJaggedArrayToStdOutput(jagged);
            jagged = TransposeJaggedArray(jagged);
            Console.WriteLine();
            PrintJaggedArrayToStdOutput(jagged);
        }
    }
}
