using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Training.MyCollection
{
    class EmpD
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        /*public override string ToString()
        {
            return $"Eid: {Id} EName: {Name}  Salary: {Salary} ";
        }*/
    }
    class QueueGenEmp
    {
        static void Main(string[] args)
        {
            EmpD e1 = new EmpD()    //Create Employee object
            {
                Id = 101,
                Name = "Snehal",
                Salary = 35000
            };
            EmpD e2 = new EmpD()
            {
                Id = 102,
                Name = "Sagar",
                Salary = 33000
            };
            EmpD e3 = new EmpD()
            {
                Id = 103,
                Name = "Shravy",
                Salary = 30000
            };
            EmpD e4 = new EmpD()
            {
                Id = 104,
                Name = "Sayali",
                Salary = 34000
            };
            EmpD e5 = new EmpD()
            {
                Id = 105,
                Name = "Madhuri",
                Salary = 32000
            };

            Queue<EmpD> q1 = new Queue<EmpD>();  // Create a Generic Queue of Employees
            q1.Enqueue(e1); // To add an item into the queue, use the Enqueue() method.
            q1.Enqueue(e2);
            q1.Enqueue(e3);
            q1.Enqueue(e4);
            q1.Enqueue(e5);

            foreach (EmpD e in q1)
            {
                Console.WriteLine(e.Id+"-"+e.Name+"-"+e.Salary);
            }

            Console.WriteLine("********************************************");
            Console.WriteLine("Item are left in Queue: " + q1.Count);
            Console.WriteLine();

            //To retrieve an item from the queue, use the Dequeue() method.
            EmpD emp = q1.Dequeue();
            Console.WriteLine(emp.Id + "-" + emp.Name + "-" + emp.Salary);

            Console.WriteLine("********************************************");
            Console.WriteLine("Item are left in Queue: " + q1.Count);
            Console.WriteLine();

        }
    }
}
