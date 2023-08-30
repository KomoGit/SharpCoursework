using NUnit.Framework;
using SchoolSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Tests
{
    [TestFixture]
    public class TestStudent
    {
        private Student student = new Student("James","Clyde",14,true);
        private Student student2 = new Student("Jane", "Clyde", 15, false);
        [TestCase]
        public void TestGetStudentFullName()
        {
            string expected = "James Clyde";
            Assert.AreEqual(expected,student.GetFullName());
        }
        [TestCase]
        public void TestGetStudentGender()
        {
            string expected = "Female";
            Assert.AreEqual(expected,student2.GetStudentGender());
        }
    }
    public class TestTeacher
    {
        Teacher teacher = new Teacher("Megan","Idunno","History");
        [TestCase]
        public void TestGetTeacherFullName()
        {
            string expected = "Megan Idunno";
            Assert.AreEqual(expected, teacher.GetFullName());
        }
    }
    public class TestClassroom
    {
        private readonly Student student = new Student("James", "Clyde", 14, true);
        private readonly Student student2 = new Student("Jane", "Clyde", 15, false);
        static readonly Teacher teacher = new Teacher("Megan", "Idunno", "History");
        static readonly List<Student> students = new List<Student>();
        Classroom room = new Classroom(15, teacher: teacher, students);

        [TestCase]
        public void TestGetAllStudents()
        {
            students.Add(student);
            students.Add(student2);
            Assert.AreEqual(students,room.GetAllStudents());
        }
        [TestCase] 
        public void TestGetAllStudentsEmpty()
        {
            Classroom room = new Classroom(15, teacher, students);
            Assert.Throws<Exception>(() => room.GetAllStudents());
        }
        [TestCase] 
        public void TestGetTeacherFullName()
        {
            string expected = "Megan Idunno";
            Assert.AreEqual(expected,room.GetTeacherFullName());
        }

    }
}
