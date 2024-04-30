 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Myexception:Exception
    {
        public Myexception(string message):base(message) 
        {

        }
        


    }
    
    internal class Program
    {
        

        static void Main(string[] args)
        {
            try
            {
                int divisor = 4;
                if(divisor == 0)
                {
                    throw new Myexception("Can not devided by zero");
                }
                int result = 10 / divisor;
                Console.WriteLine("Result :"+ result);
            }
            catch (Myexception m)
            {
                Console.WriteLine("In My Exception"+m.Message);
            }
            catch(Exception e) 
            {
                Console.WriteLine("Inbuild Exception Caught :"+ e.Message);
            }

            Console.WriteLine("good byyy");





       



            while (true)
            {

                try
                {
                    Console.WriteLine("Enter a number ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("number " + num);
                    break;
                }
                catch (OverflowException)
                {//Overflow Exception
                    Console.WriteLine("Number is large! ");
                }
                catch (FormatException)
                {//Formate Exception
                    Console.WriteLine("please only enter numbers! ");
                }

                catch (Exception)
                {
                    Console.WriteLine("somthing is wrong");

                }

            }
            Console.WriteLine("Good bye");

            Console.WriteLine("--------------------------------");


            try
            {
                Console.WriteLine("Enter a number ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("number " + num);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception :" + e.Message);

            }
            finally { Console.WriteLine("this is finaly block executed "); }
            Console.WriteLine("Good byy !");








        }

    }
}
