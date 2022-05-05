using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseFees{ get; set; }
    }
    class CourseLINQDemo
    {
        static void Main(string[] args)
        {
            List<Course> courselist = new List<Course>()
            {
                new Course(){CourseId= 101, CourseName= "C#", CourseFees= 40000},
                new Course(){CourseId= 102, CourseName= "JAVA", CourseFees= 45000},
                new Course(){CourseId= 103, CourseName= "C", CourseFees= 3000},
                new Course(){CourseId= 104, CourseName= "C++", CourseFees= 5000},
                new Course(){CourseId= 105, CourseName= "Python", CourseFees= 30000},
                new Course(){CourseId= 106, CourseName= "DS", CourseFees= 20000},
                new Course(){CourseId= 107, CourseName= "JAVA", CourseFees= 38000},
                new Course(){CourseId= 108, CourseName= "PHP", CourseFees= 32000},
            };

            //1.Display course name whose fees is greater than 45000
            var output1 = from c in courselist
                          where c.CourseFees > 35000
                          select c;
            foreach (Course c1 in output1)
            {
                Console.WriteLine($"{c1.CourseName}\t {c1.CourseFees}");
            }

            Console.WriteLine("------------------------------------------");


            //2.Display course name with ascending order
            var output2 = from c in courselist
                          orderby c.CourseName
                          select c;
            foreach (Course c1 in output2)
            {
                Console.WriteLine($"{c1.CourseName}");
            }

            Console.WriteLine("------------------------------------------");


            //3.Display course name start with 'C' in descending order
            var output3 = from c in courselist
                          where c.CourseName.StartsWith('C')
                          orderby c.CourseName descending
                          select c;
            foreach (Course c1 in output3)
            {
                Console.WriteLine($"{c1.CourseName}");
            }

            Console.WriteLine("------------------------------------------");


            //4.Display Course who belongs to Java branch
            var output4 = from c in courselist
                          where c.CourseName.Contains("JAVA")
                          select c;
            foreach (Course c1 in output4)
            {
                Console.WriteLine($"{c1.CourseName}\t {c1.CourseFees}");
            }

            Console.WriteLine("------------------------------------------");


            //5.display course whos name start with 'C' or 'P'
            var output5 = from c in courselist
                          where c.CourseName.StartsWith('C') || c.CourseName.Contains('P')
                          select c;
            foreach (Course c1 in output5)
            {
                Console.WriteLine($"{c1.CourseName}\t {c1.CourseFees}");
            }

        }
    }
}
