using DAL.Model;
using Microsoft.AspNetCore.Mvc;
namespace db_connection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsOperations : ControllerBase
    {
        List<Student> resultList= new List<Student>();
        [HttpGet]
        public List<Student> GetStudents()
        {
            resultList = AddStudents();
            return resultList;
        }
        [HttpPost]
        public List<Student> AddStudents()
        {
            List<Student>lst = new List<Student>();
            lst.Add(new Student { Id = 1, Name= "Aizat", LastName= "Esen", Age= 21,AddressId= 1,GuideId= 1 });
            lst.Add(new Student { Id = 2, Name = "Ela", LastName = "Presen", Age = 23, AddressId = 2, GuideId = 3 });
            return lst;
        }
    }
}
