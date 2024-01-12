using API_Database.Models;

namespace API_Database.Services.Students;

public interface IStudentService
{
    List<Student> GetStudents();
    List<Student> AddStudent(string FstudentName, string LstudentName, string studentHobby);
    List<Student> DeleteStudent(string studentName);
   
}