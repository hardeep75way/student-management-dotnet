using StudentManagement.DTO;
using StudentManagement.Models;

namespace StudentManagement.ViewModels
{
    public class StudentListViewModel
    {
        public List<StudentDTOs> Students { get; set; } = new List<StudentDTOs>();
        public List<string> Courses { get; set; } = new List<string>();
        public int TotalStudents { get; set; }
        public string SelectedCourse { get; set; } = string.Empty;
    }
}