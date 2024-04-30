using System;

namespace Oop
{
   class program
    {
        public class A
        {
            public int code ;
            public string name ;
            public virtual void print()
            {
                Console.WriteLine("i am in A printing "+code+" "+name);
            }
        }
        public class B :A
        {
            
            public string address = "mankhurd";
            public override void print()
            {
                Console.WriteLine("i am in B printing " + address);
            }

        }


        static void Main(string[] argus)
        {

            A a = new A();
            a.code = 45;
            a.name = "vicky";
            a.print();

            B b = new B();
            b.print();

            A c = new B();
            
            
            c.print();


           
            
        }
    }
}
