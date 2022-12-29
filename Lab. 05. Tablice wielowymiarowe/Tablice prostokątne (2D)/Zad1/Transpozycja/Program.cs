using System;

namespace Transpozycja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj liczbę wierszy i kolumn tablicy
            
            string[] input = Console.ReadLine().Split(' ');
            int rows = int.Parse(input[0]);
            int columns = int.Parse(input[1]);

            // Wczytaj tablicę
          
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = int.Parse(input[j]);
                }
            }

            // Wypisz transpozycję tablicy
   
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(array[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}