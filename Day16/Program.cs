using System;
using System.Collections.Generic;

namespace Day16
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("");

            if()
            {

            }

        }
        private static int User()
        {
            List<int> UserList = new List<int>();

            int input = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ievadiet skaitli");

                input = Convert.ToInt32(Console.ReadLine());

                UserList.Add(input);
            }
        }

        private static int RANAI()
        {
            List<int> AIList = new List<int>();

            Random random = new Random();

            int randomnumber = 0;

            for(int i = 0; i < 10; i++)
            {
                randomnumber = random.Next(1, 10);

                AIList.Add(randomnumber);
            }
            
        }
    }
}
