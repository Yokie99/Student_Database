using API_Database.Models;
using API_Database.Services.Students;
using Microsoft.AspNetCore.Mvc;

namespace API_Database.Controllers;

[ApiController] 
[Route("[controller]")] 

public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService; 

    public StudentController(IStudentService studentService) 
    {
        
        _studentService = studentService;
    }

    [HttpGet] 
    [Route("FetchQuest")] 
    public List<Student> GetStudents()
    {
        // Accessing the GetStudents() from our Interface
        return _studentService.GetStudents();
    }

    [HttpPost] 
    [Route("AddStudent/{FstudentName}/{LstudentName}/{studentHobby}")]     public List<Student> AddStudent(string FstudentName, string LstudentName, string studentHobby)
    {
        return _studentService.AddStudent(FstudentName, LstudentName, studentHobby);
    }

    [HttpDelete] 
    [Route("DeleteStudent/{studentName}")]
    public List<Student> DeleteStudent(string studentName)
    {
        return _studentService.DeleteStudent(studentName);
    }

}
