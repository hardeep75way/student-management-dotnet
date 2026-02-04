using StudentManagement.Data;
using StudentManagement.DTO;
using StudentManagement.Models;
using StudentManagement.Services.Interfaces;

namespace StudentManagement.Services
    
{
    public class StudentService : IStudentService
    {
    private static StudentDTOs MapToDto(Student student)
    { 
        return new StudentDTOs
    {
        Id = student.Id,
        Name = student.Name,
        Course = student.Course,
        Marks = student.Marks,
        CreatedAt = student.CreatedAt,
        UpdatedAt = student.UpdatedAt
    };
}
        public List<StudentDTOs> GetAllStudents()
        {
            return StudentData.Students
                .Select(MapToDto)
                .ToList();
        }

        public List<StudentDTOs> GetStudentsByCourse(string course)
        {
            return StudentData.Students
                .Select(MapToDto)
                .Where(s => s.Course == course)
                .ToList();
        }

        public StudentDTOs? GetStudentById(int id)
        {
            return StudentData.Students
                .Select(MapToDto)
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