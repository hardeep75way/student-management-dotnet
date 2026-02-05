using StudentManagement.Data;
using StudentManagement.Models;
using StudentManagement.Services.Interfaces;

namespace StudentManagement.Repository;

public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _context;

    public StudentRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Student> GetAllStudents()
    {
        return _context.Students.ToList();
    }

    public Student? GetStudentById(int id)
    {
       
            return _context.Students.Find(id);

        
    }

    public List<Student> GetStudentByCourse(string course)
    {
        return _context.Students
            .Where(s => s.Course == course)
            .ToList();
    }
    public void AddStudent(Student student)
    {
        _context.Students.Add(student);
    }

    public void UpdateStudent(Student student)
    {
        _context.Students.Update(student);
    }

    public void DeleteStudent(int id)
    {
        var student = _context.Students.Find(id);
        if (student != null)
        {
            _context.Students.Remove(student);
        }
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}