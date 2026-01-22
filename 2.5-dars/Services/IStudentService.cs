using _2._5_dars.models;

namespace _2._5_dars.Services;

public interface IStudentService
{
    public Guid AddStudent { get; set; }
    public bool UpdateStudent { get; set; }
    public bool DeleteStudent { get; set; }
    public Student? GetStudentById { get; set; }
    public List<Student> GetAllStudents();
}
