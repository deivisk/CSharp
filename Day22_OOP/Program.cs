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

            Console.WriteLine("Studenta vārds");
            string nn = Console.ReadLine();

            Console.WriteLine("Studenta uzvārds");
            string nna = Console.ReadLine();



            Candidate first = new Candidate("Pēteris ", "Gulbis", randomnumb, randomnum, avarage);
            first.izvade();

            Console.WriteLine();

            Candidate second = new Candidate("Solvita ", "Āboltiņa", randomnumb, randomnum, avarage);
            second.izvade();

            Console.WriteLine();

            Candidate inf = new Candidate(nn, nna, randomnumb, randomnum, avarage);
            inf.izvade();

            for(int i = 0; i < daudzums; i++)
            {
                Liste.Add(inf);
            }
        }
    }
}
