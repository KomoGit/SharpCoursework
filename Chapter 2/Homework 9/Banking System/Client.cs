using System.Transactions;

namespace Banking_System
{
    internal class Client
    {
        private static int GlobalId;
        public int Id { get; set; } = 0;
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public BankCard[] BankCards { get; set; }
        public int BankCardCount { get; set; }
        public float Balance { get; set; }


        private Client()
        {
            Id += GlobalId;
            BankCardCount = BankCards!.Length;
        }

        public Client(string name, string surname, float balance, BankCard[] cards):this()
        {
            Name =  name;
            Surname = surname;
            Balance = balance;
            BankCards = cards;
        }

        public void GetAllBankCards()
        {
            if (BankCards != null)
            {
                foreach (BankCard item in BankCards)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void AddBankCard(BankCard bankCard)
        {
            string[] temp = new string[BankCardCount];
            if (BankCards != null)
            {
                Array.Copy(GetAllBankCards, temp, BankCardCount - 1);
            }
            temp[BankCardCount - 1] = transaction;
        }

        public void GetBankCardByPan(string pan)
        {
            foreach (BankCard item in BankCards)
            {
                if(item.PAN == pan)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    throw new Exception("Card cannot be found.");
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Balance}";
        }
    }
}
