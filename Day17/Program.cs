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

                first.Add(ievade);
            }

            Console.WriteLine();

            for(int i = 0; i < first.Count; i++)
            {
                Console.WriteLine(first[i]);
            }

            Console.WriteLine();

            Console.WriteLine("1. Izvadīt simbolu skaitu lista elementā");
            Console.WriteLine("2. Izvadīt vidējo garumu no visiem elementiem");
            Console.WriteLine("3. Izvadīt visu elementu garumu summu");

            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                
            }
            if (choice == 2)
            {
                glass();
            }
            if (choice == 3)
            {

            }

        }

        static void glass()
        {
            for(int i = 0; i < first.Count; i++)
            {
                string kk = first.Count / first[i];
                
                Console.WriteLine(kk);
            }
        }
    }
}
