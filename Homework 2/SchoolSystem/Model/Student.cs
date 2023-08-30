using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Model
{
    public class Student : Person
    {
        public string Name { get;set; }
        public string Surname { get;set; }
        public int Age { get;set; }
        private readonly bool Gender;

        public Student(string name,string surname,int age,bool gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        public string GetStudentGender()
        {
            if (Gender)
            {
                return "Male";
            }
            return "Female";
        }

        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }
    }
}
