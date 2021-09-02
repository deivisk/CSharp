using System;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kkas = new string[5];

            for(int i = 0; i < kkas.Length; i++)
            {
                Console.WriteLine("Ievadiet frāzi");

                string ievade = Console.ReadLine();

                kkas[i] = ievade;

                if(ievade.Contains("sveiki") == true)
                {
                   kkas[i] = "*****";
                }

            }
            for(int i = 0; i <kkas.Length; i++)
            {
                Console.WriteLine(kkas[i]);
            }


        }
    }
}
