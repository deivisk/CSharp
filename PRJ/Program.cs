using System;
using System.IO;

namespace PRJ
{
    class Program
    {
        static string filepath = @"C:\Users\deivi\Downloads";
        static void Main(string[] args)
        {
            Kalk.Kalkul();
        }

        static void ok()
        {
            Kalk inf = new Kalk();
            string filename = filepath + "Prj.txt";

            try
            {
                StreamWriter writer = new StreamWriter(filename);
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
