namespace Homework_Five.Model
{
    //Splitting the class in two, allowing the helper methods and props / constructor to be in its own respective cs files.
    partial class Human
    {
        //Making this method public allows anyone to call it. Although we can make it protected as well to limit who can call it.
        public virtual string IntroduceYourself()
        {
            return $"Hello my name is {Name}, I am {Age} years old.";
        }
    }
}
