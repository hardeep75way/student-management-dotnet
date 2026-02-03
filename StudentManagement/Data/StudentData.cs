using StudentManagement.Models;

namespace StudentManagement.Data
{
    public static class StudentData
    {
        public static List<Student> Students = new()
        {
            new Student { Id = 1, Name = "Aman", Course = "BCA", Marks = 85 },
            new Student { Id = 2, Name = "Harsh", Course = "BTech", Marks = 92 },
            new Student { Id = 3, Name = "Rihan", Course = "MCA", Marks = 70 },
            new Student { Id = 4, Name = "Jashan", Course = "BTech", Marks = 95 }
        };
    }
}