using System;

namespace Bank
{
    public class Account : IAccount
    {
        public string? Name { get; }
        public decimal Balance { get; private set; }
        public bool IsBlocked { get; private set; }

        public Account(string? name, decimal balance = 0)
        {
            if (name == null)
            {
               Console.WriteLine("Name is null");
               Environment.Exit(0);
            }
            if (string.IsNullOrWhiteSpace(name) || name?.Length < 3)
                throw new ArgumentException("Invalid name. Name must have at least 3 characters");
            if (balance < 0)
                throw new ArgumentOutOfRangeException("Initial balance cannot be negative");

            Name = name?.Trim();
            Balance = Math.Round(balance, 4);
            IsBlocked = false;
        }

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
            if (amount < 0 || IsBlocked || amount > Balance)
                return false;

            Balance = Math.Round(Balance - amount, 4);
            return true;
        }

        public override string ToString()
        {          
            return $"Account name: {Name}, balance: {Balance:F2}{(IsBlocked ? ", blocked" : "")}";                  
        }


    }
}
