using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BankClient bankClient1 = new BankClient();
            bankClient1.Name = "İrem";
            bankClient1.Surname = "Çalışkan";
            bankClient1.TC = "12345678912";
            bankClient1.Birthday = new DateTime(1990, 1, 1);
            bankClient1.Phone = "905999999999";
            bankClient1.Address = "Istanbul/Turkey";
            bankClient1.Mail = "iremcaliskan0@outlook.com";

            BankClient bankClient2 = new BankClient();
            bankClient2.Name = "Ceren";
            bankClient2.Surname = "Yıldız";
            bankClient2.TC = "12345678912";
            bankClient2.Birthday = new DateTime(1992, 12, 1);
            bankClient2.Phone = "905999999999";
            bankClient2.Address = "Izmir/Turkey";
            bankClient2.Mail = "iremcaliskan0@outlook.com";

            BankClient bankClient3 = new BankClient();
            bankClient3.Name = "Cemre";
            bankClient3.Surname = "Ay";
            bankClient3.TC = "12345678912";
            bankClient3.Birthday = new DateTime(1990, 10, 8);
            bankClient3.Phone = "905999999999";
            bankClient3.Address = "Ankara/Turkey";
            bankClient3.Mail = "iremcaliskan0@outlook.com";

            BankClient[] clients = new BankClient[] { bankClient1, bankClient2, bankClient3 };


            BankClientManager bankClientManager = new BankClientManager();
            bankClientManager.addToDatabase(bankClient1);
            bankClientManager.addToDatabase(bankClient2);
            bankClientManager.addToDatabase(bankClient3);
            
            Console.WriteLine("\nMüşterilerin Adres Bilgileri");
            bankClientManager.findAddress(bankClient1);
            bankClientManager.findAddress(bankClient2);
            bankClientManager.findAddress(bankClient3);

            Console.WriteLine("\nMüşterilerin İletişim Bilgileri");
            bankClientManager.findContactInfo(bankClient1);
            bankClientManager.findContactInfo(bankClient2);
            bankClientManager.findContactInfo(bankClient3);

            Console.WriteLine("\nMüşteri Listesi");
            for (int i = 0; i < clients.Length; i++)
            {
                bankClientManager.listClients(clients[i]);
            }

            Console.WriteLine("\nMüşteri Silme");
            bankClientManager.deleteClientAccount(bankClient1);
        }
    }
}
