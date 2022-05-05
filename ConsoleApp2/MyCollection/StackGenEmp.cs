using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Training.MyCollection
{
    //write a program to display employee details using generic stact collection. 
    class EmpDemo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

       /* public override string ToString()
        {
            return $"Eid: {Id} EName: {Name}  Salary: {Salary} ";
        }*/
    }
    class StackGenEmp
    {
        static void Main(string[] args)
        {
            EmpDemo e1 = new EmpDemo()    //Create Employee object
            {
                Id = 101,
                Name = "Snehal",
                Salary = 35000
            };
            EmpDemo e2 = new EmpDemo()
            {
                Id = 102,
                Name = "Sagar",
                Salary = 33000
            };
            EmpDemo e3 = new EmpDemo()
            {
                Id = 103,
                Name = "Shravy",
                Salary = 30000
            };
            EmpDemo e4 = new EmpDemo()
            {
                Id = 104,
                Name = "Sayali",
                Salary = 34000
            };
            EmpDemo e5 = new EmpDemo()
            {
                Id = 105,
                Name = "Madhuri",
                Salary = 32000
            };

            Stack<EmpDemo> s1 = new Stack<EmpDemo>(); //Create a Generic Stack of Employees

            //To add an item into the stack, use the Push() method.
            s1.Push(e1);
            s1.Push(e2);
            s1.Push(e3);
            s1.Push(e4);
            s1.Push(e5);

            foreach (EmpDemo e in s1)
            {
                Console.WriteLine(e.Id + "-" + e.Name + "-" + e.Salary);
            }
            Console.WriteLine();
            Console.WriteLine("********************************************");
            Console.WriteLine("Item are left in stack: " + s1.Count);
            Console.WriteLine();

            Console.WriteLine("*********************************************");
            //To retrieve an item from the stack, use the Pop() method.

            EmpDemo emp = s1.Pop();
            Console.WriteLine(emp.Id +"-"+emp.Name+"-"+emp.Salary);
            Console.WriteLine();
            Console.WriteLine("********************************************");
            Console.WriteLine("Item are left in stack: " + s1.Count);
        }
    }
}
