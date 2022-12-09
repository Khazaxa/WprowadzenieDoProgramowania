using System;


namespace Tab1D
{
    class Program
    {
        public static void Print(int[] a, int[] b)
        {
            // Check if the arrays are empty
            if (a.Length == 0 || b.Length == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            // Iterate over array a and print the elements that are not in array b
            bool found = false;
            for (int i = 0; i < a.Length; i++)
            {
                bool isInB = false;
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        isInB = true;
                        break;
                    }
                }

                if (!isInB)
                {
                    // Check if this element has been printed before
                    bool isDuplicate = false;
                    for (int k = 0; k < i; k++)
                    {
                        if (a[k] == a[i])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (!isDuplicate)
                    {
                        Console.Write(a[i] + " ");
                        found = true;
                    }
                }
            }

            // If no elements were found, print "empty"
            if (!found)
            {
                Console.WriteLine("empty");
            }
        }
        public static void Main(string[] args)
        {
            int[] a = new int[] {-2, -1, 0, 1, 4};
            int[] b = new int[] {-3, -2, -1, 1, 2, 3};
            Print(a, b);
        }
    }

}
