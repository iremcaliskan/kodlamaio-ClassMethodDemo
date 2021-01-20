using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class BankClientManager
    {
        public void listClients(BankClient bankClient)
        {
            Console.WriteLine("{0} {1}", bankClient.Name, bankClient.Surname);
        }

        public void addToDatabase(BankClient bankClient) {
            Console.WriteLine("{0} {1} is added to the system!", bankClient.Name, bankClient.Surname);
        }

        public void findAddress(BankClient bankClient) {
            Console.WriteLine("{0} {1} \nAdres: {2}", bankClient.Name, bankClient.Surname, bankClient.Address);
        }

        public void findContactInfo(BankClient bankClient) {
            Console.WriteLine("{0} {1} \nTelefon: {2} Mail: {3}", bankClient.Name, bankClient.Surname, bankClient.Phone, bankClient.Mail);
        }

        public void deleteClientAccount(BankClient bankClient)
        {
            Console.WriteLine("{2} {0} {1} bilgilerine sahip müşteri silindi.", bankClient.Name, bankClient.Surname, bankClient.TC);
        }
    }
}
