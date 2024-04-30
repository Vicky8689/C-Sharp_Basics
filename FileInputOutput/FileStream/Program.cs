using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C#_Basic_Local\FileInputOutput\My Directory\Myfile.txt";
            //overlode cunstructor
            //create function override the file
            using (FileStream f = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                f.WriteByte(66); //A was writen in file


                Console.WriteLine("File created ..");
            }
            //file append ---put the cursor at the end and write  from the end
            using (FileStream f = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                f.WriteByte(66); //A was writen in file
                f.WriteByte(67);
                f.WriteByte(68);

                Console.WriteLine("File created ..");
            }
            //f.Close();

            //create new file 

            using (FileStream f = new FileStream(path, FileMode.CreateNew, FileAccess.Write)) //throw exception when file is already exists
            {
                f.WriteByte(66); //A was writen in file
                f.WriteByte(67);
                f.WriteByte(68);

                Console.WriteLine("File created ..");
            }
            //open --open the file and start writing from first line 
            using (FileStream f = new FileStream(path, FileMode.Open, FileAccess.Write))
            {
                f.WriteByte(95); //A was writen in file
                f.WriteByte(66); //A was writen in file
                f.WriteByte(67); //A was writen in file



                Console.WriteLine("File created ..");
            }


            //truncate
            using (FileStream f = new FileStream(path, FileMode.Truncate, FileAccess.Write))
            {
                f.WriteByte(95); //A was writen in file
                f.WriteByte(66); //A was writen in file
                f.WriteByte(67); //A was writen in file



                Console.WriteLine("File created ..");
            }

            //ACCESS

            //write line or paraghraph in file
            using (FileStream f = new FileStream(path, FileMode.Append, FileAccess.Write,FileShare.Read))
            {
                string data = "Welcome vicky ..";
                byte[] write_data = Encoding.UTF8.GetBytes(data);
                f.Write(write_data,0, write_data.Length);
                Console.WriteLine("File write successfully ..");
            }



        }
    }
}
