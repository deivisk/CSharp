using System;
using System.Collections.Generic;

namespace Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            List<int> UserList = new List<int>();

                        List<int> AIList = new List<int>();

                        Random random = new Random();

                        int randomnumber = 0;

                        int input = 0;

                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("Ievadiet skaitli");

                            input = Convert.ToInt32(Console.ReadLine());

                            UserList.Add(input);
                        }

                        for(int i = 0; i < 10; i++)
                        {
                            randomnumber = random.Next(1, 10);

                            AIList.Add(randomnumber);
                        }
                        Console.WriteLine("");

                        for(int i = 0; i < UserList.Count; i++)
                        {
                            for(int e = 0; e < AIList.Count; e++)
                            {
                                if(AIList[e] == UserList[i])
                                {

                                }
                            }
                        }*/

            List<string> names = new List<string>();

            List<int> years = new List<int>();

            for(int i =0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet studneta vārdu, uzvārdu");
                names.Add(Console.ReadLine());

                Console.WriteLine("Ievadiet stundetu dzimšanas gadus");
                years.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Studenta vārds " + names[i] + " dzimis " + years[i]);
            }

        } 
    }
}
