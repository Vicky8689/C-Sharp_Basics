using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{

    internal class Program
    {
        class Queue
        {
            //propreties
            int size;
            int[] arr;
            int front;
            int rarer;
            //methods
            public Queue(int size)
            {
                this.size = size;
                this.arr = new int[size];
                this.front = 0;
                this.rarer = 0;
            }
            public void Enqueue(int value)
            {
                if(isEmpty())
                {
                    arr[rarer] = value;
                    rarer++;

                }
                else
                {
                    Console.WriteLine("Queue is overflow");
                }

            }
            public int Dequque()
            {
                if(!isEmpty())
                {
                    int ans = arr[front];
                    arr[front] = -1;
                    front++;
                    if(front == rarer)
                    {
                        front = 0;
                        rarer = 0;
                    }
                    return ans;

                }
                else
                {
                    Console.WriteLine("queue is empty ");
                    return -1;
                }

            }
            public int peek()
            {
               if (!isEmpty())
                {
                    return arr[front];
                }
                else
                {
                    return -1;
                }
            }
            public bool isEmpty()
            {
                if (!(rarer==size))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }



        }
        static void Main(string[] args)
        {
            Queue q = new Queue(10);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            q.Enqueue(8);
            q.Enqueue(9);
            q.Enqueue(10);
            q.Enqueue(11);
            Console.WriteLine("peek elmenth is = "+ q.peek());
           Console.WriteLine("Dequed elment is = " + q.Dequque());
            Console.WriteLine("peek elmenth is = "+ q.peek());
           Console.WriteLine("Dequed elment is = " + q.Dequque());
            Console.WriteLine("peek elmenth is = "+ q.peek());
            Console.WriteLine("peek elmenth is = "+ q.peek());
            Console.WriteLine("Dequed elment is = " + q.Dequque());
            Console.WriteLine("peek elmenth is = "+ q.peek());
           Console.WriteLine("Dequed elment is = " + q.Dequque());
            Console.WriteLine("peek elmenth is = "+ q.peek());
            Console.WriteLine("Dequed elment is = " + q.Dequque());
            Console.WriteLine("peek elmenth is = "+ q.peek());
           Console.WriteLine("Dequed elment is = " + q.Dequque());
            Console.WriteLine("peek elmenth is = "+ q.peek());
            Console.WriteLine("Dequed elment is = " + q.Dequque());
            Console.WriteLine("peek elmenth is = "+ q.peek());
            Console.WriteLine("Dequed elment is = " + q.Dequque());
            Console.WriteLine("Dequed elment is = " + q.Dequque());
           Console.WriteLine("Dequed elment is = " + q.Dequque());
           Console.WriteLine("Dequed elment is = " + q.Dequque());




            //Queue by generics
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(11);
            //queue.Enqueue(12);
            //queue.Enqueue(13);
            //queue.Enqueue(14);
            //queue.Enqueue(15);
            //foreach (int i in queue)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine($"the Deque element {queue.Dequeue()}");
            //Console.WriteLine();
            //foreach (int i in queue)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine($"the peak element is {queue.Peek()}");
            //Console.WriteLine(queue.Count);

        }
    }
}
