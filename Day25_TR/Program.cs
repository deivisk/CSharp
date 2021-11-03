using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Day25_TR
{
    class Program
    {
       static string filepath = @"C:\Users\deivi\Desktop";

        static void Main(string[] args)
        {
            try
            {
                String filename = filepath + "darbs.txt";
                List<String> liste = new List<String>();

    ;
                StreamWriter writer = new StreamWriter(filename);

                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Īevadi vārdus");
                    String names = Console.ReadLine();
                    liste.Add(names);
                }


                string jsonString = JsonSerializer.Serialize(liste);

                Console.WriteLine(jsonString);

                writer.Close();
            }
            catch
            {
                Console.WriteLine("Error");
            }

            reader();

        }

        static void reader()
        {
            string filename = filepath + "darbs.txt";
            try
            {
                StreamReader reader = new StreamReader(filename);
                string las = reader.ReadToEnd();
                reader.Close();
                List<string> liste = JsonSerializer.Deserialize<List<string>>(las);

                for(int i = 0; i < liste.Count; i++)
                {
                    Console.WriteLine(liste[i]);
                }

            }
            catch
            {
                Console.WriteLine("Errors!");
            }
        }
    }
}
