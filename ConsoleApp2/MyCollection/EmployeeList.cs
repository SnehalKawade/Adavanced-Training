using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Training.MyCollection
{
    public class Emp1
    {
        public int Id { get; set; }   
        public string Ename { get; set; }  
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Eid: {Id} EName: {Ename}  Salary: {Salary} ";
        }
    }
    public class EmployeeList
    {
        static void Main(string[] args)
        {
            List<Emp1> e1 = new List<Emp1>()
            {
                new Emp1{Id=1,Ename="Snehal",Salary=35000},
                new Emp1{Id=2,Ename="Sagar",Salary=30000},
                new Emp1{Id=3,Ename="Prasad",Salary=40000},
                new Emp1{Id=4,Ename="Sonu",Salary=45000},
                new Emp1{Id=5,Ename="Shravy",Salary=33000}
            };    
            foreach(Emp1 e in e1)
            {
                Console.WriteLine(e);
            }
        }
    }
}
