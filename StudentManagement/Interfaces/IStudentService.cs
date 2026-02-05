using StudentManagement.DTO;
using StudentManagement.Models;

namespace StudentManagement.Services.Interfaces
{
    public interface IStudentService
    {
        List<StudentDTOs> GetAllStudents();
        List<StudentDTOs> GetStudentsByCourse(string course);
        StudentDTOs? GetStudentById(int id);
        int GetTotalStudents(string? course);

        void AddStudent(StudentDTOs student);
        void UpdateStudent(StudentDTOs student);
        void DeleteStudent(int id);
    }
}