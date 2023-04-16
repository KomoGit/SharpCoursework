 class Program
{
    public static void Main()
    {
        string name,lastName,age;

        Console.WriteLine("Insert your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Insert your last name: ");
        lastName = Console.ReadLine();
        if (IsValidNumber(name) || IsValidNumber(lastName))
        {
            Console.WriteLine("Cannot contain number");
            return;
        }
        Console.WriteLine("Insert your age: ");
        age = Console.ReadLine();
        if (!IsValidNumber(age))
        {
            Console.WriteLine("The age is invalid, use numbers 1 to 9");
            return;
        }
        else
        {
            string formattedName = MakeUppercase(name);
            string formattedLastName = MakeUppercase(lastName);
            string message = string.Format("My name is {0} {1} and I am {2} years old.", formattedName, formattedLastName,age);
            Console.WriteLine(message);
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
    static string MakeUppercase(string value)
    {
        if (value != "")
        {
            value = Char.ToUpper(value[0]) + value.Substring(1);
            return value;
        }
        else
        {
            return "Cannot be empty.";
        }             
    }
}

