using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        //Method Overriding

        class Animal
        {
            public  void Eat()
            {
                Console.WriteLine("Animal is Eating ");
            }

        }
        class Dog: Animal
        {
            public  void Eat()
            {
                Console.WriteLine("Dog is Eating ");
            }
        }

        //Method Overloding 
        void Sum(int a , int b)
        {
            Console.WriteLine(a+b);
        }
        void Sum(float a ,float b)
        {
            Console.WriteLine(a+b);
        }

        static void Main(string[] args)
        {
            //method overloding
            Program obj  = new Program();
            obj.Sum(10 ,20);
            obj.Sum(10.5f ,20.5f);

            //method Override
            Dog tommy = new Dog();
            tommy.Eat();

            Animal rocky = new Dog();
            rocky.Eat();

        }
    }
}
