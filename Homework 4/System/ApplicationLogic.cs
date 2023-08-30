using HomeworkFour;

namespace Homework_4
{
    internal class ApplicationLogic
    {
        private static Phone ph1 = new Phone(id:"000AA","IPhone","XS Max",690,10);
        private static Phone ph2 = new Phone(id:"000AB","IPhone","13 Pro Max",700,10);
        private static Phone ph3 = new Phone(id:"000AC",name:"IPhone",model:"11 Pro Max",price:1000,count:25);
        private static Phone[] phones = new Phone[] {ph1,ph2,ph3};
        private Store str = new Store(name: "Bubu Store",PhonesArray: phones);
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

        public static int ConvertUserInput(string? userInput,int returnCode)
        {
            try
            {
                int userSelection = Convert.ToInt32(userInput);
                return userSelection;
            }
            catch(FormatException)
            {
                return returnCode;//By default we are giving out zero code but with this override we can give any code.
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
                    Console.WriteLine("Get All Phones Information.");
                    str.GetAllPhones();       
                    break;
                case 2:
                    Console.WriteLine("Sell phone from store.");
                    SellItem();
                    break;
                case 3:
                    Console.WriteLine("Get phone in price range (MAX PRICE)");
                    FindItemWithMaxPrice();
                    break;
                case 4:
                    Console.WriteLine("Get phone in price range (MIN PRICE) (MAX PRICE)");
                    FindItemMinMax();
                    break;
                case 5:
                    Console.WriteLine("Remove Phone from Store");
                    RemoveItemFromStore();
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
        private void FindItemMinMax()
        {
            try
            {
                Console.WriteLine("Insert Min Price");
                string? MinPrice = Console.ReadLine()!;
                System.Console.WriteLine("Insert Max Price");
                string? MaxPrice = Console.ReadLine()!; 
                str.GetPhoneInRange(Convert.ToDecimal(MinPrice),Convert.ToDecimal(MaxPrice));   
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void RemoveItemFromStore(){
            str.GetAllPhones();
            Console.WriteLine("Insert phone ID");
            string? userIDInput = Console.ReadLine()!;
            str.RemovePhone(userIDInput);
            str.GetAllPhones();
        }
        private void SellItem()
        {
            try
            {
                Console.WriteLine("Insert phone ID");
                string? userIDInput = Console.ReadLine();
                Console.WriteLine("Insert count");
                string? userCountInput = Console.ReadLine();
                int b = ConvertUserInput(userInput: userCountInput!,2);
                string a = userIDInput!;
                str.SellItem(id: a,count: b);
                Console.WriteLine(str.Revenue);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void FindItemWithMaxPrice()
        {
            try
            {
                string? userMaxPrice = Console.ReadLine();
                int a = ConvertUserInput(userMaxPrice);
                str.GetPhoneInRange(a);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
