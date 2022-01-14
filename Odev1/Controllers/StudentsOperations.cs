using Microsoft.AspNetCore.Mvc;
using Odev1.Model;


namespace Odev1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsOperationsController : ControllerBase
    {
        //Defining global variables
        List<Student> resultList = new List<Student>();
        Result result=new Result();
        LoggerCls logCls = new LoggerCls();
      

        [HttpGet]
        //Show list of all students
        public List<Student> getStudents()
        {
            //Filling the list of students
            resultList = AddUser();
            //Sending back the list of students

            //Save process to Logging file
            logCls.CreateLog("Bütün öğrencilerin listesi görüntülendi");
            return resultList;

        
        }

        [HttpGet("{id}")]
        //Show only the student whose id is specified
        public Student getStudent(int id)
        {
            
            resultList = AddUser();
            Student student = new Student();
            //Find specified student with id
            student = resultList.FirstOrDefault(x => x.StudentId == id);
            //Save process to Logging file
            logCls.CreateLog(id + " nolu öğrencinin bilgileri görüntülendi");
            return student; 

      
        }
        
        [HttpPost]
        //Add student to list
        public Result PostStudents(Student ogr)
        {
            //Filling the list of students
            resultList = AddUser();

            //Is the student we want to add on the list?
            bool control = resultList.Select(x => x.StudentId == ogr.StudentId).FirstOrDefault();
            //if answer is "NO" add student to the list
            if(control==false)
            {
               
                resultList.Add(ogr);
                result.status = 1;
                result.message = "Listeye ogrenci basariyla eklendi";

                //Save process to Logging file
                logCls.CreateLog(ogr.StudentId + " nolu ogrenci listeye başarıyla eklendi");
            }
            // return failed message and all list of students
            else
            {
                result.status = 0;
                result.message = "Ekleme basarisiz";
                result.students = resultList;
            }
               

            return result;

        }

        [HttpPut("{id}")]
        //Update the information of the student whose id is specified in the list
        public Result UpdateStudent(Student newValue, int id)
        {
            //Filling the list of students
            resultList = AddUser();

            //Find student with specified id
            //student may not be on the list
            Student? oldValue=resultList.Find(y=>y.StudentId ==id);
            if(oldValue!=null)
            {
                //if student on the list update student's unformation 
                result.status = 1;
                result.message = "öğrenciler listesi basariyla guncellendi";
                result.students = resultList;

                //Save process to Logging file
                logCls.CreateLog(id + " nolu ogrencinin bilgileri ve " + result.message);
            }
            else
            {
                //else return failed message
                result.status = 0;
                result.message = "Bilgisini guncellemek istediginiz ogrenci listede bulunamadi";
            }
            return result;
           
        }

        [HttpDelete("{id}")]
        //Delete the information of the student whose id is specified in the list
        public Result DeleteStudent(int id)
        {
            //Filling the list of students
            resultList = AddUser();

            //Find student with specified id
            //student may not be on the list
            Student? deletedValue=resultList.Find(y=>y.StudentId==id);
            if (deletedValue != null)
            {
                //if student on the list delete student's information from list
                resultList.Remove(deletedValue);
                result.status = 1;
                result.message = "Ogrenci başarıyla silindi";
                result.students = resultList;
                logCls.CreateLog(id + " nolu " + result.message);
                
               

            }
            else
            {
                //else return failed message
                result.status = 0;
                result.message = "Bilgisini guncellemek istediginiz ogrenci listede bulunamadi";
            }
            return result;
            
        }
       
        //fuction which filling students' information
        //use this function if you don't have database 
        public List<Student> AddUser()
        {
            List<Student> lst = new List<Student>();
            lst.Add(new Model.Student { StudentId = 1, Name = "Aizat", Surname = "Esenbekova", Age = 20 });
            lst.Add(new Model.Student { StudentId = 2, Name = "Dilara", Surname = "Sahin", Age = 21 });
            lst.Add(new Model.Student { StudentId = 3, Name = "Duygu", Surname = "Koc", Age = 19 });
            lst.Add(new Model.Student { StudentId = 4, Name = "Selin", Surname = "Yilmaz", Age = 25 });
            return lst;
        }
    }
}