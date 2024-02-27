using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    internal class Clients
    {
        static List<Client> clients = new List<Client>();
        public static void CreateClients()
        {
            
            //var dataLicense = new DateTime(2021, 3, 4);
            clients.Add(new Client(1, "Jan Nowak", new DateTime(2021,3,4)));
            clients.Add(new Client(2, "Agnieszka Kowalska", new DateTime(1999,1,15)));
            clients.Add(new Client(3, "Robert Lewandowski ", new DateTime(2010,12,18)));
            clients.Add(new Client(4, "Zofia Plucińska", new DateTime(2020,4,28)));
            clients.Add(new Client(5, "Grzegorz Braun", new DateTime(2015,7,12)));
        }

        public static void ShowClients()
        {
            Console.Clear();
            Console.WriteLine("LISTA KLIENTÓW");
            Console.WriteLine("------------------");
            Console.WriteLine("Id | Imię i nazwisko | Data wydania prawa jazdy");

            foreach (var client in clients)
            {
                Console.WriteLine(client.Id + " | " + client.Name + " | " + client.CarLicense.ToShortDateString()); 
            }
        }

        public static bool CheckClientId(int id)
        {
            bool exists = false;

            foreach (var client in clients)
            {
                if (client.Id == id) 
                {
                    exists = true;
                    return exists;
                }
            }
            Console.WriteLine("Nie ma klienta o takim id");
            Console.WriteLine("Naciśnij eneter");
            Console.ReadLine();
            return exists;
        }

        public static bool IsFourYears(int id)
        {
            var today = DateTime.Now;

            
            foreach (var client in clients)
            {
                if (client.Id == id)
                {
                    var diff = today.Subtract(client.CarLicense);

                    if (diff.Days > 1459)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static int CalculateDays(Rental ren)
        {
            var days = ren.Days;

            if (days > 30)
            {
                days += 3;
            }
            else if (days > 7)
            {
                days += 1;
            }

            return days;

        }

        public static string GetName(int id)
        {
            foreach (Client client in clients)
            {
                if (client.Id == id)
                {
                    return client.Name;
                }
            }
            return "Error";
        }
    }
}
