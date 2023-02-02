using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class AccountPlus : Account, IAccountWithLimit
    {
        private decimal oneTimeDebetLimit = 100;
        private bool blocked = false;

        public decimal OneTimeDebetLimit
        {
            get => oneTimeDebetLimit;
            set
            {
                if (value >= 0)
                    oneTimeDebetLimit = value;
            }
        }

        public bool Withdrawal(decimal amount)
        {
            if (blocked || amount > Balance + oneTimeDebetLimit)
                return false;
            if (amount > Balance)
                blocked = true;
            Balance -= amount;
            return true;
        }

        public bool Block()
        {
            if (Balance + oneTimeDebetLimit > 0)
                return false;
            blocked = true;
            return true;
        }

        public bool Unblock()
        {
            if (Balance + oneTimeDebetLimit > 0)
                return false;
            blocked = false;
            return true;
        }

        public override string ToString()
        {
            return blocked
                ? $"Account name: {Name}, balance: {Balance}, blocked, , available founds: {Balance + oneTimeDebetLimit}, limit: {oneTimeDebetLimit}"
                : $"Account name: {Name}, balance: {Balance}, available founds: {Balance + oneTimeDebetLimit}, limit: {oneTimeDebetLimit}";
        }
    }

}
