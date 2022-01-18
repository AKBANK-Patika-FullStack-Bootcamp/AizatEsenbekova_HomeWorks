using DAL.Model;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace db_connection.Controllers
{
    public class StudentsDbOperations
    {

        private StudentContext _context = new StudentContext();
        public void AddModel(Student student)
        {
            try
            {
                _context.Student.Add(student);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }
       
        //to get all students from database
        public List<Student> getStudents()
        {
            List<Student> resultList=new List<Student>();
            resultList=_context.Student.ToList();
            return resultList;
        }
        //get one sepific students from database by id
        public Student getStudent(int id)
        {
            Student resultStudent = new Student();
            resultStudent = _context.Student.FirstOrDefault(x => x.StudentID == id);
            return resultStudent;
        }

        //add student to database
        public String addStudent(Student student)
        {
            //check is student in the database
            //return message after process
            bool check=_context.Student.Contains(student);
            if(check==true)
            {
                return "Studens is alreay exists";
            }
            else
            {
                _context.Student.Add(student);
                _context.SaveChanges();
                return "Student added to databse successfully";
            }
        }

        //update student's information from database by id
        public String updateStudent(Student newValue,int id)
        {
            //find student from database
            Student? oldValue=new Student();
            oldValue=_context.Student.FirstOrDefault(y=>y.StudentID==id);
            if(oldValue==null)
            {
                return "This student is not in the database";
            }
            else
            {
                oldValue.StudentID = newValue.StudentID;
                oldValue.Name = newValue.Name;
                oldValue.Surname = newValue.Surname;
                oldValue.Age = newValue.Age;
                oldValue.GuideId = newValue.GuideId;
                oldValue.AddressId = newValue.AddressId;
                _context.SaveChanges();
                return "Student's information updates successfully";
                
            }
           
        }
        //delete student from database by id
        public String deleteStudent(int id)
        {
            Student? student = new Student();
            //find student from database
            student=_context.Student.FirstOrDefault(x=>x.StudentID==id);
            if(student==null)
            {
                //can't find student from database
                return "This student is not in the database";
            }
            else
            {
                //remove student 
                _context.Student.Remove(student);
                _context.SaveChanges();
                return "Student deleted from database succesfully";
            }


        }
        
    }
}
