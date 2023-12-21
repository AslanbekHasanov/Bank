using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal_kassa;

namespace Bosh_menyu
{
    public class Client
    {
        public string Name { get; set; }
        public Account Account { get; set; }

        public Client(string name, Account account)
        {
            Name = name;
            Account = account;
        }

        public Client()
        {
        }

        public string GetDetails() => $"Name: {Name}, Account number: {Account.AccountNumber}";
    }
}
