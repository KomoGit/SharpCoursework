namespace Practice_2
{
    public class Student
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Group { get;private set; }
        public float GPA { get; private set; }
        private readonly bool HasGraduated = false;

        public Student(string name,string surname,string group,float gpa,bool hasGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            GPA = gpa;
            HasGraduated = hasGraduated;
        }

        public string GetStudentInfo()
        {
            return $"{Name} {Surname} {Group} {GPA} {HasGraduated}";
        }

        public string GetDiplomaDegree()
        {
            if (GPA > 90) return "With honors";
            return "Lol loser, couldn't even graduate with honors";
        }

        public bool HasStudentGraduated()
        {
            return HasGraduated;    
        }
    }
}
