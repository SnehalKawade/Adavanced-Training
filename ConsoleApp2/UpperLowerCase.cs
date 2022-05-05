using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Training
{
    public delegate void MyDel(string name);
    class Demo
    {
        public void UpperCase(string name)
        {
            Console.WriteLine(name.ToUpper());
        }

        public void LowerCase(string name)
        {
            Console.WriteLine(name.ToLower());
        }
    }
    class UpperLowerCase
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            MyDel del = new MyDel(d.UpperCase);
            del += new MyDel(d.LowerCase);


            Delegate[] list1 = del.GetInvocationList();
            foreach (Delegate d1 in list1)
            {
                Console.WriteLine(d1.Method);
                d1.DynamicInvoke("Snehal");
            }
        }
    }
}
