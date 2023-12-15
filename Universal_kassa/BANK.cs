using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal_kassa;

namespace Bosh_menyu
{
    public class BANK
    {
        private List<Client> clients;

        public BANK()
        {
            clients = new List<Client>();
        }

        public void OpenAccount(string name, Account account)
        {
            clients.Add(new Client(name, account));
        }

        public void CloseAccount(Client client)
        {
            clients.Remove(client);
        }

        public bool TransferMoney(Client sender, Client receiver, decimal amount)
        {
            if (sender.Account.Withdraw(amount))
            {
                receiver.Account.Deposit(amount);
                return true;
            }
            return false;
        }

        public List<Client> GetClients() => clients;
    }
}
