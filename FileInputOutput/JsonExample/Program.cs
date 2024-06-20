using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using System.Threading.Tasks;
using Microsoft.Win32;
using Newtonsoft.Json;
namespace JsonExample
{
    class User
    {  
        public string Name { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
      
    }
    internal class Program
    {
       public static void AddData(string path ,User user)
        {
            using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            {

                using (StreamWriter writer = new StreamWriter(file, Encoding.UTF8))
                {
                    string json = JsonConvert.SerializeObject(user, Formatting.Indented);
                    if(new FileInfo(path).Length > 0) { writer.WriteLine(","); }
                    writer.WriteLine(json);
                    Console.WriteLine("file added succes full");

                }

            }
        }
        //dsirializetion
        static void GetData(string path)
        {
            string json = File.ReadAllText(path);
            json = "["+json+"]";

            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            

            foreach(User user in users)
            {
                Console.WriteLine(user.Name);
                
            }
        }


        static void UpdateData(string path)
        {
            string json = File.ReadAllText(path);
            json = "[" + json + "]";

            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            foreach (User user in users)
            {
                user.Name = "Update456";
            }

            string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
            Console.WriteLine(updatedJson);
            string letest = updatedJson.Substring(1, updatedJson.Length - 2);
            File.WriteAllText(path,letest);
            Console.WriteLine("file update ");


        }
        static void Main(string[] args)
        {

            string path = @"D:\C#_Basic_Local\myFile.json";
            User user = new User()
            {
                Name = "beter",
                Description = "Loc54trfobuzz",
                Contact = "5465trgf67u"
            };
           //add data 
          //AddData(path ,user);
           //get Data from file 
          GetData(path);
           //UpdateData(path);

            
            //string json = JsonConvert.SerializeObject(user , Formatting.Indented);
            //Console.WriteLine(json);
            //File.WriteAllText(path, json);
          //  var newUser = JsonConvert.DeserializeObject<User>(json);
        //  Console.WriteLine(newUser.Name);
           
            
        }
    }
}
