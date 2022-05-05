using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Training
{
    public delegate int MyDelegate(int x,int y);
    class Calculation
    {
        public int Add(int a,int b)
        {
            return a + b;   
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
    class MulticastDelegateDemo
    {
        static void Main(string[] args)
        {
            Calculation c=new Calculation();    
            MyDelegate del=new MyDelegate(c.Add);
            del +=new MyDelegate(c.Sub);
            del +=new MyDelegate(c.Mul);

            Delegate[] list = del.GetInvocationList();
            foreach(Delegate d in list)
            {
                Console.WriteLine(d.Method); 
                Console.WriteLine(d.DynamicInvoke(30,20));
            }
        }
    }
}
