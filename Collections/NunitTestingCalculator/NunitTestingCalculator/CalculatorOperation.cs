using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NunitTestingCalculator
{
    public class CalculatorOperation
    {
       
        public int Add(int a,int b) 
        {
            return a + b;
        }
       public int Sub(int a, int b)
        {
            return a - b;
        }

       public int Multiply(int a, int b)
        {
            return a * b;
        }

       public int Divide(int a, int b)
        {
            return a / b;
        }

        



    }
}
