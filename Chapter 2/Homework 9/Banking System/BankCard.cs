namespace Banking_System
{
    internal class BankCard
    {
        private readonly string BankName = string.Empty;
        public readonly string PAN = string.Empty;
        private int _pin;
        public int PIN
        {
            get
            {
                return _pin;
            } 
            set 
            { 
                if(value == 4)
                {
                    _pin = value;
                }
            } 
        }
        private int _cvc;
        public int CVC 
        {
            get
            {
                return _cvc;
            }
            private set 
            {
                if(value == 3)
                {
                    _cvc = value;
                }
            } 
        }
        public DateTime Date { get; private set; } = default;

        public string[] AllTransactions { get; set; }
        private readonly int TransactionCount;

        private BankCard()
        {
            TransactionCount = AllTransactions!.Length;
            Date = DateTime.Now;
        }

        public BankCard(string bankname, string pan, int pin, int cvc):this()
        {
            BankName = bankname;
            PAN = pan;
            CVC = cvc;
            PIN = pin;
        }

        public void AddTransaction(string transaction)
        {
            string[] temp = new string[TransactionCount];
            if(AllTransactions != null)
            {
                Array.Copy(AllTransactions, temp, TransactionCount - 1);
            }
            temp[TransactionCount - 1] = transaction;
        }

        public void GetAllTransactions()
        {
            foreach (string item in AllTransactions)
            {
                Console.WriteLine(item);
            }
        }

        public override string ToString()
        {
            return $"{BankName} {PAN} {PIN} {CVC} {Date}";
        }

        public void Withdraw(ref int balance, int withdrawalAmount)
        {
            if(balance != 0)
            {
                if (balance > withdrawalAmount)
                {
                    balance -= withdrawalAmount;
                    Console.WriteLine($"You have {balance} in your bank account");
                }
            }
            else
            {
                throw new Exception("Insufficent amount in balance.");
            }
        }
    }
}