using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            client1.Id = 1;
            client1.Name = "Asap";
            client1.SurName = "Rocky";
            client1.LoanType = "consumer loan";
            client1.LoanDebt = 20000;

            Client client2 = new Client();
            client2.Id = 2;
            client2.Name = "Travis";
            client2.SurName = "Scott";
            client2.LoanType = "student loan";
            client2.LoanDebt = 5000;

            Client client3 = new Client();
            client3.Id = 3;
            client3.Name = "Kendrick";
            client3.SurName = "Lamar";
            client3.LoanType = "mortgage loan";
            client3.LoanDebt = 80000;

            Client[] clients = new[] { client1, client2, client3};

            ClientManager manager = new ClientManager();
            manager.Add(client1);
            manager.Remove(client3);
            manager.List(clients);

        }
    }
}
