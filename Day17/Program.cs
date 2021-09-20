using System;
using System.Collections.Generic;

namespace Day17
{
    class Program
    {
        static List<string> first = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Izvēlaties, cik elementus ievadīt");

            int count = Convert.ToInt32(Console.ReadLine());

            if(count < 1)
            {
                count = 5;

            }

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Ievadiet elementu");

                String ievade = Console.ReadLine();


            }
        }
    }
}
