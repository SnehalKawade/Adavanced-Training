using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Advanced_Training
{
    class EmployeeI
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }

        public string Depart { get; set; }
    }
     class EmployeeLINQ
    {
        static void Main(string[] args)
        {
            List<EmployeeI> emplist = new List<EmployeeI>()
            {
                new EmployeeI(){Id=1,Name="Snehal",City="Solapur",Salary=35000,Depart="Trainer"},
                new EmployeeI(){Id=2,Name="Sagar",City="Pune",Salary=25000,Depart="Placements"},
                new EmployeeI(){Id=3,Name="Sayali",City="Mumbai",Salary=40000,Depart="Admin"},
                new EmployeeI(){Id=4,Name="Akash",City="Pune",Salary=38000,Depart="HR"},
                new EmployeeI(){Id=5,Name="Shravy",City="Pune",Salary=30000,Depart="Permanant_Trainer"},
                new EmployeeI(){Id=6,Name="Sunita",City="Kolhapur",Salary=31000,Depart="Management"},
                new EmployeeI(){Id=7,Name="Madhuri",City="Nashik",Salary=37000,Depart="HourlyBased_Trainer"},
                new EmployeeI(){Id=8,Name="Priynka",City="Hydrabad",Salary=39000,Depart="SoftSkill_Trainer"},
                new EmployeeI(){Id=9,Name="Prasad",City="Baramati",Salary=35000,Depart="Grooming_Trainer"},
                new EmployeeI(){Id=10,Name="Kiran",City="Noida",Salary=35400,Depart="Counsling"},
            };

            //1.display emp whose salary is greater than 45000
            var ans =from e in emplist
                    where e.Salary<45000
                    select e;
            foreach(EmployeeI e in ans)
            {
                Console.WriteLine($"{e.Name} {e.Salary}");
            }
            Console.WriteLine("**********************************");

            //2.display all emp accesending order by their name
            var ans1 = from e in emplist
                      orderby e.Name
                      select e;
            foreach (EmployeeI e in ans1)
            {
                Console.WriteLine($"{e.Name}");
            }
            Console.WriteLine("**********************************");

            //3.display emps who lives in mumbai city
            var ans2 = from e in emplist
                      where e.City.Contains("Mumbai")
                      select e;
            foreach (EmployeeI e in ans2)
            {
                Console.WriteLine($"{e.Name} {e.City}");
            }
            Console.WriteLine("**********************************");

            //4.display emps who belongs to HR dept
            var ans3 = from e in emplist
                       where e.Depart.Contains("HR")
                       select e;
            foreach (EmployeeI e in ans3)
            {
                Console.WriteLine($"{e.Name} {e.Depart}");
            }
            Console.WriteLine("**********************************");

            //5.display all emps orderby salary desending
            var ans4 = from e in emplist
                      orderby e.Salary descending
                      select e;
            foreach (EmployeeI e in ans4)
            {
                Console.WriteLine($"{e.Name} {e.Salary}");
            }
            Console.WriteLine("**********************************");

            // 6.display emp whos name start with 'a' or 'k'
            var ans5 = from e in emplist
                       where e.Name.StartsWith('A') || e.Name.StartsWith('K')
                       orderby e.Name
                       select e;
            foreach (EmployeeI e in ans5)
            {
                Console.WriteLine($"{e.Name}");
            }
            Console.WriteLine("**********************************");

            //7.display emps beglogs to pune city & salary <35000
            var ans6 = from e in emplist
                       where e.Salary <35000 && e.City.Contains("Pune")
                       select e;
            foreach (EmployeeI e in ans6)
            {
                Console.WriteLine($"{e.Name} {e.City} {e.Salary}");
            }
          
        }

    }
}
