using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    class CourseList
    {
        public int CId { get; set; }
        public string CName { get; set; }

        public int CourseFee { get; set; }
    }
    class CourseListDemo
    {
        static void Main(string[] args)
        {
            List<CourseList> clist=new List<CourseList>()
            {
                new CourseList{CId= 10001, CName= "JAVA", CourseFee= 45000},
                new CourseList{CId= 10002, CName= "C# ", CourseFee= 40000},
                new CourseList{CId= 10003, CName= "PHP", CourseFee= 35000},
                new CourseList{CId= 10004, CName= "C  ", CourseFee= 10000},
                new CourseList{CId= 10005, CName= "C++", CourseFee= 20000},
                new CourseList{CId= 10006, CName= "PYTHON", CourseFee= 38000}
            };

            foreach(CourseList c in clist)
            {
                Console.WriteLine($"CourseId: {c.CId}\t CourseName: {c.CName}\t CourseFees: {c.CourseFee}");
            }
        }
    }
}
