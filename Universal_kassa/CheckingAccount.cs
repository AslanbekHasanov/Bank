using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal_kassa;

namespace Bosh_menyu
{
    public abstract class CheckingAccount: Account
    {
        public virtual bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public decimal GetBalance() => Balance;
    }
}
