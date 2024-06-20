using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    //use to refrencing method
    public delegate int MyDelegate(int num);

    internal class Program
    {
        static void Main(string[] args)
        {
            //lambda expration is simplyfy anonimus function
            //stament lambd  inmpu =>{statement};

            //MyDelegate objStatement = (a) => { a = a + 5; Console.WriteLine(a); };
            //objStatement.Invoke(5);


            //expretion lambda
            MyDelegate objExpretion = (a) => a * a;
            
            Console.WriteLine(objExpretion.Invoke(5));

            //MyDelegate obj = delegate (int a) { a = a + 5; Console.WriteLine(a); };
            //obj.Invoke(5);
        } 
    }
}
