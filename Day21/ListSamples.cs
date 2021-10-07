using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day21
{
    class ListSamples
    {
        static String folderPath = @"C:\Users\deivi\Desktop";

        static List<String> Liste = new List<String>();
        
        
        public static void Sample1()
        {


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
        public static void read()
        {

            String fileName = folderPath + "piemeri.txt";

            StreamReader reader = new StreamReader(fileName);


            string a = reader.ReadLine();

            try
            {
                while(wtf != null)
                {
                    Liste.Add(wtf);

                    a = reader.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("kkas nesanak");
            }



        }
    }
}
