namespace AnimalKingdom
{
    public class Animal
    {
        public string Name;

        public Animal(string name)
        {
            Name = name;
        }

        public virtual string Identify()
        {
            return "I am an animal";
        }
    }
}
