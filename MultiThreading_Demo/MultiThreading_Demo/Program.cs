using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading_Demo
{
    internal class Program
    {
        public static void func1()
        {
           // Console.WriteLine("the thred is " + Thread.CurrentThread.Name);
            for (int i = 0; i <=10; i++)
            {

                Console.WriteLine("Func1 = "+ i);
            }
        }
   
        public static void func2()
        {
            for(int i = 0;i <= 30; i++)
            {
             //   Console.WriteLine("the thred is " + Thread.CurrentThread.Name);
                Console.WriteLine("Func2 = " + i);
                //if (i == 25)
                //{
                //    Console.WriteLine("thread is sleeping");
                //   // Thread.Sleep(8000);
                   
                //}
            }
        }
        public static void func3()
        {
            for (int i = 0; i <=10; i++)
            {
              //  Console.WriteLine("the thred is " + Thread.CurrentThread.Name);
                Console.WriteLine("Func3 = " + i);
            }
        }

        static void Main(string[] args)
        {
            //creat thread for particuler thread
            Thread t1 = new Thread(new ThreadStart(func1));
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);
         //   Console.WriteLine(t1.ThreadState);
            t1.Name = "Test1";
            t2.Name = "Test2";
            t3.Name = "Test3";

            
            t1.Start();
            //Console.WriteLine(t1.ThreadState);
            //try
            //{
            //t1.Resume();
            //Console.WriteLine(t1.ThreadState);
            //}
            //catch (Exception e) { Console.WriteLine(e.Message); }
            //finally
            //{
            //    t1.Suspend();
            //    Console.WriteLine(t1.ThreadState);
            //}
            t2.Start();
            t3.Start();
            // t2.Join();   //we use the join method to tell main thread to stop untill complite this thread







            //while(t1.IsAlive)
            //{
            //    Console.WriteLine("T1 is runing----*********************************");
            //}
            //Console.WriteLine("-----------------------------------------------------------");

            //Program.func1();
            //Program.func2();
            //Program.func3();


            //Thread t = Thread.CurrentThread;
            //t.Name = "Main Thread";
            //Console.WriteLine(" Current Executing thread is "+Thread.CurrentThread.Name);
        }
    }
}
