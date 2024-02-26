using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    internal class Car
    {
        
        public int Id {get;set;}
        public string Brand {get; set;}
        public string Segment { get; set; }
        public string Fuel { get; set; }
        public int Price { get; set; }
        public string isLoan { get; set; }

        public Car(int id,string brand,string segment,string fuel,string isloan,int price)
        {
            this.Id = id;
            this.Brand = brand;
            this.Segment = segment;
            this.Fuel = fuel;
            this.Price = price;
            this.isLoan = isloan;
        }
        
    }
}
