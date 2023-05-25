using HomeworkFour;

namespace Homework_4
{
    internal class ApplicationLogic
    {
        private Phone ph1 = new Phone(id:"000AA","IPhone","XS Max",690,10);
        private Phone ph2 = new Phone(id:"000AB","IPhone","13 Pro Max",1000,10);
        private Phone ph3 = new Phone(id:"000AC",name:"IPhone",model:"11 Pro Max",price:1000,count:25);

        private bool isRunning = true;
        public void ApplicationRun()
        {
            while (isRunning)
            {
                Console.WriteLine("Insert what you wish to do: ");
                string? userInput; //Ensuring it is nullable so ReadLine() would stop annoying me.
                userInput = Console.ReadLine();
                ProcessUserInput(ConvertUserInput(userInput: userInput));
            }
        }

        public static int ConvertUserInput(string? userInput)
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
                    Console.WriteLine("Get Phone Information.");
                    Console.WriteLine(ph1.ShowInfo());       
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
