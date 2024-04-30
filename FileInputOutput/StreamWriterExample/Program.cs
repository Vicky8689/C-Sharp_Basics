using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StreamWriterExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C#_Basic_Local\FileInputOutput\StreamWriterReaderExamples\myFile.txt";

            using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            {

                using (StreamWriter writer = new StreamWriter(file,Encoding.UTF8))
                {
                    //int[] arr = { 13, 45, 67, 89 };
                    char[] arr2 = { 'a','b','c','d' };

                    foreach (char i in arr2)
                    {
                        writer.WriteLine(i);
                    }

                    writer.Write("vicky");   //write method 
                    writer.WriteLine("statement no1");     //using write line
                    writer.WriteLine("statement no2");     //using write line
                    writer.WriteLine("statement no3");     //using write line
               // writer.Close();//close the streamwriter 
                } 

            }
            //file.Close();

        }
    }
}
