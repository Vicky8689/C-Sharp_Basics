using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> name  = new SortedSet<string>();
            name.Add("A");
            name.Add("B");
            name.Add("C");
            name.Add("D");
            name.Add("E");
            name.Add("F");
            foreach (string s in name)
            {
                Console.WriteLine(s);
            }
            SortedSet<int> num = new SortedSet<int>();
            num.Add(81);
            num.Add(24);
            num.Add(3);
            num.Add(04);
            num.Add(50);
            foreach (int s in num)
            {
                Console.WriteLine(s);
            }
        }
    }
}
