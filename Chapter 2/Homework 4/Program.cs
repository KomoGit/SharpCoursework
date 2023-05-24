using Homework_4;

namespace HomeworkFour
{
    class Program
    {
        private static readonly ApplicationLogic appLogic = new ApplicationLogic();//What is this dart? Why do i have to do null check?
        public static void Main(string[] args)
        {
            appLogic.ApplicationRun();
        }
    }
}