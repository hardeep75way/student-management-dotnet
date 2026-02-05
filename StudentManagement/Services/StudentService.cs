using StudentManagement.Data;
using StudentManagement.DTO;
using StudentManagement.Mappings;
using StudentManagement.Models;
using StudentManagement.Services.Interfaces;

namespace StudentManagement.Services
    
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        
        public List<StudentDTOs> GetAllStudents()
        {
            var students = _studentRepository.GetAllStudents();
            
            return students.Select(StudentMapper.ToDto).ToList();

        }

        public List<StudentDTOs> GetStudentsByCourse(string course)
        {
            var students = _studentRepository.GetStudentByCourse(course);
            return students
                .Select(StudentMapper.ToDto)
                .ToList();
        }

        public StudentDTOs? GetStudentById(int id)
        {
            var student = _studentRepository.GetStudentById(id);

            if (student == null)
            {
                return null;
            }

            return StudentMapper.ToDto(student);

        }

        public int GetTotalStudents(string? course)
        {
            if (string.IsNullOrEmpty(course))
                return _studentRepository.GetAllStudents().Count;

            return _studentRepository.GetStudentByCourse(course).Count;
        }

        public void AddStudent(StudentDTOs studentDto)
        {
            var student = StudentMapper.ToEntity(studentDto);

            _studentRepository.AddStudent(student);

            _studentRepository.Save();
        }


        public void UpdateStudent(StudentDTOs studentDto)
        {
            var student = StudentMapper.ToEntity(studentDto);

            _studentRepository.UpdateStudent(student);

            _studentRepository.Save();
            
        }

        public void DeleteStudent(int id)
        {
            var student = _studentRepository.GetStudentById(id);

            if (student == null)
                return;

            _studentRepository.DeleteStudent(student.Id);

            _studentRepository.Save();
            
        }
        
    }
}