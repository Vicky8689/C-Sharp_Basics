using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_Array_
{
    internal class Program
    {
        static void sort_array(ref int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int min_index = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                       
                    }
                }
                swap_element(ref arr,i,min_index);
            }
        }
        static void swap_element(ref int[] arr,int i,int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static int sum(int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        static bool search_in_array(int[] arr)
        {
            Console.WriteLine("Enter the number");
            int num  = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    return true;
                }

            }
            return false;
            
        }
        static void print_array(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 6, 5, 9, 1, 0, 2, 15, 13, 12, 18, 14 };
            print_array(arr);
            Console.WriteLine("");
            Console.WriteLine($" the length is {arr.Length} ");
            Console.WriteLine("For print Enter the 1 ");
            Console.WriteLine("For search Enter the 2 ");
            Console.WriteLine("For sort Enter the 3 ");
            int inp = Convert.ToInt32(Console.ReadLine());

            switch (inp)
            {
                case 1:
                    print_array(arr);
                    break;
                case 2:
                    Console.WriteLine(search_in_array(arr)?"Yes it present":"Not present");
                    break;
                case 3:
                    sort_array(ref arr);
                    print_array(arr);
                    break;
                default:
                    Console.WriteLine("tery again");
                    break;

            }



        }
    }
}
