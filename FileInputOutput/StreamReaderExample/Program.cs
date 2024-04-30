using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StreamReaderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C#_Basic_Local\FileInputOutput\StreamWriterReaderExamples\myFile.txt";
            using(FileStream sf = new FileStream(path,FileMode.Open,FileAccess.Read))    // first step
            {
                using(StreamReader sr = new StreamReader(sf))                         //second step
                {
                    //reade all data
                    string data = sr.ReadToEnd();
                    Console.WriteLine(data);



                    string line = sr.ReadLine();  //read charateor one by one from stream
                    Console.WriteLine(line);
                     line = "";
                    while ((line = sr.ReadLine()) != null)  //reade line and store in line variable if line is not null the retun TRUE
                    {
                        Console.WriteLine(line);
                    }

                    foreach (var item in sr.ReadToEnd())
                    {
                        Console.WriteLine(item);
                    }

                    string[] names = new string[5];
                    for (int i = 0; i < names.Length; i++)
                    {
                        names[i] = sr.ReadLine();
                    }

                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.Write(names[i] + " ");
                    }

                    if (sr.Peek() > 0)
                    {
                        Console.WriteLine(true);

                    }
                    else
                    {
                        Console.WriteLine(false);
                    }







                }

            }
        }
    }
}
