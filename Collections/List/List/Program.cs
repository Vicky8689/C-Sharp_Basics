using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(34);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list.Remove(2));
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.Clear();

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
