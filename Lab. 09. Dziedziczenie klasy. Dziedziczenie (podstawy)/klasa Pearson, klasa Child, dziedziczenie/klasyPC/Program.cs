using System;


namespace klasyPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Test: poprawne tworzenie obiektu Person, dane poprawne */
            try
            {
                Person p = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}