using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal_kassa
{
         public abstract class Account
         {
            public string? AccountNumber { get; set; }
            public decimal Balance { get; protected set; }

            public abstract void Deposit(decimal amount);

        internal object GetBalance()
        {
            throw new NotImplementedException();
        }

        internal bool Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
         }

}

