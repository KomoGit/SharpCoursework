using System;

namespace HomeworkFour{
    class Program{
        private static int userSelection;
        public static void Main(){
            Console.WriteLine("Insert what you wish to do: ");
            userSelection = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userSelection);
        }
    }

}