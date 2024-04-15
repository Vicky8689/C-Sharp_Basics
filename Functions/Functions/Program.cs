using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Test
    {
        public void Welcome()
        {
            Console.WriteLine(" in test Hello vicky");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();
            //test.Welcome();
            //Welcome();
            //string nameip = "vicky";
            //int ageip = 10;
            //string addip = "Mankhurd";
            //datils(nameip, ageip, addip);
            //datils(age:ageip, add:addip, name:nameip) ;//named paramiters

            //int num = 0;
            //update(out num);
            //Console.WriteLine(num);
            //Console.WriteLine(5 > 14 ?"Yes":"No");

            //referencr key

            int num = 10;
            assign(ref num);
            Console.WriteLine( num);
            

        }
        //function
        static void assign(ref int num)
        {
            num = 45;

        }

        static void update(out int num)
        {
            num = 5;
            
        }


        static void Welcome()
        {
            Console.WriteLine("Hello vicky");
        }
        static void datils(string name ,int age , string add)
        {
            Console.WriteLine($"name :{name}");
            Console.WriteLine($"Age :{age}");
            Console.WriteLine($"Add :{add}");
        }   



    }
}
