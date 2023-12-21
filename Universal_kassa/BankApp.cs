using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal_kassa;

namespace Bosh_menyu
{
    public class BankApp
    {
        private BANK bank;

        public BankApp()
        {
            bank = new BANK();
        }

        public void CreateClientAndAccount(string name, Account account)
        {
            bank.OpenAccount(name, account);
        }

        public bool Transfer(string senderName, string receiverName, decimal amount)
        {
            Client? sender = bank.GetClients().Find(c => c.Name == senderName);
            Client? receiver = bank.GetClients().Find(c => c.Name == receiverName);
            if (sender != null && receiver != null)
                return bank.TransferMoney(sender, receiver, amount);
            return false;
        }

        public void ShowBalance(string clientName)
        {
            Client? client = bank.GetClients().Find(c => c.Name == clientName);
            if (client != null)
                Console.WriteLine($"{client.Name}'s account balance: {client.Account.GetBalance():C2}");
            else
                Console.WriteLine("Client not found!");
        }

        public void CreateClientAndAccount(string v)
        {
            throw new NotImplementedException();
        }
    }
}
