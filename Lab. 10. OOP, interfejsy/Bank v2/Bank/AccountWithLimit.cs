using System;


namespace Bank
{
    public class AccountWithLimit : Account, IAccountWithLimit
    {
        public decimal OneTimeDebetLimit { get; set; }

        public AccountWithLimit(decimal balance = 0, decimal limit = 100) : base(balance)
        {
            OneTimeDebetLimit = limit;
        }

        public bool Withdrawal(decimal amount)
        {
            if (IsLocked)
                return false;

            if (amount > Balance + OneTimeDebetLimit)
                return false;

            if (amount <= Balance)
            {
                base.Withdrawal(amount);
                return true;
            }
            else
            {
                base.Withdrawal(amount);
                IsLocked = true;
                return true;
            }
        }

        public override bool Deposit(decimal amount)
        {
            if (base.Deposit(amount))
            {
                if (Balance >= 0)
                    IsLocked = false;
                return true;
            }
            return false;
        }
    }
}
