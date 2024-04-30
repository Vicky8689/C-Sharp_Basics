using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> name = new LinkedList<string>();
            name.AddLast("a");
            name.AddLast("b");
            name.AddLast("c");
            foreach (string s in name)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            //insert new element before "Peter
            LinkedListNode<string> node = name.Find("b");
            name.AddBefore(node ,"vicky");
            name.AddAfter(node ,"yadav");
            foreach (string s in name)
            {
                Console.WriteLine(s);
            }
        }
    }
}
