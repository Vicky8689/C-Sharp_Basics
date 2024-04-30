using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;


namespace StringWriterReaderExamples
{
    /*
     * string writer deal with string data rather than files
     * the purpose of stringwriter class is to manipulate string and store in string builder
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //create string
            string text = "Hello vicky what are you doing....? ";
            
            //create string builder
            StringBuilder sb = new StringBuilder();

            using (StringWriter sw = new StringWriter(sb))
            {
                sw.WriteLine(text);
            sw.Flush(); //manage the buffer
            }
            using (StringWriter sw = new StringWriter(sb))
            {
                sw.WriteLine("what is your name");
            }

            //string reader
            StringReader reader = new StringReader(sb.ToString());

            //reading data
            while (reader.Peek() > 0)
            {
                Console.WriteLine(reader.ReadLine());
            }


        }
    }
}
