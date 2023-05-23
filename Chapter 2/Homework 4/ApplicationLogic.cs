using HomeworkFour;

namespace Homework_4
{
    internal class ApplicationLogic
    {
        private bool isRunning = true;

        public void ApplicationRun()
        {
            while (isRunning)
            {
                Console.WriteLine("Insert what you wish to do: ");
                ProcessUserInput(ConvertUserInput(userInput: Console.ReadLine()));
            }
        }

        public static int ConvertUserInput(dynamic userInput)
        {
            try
            {
                int userSelection = Convert.ToInt32(userInput);
                return userSelection;
            }
            catch(FormatException)
            {
                return 999;//This is an invalid input so it will resume usual program processes.
            }        
        }

        public void ProcessUserInput(int input)
        {
            switch (input)
            {
                case 0:
                    Console.WriteLine("Shutting down!");
                    isRunning = false;
                    break;
                case 1:
                    Console.WriteLine("First Input");
                    //phone.ShowInfo();
                    break;
                case 2:
                    Console.WriteLine("Second Input");
                    //store.SellItem();
                    break;
                case 3:
                    Console.WriteLine("Third Input");
                    break;
                case 4:
                    Console.WriteLine("Fourth Input");
                    break;
                case 5:
                    Console.WriteLine("Fifth Input");
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
    }
}
