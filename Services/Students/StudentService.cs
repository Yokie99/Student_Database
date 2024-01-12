using API_Database.Data;
using API_Database.Models;

namespace API_Database.Services.Students;


public class StudentService : IStudentService
{
    private readonly DataContext _db;

    public StudentService(DataContext db)
    {
        _db = db;
    }

    public List<Student> AddStudent(string FstudentName, string LstudentName, string studentHobby)
    {
        Student newStudent = new(); 
        newStudent.FirstName = FstudentName;
        newStudent.LastName = LstudentName;
        newStudent.Hobby = studentHobby;

        _db.Students.Add(newStudent); // Adding the newStudent to the Students table on our Database
        _db.SaveChanges(); // Saving the Database changes

        return _db.Students.ToList(); // Returning our Students table as a List
    }

    public List<Student> DeleteStudent(string studentName)
    {
        var foundStudent = _db.Students.FirstOrDefault(student => student.FirstName == studentName);
        if(foundStudent != null) {
            _db.Students.Remove(foundStudent);
            _db.SaveChanges();
        }
        return _db.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _db.Students.ToList();
    }

}