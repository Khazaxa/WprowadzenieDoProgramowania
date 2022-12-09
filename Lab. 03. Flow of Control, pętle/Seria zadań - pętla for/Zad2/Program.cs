using System;

namespace Zadania_petle
{
    class Program
    {
        static void Main()
        {
            //wczytywanie i parsowanie danych wejściowych
                //string wejscie = Console.ReadLine();
                //int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);
            // Twój kod

            
            var Dane = Console.ReadLine().Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int a = short.Parse(Dane[0]);
            int b = short.Parse(Dane[1]);
            int zakres = (b-a)-1;

         
            if(a==b || (a-b)==1 || (b-a)==1){
                Console.Write("empty");
            }
            else{
                if(zakres>10){
                    Console.Write($"{a+1}, ");
                    Console.Write($"{a+2}, ");
                    Console.Write($"{a+3}, ");
                    Console.Write($"..., ");
                    for(int i=(a); i<(b-3); i++){
                        a++;              
                    }
                    Console.Write($"{a+1}, ");
                    Console.Write($"{a+2}");
                }
                else if(a<b){
                    for(int i=a; i<(b-2); i++){
                        a++;
                        Console.Write($"{a}, ");               
                    }
                    Console.Write($"{a+1}");
                }
                else if(a>b){
                    for(int i=b; i<(a-2); i++){
                        b++;
                        Console.Write($"{b}, ");               
                    }
                    Console.Write($"{b+1}");
                }
               
            }
        }
    }
}
