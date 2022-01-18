using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Entities
{
    public class StudentContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public StudentContext() 
        {
            //constructor for this class
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //connect with sql server
            options.UseSqlServer ("Data Source=BOSSLADY\\AIZATSQL; Database=StudentsDB; integrated security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //matching with tables
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Guide>().ToTable("Guide");
            modelBuilder.Entity<Address>().ToTable("Address");
        }

        public DbSet<Student> Student{ get; set; }
        public DbSet<Guide> Guide{ get; set; }
        public DbSet<Address> Address { get; set; }
   
    }
}
