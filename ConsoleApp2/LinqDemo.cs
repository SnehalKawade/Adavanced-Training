using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Training
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Price { get; set; }
    }
    class LinqDemo
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "HP",Price=35000},
                new Product() { Id = 2, Name = "DELL",Price=32000},
                new Product() { Id = 3, Name = "Lenovo",Price=34000},
                new Product() { Id = 4, Name = "Sony",Price=36000},
                new Product() { Id = 5, Name = "Asus",Price=38000},
            };
            foreach (Product p in products)
            {
                Console.WriteLine($"{p.Name} {p.Price}");
            }

            /*var res=from p in products
                    where p.Price>35000 && p.Price<37000
                    orderby p.Name
                    select p;*/

            /* var res = from p in products
                       where p.Name.StartsWith('l') || p.Name.StartsWith('L')
                       orderby p.Name
                       select p;*/

            var res = from p in products
                      where p.Name.Contains("name") 
                      orderby p.Price descending
                      select p;

            Console.WriteLine("***************************");
            foreach(Product p in res)
            {
                Console.WriteLine($"{p.Name} {p.Price}");
            }

        }
    }
}
