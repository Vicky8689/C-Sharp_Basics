using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello vicky");
            int a = 5;
            Type t =a.GetType();
            Console.WriteLine(t);
            Type t1 =typeof(int);
            Console.WriteLine(t1);
            Type t2 = typeof(System.String);
            Console.WriteLine(t2);
            Console.WriteLine(t2.FullName);
            Console.WriteLine(t2.Name);
            Console.WriteLine(t2.IsArray);
            Console.WriteLine(t2.Assembly);
        }
    }
}
