namespace Hooomans
{
    public class Teacher : Human
    {
        private readonly string Subject;
        public Teacher(string name,int age,string subject):base(name,age)
        {
            Subject = subject;
        }

        public override string IntroduceYourself()
        {
            return $"{base.IntroduceYourself()} I work as a {Subject} teacher!";
        }
    }
}
