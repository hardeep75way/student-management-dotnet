using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models;

public class Student
{
    public int Id { get; set; }
    [MaxLength(250)]
    public string Name { get; set; } = string.Empty;
    [MaxLength(250)]
    public string Course { get; set; } = string.Empty;
    public int Marks { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public string UpdatedBy { get; set; } = string.Empty;
}