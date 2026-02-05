using StudentManagement.Models;

namespace StudentManagement.Services.Interfaces;

public interface IStudentRepository
{
    List<Student> GetAllStudents();
    Student? GetStudentById(int id);
    List<Student> GetStudentByCourse(string course);

    void AddStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(int id);

    void Save();
}