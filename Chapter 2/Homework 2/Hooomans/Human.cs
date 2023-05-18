namespace Hooomans
{
    public class Human
    {
        private readonly string Name;
        private readonly int Age;
        public Human(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string IntroduceYourself()
        {
            return $"Hello my name is {Name} and I am {Age} years old.";
        }
    }
}
