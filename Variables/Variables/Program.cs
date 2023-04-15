 class Program
{
    public static void Main()
    {
        string userInput; //User input can never be null. Don't try to null check user input even if not initialized.
        Console.WriteLine("What is your age?");
        userInput = Console.ReadLine();
        if (IsValidNumber(userInput ?? ""))
        {
            string result = string.Format("Your age is {0}", userInput);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Please use numbers (1 to 9)");
        }       
    }

    static bool IsValidNumber (string value)
    {
        if(value != "")
        {
            return int.TryParse(value, out int result);
        }
        return false;       
    }
}

