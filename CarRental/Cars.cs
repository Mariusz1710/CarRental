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
            cars.Add(new Car(1, "Skoda Citigo", "mini", "benzyna", true, 70));
            cars.Add(new Car(2, "Toyota Aygo", "mini", "benzyna", true, 90));
            cars.Add(new Car(3, "Fiat 500", "mini", "elektryczny", true, 110));
            cars.Add(new Car(4, "Ford Focus", "kompakt", "diesel", true, 160));
            cars.Add(new Car(5, "Kia Ceed", "kompakt", "benzyna", true, 150));
            cars.Add(new Car(6, "Volkswagen Golf", "kompakt", "benzyna", true, 160));
            cars.Add(new Car(7, "Hyundai Kona Electric", "kompakt","elektryczny", true, 180));
            cars.Add(new Car(8, "Audi A6 Allroad", "premium","diesel", true, 290));
            cars.Add(new Car(9, "Mercedes E270 AMG", "premium","benzyna", true, 320));
            cars.Add(new Car(10, "Tesla Model S", "premium","elektryczny", true, 350));
        }

        public static void ShowCars()
        {
            Console.WriteLine("\nLISTA SAMOCHODÓW");
            Console.WriteLine("-------------------");
            Console.WriteLine("Id | Model | Segment | Rodzaj paliwa | Cena za dobę");

            foreach (var car in cars)
            {
                Console.WriteLine(car.Id + " | " + car.Brand + " | " + car.Segment + " | " + car.Fuel + " | " + car.Price + " PLN");
            }

            Console.WriteLine("\nNaciśnij Enter, aby kontynuować");
        }

        public static void CheckAvailable(Rental ren)
        {
            foreach (var car in cars)
            {
                if ((car.Segment.Equals(ren.ClientSegment)) && (car.Fuel.Equals(ren.ClientFuel)) && car.Available)
                {
                    var amount = CalculateAmount(car, ren);
                    var days = Clients.CalculateDays(ren);
                    var client = Clients.GetName(ren.ClientId);
                    Rental.ShowRental(car, client, amount, days);
                    car.Available = false;
                    //Console.WriteLine(car.Brand);
                    Console.WriteLine("\nNACIŚNIJ ENTER, ABY KONTYNUOWAĆ");
                    Console.ReadLine();
                    return;
                }
            }
            ShowNotAvailable();
        }

        public static double CalculateAmount(Car car, Rental ren)
        {
            var price = car.Price;
            var days = ren.Days;

            var amount = (double)price * days;

            if (!Clients.IsFourYears(ren.ClientId))
            {
                amount *= 1.2;
            }

            return amount;

        }

        public static void ShowNotAvailable()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIESTETY BRAK JEST SAMOCHODÓW O PODANYCH KRYTERIACH");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nNACIŚNIJ ENTER, ABY KONTYUOWAĆ");
            Console.ReadLine();
        }
    }
}
