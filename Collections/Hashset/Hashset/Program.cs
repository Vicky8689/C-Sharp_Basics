using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> name = new HashSet<string>();
            name.Add("a");
            name.Add("b");
            name.Add("c");
            name.Add("d");
            name.Add("e");
            foreach (string s in name)
            {
                Console.WriteLine(s);
            }
            name.Clear();
        }
    }
}
