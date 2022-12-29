using System;

namespace IloczynMacierzowy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj macierz A
            //Console.WriteLine("Podaj liczbę wierszy i kolumn macierzy A, oddzielając je spacją:");
            string[] input = Console.ReadLine().Split(' ');
            int rowsA = int.Parse(input[0]);
            int columnsA = int.Parse(input[1]);
            //Console.WriteLine("Podaj elementy macierzy A, oddzielając je spacją:");
            int[,] matrixA = new int[rowsA, columnsA];
            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsA; j++)
                {
                    matrixA[i, j] = int.Parse(input[i * columnsA + j]);
                }
            }

            // Wczytaj macierz B
            //Console.WriteLine("Podaj liczbę wierszy i kolumn macierzy B, oddzielając je spacją:");
            input = Console.ReadLine().Split(' ');
            int rowsB = int.Parse(input[0]);
            int columnsB = int.Parse(input[1]);
            //Console.WriteLine("Podaj elementy macierzy B, oddzielając je spacją:");
            int[,] matrixB = new int[rowsB, columnsB];
            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < columnsB; j++)
                {
                    matrixB[i, j] = int.Parse(input[i * columnsB + j]);
                }
            }

            // Sprawdź czy iloczyn macierzy jest możliwy
            if (columnsA != rowsB)
            {
                Console.WriteLine("impossible");
                return;
            }

            // Oblicz i wypisz iloczyn macierzy
            //Console.WriteLine("Iloczyn macierzy A x B:");
            int[,] result = new int[rowsA, columnsB];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsB; j++)
                {
                    for (int k = 0; k < columnsA; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


