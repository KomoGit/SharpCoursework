namespace Hooomans
{
    public class Developer : Human
    {
        private readonly string FavoriteLanguage;

        public Developer(string name,int age,string favlang):base(name,age)
        {
            FavoriteLanguage = favlang;
        }
        public override string IntroduceYourself()
        {
            return $"{base.IntroduceYourself()} I work as a developer, my favorite language is : {FavoriteLanguage}";
        }
    }
}
