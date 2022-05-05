using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Training.MyCollection
{
    public class EmpolyeeD
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }
    public class Department
    {
        public int DId { get; set; } 
        public string DName { get; set; }  

        public List<EmpolyeeD> Employees=new List<EmpolyeeD>();
    }
    class DepartEmpDemo
    {
        static void Main(string[] args)
        {
            List<Department> depart=new List<Department>()
            {
                new Department
                {
                    DId = 1111,
                    DName = "Training",
                    Employees =
                    {
                        new EmpolyeeD{EmpId=101,EmpName="Snehal"},
                        new EmpolyeeD{EmpId=102,EmpName="Sayli"},
                        new EmpolyeeD{EmpId=103,EmpName="Ankita"},
                        new EmpolyeeD{EmpId=104,EmpName="Priynka"}

                    }
                },

                new Department
                {
                    DId = 1112,
                    DName = "Placements",
                    Employees =
                    {
                        new EmpolyeeD{EmpId=105,EmpName="Sagar"},
                        new EmpolyeeD{EmpId=106,EmpName="Prasad"},
                        new EmpolyeeD{EmpId=107,EmpName="Shravy"},
                        new EmpolyeeD{EmpId=108,EmpName="Sumit"},
                        new EmpolyeeD{EmpId=109,EmpName="Shweta"}

                    }
                }
            };

            foreach(Department d in depart)
            {
                Console.WriteLine(d.DId+" "+d.DName);
                foreach(EmpolyeeD e in d.Employees)
                {
                    Console.WriteLine($"\t {e.EmpId} {e.EmpName}");
                }
            }

        }
    }
}
