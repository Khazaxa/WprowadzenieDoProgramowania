using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();
            
        }
        static void Test1()
        {
            // tworzenie konta, zmiana limitu
            // utworzenie konta plus z domyslnym limitem 100
            var john = new AccountPlus("John");
            Console.WriteLine(john);

            // utworzenie konta plus z ustawionym limitem na 200 i bilansem początkowym 99
            var eve = new AccountPlus("Eve", initialLimit: 200.0m, initialBalance: 99.0m);
            Console.WriteLine(eve);

            // zmiana limitu, konto nie zablokowane
            eve.OneTimeDebetLimit = 120.0m;
            Console.WriteLine(eve);

            // próba zmiany limitu, konto zablokowane
            eve.Block();
            eve.OneTimeDebetLimit = 500.0m;
            Console.WriteLine(eve);

            // próba utworzenia konta z limitem ujemnym
            var stan = new AccountPlus(name: "Stan", initialLimit: -200.0m);
            Console.WriteLine(stan);
        }
        static void Test2()
        {

            // scenariusz: wpłaty wypłaty, blokada konta
            // utworzenie konta plus z domyslnym limitem 100
            var john = new AccountPlus("John", initialBalance: 100.0m);
            Console.WriteLine(john);

            // wypłata - podanie kwoty ujemnej
            john.Withdrawal(-50.0m);
            Console.WriteLine(john);

            // wypłata bez wykorzystania debetu            
            john.Withdrawal(50.0m);
            Console.WriteLine(john);

            // wypłata z wykorzystaniem debetu
            john.Withdrawal(100.0m);
            Console.WriteLine(john);

            // konto zablokowane, wypłata niemożliwa
            john.Withdrawal(10.0m);
            Console.WriteLine(john);

            // wpłata odblokowująca konto
            john.Deposit(80.0m);
            Console.WriteLine(john);

            // wpłata podanie kwoty ujemnej
            john.Deposit(-80.0m);
            Console.WriteLine(john);
        }

       
    }
}