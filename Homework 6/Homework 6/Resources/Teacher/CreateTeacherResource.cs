namespace Homework_6.Resources.TeacherResource
{
    public class CreateTeacherResource:BaseResource
    {
        public Guid? SchoolId { get; set; }
        public string? Subject { get; set; }
    }
}
