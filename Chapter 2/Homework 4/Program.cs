using Homework_4;

namespace HomeworkFour
{
    class Program
    {
        //private static int userSelection;
        //private static bool isRunning = true;
        private static readonly ApplicationLogic appLogic = new ApplicationLogic();
        public static void Main(string[] args)
        {
            appLogic.ApplicationRun();
        }
    }
}