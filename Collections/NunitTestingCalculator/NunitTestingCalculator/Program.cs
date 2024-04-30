using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestingCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2st number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            CalculatorOperation obj = new CalculatorOperation();
            int sum = obj.Add(num1 , num2);
            int sub = obj.Sub(num1 , num2);
            int mltipication = obj.Multiply(num1 , num2);
            float div = obj.Divide(num1 , num2);
            Console.WriteLine("Addition is " +sum);
            Console.WriteLine("Substraction is " +sub);
            Console.WriteLine("Miltiplication is " +mltipication);
            Console.WriteLine("Divition is " + div);

        }
    }
}
