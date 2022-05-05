using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Advanced_Training.MyCollection
{
    public class Employee:IComparable
    {
        public int Id { get; set; } 
        public string Ename { get; set; }
        public int Salary { get; set; }

        public int CompareTo(object obj)
        {
            Employee e2 = (Employee)obj;
            if (this.Salary > e2.Salary)
                return 1;
            else
                return 0;
        }
    }
    public class ETest:IComparer
    {
        public int Compare(object x,object y)
        {
            Employee emp1 = (Employee)x;
            Employee emp2 = (Employee)y;
            if (emp1.Salary > emp2.Salary)
                return 1;
            else
                return 0;
        }
    }
    public class EmpTest
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Id = 101, Ename = "Snehal", Salary = 35000 };
            Employee e2 = new Employee { Id = 102, Ename = "Sonu", Salary = 40000 };
            int result=e1.CompareTo(e2);
            if(result==1)
            {
                Console.WriteLine($"{e1.Id} Salary more than {e2.Id}");
            }
            else
            {
                Console.WriteLine($"{e2.Id} Salary more than {e1.Id}");
            }

            Console.WriteLine("************************************************");

            ETest t1 = new ETest();
            int res = e1.CompareTo(e2);
            if (res == 1)
            {
                Console.WriteLine($"{e1.Id} Salary more than {e2.Id}");
            }
            else
            {
                Console.WriteLine($"{e2.Id} Salary more than {e1.Id}");
            }
        }
    }
}
