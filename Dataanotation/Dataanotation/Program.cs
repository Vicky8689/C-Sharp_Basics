using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataanotation
{
    internal class Program
    {
        public static bool TryValidate(object obj,out List<ValidationResult> result)
        {
            var context = new ValidationContext(obj);
            result = new List<ValidationResult>();
            return Validator.TryValidateObject(obj,context,result);
        }


        static void PassbyOut(out int a)
        {
            a = 20;
            Console.WriteLine("in out func"+a);
        }
        static void PassbyRef( ref int a)
        {
            a++;
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            //int value;
            PassbyOut(out int value);
            Console.WriteLine("valu in main"+value);




            int num = 5;
            PassbyRef(ref num);
            Console.WriteLine(num);


            var u = new User();
            Console.WriteLine("enter your name...:");
            u.Name = Console.ReadLine();

            if(TryValidate(u,out var result))
            {
              
            }
            else
            {
                Console.WriteLine(result[0]);
                
                //foreach(var v in result)
                //{
                //    Console.WriteLine(v.ErrorMessage);
                //}
            }


        }
    }
}
