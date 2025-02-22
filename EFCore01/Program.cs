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
        }

        public class Department
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Ins_ID { get; set; } 
            public DateTime HiringDate { get; set; }
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
        }

        public class Topic
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public class Stud_Course
        {
            public int stud_ID { get; set; }
            public int Course_ID { get; set; }
            public int Grade { get; set; }
        }

        public class Course_Inst
        {
            public int inst_ID { get; set; }
            public int Course_ID { get; set; }
            public int Evaluate { get; set; }
        }

        static void Main()
        {
            Console.WriteLine("Hello, ITI!");
        }
    }
}