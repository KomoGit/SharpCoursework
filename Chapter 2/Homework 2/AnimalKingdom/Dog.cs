namespace AnimalKingdom
{
    public class Dog :Animal
    {
        public string FurColor 
        {   
            get 
            {
                return FurColor;
            } 
            set 
            { 
                FurColor = value;
            } 
        }
        public Dog() : base("Waffle")
        {

        }
        public override string Identify()
        {
            return "I am a dog";
        }
    }
}
