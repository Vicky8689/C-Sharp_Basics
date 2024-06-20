using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    /*
     * carries the data
     * store meta data
     * 
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"D:\C#_Basic_Local\FileInputOutput\employee.txt";
            ////create obj
            //Employee emp = new Employee();
            //emp.Name = "Test";
            //emp.Id = 451;
            ////create stream 
            //FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            ////create intance of Binary Formatter
            //BinaryFormatter bf = new BinaryFormatter();
            ////call serializetion 
            //bf.Serialize(fs,emp);
            //fs.Close();
            //Console.WriteLine("filecreate ");

            //Deserialzation

            string path = @"D:\C#_Basic_Local\FileInputOutput\employee.txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Employee emp =(Employee) bf.Deserialize(fs);
            Console.WriteLine(emp.Id);
            Console.WriteLine(emp.Name);
            fs.Close();



        }
    }
}
