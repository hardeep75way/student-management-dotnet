using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.Services.Interfaces;
using StudentManagement.ViewModels;

namespace StudentManagement.Controllers;

public class StudentsController : Controller
{
    
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }
    
    [HttpGet]
    public IActionResult Index(string course = "")
    {
        try
        {
            var allStudents = _studentService.GetAllStudents();

            var students = string.IsNullOrEmpty(course)
                ? allStudents
                : _studentService.GetStudentsByCourse(course);
            
            var model = new StudentListViewModel
            {
                Students = students,
                Courses = allStudents
                    .Select(s => s.Course)
                    .Distinct()
                    .ToList(),
                
                TotalStudents = students.Count,
                SelectedCourse = course
            };
            
            Console.WriteLine();

            return View(model);
        }
        catch (Exception ex)
        {
            ViewBag.ErrorMessage = ex.Message;
            return View("Error");
        }
    }
    
    [HttpGet]
    public IActionResult Details(int id)
    {
        try
        {

            var student = _studentService.GetStudentById(id);

            if (student == null)
                return BadRequest("Student Not Found");

            return View(student);
        }
        catch (Exception ex)
        {
            ViewBag.ErrorMessage = ex.Message;
            return View("Error");
        }
    }
}
