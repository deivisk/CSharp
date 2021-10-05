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

                Console.WriteLine("Ievadi pirmo teksu!");
                string pirmais = Console.ReadLine();

                Console.WriteLine("Ievadi otro teksu!");
                string otrais = Console.ReadLine();

                Console.WriteLine("Ievadi trešo teksu!");
                string trešais = Console.ReadLine();

                writer.WriteLine(pirmais);
                writer.WriteLine(otrais);
                writer.WriteLine(trešais);
                writer.Close();
            }
            catch
            {
                Console.WriteLine("Kļūda!");
            }
        }
    }
}
