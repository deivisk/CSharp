using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day21
{
    class ListSamples
    {
        static String folderPath = @"C:\Users\deivi\Desktop\C# kursi";
        
        
        public static void Sample1()
        {
            List<String> Liste = new List<String>();

            Random random = new Random();



            String fileName = folderPath + "piemeri.txt";

            try
            {
                StreamWriter writer = new StreamWriter(fileName);

                for(int i = 0; i < 20; i++)
                {
                    int randomnum = random.Next(0, 21);

                    writer.WriteLine(randomnum);
                }

                writer.Close();

            }
            catch
            {
                Console.WriteLine("Fails neeksistē");
            }
        }
    }
}
