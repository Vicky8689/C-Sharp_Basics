using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileInputOutput
{
    internal class Program
    {

        /*
         * File.Exists(path) -----T or F
         * File.ReadAllFile(path)
         * File.Copy(Source_path,Destination_path)
         
         
         */

        static void Main(string[] args)
        {
            string path = @"D:\C#_Basic_Local\FileInputOutput\FileInputOutput\data\TextFile1.txt"; //verbatim Literal
         
            if(File.Exists(path))
            {
                Console.WriteLine("file is found.. ");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);

                //create copy of above file
                //first create path 
                string path3 = @"D:\C#_Basic_Local\FileInputOutput\FileInputOutput\data\TextFile3.txt";
                //copy file
                File.Copy(path, path3);
                //override 
               // File.Copy(path, path3,true);






            }
            else
            {
                Console.WriteLine("File not found");
            }
           
            
            
            
            
            
            
            
            //checkin file status 
            //File.Exites checking file eect or not
            //if(File.Exists(path))
            //{
            //    Console.WriteLine("yes deceted");
            //}
            //else
            //{
            //            Console.WriteLine("file not found ");
            //}

            



        }
    }
}
