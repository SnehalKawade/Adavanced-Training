using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    class DepartmentList
    {
        public int DId { get; set; }    
        public string DName { get; set; }   

    }
    class DepartmentListDemo
    {
        static void Main(string[] args)
        {
            List<DepartmentList> departlist = new List<DepartmentList>()
            {
                new DepartmentList{DId =11111, DName= "Snehal"},
                new DepartmentList{DId =22222, DName= "Shravy"},
                new DepartmentList{DId =33333, DName= "Prasad"},
                new DepartmentList{DId =44444, DName= "Sayali"},
                new DepartmentList{DId =11111, DName= "Snehal"},
            };
            foreach(DepartmentList d in departlist)
            {
                Console.WriteLine($"Department Id: {d.DName}\t Department Name: {d.DName}");
            }
        }
    }
}
