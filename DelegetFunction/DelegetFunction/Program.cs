using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegetFunction
{
    //create delegate
    public delegate void Calculation(int a, int b);
    internal class Program
    {
        public static void Add(int a ,int b) 
        {
            int result = a + b;
            Console.WriteLine("Adition resuld "+result);
        }
        public static void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Sub resuld " + result);
        }


        static void Main(string[] args)
        {
            //create deliget object
            Calculation obj = new Calculation(Program.Add);
            obj.Invoke(5,6);
            obj = Sub;
            obj(5, 6);




            
                }
    }
}
