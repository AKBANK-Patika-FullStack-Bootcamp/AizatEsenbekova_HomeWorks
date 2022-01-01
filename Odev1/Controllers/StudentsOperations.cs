using Microsoft.AspNetCore.Mvc;
using Odev1.Model;

namespace Odev1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsOperationsController : ControllerBase
    {
        List<Student> resultList = new List<Student>();//bulisteyi bir kac yerde kullandigimiz icin global yaptim
        Result result=new Result();
        [HttpGet]
        //Butun ogrencilerin listedini goster
        public List<Student> getStudents()
        {
            
            resultList = AddUser();
            return resultList;
        }

        [HttpGet("{id}")]
        //Sadece idsi belirtilen ogrenciyi goster
        public Student getStudent(int id)
        {
            
            resultList = AddUser();
            Student student = new Student();
            student = resultList.FirstOrDefault(x => x.StudentId == id);
            return student;
        }

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
       
        //ogrenciler listesini burada dolduruyoruz 
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