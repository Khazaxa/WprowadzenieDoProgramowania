using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test3();
        }
        static void Test1()
        {
            /* wypłaty
*/
            var account = new Account("John");
            account.Deposit(100.00m);
            Console.WriteLine(account.Withdrawal(10.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(100.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(0.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(-10.00m));
            Console.WriteLine(account);
            account.Block();
            Console.WriteLine(account.Withdrawal(10.4999m));
            Console.WriteLine(account);
        }
        static void Test2()
        {

            /* Utworzenie konta dla dwóch argumentów, nazwa jest null
            */
            try
            {
                var account = new Account(null, 100.0m);
                Console.WriteLine(account);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Name is null");
            }
        }

        static void Test3()
        {

            /* weryfikacja, czy implementowany jest interfejs IAccount
            */
            var account = new Account("AAA", 100.00m);
            if (account is Bank.IAccount )
                Console.WriteLine("IAccount implemented");
            else
                Console.WriteLine("IAccount not implemented");
        }
    }
}