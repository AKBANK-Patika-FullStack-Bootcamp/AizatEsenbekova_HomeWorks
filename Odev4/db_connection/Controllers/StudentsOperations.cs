using Microsoft.AspNetCore.Mvc;
using DAL.Model;
using Entities;
using Microsoft.AspNetCore.Authorization;

namespace db_connection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsOperationsController : ControllerBase
    {
        List<Student> resultList = new List<Student>();
        StudentsDbOperations dboperations= new StudentsDbOperations();
      
        [Authorize]
        [HttpGet]
        //Get list of all students
        public List<Student> GetStudents()
        {
            return dboperations.getStudents();
        }


        //paging- get just some students by size
        [HttpGet("GetStudentPaging")]
        public IActionResult GetUserPaging([FromQuery] OwnerParameters ownerParameters)
        {
            var owners = dboperations.getStudents() //all students on students table
                                                
           .Skip(ownerParameters.PageNumber) //from which row
           .Take(ownerParameters.PageSize) //by given size, Ex: 3:2
           .ToList();


            return Ok(owners);
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