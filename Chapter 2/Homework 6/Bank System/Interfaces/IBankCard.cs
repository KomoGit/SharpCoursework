namespace Bank_System.Interfaces
{
    public interface IBankCard
    {
        int ProcessPayment(int fee);
        int CheckBalance();
    }
}
