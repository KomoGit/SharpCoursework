namespace Banking_System
{
    internal class Bank
    {
        public Client[] Clients { get; set; }
        public int ClientCount { get; set; } = 0;


        public Bank()
        {
            Clients = new Client[0];
        }

        public void AddClient(Client client)
        {
            var temp = new Client[++ClientCount];
            if (Clients != null)
            {
                Array.Copy(Clients, temp, ClientCount - 1);
            }
            temp[ClientCount - 1] = client;
            Clients = temp;
        }



        public void ShowAllClient()
        {
            foreach (Client client in Clients)
            {
                Console.WriteLine(client);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public BankCard GetCardByPan(string pan)
        {
            pan = pan.Replace(" ", "");
            foreach (var client in Clients)
            {
                foreach (var card in client.BankCards)
                {
                    if (card.PAN.Replace(" ", "") == pan)
                    {
                        return card;
                    }
                }
            }
            throw new Exception("User by that PAN could not be found.");
        }

        public Client GetClientByPan(string pan)
        {
            pan = pan.Replace(" ", "");
            foreach (Client client in Clients)
            {
                if (GetCardByPan(pan).PAN == pan)
                {
                    return client;
                }
            }
            throw new Exception("User by that PAN could not be found.");
        }

        public void ShowBalance(Client client, string Pan)
        {
            string pan = Pan.Replace(" ", "");
            if(client != null)
            {
                BankCard card = GetCardByPan(pan);
                if (card != null)
                {
                    Console.WriteLine(client.Balance);
                }
            }
        }
    }
}
