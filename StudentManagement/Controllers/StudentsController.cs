using Microsoft.AspNetCore.Mvc;
using StudentManagement.DTO;
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
            

            return View(model);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
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
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
public IActionResult Create([FromBody] StudentDTOs dto)
{
    if (!ModelState.IsValid) return BadRequest(ModelState);
    _studentService.AddStudent(dto);
    return Ok();
}
    
    [HttpPost]
    public IActionResult Update(StudentDTOs dto)
    {
        _studentService.UpdateStudent(dto);

        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult Delete(int id)
    {
        _studentService.DeleteStudent(id);

        return RedirectToAction("Index");
    }


}
