using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample
{
    internal class Program
    {
         //
         public static Tuple<string,string ,int> func(string name,string book,int year)
        {
            var datils = new Tuple<string,string ,int>(name,book,year);
            return datils;
        }
        static void Main(string[] args)
        {
            var tp = (1, "hello",0 ,2,3,4,5,6,7,8,9,10);
            Console.WriteLine(tp);
            Console.WriteLine(tp.Item2);
            Console.WriteLine(tp.Item3);

            var auther = new Tuple<string, string, int>("vicky","C#",2005);
            Console.WriteLine("name : {0} Book name: {1} Year :{2}",auther.Item1,auther.Item2,auther.Item3);
            var datils = func("vicky", "C#", 2003);
            Console.WriteLine(datils);
            

        }
    }
}
