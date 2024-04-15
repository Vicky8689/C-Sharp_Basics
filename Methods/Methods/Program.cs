using System;

namespace Mtethods
{
    public class Program
    {
        //ADD function
        public static int add(int a ,int b)
        {
            return a + b;
        }
        //up date function -----this will nat work 
        //public   static void update(int num)
        //    {
        //        num += 5; 
        //        Console.WriteLine(num);
        //    }
        static int update(int num)
        {
            return num + 1;
        }

        public static int[] fun(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2; 
            }
            return arr;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine(add(5,6));
            int a = 5;
            Console.WriteLine(a);
            
            Console.WriteLine(a);

            int[] arr = { 4, 6, 7, 1, 0, 45, 31 };
            arr = fun(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }


        }
    }
}