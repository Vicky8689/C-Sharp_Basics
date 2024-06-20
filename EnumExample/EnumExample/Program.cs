using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    internal class Program
    {
        enum Days {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thesday,
            Friday,
            Saturday
        }

       public class  Singleton
        {
            private static Singleton instance;
            private Singleton() { }

            public static Singleton GetInstance()
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
         


        }


        static void Main(string[] args)
        {
            Singleton sit = Singleton.GetInstance();
            
            Days d = Days.Sunday;
            Console.WriteLine(d);
        }
    }
}
