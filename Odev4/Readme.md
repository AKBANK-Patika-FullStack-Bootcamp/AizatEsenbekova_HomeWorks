# ReadMe file for homework week4
This time we will do the http method operations over the database.
First off all you need to install some packages below to your project
* EntityFramework
* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools
### This project consists of 3 layers.
* DAL
  * Model-for store entities
  ![image](https://user-images.githubusercontent.com/60337657/149985236-74894bb1-6395-4e8f-b293-34ea599ab49c.png)
* Entities
  * StudentContext.cs- for connection with our database
  ![image](https://user-images.githubusercontent.com/60337657/149985682-c338067d-0b88-430f-be04-3a99944bc58a.png)
  #### Connect with Database
  ```
  protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //connect with sql server
            options.UseSqlServer ("Data Source=yourServer's name; Database=your Database's name; integrated security=True;");
        }
  ```
  #### Match entity with table on the database
  ```
   protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //matching with tables
            modelBuilder.Entity<Student>().ToTable("Student");
           //Student is your table's name
        }
   ```
* db_connections
There two classes in db_connections:
    * StudentsOperations.cs - send Http methods to StudentDbOperations
    * StudentsDbOperations.cs - processes database queries.
    
*************************************************************************************************
I have database which name is StudentDB. Its diagram is below:
![image](https://user-images.githubusercontent.com/60337657/149983008-43e7d813-2035-42c4-8b04-4d174e1c51f9.png)

There are three tables:
* Student
* Guide
* Adress

I will try my operations on the Student table

## [HttpGet]
```
Select * from student
```
## [HttpGet("{id}")]
```
Select * from student where StudentID=id
```
## [HttpPost]
```
Insert into student {Name, Surname, Age, GuideId, AddressId} values {'Aizat', 'Esenbekova',21,4,2}
```

 Update age=34 student whose id=5;
## [HttpPut("{5}")]
```
Update student set age=34 where SudentID=5
```
## [HttpDelete("{id}")]
```
Delete from student where StudentID=id
```
