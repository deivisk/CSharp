using System;
using System.Collections.Generic;

namespace Day22_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Candidate> Liste = new List<Candidate>();

            Double randomnum = random.Next(0, 11);
            Double randomnumb = random.Next(0, 11);

            double avarage = (randomnum + randomnumb) / 2;

            Console.WriteLine("Cik studentus ievadīt?");
            int daudzums = Convert.ToInt32(Console.ReadLine());

            String name = "";

            String LastName = "";

            Candidate inf = new Candidate(name, LastName, randomnumb, randomnum, avarage);

            for(int i = 0; i < daudzums; i++)
            {
                Console.WriteLine("Studenta vārds");

                Console.WriteLine("Studenta uzvārds");

                Liste.Add(inf);
                inf.izvade();
            }

        }
    }
}
