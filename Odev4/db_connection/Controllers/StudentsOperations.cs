using DAL.Model;
using Microsoft.AspNetCore.Mvc;
namespace db_connection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsOperations : ControllerBase
    {
        List<Student> resultList = new List<Student>();
        [HttpGet]

        //return all students' list
        public List<Student> GetStudents()
        {
            resultList = AddStudents();
            return resultList;
        }
        //take student by id
        [HttpGet("{id}")]

        public Student getStudent(int id)
        {
            resultList = AddStudents();
            Student student = new Student();
            //find student
            student = resultList.FirstOrDefault(x => x.Id == id);
            return student;
        }


        [HttpPost]

        //fill students' list
        public List<Student> AddStudents()
        {
            List<Student>lst = new List<Student>();
            lst.Add(new Student { Id = 1, Name= "Aizat", LastName= "Esen", Age= 21,AddressId= 1,GuideId= 1 });
            lst.Add(new Student { Id = 2, Name = "Ela", LastName = "Presen", Age = 23, AddressId = 2, GuideId = 3 });
            return lst;
        }
    }
}
