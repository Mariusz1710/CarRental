using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    internal class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CarLicense { get; set; }

        public Client(int id, string name, DateTime license)
        {
            this.Id = id;
            this.Name = name;
            this.CarLicense = license;
        }
    }
}
