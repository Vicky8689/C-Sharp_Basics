using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        class Shape
        {
           protected string color;
            public Shape(string color)
            {
                this.color = color;
            }
            public Shape()
            {

            }

            public virtual double get_area()
            {
                return 0;
                
            }
           public virtual double get_perimeter()
            {
                return 0;
               
            }
           public virtual void DisplayInfo()
            {
                Console.WriteLine("color: "+color);
            }


        }


        //drived class
        class Rectangle : Shape
        {
            //rectengle length and height
            protected double length;
            protected double width;

            //make cunstructor
            public Rectangle(string color, double length, double width): base(color)
            {
                this.length = length;
                this.width = width;
            }
            //get area method 
            public override double get_area()
            {
                return length * width ;
                
            }
            //get perimeter method
            public override double get_perimeter()
            {
                
                return 2*(length+width);
                
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("Length : "+length);
                Console.WriteLine("Weight : "+width);
                Console.WriteLine("Area : "+get_area());
                Console.WriteLine("Perimeter :"+get_perimeter());
            }


        }




        //Circle class
        class Circle : Shape
        {
            //radius
            protected double radius;

            //cunstructor
            public Circle(string color,double radius):base(color)
            {
                this.radius = radius;
            }

           public override double get_area()
            {
              return Math.PI*radius*radius;
                
            }
            public override double get_perimeter()
            {    
                return 2*Math.PI*radius;
            }
            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("Redius : " + radius);
                Console.WriteLine("Area :" +get_area());
                Console.WriteLine("Perimeter :" +get_perimeter());
            }
        }
    
        static void Main(string[] args)
        {

            Circle c1 = new Circle("red" , 5);

            c1.DisplayInfo();

            Shape sh = new Shape();

            sh.DisplayInfo();

           Console.WriteLine( sh.get_area());

            Console.WriteLine("------------------------");
            Shape s1 = new Circle("yello",5);
            s1.DisplayInfo();
            Console.WriteLine("------------------------");
            Circle s2 = new Circle("yello", 5);
            s1.DisplayInfo();


        }
    }
}
