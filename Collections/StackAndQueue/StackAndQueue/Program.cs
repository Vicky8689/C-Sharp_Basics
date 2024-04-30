using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> name = new Stack<string>();
            name.Push("a");
            name.Push("b");
            name.Push("c");
            name.Push("d");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            name.Pop();
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }


            //Queue
            Console.WriteLine("Queue  ");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            queue.Enqueue("d");
            foreach (var item in queue)
            { Console.WriteLine(item); }
            queue.Dequeue();
            Console.WriteLine();
            foreach (var item in queue)
            { Console.WriteLine(item); }
            Console.WriteLine(queue.Peek());
           

        }
    }
}
