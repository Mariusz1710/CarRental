namespace CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clients.CreateClients();
            Cars.CrateCars();
            int correct = 0;

            do
            {
                Console.Clear();
                Menu.ShowMenu();
                var userInput = Console.ReadLine();

                var correctKey = IsCorrectKey(userInput);

                while (!correctKey)
                {
                    Console.Clear();
                    Menu.ShowMenu();
                    userInput = Console.ReadLine();
                    correctKey = IsCorrectKey(userInput);
                }

                
                correct = Convert.ToInt32(userInput);

                if (correct == 1)
                {
                    Clients.ShowClients();
                    Cars.ShowCars();
                    Console.ReadLine();
                }
                else if (correct == 2)
                {
                    var rental = new Rental();
                    rental.GetInput();
                    Cars.CheckAvailable(rental);
                }
                else if (correct == 3)
                {
                    Console.Clear();
                    Console.WriteLine("DZIĘKUJEMY ZA SKORZYSTANIE Z NASZEJ WYPOŻYCZALNI");
                    Console.WriteLine("ZAPRASZAMY PONOWNIE");
                    Environment.Exit(0);
                }

            } while (true);

            
        }

        public static bool IsCorrectKey(string input)
        {
            var acceptedKeys = new List<string>() { "1", "2", "3" };
            return acceptedKeys.Contains(input);
        }

        public static bool IsCorrectKeyTwo(string input)
        {
            var acceptedKeys = new List<string>() { "1", "2"};
            return acceptedKeys.Contains(input);
        }
    }
}
