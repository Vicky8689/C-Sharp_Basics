using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deginepatterns
{
    //factory degine
    public interface Icar 
    {
        void start();
    }
    public class SixseaterCar :Icar
    {
        public void start() { Console.WriteLine("sixseater started"); }
    }
    public class FourseaterCar : Icar
    {
        public void start() { Console.WriteLine("Fourseater started"); }
    }

    public class Carfactory
    {
        public Icar GetCar(string carType)
        {
            switch (carType)
            {
                case "SixseaterCar":
                    return new SixseaterCar();
                case "FourseaterCar":
                    return new FourseaterCar();

            }
            return null;
            
            
        }
    }


    //single ton 
    public class Singleton
    {
        private static Singleton instance;
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

    }

    //decorator


    internal class Program
    {





        static void Main(string[] args)
        {


            //Console.WriteLine("hello");
            //Singleton st = Singleton.GetInstance();

            ////carfactory object
            //Carfactory carfactry = new Carfactory();

            //Icar sixseater = carfactry.GetCar("SixseaterCar");
            //Icar fourseater = carfactry.GetCar("FourseaterCar");



            //Icar six = new SixseaterCar();
            //six.start();

            //Icar four = new FourseaterCar();
            //four.start();
        }

    }
}
