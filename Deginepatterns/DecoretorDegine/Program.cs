using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoretorDegine
{
    //base interface
    public abstract class AbIcecream
    {
        string desc;
        public virtual string GetDesc()
        {
            return desc;
        }

        public abstract int cost();
    }





    //concrete implementation
   public class ChoclateIceCream : AbIcecream
    {
        //overrided
       public  string GetDesc()
        {
            return "choclate";
        }
       public override int cost()
        {
            return 70;
        }
    }



    //base Decorator
    public abstract class AIceCreamDecorator : AbIcecream 
    {
      public abstract override int cost();
    }



    //concrete decorators
    public class RaimboSprinkalDecorator : AIceCreamDecorator
    {
        AbIcecream iceCream;
       public RaimboSprinkalDecorator(AbIcecream iceCream)
        {
            this.iceCream = iceCream;
        }
        public override int cost() { return iceCream.cost() + 20; }
        public override string GetDesc()
        {
            return iceCream.GetDesc() + " with Rainbo Sprinkle  ";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello iceCream");
            AbIcecream myIceCream = new ChoclateIceCream();
            myIceCream = new RaimboSprinkalDecorator(myIceCream);
            Console.WriteLine(myIceCream);
            Console.WriteLine(myIceCream.cost());




        }
    }
}
