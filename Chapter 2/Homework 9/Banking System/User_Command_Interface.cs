namespace Banking_System
{
    public class User_Command_Interface
    {
        public static void StartApplication(ref bool isRunning)
        {
            while (isRunning)
            {
                Console.WriteLine("Hello, press enter: ");
                string userInput = Console.ReadLine()!;
                InterpretUserInput(userInput);
            }
        }

        private static void InterpretUserInput(string Input)
        {
            char input = Convert.ToChar(Input.ToLower());
            switch (input)
            {
                case 'A':
                    Console.WriteLine(input);
                    break;
                case 'B':
                    Console.WriteLine(input);
                    break;
                case 'C':
                    Console.WriteLine(input);
                    break;
                case 'D':
                    Console.WriteLine(input);
                    break;
                case 'E':
                    Console.WriteLine(input);
                    break;
            }
        }
    }
}
