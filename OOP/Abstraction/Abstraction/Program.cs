using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //Interface 
    /*
     *Interface cannot be used to create object
     *Interface method does not have any body
     *Interface memeber are by default abstract and public  
     */
    interface IAnimal
    { 
        void animalSound();//inteface method (does not have any body)
        void sleep();
    }

    //implement  the IAnimal interface
   
    class Cat : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Cat sound");
        }
        public void sleep()
        {
            Console.WriteLine("Cat is sleeping");
        }

    }





    abstract class Animal
    {
        //Abstract method (does not have a body)
        public abstract void animalSound();
        //Regular method
        public void sleep()
        {
            Console.WriteLine("Zzzzzzz");
        }
    }

    //DErived class (inherit form Animal)
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Dog Sound");
        }
    }
   
    internal class Program
    {

        static void Main(string[] args)
        {
            //abstraction
            Dog tommy = new Dog();//create dog object
            tommy.animalSound();// call the abstract method
            tommy.sleep();//call the regular method


            //interface 

            Cat myCat  = new Cat();
            myCat.animalSound();
            myCat.sleep();

           

        }
    }
}
