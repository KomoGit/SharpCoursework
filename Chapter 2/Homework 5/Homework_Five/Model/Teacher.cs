namespace Homework_Five.Model
{
    internal class Teacher:Human
    {
        private string _subject;
        //Public allows _subject to be changed anytime.
        public string Subject 
        { 
            get 
            { 
                return _subject; 
            } 
            set 
            { 
                _subject = value; 
            } 
        }

        public Teacher(string name,int age,string subject):base(name: name, age: age)
        {
            _subject = subject;
        }

        public override string IntroduceYourself()
        {
            return $"{base.IntroduceYourself()} I am a {_subject} teacher.";
        }
    }
}
