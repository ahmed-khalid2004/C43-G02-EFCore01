using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore01
{
    internal class Program
    {
     
        public class Student
        {
            public int ID { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public string Address { get; set; }
            public int Age { get; set; }
            public int Dep_Id { get; set; }

            [ForeignKey("Dep_Id")]
            public Department Department { get; set; }
        }

        public class Department
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Ins_ID { get; set; }
            public DateTime HiringDate { get; set; }

            [ForeignKey("Ins_ID")]
            public Instructor Instructor { get; set; }
        }

        public class Course
        {
            public int ID { get; set; }
            public int Duration { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int? Top_ID { get; set; }
        }

        public class Instructor
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public string Address { get; set; }
            public decimal HourRateBonus { get; set; }
            public int Dept_ID { get; set; }

            [ForeignKey("Dept_ID")]
            public Department Department { get; set; }
        }

        public class Topic
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public class Stud_Course
        {
            [Key, Column(Order = 1)]
            public int stud_ID { get; set; }

            [Key, Column(Order = 2)]
            public int Course_ID { get; set; }

            public int Grade { get; set; }
        }

        public class Course_Inst
        {
            [Key, Column(Order = 1)]
            public int inst_ID { get; set; }

            [Key, Column(Order = 2)]
            public int Course_ID { get; set; }

            public int Evaluate { get; set; }
        }

        public class ITIDbContext : DbContext
        {
            public ITIDbContext(DbContextOptions<ITIDbContext> options) : base(options) { }
            public DbSet<Student> Students { get; set; }
            public DbSet<Department> Departments { get; set; }
            public DbSet<Course> Courses { get; set; }
            public DbSet<Instructor> Instructors { get; set; }
            public DbSet<Topic> Topics { get; set; }
            public DbSet<Stud_Course> Stud_Courses { get; set; }
            public DbSet<Course_Inst> Course_Insts { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Stud_Course>().HasKey(sc => new { sc.stud_ID, sc.Course_ID });
                modelBuilder.Entity<Course_Inst>().HasKey(ci => new { ci.inst_ID, ci.Course_ID });
            }
        }
        static void Main()
        {
            Console.WriteLine("Hello, ITI!");

            var options = new DbContextOptionsBuilder<ITIDbContext>()
                .UseSqlServer("\"Server=DESKTOP-FT1LQTB;Database=ITI;Trusted_Connection=True;\"\r\n")
                .Options;

            using (var context = new ITIDbContext(options))
            {
                Console.WriteLine("Connected to the database successfully!");
            }
        }
    }
}