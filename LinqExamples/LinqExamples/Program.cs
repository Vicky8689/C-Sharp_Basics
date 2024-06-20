using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            int[] age = { 12, 32, 54, 3, 42, 13, 15, 16, 17, 18, 19, 20, };
            var a = from i in age where i > 20 select i;
            foreach(int  item in a)
            {
                Console.WriteLine(item);
            }
            //sort the result
            var b =from i in age where i> 20 orderby i descending select i ;
            foreach (int item in b)
            {
                Console.WriteLine(item);
            }
            //case sencitive
            string[] names = {"vicky","mukesh","sachin","" };
            var c = from i in names where i.Contains("i") select i;
            foreach(string name in c)
            {
                Console.WriteLine(name);
            }

            //linq to sql

        }
    }
}
