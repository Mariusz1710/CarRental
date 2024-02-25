namespace CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clients.CreateClients();

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

                
                var correct = Convert.ToInt32(correctKey);

                if (correct == 1)
                {
                    Clients.ShowClients();
                    Console.ReadLine();
                }

            } while (true);

            
        }
    }
}
