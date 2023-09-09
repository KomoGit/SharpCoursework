namespace Homework_6.Resources.Student
{
    public class CreateStudentResource:BaseResource
    {
        public Guid? SchoolId { get; set; }
        public Guid? TeacherId { get; set; }
    }
}
