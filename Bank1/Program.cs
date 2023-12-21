using Bosh_menyu;

BankApp app = new BankApp();
Client d = new Client();
d.GetDetails();


/*app.CreateClientAndAccount("John Doe", new CheckingAccount { AccountNumber = "12345678", Balance = 1000 });
app.CreateClientAndAccount("Jane Doe", new CheckingAccount { AccountNumber = "98765432", Balance = 500 });
*/
app.Transfer("John Doe", "Jane Doe", 200);

app.ShowBalance("John Doe");
app.ShowBalance("Jane Doe");