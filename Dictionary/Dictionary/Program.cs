using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
            //key - value pair
                {1,"a" },
                {2,"b"},
                {3,"c"}, 
                {4,"d"}, 
                {5,"e"}
            };
            //Console.WriteLine(names.ElementAt(0));
            for(int i= 0; i < names.Count; i++)
            {
                // KeyValuePair<int, string> pair = names.ElementAt(i);
                // Console.WriteLine(pair.Key);
                Console.WriteLine(names.ElementAt(i));

            }
            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            foreach(KeyValuePair<int , string> i in names)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");

            }
            Console.WriteLine($" key is {names.ElementAt(0).Key}");
            Console.WriteLine($" value is {names.ElementAt(0).Value}");
            Console.WriteLine(names[1]);

            //names.Add(1, "vicky");
            //names.Add(2, "Mukesh");
            //names.Add(3, "Rohan");
            //names.Add(4, "Sachin");
        }
    }
}
