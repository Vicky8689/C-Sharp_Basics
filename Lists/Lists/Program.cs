using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3] { 1, 2, 3 };


            //List<int> listNumbrs = new List<int>() { 1,2,3,4,5,6,7,8};
            //listNumbrs.Add(1);
            //listNumbrs.Add(2);
            //listNumbrs.Add(3);
            List<int> listNumbrs = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter the numbers : ");
                listNumbrs.Add(Convert.ToInt32(Console.ReadLine()));

            }
            for (int i = 0; i < listNumbrs.Count; i++)
            {
                Console.Write($"{listNumbrs[i]} ");
            }
            Console.WriteLine();
            listNumbrs.RemoveAt(1);
            foreach (int i in listNumbrs)
            {
                Console.Write($"{i} ");

            }



        }
    }
}
