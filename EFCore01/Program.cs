using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
            public int Top_ID { get; set; }
        }

        public class Instructor
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public string Address { get; set; }
            public decimal HourRateBouns { get; set; }
            public int Dept_ID { get; set; }
        }

        public class Topic
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public class Stud_Course
        {
            public int Stud_ID { get; set; }
            public int Course_ID { get; set; }
            public int Grade { get; set; }
        }

        public class Course_Inst
        {
            public int Inst_ID { get; set; }
            public int Course_ID { get; set; }
            public int Evaluate { get; set; }
        }

        // Data Annotations-based Mapping
        public class Student_Annotated
        {
            [Key]
            public int ID { get; set; }

            [Required]
            [MaxLength(50)]
            public string FName { get; set; }

            [Required]
            [MaxLength(50)]
            public string LName { get; set; }

            [Required]
            [MaxLength(200)]
            public string Address { get; set; }

            [Range(18, 100)]
            public int Age { get; set; }

            [ForeignKey("Department")]
            public int Dep_Id { get; set; }
        }
    }
}