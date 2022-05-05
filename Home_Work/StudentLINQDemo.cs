using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    class Student
    {
        public int RollNo { get; set; }
        public string Sname { get; set; }   
        public float Percentage { get; set; }
        public string Branch { get; set; }
    }
    class StudentLINQDemo
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){ RollNo = 1, Sname = "Snehal", Percentage=78, Branch= "CSE"},
                new Student(){ RollNo = 2, Sname = "Sagar", Percentage=75, Branch= "MECH"},
                new Student(){ RollNo = 3, Sname = "Sayali", Percentage=85, Branch= "E&TC"},
                new Student(){ RollNo = 4, Sname = "Priynka", Percentage=80, Branch= "CSE"},
                new Student(){ RollNo = 5, Sname = "Shravy", Percentage=60, Branch= "MSC"},
                new Student(){ RollNo = 6, Sname = "Prasad", Percentage=68, Branch= "MSC"},
                new Student(){ RollNo = 7, Sname = "Ankita", Percentage=65, Branch= "E&TC"},
                new Student(){ RollNo = 8, Sname = "Madhuri", Percentage=72, Branch= "Civil"},
            };

            //1.Display student whose percentage is greater than 75
            var res1=from s in studentList
                     where s.Percentage>75
                     select s;
            foreach (Student s1 in res1)
            {
                Console.WriteLine($"{s1.Sname}\t {s1.Percentage}");
            }
            Console.WriteLine("-----------------------------------------");
     
            //2.Display all student ascending order by their name
            var res2 = from s in studentList
                       orderby s.Sname
                       select s;
            foreach (Student s1 in res2)
            {
                Console.WriteLine($"{s1.Sname}");
            }
            Console.WriteLine("-----------------------------------------");
            
            //3.Display student name who belongs to "CSE" branch 
            var res3 = from s in studentList
                       where s.Branch.Contains("CSE")
                       select s;
            foreach (Student s1 in res3)
            {
                Console.WriteLine($"{s1.Sname}\t {s1.Branch}");
            }
            Console.WriteLine("-----------------------------------------");

            //4.Display student who name start with 'S' descending order 
            var res4 = from s in studentList
                       where s.Sname.StartsWith('S')
                       orderby s.Sname descending
                       select s;
            foreach (Student s1 in res4)
            {
                Console.WriteLine($"{s1.Sname}\t {s1.Branch}");
            }
            Console.WriteLine("-----------------------------------------");


            //5.Display student name whose percentage is less than 75 or greater than 65
            var res5 = from s in studentList
                       where s.Percentage > 65 && s.Percentage < 75
                       select s;
            foreach (Student s1 in res5)
            {
                Console.WriteLine($"{s1.Sname}\t {s1.Percentage}");
            }
        }
    }
}
