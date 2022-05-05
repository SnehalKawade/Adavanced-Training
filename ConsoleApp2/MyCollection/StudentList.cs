using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Training.MyCollection
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
    class StudentList
    {
        static void Main(string[] args)
        {
            List<Student> s1 = new List<Student>()
            {
                new Student{Id=1,Name="Snehal",  Address="Solapur"},
                new Student{Id=2,Name="Sagar",   Address="Pune"},
                new Student{Id=3,Name="Prasad",  Address="Mumbai"},
                new Student{Id=4,Name="Sonu",    Address="Banglore"},
                new Student{Id=5,Name="Shravy",  Address="Nashik"}
            };
            foreach (Student s in s1)
            {
                Console.WriteLine($"SID: {s.Id} Sname: {s.Name}  Address: {s.Address}");
            }
        }
    }
}
