using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_And_Userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------user input ----------------------------------------------------------------

            //String str = Console.ReadLine();
            //Console.WriteLine("hello "+str);
            //Console.Write("How many canday you want "+str+ " " );
            //String can  = Console.ReadLine();
            //Console.WriteLine("you got 4 extra candy " +( Convert.ToInt32(can) + 4));

            //----------------Math class--------------------------------------------------------------------------
            //int a = Math.Max(45, 67);
            //Console.WriteLine(a);
            //int b = Math.Min(45, 5);
            //Console.WriteLine(b);
            //Console.WriteLine(Math.Sqrt(4));

            //double x = Math.Sqrt(4);
            //Console.WriteLine(x);


            //------------------string-----------------------------------------------------------------------------

            // String hello = "hello my name is vicky";
            // Console.WriteLine(hello.Length);
            // Console.WriteLine(hello);
            // Console.WriteLine(hello.ToUpper());
            // Console.WriteLine(hello.ToLower());
            // Console.WriteLine(hello + " you are ok ");
            // Console.WriteLine(string.Concat(hello, " you are ok "));

            // //--------string inter poletion -----------------------------------------
            // string name = Console.ReadLine();
            // string can = Console.ReadLine();
            // Console.WriteLine($"your name is {name}. you got {can} candies. ");


            // //access charater in string ------------
            //// String hello = "hello my name\" is vicky";
            // Console.WriteLine(hello[0]);
            // Console.WriteLine(hello.IndexOf("is"));
            // Console.WriteLine(hello.Substring(1));   //sub string 

            // string str = "vicky yadav";
            // string ns = "";
            // for (int i = 0; i < str.Length; i++)
            // {
            //     if (i == 0)
            //     {

            //         ns += char.ToUpper(str[i]);
            //     }
            //     else if (str[i - 1] == ' ')
            //     {
            //         ns+=char.ToUpper(str[i]);

            //     }
            //     else
            //     {
            //         ns+=str[i];

            //     }
            // }
            // Console.WriteLine(ns);

            // ns = "";
            // for (int i = 0; i < str.Length; i++)
            // {
            //     if (i == 0){ns=ns + str[i].ToString().ToUpper();} 
            //     else if (str[i-1] == ' ') { ns = ns + str[i].ToString().ToUpper(); ; }
            //     else { ns += str[i]; }
            // }
            // Console.WriteLine(ns);
            // //string[] s = str.Split(' ');
            // //Console.WriteLine(str);
            // //Console.WriteLine(str[6]);
            // //StringBuilder sb = new StringBuilder();
            // //sb.AppendLine(s[0]);
            // //Console.WriteLine(sb.ToString());

            // int[] arr = new int[5];
            // for(int i = 0;i < arr.Length;i++)
            // {

            //     Console.WriteLine(arr[i]);
            // }














            //string[] s = str.Split(' ');
            //string s = char.ToUpper(str.First())+str.Substring(1);













            ///by for loop






            //string news = "";
            //foreach(string i in s) {

            //    news+=char.ToUpper(i[0])+i.Substring(1);
            //    Console.WriteLine(news);

            //}
            //Console.WriteLine(news);
            //char[] s = str.Split(' ');

            //foreach (string i in s) {
            //    Console.WriteLine(i[0]);
            //}




            //array
            //int[] zeros = new int[]{ 1, 0, 5, 0, 0, 3, 8, 4, 0, 7, 10, 0, 11, 0 };
            //int s = 0;
            //int e = zeros.Length;


            //for(int i= 0;i<zeros.Length;i++)
            //{
            //    for(int j= i+1;j<zeros.Length;j++) {
            //        if (zeros[i] == 0)
            //        {
            //            int temp = zeros[i];
            //            zeros[i] = zeros[j];
            //            zeros[j] = temp;
            //        }
            //    }
            //}
            //for(int i=0; i<zeros.Length;i++)
            //{
            //    Console.Write(zeros[i]+ " ");
            //}

            //while (s < e)
            //{
            //    while()
            //    if (zeros[s] != 0) { s++; }
            //    if (zeros[e] != 0) { e--; }

            //}




            string str = "vIcKy";
                
            for (int i = 0; i < str.Length; i++)
            {
               
                char ch =char.ToUpper( str[i]);
                if(str[i]==ch)
                {
                    Console.WriteLine(i);
                }

            }









           // int ui = 0;
           // Console.WriteLine(1^ui);



        }
    }
}
