using Bank_System.Interfaces;

namespace Bank_System.Model
{
    public class Visa : IBankCard
    {
        private int _balance = 10;
        public int CheckBalance()
        {
            return _balance;
        }

        public int ProcessPayment(int fee)
        {
            return _balance -= fee;
        }
    }
}
