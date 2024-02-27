namespace CarRental
{
    internal class Rental
    {
        
        public int ClientId { get; set; }
        public string ClientSegment { get; set; } = "mini";
        public string ClientFuel { get; set; } = "benzyna";
        public int Days { get; set; }

        public void GetInput()
        {
            var correctId = false;
            var tempId = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Podaj Id klienta");
                var userId = Console.ReadLine();

                if (!int.TryParse(userId, out tempId))
                {
                    Console.WriteLine("To nie jest liczba");
                    Console.WriteLine("Naciśnij enter");
                    Console.ReadLine();
                    continue;
                }
                correctId = Clients.CheckClientId(tempId);
            } while (!correctId);

            this.ClientId = tempId;
            //Console.WriteLine("Podałeś klienta o id" + this.clientId);
            //Console.ReadLine();

            if (Clients.IsFourYears(tempId))
            {

                while (true)
                {
                    ShowMenuSegment();
                    var userSegment = Console.ReadLine();
                    var correctSegment = Program.IsCorrectKey(userSegment);

                    while (!correctSegment)
                    {
                        Console.WriteLine("Podałeś nieprawidłowy segment");
                        Console.WriteLine("Naciśnij eneter");
                        Console.ReadLine();
                        Console.Clear();
                        ShowMenuSegment();
                        userSegment = Console.ReadLine();
                        correctSegment = Program.IsCorrectKey(userSegment);
                    }

                    if (userSegment.Equals("1"))
                    {
                        this.ClientSegment = "mini";
                    }
                    else if (userSegment.Equals("2"))
                    {
                        this.ClientSegment = "kompakt";
                    }
                    else if (userSegment.Equals("3"))
                    {
                        this.ClientSegment = "premium";
                    }
                    break;
                }
            }
            else
            {
                while (true)
                {
                    ShowMenuSegmentWithoutPremium();
                    var userSegment = Console.ReadLine();
                    var correctSegment = Program.IsCorrectKeyTwo(userSegment);

                    while (!correctSegment)
                    {
                        Console.WriteLine("Podałeś nieprawidłowy segment");
                        Console.WriteLine("Naciśnij eneter");
                        Console.ReadLine();
                        Console.Clear();
                        ShowMenuSegmentWithoutPremium();
                        userSegment = Console.ReadLine();
                        correctSegment = Program.IsCorrectKey(userSegment);
                    }

                    if (userSegment.Equals("1"))
                    {
                        this.ClientSegment = "mini";
                    }
                    else if (userSegment.Equals("2"))
                    {
                        this.ClientSegment = "kompakt";
                    }
                    else if (userSegment.Equals("3"))
                    {
                        this.ClientSegment = "premium";
                    }
                    break;
                }
            }
            while (true)
            {
                ShowMenuFuel();
                var userFuel = Console.ReadLine();
                var correctFuel = Program.IsCorrectKey(userFuel);

                while (!correctFuel)
                {
                    Console.WriteLine("Podałeś nieprawidłowy rodzaj paliwa");
                    Console.WriteLine("Naciśnij eneter");
                    Console.ReadLine();
                    Console.Clear();
                    ShowMenuFuel();
                    userFuel = Console.ReadLine();
                    correctFuel = Program.IsCorrectKey(userFuel);
                }

                if (userFuel.Equals("1"))
                {
                    this.ClientFuel = "benzyna";
                }
                else if (userFuel.Equals("2"))
                {
                    this.ClientFuel = "elektryczny";
                }
                else if (userFuel.Equals("3"))
                {
                    this.ClientFuel = "diesel";

                }
                break;
            }

            var correctDays = false;
            var tempDays = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Ile dni");
                var userDays = Console.ReadLine();

                if (!int.TryParse(userDays, out tempDays))
                {
                    Console.WriteLine("To nie jest liczba");
                    Console.WriteLine("Naciśnij enter");
                    Console.ReadLine();
                    continue;
                }
                
                if (tempDays > 0 && tempDays < 366)
                {
                    correctDays = true;
                }
                else if (tempDays < 1)
                {
                    Console.WriteLine("Podałeś liczbę ujemną");
                    Console.WriteLine("Naciśnij enter");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Możesz wypożyczyć samochód maksymalnie na rok");
                    Console.WriteLine("Naciśnij enter");
                    Console.ReadLine();
                }
            } while (!correctDays);

            this.Days = tempDays;
        }
        public static void ShowMenuSegment()
        {
            Console.Clear();
            Console.WriteLine("Podaj segment");
            Console.WriteLine("1 - mini");
            Console.WriteLine("2 - kompakt");
            Console.WriteLine("3 - premium");
           
        }

        public static void ShowMenuSegmentWithoutPremium()
        {
            Console.Clear();
            Console.WriteLine("Podaj segment");
            Console.WriteLine("1 - mini");
            Console.WriteLine("2 - kompakt");
            
        }


        public static void ShowMenuFuel()
        {
           Console.Clear();
           Console.WriteLine("Podaj rodzaj paliwa");
           Console.WriteLine("1 - benzyna");
           Console.WriteLine("2 - elektryczny");
           Console.WriteLine("3 - diesel");

        }

        public static void ShowRental(Car car,string name,double amount,int days)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("UMOWA NAJMU POJAZDU");
            Console.WriteLine("DATA ZAWARCIA" + DateTime.Now);
            Console.WriteLine("------------------");
            Console.WriteLine("WYNAJMUJĄCY: " + name);
            Console.WriteLine("RODZAJ POJAZDU: " + car.Brand);
            Console.WriteLine("RODZAJ PALIWA: " + car.Fuel);
            Console.WriteLine("RODZAJ SEGMENTU: " + car.Segment);
            Console.WriteLine("----------------");
            Console.WriteLine("DATA ZWROTU POJAZDU: " + DateTime.Now.AddDays(days));
            Console.WriteLine("OPŁATA: " + amount + "PLN");
            Console.WriteLine("Naciśnij enter");
            Console.Clear();
        }

    }
}
