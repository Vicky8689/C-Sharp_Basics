using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSet
{
    internal class Program
    {
        static void table(int num ,int till,int s=1)
        {
            //base case 
            if (s > till ) return ;

            Console.WriteLine($"{num}*{s}={num*s}");
            table(num , till, ++s );
        }
        static void Main(string[] args)
        {
            table(5, 10);
        }
    }
}
