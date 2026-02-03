namespace StudentManagement.ViewModels
{
    public class StudentListViewModel
    {
        public List<StudentManagement.Models.Student> Students { get; set; }
        public List<string> Courses { get; set; }
        public int TotalStudents { get; set; }
        public string? SelectedCourse { get; set; }
    }
}