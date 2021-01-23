using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class ClientManager
    {
       public void Add(Client client)
        {
            Console.WriteLine(client.Name + " Added." );
        }

        public void Remove(Client client)
        {
            Console.WriteLine(client.Name + " Removed.");
        }

        public void List(Client[] clients)
        {
            foreach (Client client in clients)
            {
                Console.WriteLine("Client Id: " + client.Id + "Name: " + client.Name + "Surname: " + client.SurName + "Loan Type: " + client.LoanType + "Loan debt: " + client.LoanDebt );
            }
        }
    }
}
