namespace Homework_Five.Model
{
    // Comes as internal by default. 
    partial class Human
    {
        private readonly string Name; //Private so they are only accessed via Constructor and Virtual Method.
        private readonly int Age; //Given these props won't be set aside from constructor, they are set to 'readonly'.
        //This ensures Human as a class cannot be created, you can only make classes that derive from this and use that.
        protected Human(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }
}
