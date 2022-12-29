using System;
using System.Collections.Generic;

namespace ColumnWithLargestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj dane
            //Console.WriteLine("Podaj elementy tablicy, oddzielając je spacjami. Aby zakończyć wprowadzanie, naciśnij Enter bez podawania żadnych danych:");
            List<int[]> data = new List<int[]>();
            while (true)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }
                int[] row = Array.ConvertAll(line.Split(' '), int.Parse);
                data.Add(row);
            }

            // Oblicz sumy kolumn
            int[] columnSums = new int[data[0].Length];
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    columnSums[j] += data[i][j];
                }
            }

            // Znajdź indeks kolumny o największej sumie
            int maxSum = 0;
            int maxSumIndex = 0;
            for (int i = 0; i < columnSums.Length; i++)
            {
                if (columnSums[i] > maxSum)
                {
                    maxSum = columnSums[i];
                    maxSumIndex = i;
                }
            }

            // Wypisz indeks kolumny o największej sumie
            Console.WriteLine(maxSumIndex);
        }
    }
}
