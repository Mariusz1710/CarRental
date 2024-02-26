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

                var correctKey = Menu.IsCorrectKey(userInput);

                while (!correctKey)
                {
                    Console.Clear();
                    Menu.ShowMenu();
                    userInput = Console.ReadLine();
                    correctKey = Menu.IsCorrectKey(userInput);
                }

                
                correct = Convert.ToInt32(userInput);

                if (correct == 1)
                {
                    Clients.ShowClients();
                    Cars.ShowCars();
                    Console.ReadLine();
                }

            } while (true);

            
        }
    }
}
