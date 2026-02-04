using StudentManagement.Models;

namespace StudentManagement.Services.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        List<Student> GetStudentsByCourse(string course);
        Student? GetStudentById(int id);
        int GetTotalStudents(string? course);
    }
}