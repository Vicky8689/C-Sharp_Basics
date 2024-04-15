using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        //sum of numbers
        static int sum(int[] nums, int i)
        {
            if(nums.Length == i) return 0;
            
            int rs = nums[i] + sum(nums, ++i);
            return rs; 
        }
        //factorial of number
        static int factorial(int num)
        {
            //base case
            if(num == 0) return 1;
            int result = num * factorial(num - 1);
            return result;
        }
        //reverse string
        static string Revers_string(string s,int i)
        {
            if (s.Length == i) return "" ;
             
            return Revers_string(s, i+1) + s[i];


        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(factorial(6));
            Console.WriteLine(sum(arr,0));
            string str = "vicky";
            Console.WriteLine(str);
            Console.WriteLine(str[0]);
            Console.WriteLine(Revers_string(str, 0));

        }
    }
}
