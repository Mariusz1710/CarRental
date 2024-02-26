namespace CarRental
{
    internal class Rental
    {
        
        public int clientId { get; set; }
        public string clientSegment { get; set; } = "mini";
        public string clientFuel { get; set; } = "benzyna";
        public int days { get; set; }

        public void GetInput()
        {
            var correctId = false;
            var tempId = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Podaj Id klienta");
                var userId = Console.ReadLine();
                int a;
                if (!int.TryParse(userId,out tempId))
                {
                    Console.WriteLine("To nie jest liczba");
                    Console.WriteLine("Naciśnij enter");
                    Console.ReadLine();
                    continue;
                }
                correctId = Clients.CheckClientId(tempId);
            } while (!correctId);

            this.clientId = tempId;
            Console.WriteLine("Podałeś klienta o id" + this.clientId);
            Console.ReadLine();

        }

        

        
    }
}
