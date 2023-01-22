namespace Bank
{
    interface IAccountWithLimit : IAccount
    {
        decimal OneTimeDebetLimit { get; set; }

        new bool Withdrawal(decimal amount);
    }
}
