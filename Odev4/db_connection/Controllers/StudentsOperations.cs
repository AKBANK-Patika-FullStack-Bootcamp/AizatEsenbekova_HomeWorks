using Microsoft.AspNetCore.Mvc;
using DAL.Model;
using Entities;

namespace db_connection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsOperationsController : ControllerBase
    {
        List<Student> resultList = new List<Student>();
        StudentsDbOperations dboperations= new StudentsDbOperations();
      
        [HttpGet]
        //Get list of all students
        public List<Student> GetStudents()
        {
            return dboperations.getStudents();
        }

        [HttpGet("{id}")]
        //get one specific student
        public Student GetStudent(int id)
        {
            return dboperations.getStudent(id);
        }

        [HttpPost]
        //add student to database
        public String AddStudent(Student student)
        {
           String message=dboperations.addStudent(student);
           return message;
        }

        //update student's information by id
        [HttpPut("{id}")]
        public String UpdateStudent(Student newValue, int id)
        {
            String message=dboperations.updateStudent(newValue, id);
            return message;
        }

        //delete student from database
        [HttpDelete("{id}")]
        public String DeleteStudent(int id)
        {
            String message=dboperations.deleteStudent(id);
            return message;
        }

  
    }
}