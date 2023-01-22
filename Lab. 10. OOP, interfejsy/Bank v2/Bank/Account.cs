using System;


namespace Bank
{
    public class Account : IAccount
    {
        public string Name { get; }
        public decimal Balance { get; private set; }
        public bool IsBlocked { get; private set; }

        public bool IsFault { get; private set; }

        public Account(string name, decimal balance = 0)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name is null");
                IsFault = true;
                return;
            }
            Name = name.Trim();
            if (string.IsNullOrWhiteSpace(Name) || Name.Length < 3)
            {
                Console.WriteLine("Name is to short");
                IsFault = true;
                return;
            }
            if (balance < 0 || IsFault)
            {
                Console.WriteLine("negative argument");
                IsFault = true;
                return;
            }
            else
            {
                Name = name.Trim();
                Balance = Math.Round(balance, 4);
                IsBlocked = false;
                IsFault = false;
            }
        }

        public Account(decimal balance)
        {
            Balance = balance;
        }

        public void Exception() => IsFault = true;
        public void NoException() => IsFault = false;
        public void Block() => IsBlocked = true;
        public void Unblock() => IsBlocked = false;

        public bool Deposit(decimal amount)
        {
            if (amount < 0 || IsBlocked)
                return false;

            Balance = Math.Round(Balance + amount, 4);
            return true;
        }

        public bool Withdrawal(decimal amount)
        {
            if (amount < 0 || IsBlocked || amount > Balance || Balance <= Balance - amount || amount > 99)
                return false;

            else
            {
                Balance = Math.Round(Balance - amount, 4);
                return true;
            }
        }

        public override string ToString()
        {
            return (IsFault) ? "" : $"Account name: {Name}, balance: {Balance:F2}{(IsBlocked ? ", blocked" : "")}";
        }
    }
}