using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunction
{
    public delegate void MyDelegate(int num);
    class Program
    {
        public static void MyMethod(int a)
        {
            a = a + 10;
            Console.WriteLine(a);

        }
        static void Main(string[] args)
        {
            //delegate
            MyDelegate obj = new MyDelegate(Program.MyMethod);
            //obj.Invoke(5);
            obj(5);


            //anonimus
            MyDelegate aNobj = delegate (int a)
            {
                a += 50;
                Console.WriteLine(a);
            };
            aNobj(5);
        }
    }
}
