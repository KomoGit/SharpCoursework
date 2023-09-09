using AutoMapper;
using Homework_6.Models;
using Homework_6.Resources;
using Homework_6.Resources.Student;
using Homework_6.Resources.School;
using Homework_6.Resources.TeacherResource;

namespace Homework_6.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateStudentResource, Student>();
            CreateMap<Student, StudentResource>();
            CreateMap<CreateSchoolResource, School>();
            CreateMap<School, SchoolResource>();
            CreateMap<CreateTeacherResource, Teacher>();
            CreateMap<Teacher, TeacherResource>();
        }
    }
}
