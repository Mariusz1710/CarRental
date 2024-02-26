using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    internal class Cars
    {
        
        static List<Car> cars = new List<Car>();

        public static void CrateCars()
        {
            cars.Add(new Car(1, "Skoda Citigo", "mini", "benzyna", "dostępny", 70));
            cars.Add(new Car(2, "Toyota Aygo", "mini", "benzyna", "dostępny", 90));
            cars.Add(new Car(3, "Fiat 500", "mini", "elektryczny", "dostępny", 110));
            cars.Add(new Car(4, "Ford Focus", "kompakt", "diesel", "dostępny", 160));
            cars.Add(new Car(5, "Kia Ceed", "kompakt", "benzyna", "dostępny", 150));
            cars.Add(new Car(6, "Volkswagen Golf", "kompakt", "benzyna", "dostępny", 160));
            cars.Add(new Car(7, "Hyundai Kona Electric", "kompakt","elektryczny", "dostępny", 180));
            cars.Add(new Car(8, "Audi A6 Allroad", "premium","diesel", "dostępny", 290));
            cars.Add(new Car(9, "Mercedes E270 AMG", "premium","benzyna", "dostępny", 320));
            cars.Add(new Car(10, "Tesla Model S", "premium","elektryczny", "dostępny", 350));
        }

        public static void ShowCars()
        {
            Console.WriteLine("\nLISTA SAMOCHODÓW");
            Console.WriteLine("-------------------");
            Console.WriteLine("Id | Model | Segment | Rodzaj paliwa | Cena za dobę");

            foreach (var car in cars)
            {
                Console.WriteLine(car.Id + " | " + car.Brand + " | " + car.Segment + " | " + car.Fuel + " | " + car.Price);
            }
        }
        
    }
}
