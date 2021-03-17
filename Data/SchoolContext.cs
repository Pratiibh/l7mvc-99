using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

//tinfo200:[2021-03-14-pratiibh-dykstra1] - The code below (specifically lines 5-18) is to connect all the different pieces we have built together.  More specifically, block of code connects all the models we have created (Courses, Enrollments, Students) to each other.  There is a base constructor with the base constructor call as well. 

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }


        //tinfo200:[2021-03-14-pratiibh-dykstra1] - This comment is strictly for the code below (lines 20-25).  The code block we are looking at is a method which tells the entire entity framework what names we want for our tables (in the SQL database).
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}