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

      /*

        [HttpPost]
        //Listeye ogrenci ekle
        public Result PostStudents(Student ogr)
        {
            //Liste dolduruluyor
            resultList = AddUser();
        
            //Eklemek istedigimiz ogrenci listede var mi?
            bool control = resultList.Select(x => x.StudentId == ogr.StudentId).FirstOrDefault();
            if(control==false)
            {
                //Listeye yeni ogrenci ekleniyor
                resultList.Add(ogr);
                result.status = 1;
                result.message = "Listeye ogrenci basariyla eklendi";
            }
            else
            {
                result.status = 0;
                result.message = "Ekleme basarisiz";
                result.students = resultList;
            }
               

            return result;

        }

        [HttpPut("{id}")]
        //Litedeki ogrencinin bilgilerini guncelle
        public Result UpdateStudent(Student newValue, int id)
        {
            resultList=AddUser();
            //Kullanici tarafindan idsi alinan ogrencini listeden buluyoruz
            Student ? oldValue=resultList.Find(y=>y.StudentId ==id);
            if(oldValue!=null)
            {
                //Eger ogrenci listede varsa bilgilerini guncelliyoruz
                resultList.Remove(oldValue); 
                resultList.Add(newValue);
                result.status = 1;
                result.message = "Ogrenciler listesi basariyla guncellendi";
                result.students = resultList;
            }
            else
            {
                result.status = 0;
                result.message = "Bilgisini guncellemek istediginiz ogrenci listede bulunamadi";
            }
            return result;
           
        }

        [HttpDelete("{id}")]
        //Listeden ogrenci sil
        public Result DeleteStudent(int id)
        {
            //her seferinde listeyi doldur
            resultList = AddUser();
            Student ? deletedValue=resultList.Find(y=>y.StudentId==id);
            if (deletedValue != null)
            {
                //Eger ogrenci listede varsa siliyoruz
                resultList.Remove(deletedValue);
                result.status = 1;
                result.message = "Ogrenciler listesi basariyla guncellendi";
                result.students = resultList;
            }
            else
            {
                result.status = 0;
                result.message = "Bilgisini guncellemek istediginiz ogrenci listede bulunamadi";
            }
            return result;

        }
       
     */
    }
}