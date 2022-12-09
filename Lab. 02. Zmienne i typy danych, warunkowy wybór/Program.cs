using System;

class Program
{
    static void Main(string[] args)
    {
        string LastName = Console.ReadLine();
        int Age = Convert.ToInt32(Console.ReadLine());
        int AgePension = Convert.ToInt32(Console.ReadLine());
        int x = AgePension - Age;

        
        Console.WriteLine($"Witaj, {LastName}!");

        if(Age<0 || AgePension<0)
        {
            Console.WriteLine("Wiek nie może być ujemny!");
        }
        else if(Age < AgePension)
        {
            Console.WriteLine($"Do emerytury brakuje Ci {x} lat!");
        }
        else
        {
            Console.WriteLine("Jesteś emerytem!");
        }
    }
}