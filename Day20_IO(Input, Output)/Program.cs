using System;
using System.IO;

namespace Day20_IO_Input__Output_
{
    class Program
    {
        static string filepath = @"C:\Users\deivi\Desktop\C# kursi";
        static void Main(string[] args)
        {

            String fileName = filepath + "piemers.txt";

           try
            {
                StreamWriter writer = new StreamWriter(fileName);

                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Ievadi teksu!");
                    string ievade = Console.ReadLine();
                    writer.WriteLine(ievade);
                }

                writer.Close();
            }
            catch
            {
                Console.WriteLine("Kļūda!");
            }
        }
    }
}
