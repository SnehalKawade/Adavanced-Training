using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Advanced_Training.MyCollection
{
    //Interface fron Non generic Collections
    //1.IComparable
    //2.IComparer
    public class Product : IComparable
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object obj)
        {
            Product p2=(Product)obj;    
            if(this.Price>p2.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    public class Test:IComparer
    {
        public int Compare(object x,object y)
        {
            Product pro1=(Product)x;
            Product pro2=(Product)y;    
            if(pro1.Price>pro2.Price)   
                return 1;
            else
                return 0;
        }
    }
    class ProductTest
    {
        static void Main(string[] args)
        {
            Product p1 = new Product { Id = 1, Name = "Hp Laptop", Price = 40000 };
            Product p2 = new Product { Id = 2, Name = "Dell Laptop", Price = 35000 };
            int result = p1.CompareTo(p2);
            if(result==1)
            {
                Console.WriteLine("HP laptop have more praice than Dell");
            }
            else
            {
                Console.WriteLine("Dell laptop have more price than HP");
            }
            Console.WriteLine("************************************************");
            Test t1 = new Test();
            int res = t1.Compare(p1,p2);
            if (res == 1)
            {
                Console.WriteLine("HP laptop have more praice than Dell");
            }
            else
            {
                Console.WriteLine("Dell laptop have more price than HP");
            }
        }  
    }
}
