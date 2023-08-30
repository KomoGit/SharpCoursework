using System;
using System.Collections.Generic;

namespace SchoolSystem.Model
{
    public class Classroom
    {
        public int Id { get; set; }
        public Teacher Teacher;
        private readonly List<Student> Students = new List<Student>();

        public Classroom(int id, Teacher teacher,List<Student>students)
        {
            Id = id;
            Teacher = teacher;
            Students = students;          
        }

        public string GetTeacherFullName()
        {
            return Teacher.GetFullName();
        }

        public List<Student> GetAllStudents()
        {
            
            if(Students == null) return Students;
            throw new Exception("No students available in this class");
        }
    }
}
