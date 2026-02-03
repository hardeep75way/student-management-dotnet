using StudentManagement.Data;
using StudentManagement.Models;
using StudentManagement.Services.Interfaces;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> GetAllStudents()
        {
            return StudentData.Students;
        }

        public List<Student> GetStudentsByCourse(string course)
        {
            return StudentData.Students
                .Where(s => s.Course == course)
                .ToList();
        }

        public Student? GetStudentById(int id)
        {
            return StudentData.Students
                .FirstOrDefault(s => s.Id == id);
        }

        public int GetTotalStudents(string? course)
        {
            return string.IsNullOrEmpty(course)
                ? StudentData.Students.Count
                : StudentData.Students.Count(s => s.Course == course);
        }
    }
}