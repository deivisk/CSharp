using System;
using System.Collections.Generic;

namespace Day22_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidate> Liste = new List<Candidate>();

            Console.WriteLine("Cik studentus ievadīt?");
            int daudzums = Convert.ToInt32(Console.ReadLine());

            String name = "";

            String LastName = "";

            Double HRmark = 0;

            Double TVmark = 0;

            for(int i = 0; i < daudzums; i++)
            {
                Console.WriteLine("Tagad Tu ievadi informāciju par " + i + ". studentu");
                Console.WriteLine();
                Console.WriteLine("Studenta vārds");
                name = Console.ReadLine();
                Console.WriteLine("Studenta uzvārds");
                LastName = Console.ReadLine();
                Console.WriteLine("Ievadi HR doto atzīmi");
                HRmark = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ievadi vadītāja doto atzīmi");
                TVmark = Convert.ToDouble(Console.ReadLine());

                ave(HRmark, TVmark);

                Candidate inf = new Candidate(name, LastName, HRmark, TVmark, ave(HRmark, TVmark));
                Liste.Add(inf);
            }

            for(int i = 0; i < Liste.Count; i++)
            {
                Liste[i].izvade();
            }
        }
        static Double ave(Double HRmark, Double TVmark)     //BEIDZOT sanāca!1!!!111!
        {
            Double average = (HRmark + TVmark) / 2;
            return average;
        }
    }
}
