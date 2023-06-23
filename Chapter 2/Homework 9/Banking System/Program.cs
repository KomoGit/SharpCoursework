namespace Banking_System
{
    class Program
    {
        static bool isActive = true;
        public static void Main(string[] args)
        {
            User_Command_Interface.StartApplication(ref isActive);
        }
    }
}