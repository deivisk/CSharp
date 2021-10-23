using System;
using System.IO;
using System.Text.Json;

namespace Day24_JSON
{
    class Program
    {
        static string filepath = @"C:\Users\deivi\Downloads";
        static void Main(string[] args)
        {
            string fileName = filepath + "piemers.txt";
            User inf = new User() ;

            try
            {
                StreamWriter writer = new StreamWriter(fileName);

                inf.InitUser("abc","abc", "abc", "abc");
                String jsonString = JsonSerializer.Serialize(inf);
                writer.WriteLine(jsonString);

                writer.Close();
            }
            catch
            {
                Console.WriteLine("404");
            }

        }
    }
}
