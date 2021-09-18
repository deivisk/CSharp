using System;
using System.Collections.Generic;

namespace Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> UserList = new List<int>();

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

            }
        }
    }
}
