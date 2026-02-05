using StudentManagement.DTO;
using StudentManagement.Models;

namespace StudentManagement.Mappings;

public static class StudentMapper
{
    public static StudentDTOs ToDto(Student student)
    {
        return new StudentDTOs()
        {
            Id = student.Id,
            Name = student.Name,
            Course = student.Course,
            Marks = student.Marks,
        };
    }
    
    public static Student ToEntity(StudentDTOs dto)
    {
        return new Student
        {
            Id = dto.Id,
            Name = dto.Name,
            Course = dto.Course,
            Marks = dto.Marks
        };
    }
}